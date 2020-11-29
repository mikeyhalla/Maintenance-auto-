using System;
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
            if (Default.LoggingEnabled)
            {
                EasyLogger.BackupLogs(EasyLogger.LogFile);
                EasyLogger.AddListener(EasyLogger.LogFile);
            }

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

                    if (args[0] == "/optimize" || args[0] == "-optimize")
                    {
                        StartLightCleanup();
                    }
                    else
                    {
                        StartLightCleanup();
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

            EasyLogger.Info("*********************  END OF OPIMIZATIONS  *********************");

            Environment.Exit(0);
        }

        private static void StartLightCleanup()
        {
            if (Default.InvalidFirewallBox)
            {
                EasyLogger.Info("*********************  Remove Invalid Firewall Rules  *********************" + Environment.NewLine);
                WindowsFirewall.DeleteInvalid();
            }

            if (Default.InvalidVariablesBox)
            {
                EasyLogger.Info("*********************  Remove Invalid Environment Variables  *********************" + Environment.NewLine);
                WindowsVariables.DeleteInvalid();
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
