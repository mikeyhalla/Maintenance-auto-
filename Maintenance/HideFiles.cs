using System;
using System.IO;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public class HideFiles
    {
        public static void SetAsHidden()
        {
            // Hide Files
            foreach (var hideFile in Default.FilesToHide)
            {
                try
                {
                    var filePath = Environment.ExpandEnvironmentVariables(hideFile);
                    if (File.Exists(filePath))
                    {
                        if ((File.GetAttributes(filePath) & FileAttributes.Hidden) != FileAttributes.Hidden)
                        {
                            FileAttributes attributes = File.GetAttributes(filePath);
                            if (attributes != FileAttributes.Hidden || attributes != FileAttributes.System)
                            {
                                EasyLogger.Info("Hiding file: " + filePath);

                                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
                                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.System);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    EasyLogger.Error(hideFile + " : " + ex);
                    continue;
                }
            }

            // Hide Directories
            foreach (var hideFile in Default.DirectoriesToHide)
            {
                try
                {
                    var filePath = Environment.ExpandEnvironmentVariables(hideFile);
                    if (Directory.Exists(filePath))
                    {
                        if ((File.GetAttributes(filePath) & FileAttributes.Hidden) != FileAttributes.Hidden)
                        {
                            EasyLogger.Info("Hiding directory: " + filePath);

                            FileAttributes attributes = File.GetAttributes(filePath);
                            if (attributes != FileAttributes.Hidden || attributes != FileAttributes.System)
                            {
                                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
                                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.System);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    EasyLogger.Error(hideFile + " : " + ex);
                    continue;
                }
            }
        }
    }
}
