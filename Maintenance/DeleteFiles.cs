using System;
using System.IO;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public class DeleteFiles
    {
        public static void DeleteSetFiles()
        {
            // Delete Files
            foreach (string file in Default.FilesToDelete)
            {
                bool deleted = false;
                if (File.Exists(file))
                {
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
            }
        }
    }
}
