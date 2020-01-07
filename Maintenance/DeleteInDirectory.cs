using System;
using System.IO;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public class DeleteInDirectory
    {
        public static void DeleteSetFiles()
        {
            // Delete Files and Folders in a Directory
            foreach (string paths in Default.PathFilesToDelete)
            {
                try
                {
                    if (Directory.Exists(paths))
                    {
                        var filesPath = Environment.ExpandEnvironmentVariables(paths);

                        // Files
                        foreach (string file in Directory.GetFiles(filesPath))
                        {
                            bool deleted = false;
                            try
                            {
                                File.Delete(file);
                                deleted = true;
                            }
                            catch (Exception ex)
                            {
                                deleted = false;
                                EasyLogger.Error(file + " : " + ex);
                                continue;
                            }
                            if (deleted)
                            {
                                EasyLogger.Info("Deleting file: " + file);
                            }
                        }

                        // Directories
                        foreach (string directory in Directory.GetDirectories(filesPath))
                        {
                            bool deleted = false;
                            try
                            {
                                Directory.Delete(directory, true);
                                deleted = true;
                            }
                            catch (Exception ex)
                            {
                                deleted = false;
                                EasyLogger.Error(directory + " : " + ex);
                                continue;
                            }
                            if (deleted)
                            {
                                EasyLogger.Info("Deleting directory: " + directory);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    EasyLogger.Error(paths + " : " + ex);
                    continue;
                }
            }
        }
    }
}
