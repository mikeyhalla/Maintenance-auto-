using System;
using System.Diagnostics;
using System.IO;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public class DeleteDirectories
    {
        public static void DeleteSetPaths()
        {
            // Delete Files
            foreach (string dir in Default.DirectoriesToDelete)
            {
                bool deleted = false;
                if (Directory.Exists(dir))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        deleted = true;
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            using (Process proc = new Process())
                            {
                                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                proc.StartInfo.CreateNoWindow = true;
                                proc.StartInfo.UseShellExecute = false;
                                proc.StartInfo.FileName = "cmd.exe";
                                proc.StartInfo.Arguments = "/C takeown /a /r /d Y /f" + dir;
                                proc.Start();
                                proc.WaitForExit();
                            }
                            var file = new FileInfo(dir.ToString())
                            {
                                Attributes = FileAttributes.Normal
                            };

                            foreach (var subDirectoryPath in Directory.GetDirectories(dir))
                            {
                                var directoryInfo = new DirectoryInfo(subDirectoryPath);
                                foreach (var filePath in directoryInfo.GetFiles())
                                {
                                    file = new FileInfo(filePath.ToString())
                                    {
                                        Attributes = FileAttributes.Normal
                                    };
                                }
                            }

                            Directory.Delete(dir, true);
                        }
                        catch (Exception)
                        {
                            deleted = false;
                            EasyLogger.Error(dir + " : " + ex);
                            continue;
                        }
                    }
                    if (deleted)
                    {
                        EasyLogger.Info("Deleting directory: " + dir);
                    }
                }
            }
        }
    }
}
