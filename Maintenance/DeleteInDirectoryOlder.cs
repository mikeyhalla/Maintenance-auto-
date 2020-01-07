using System;
using System.IO;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public class DeleteInDirectoryOlder
    {
        // Delete Files and Folders in a Directory older than x days
        public static void DeleteSetFiles()
        {
            foreach (string path in Default.PathFilesToDeleteOlder)
            {
                try
                {
                    int days = Convert.ToInt32(path.Split(',')[0]);
                    var filesPath = Environment.ExpandEnvironmentVariables(path.Split(',')[1].Trim());

                    // Files
                    foreach (string f in Directory.GetFiles(filesPath, "*", SearchOption.AllDirectories))
                    {
                        bool deleted = false;
                        try
                        {
                            FileInfo fi = new FileInfo(f);
                            if (fi.LastWriteTime < DateTime.Now.AddDays(-days))
                            {
                                File.Delete(f);
                                deleted = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            deleted = false;
                            EasyLogger.Error(f + " : " + ex);
                            continue;
                        }
                        if (deleted)
                        {
                            EasyLogger.Info("Deleting file: " + f);
                        }
                    }

                    // Directories
                    string[] dirs = Directory.GetDirectories(filesPath, "*", SearchOption.AllDirectories);
                    foreach (string d in dirs)
                    {
                        bool deleted = false;
                        try
                        {
                            DirectoryInfo fi = new DirectoryInfo(d);
                            if (fi.LastWriteTime < DateTime.Now.AddDays(-days))
                            {
                                try
                                {
                                    Directory.Delete(d, false);
                                    deleted = true;
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            deleted = false;
                            EasyLogger.Error(d + " : " + ex);
                            continue;
                        }
                        if (deleted)
                        {
                            EasyLogger.Info("Deleting file: " + d);
                        }
                    }
                }
                catch (Exception ex)
                {
                    EasyLogger.Error(path + " : " + ex);
                    continue;
                }
            }
        }
    }
}
