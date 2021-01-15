using Shell32;
using System;
using System.IO;
using System.Linq;

namespace Maintenance
{
    internal class BrokenShortcuts
    {
        internal static void Remove()
        {
            try
            {
                string[] directories = { Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu), Environment.GetFolderPath(Environment.SpecialFolder.Programs), Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) };
                foreach (string directory in directories)
                {
                    try
                    {
                        EasyLogger.Info("Searching " + directory + " for broken shortcuts...");

                        var files = Directory.EnumerateFiles(directory, "*.lnk", SearchOption.AllDirectories);

                        foreach (var file in files)
                        {
                            RemoveBrokenShortcuts(file);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                    catch (PathTooLongException)
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error(ex);
            }

            try
            {
                string[] directories = { Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu), Environment.GetFolderPath(Environment.SpecialFolder.Programs), Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) };
                foreach (string directory in directories)
                {
                    try
                    {
                        DeleteEmptySubdirectories(directory);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error(ex);
            }
        }

        private static void RemoveBrokenShortcuts(string shortcut)
        {
            try
            {
                Shell shell = new Shell();

                string shortcut_path = shortcut.Substring(0, shortcut.LastIndexOf("\\"));
                string shortcut_name = shortcut.Substring(shortcut.LastIndexOf("\\") + 1);
                if (shortcut_name.EndsWith(".lnk"))
                {
                    Folder shortcut_folder = shell.NameSpace(shortcut_path);

                    FolderItem folder_item = shortcut_folder.Items().Item(shortcut_name);

                    if (folder_item == null)
                        EasyLogger.Warning("Cannot find shortcut file '" + shortcut + "'");
                    if (!folder_item.IsLink)
                        EasyLogger.Warning(shortcut + "' isn't a shortcut.");

                    try
                    {
                        ShellLinkObject lnk = (ShellLinkObject)folder_item.GetLink;
                        string path = lnk.Path;
                        bool exists = false;
                        if (File.Exists(path))
                        {
                            exists = true;
                        }
                        if (Directory.Exists(path))
                        {
                            exists = true;
                        }
                        if (!exists)
                        {
                            EasyLogger.Info("Deleting broken shortcut: " + shortcut + ". The target doesn't exits: " + path);
                            try
                            {
                                File.Delete(shortcut);
                            }
                            catch { /* ignore */ }
                            try
                            {
                                Directory.Delete(shortcut);
                            }
                            catch { /* ignore */ }
                        }
                    }
                    catch { /* ignore */ }
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error(ex);
            }
        }

        private static void DeleteEmptySubdirectories(string parentDirectory)
        {
            foreach (string directory in Directory.GetDirectories(parentDirectory))
            {
                try
                {
                    DeleteEmptySubdirectories(directory);
                }
                catch { continue; }

                try
                {
                    if (!Directory.EnumerateFileSystemEntries(directory).Any())
                    {
                        EasyLogger.Info("Removing empty directory: " + directory);
                        try
                        {
                            Directory.Delete(directory, false);
                        }
                        catch { continue; }
                    }
                }
                catch { continue; }
            }
        }
    }
}
