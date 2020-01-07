using System.Diagnostics;
using System.IO;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public class DisableTasks
    {
        public static void SetTasks()
        {
            // Disable Tasks
            foreach (string task in Default.TasksToDisable)
            {
                DisableSetTask(task);
            }
        }

        // Disable Sceduled Tasks
        static void DisableSetTask(string taskname)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "schtasks.exe";
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.Arguments = "/query /TN " + "\"" + taskname + "\"";
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stdout = reader.ReadToEnd();
                    if (stdout.Contains(taskname))
                    {
                        if (stdout.Contains("Ready"))
                        {
                            EasyLogger.Info("Disabling task: " + taskname);

                            ProcessStartInfo info = new ProcessStartInfo();
                            info.FileName = "schtasks.exe";
                            info.UseShellExecute = false;
                            info.CreateNoWindow = true;
                            info.WindowStyle = ProcessWindowStyle.Hidden;
                            info.Arguments = "/change /TN " + "\"" + taskname + "\"" + " /DISABLE";
                            info.RedirectStandardOutput = true;
                            using (Process proc = Process.Start(info))
                            {
                                proc.WaitForExit();
                            }
                        }
                    }
                }
            }
        }
    }
}
