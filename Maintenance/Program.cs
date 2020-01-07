using System;
using System.Text;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    static class Program
    {
        public static string PuranDefragArgs = string.Empty;

        /// <summary>
        /// Cleanup and Maintenance
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Default.UpgradeRequired)
            {
                Default.Upgrade();
                Default.UpgradeRequired = false;
                Default.Save();
                Default.Reload();
            }
            if (Default.FirstRun)
            {
                Default.FirstRun = false;
                Default.Save();
                Default.Reload();

                SettingsForm settings = new SettingsForm();
                settings.ShowDialog();

                Environment.Exit(0);
            }
            if (args.Length > 0)
            {
                try
                {
                    string A0 = args[0].ToLower();

                    if (args[0] == "/Logon" || args[0] == "-Logon")
                    {
                        StartLightCleanup();
                    }
                    else if (A0 == "/help" || A0 == "/?" || A0 == "-help" || A0 == "-?")
                    {
                        Console.WriteLine("/FULLCHECKUP as a scheduled task when you are not using the computer for a long while.");

                        EasyLogger.Info("/FULLCHECKUP as a scheduled task when you are not using the computer for a long while." + Environment.NewLine);
                    }
                    else
                    {
                        StartLightCleanup();

                        // Get conditions for Full Checkup
                        if (args.Length > 1)
                        {
                            string A1 = args[1].ToLower();

                            if (A1 == "/puranfd" || A1 == "-puranfd")
                            {
                                StringBuilder sb = new StringBuilder();

                                foreach (string arg in args)
                                {
                                    if (arg != args[0] && arg != args[1])
                                    {
                                        if (sb.ToString() == string.Empty)
                                        {
                                            sb.Append(arg);
                                        }
                                        else
                                        {
                                            sb.Append(" " + arg);
                                        }
                                    }
                                }
                                PuranDefragArgs = sb.ToString();
                            }
                        }

                        if (A0 == "/fullcheckup" || A0 == "-fullcheckup")
                        {
                            EasyLogger.Info("*********************  Full Checkup *********************" + Environment.NewLine);

                            FullCheckup.StartCheckup(PuranDefragArgs);
                        }
                    }
                }
                catch (Exception ex)
                {
                    EasyLogger.Info(ex.Message);
                    throw;
                }
            }
            else
            {
                // Run Settings and Close
                SettingsForm settings = new SettingsForm();
                settings.ShowDialog();
            }

            EasyLogger.Info("*********************  END OF FILE  *********************");

            Environment.Exit(0);
        }

        private static void StartLightCleanup()
        {
            if (Default.LoggingEnabled)
            {
                EasyLogger.BackupLogs(EasyLogger.LogDirectory);
                EasyLogger.AddListener(EasyLogger.LogDirectory);
            }

            if (Default.TasksToDisable.Count > 0)
            {
                EasyLogger.Info("*********************  Disable Scheduled Tasks  *********************" + Environment.NewLine);
                DisableTasks.SetTasks();
            }

            if (Default.ServicesToManual.Count > 0 || Default.ServicesToDisable.Count > 0)
            {
                EasyLogger.Info("*********************  Unused Services To Manual  *********************" + Environment.NewLine);
                SetServices.SetStatus();
            }

            if (Default.FilesToHide.Count > 0)
            {
                EasyLogger.Info("*********************  Set Files to Hidden  *********************" + Environment.NewLine);
                HideFiles.SetAsHidden();
            }

            if (Default.PathFilesToDelete.Count > 0)
            {
                EasyLogger.Info("*********************  Delete Files In Directory  *********************" + Environment.NewLine);
                DeleteInDirectory.DeleteSetFiles();
            }

            if (Default.PathFilesToDeleteOlder.Count > 0)
            {
                EasyLogger.Info("*********************  Delete Files in Directory Older  *********************" + Environment.NewLine);
                DeleteInDirectoryOlder.DeleteSetFiles();
            }

            if (Default.FilesToDelete.Count > 0)
            {
                EasyLogger.Info("*********************  Delete Specific Files  *********************" + Environment.NewLine);
                DeleteFiles.DeleteSetFiles();
            }

            if (Default.DirectoriesToDelete.Count > 0)
            {
                EasyLogger.Info("*********************  Delete Specific Directories  *********************" + Environment.NewLine);
                DeleteDirectories.DeleteSetPaths();
            }
        }
    }
}
