using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public class FullCheckup
    {
        public static void StartCheckup(string PuranDefragArgs)
        {
            // Flush DNS
            EasyLogger.Info("*******************************  Flush DNS  *******************************" + Environment.NewLine);
            RunCommand("cmd.exe", "/C ipconfig /flushdns");

            // DISM
            if (Default.DaysDism > 0)
            {
                if (ReturnDateTime(DateTime.Now.AddDays(-Default.DaysDism), Default.DISMLastRun))
                {
                    Default.DISMLastRun = DateTime.Now;
                    Default.Save();

                    // DISM Restorehealth
                    EasyLogger.Info("*******************************  DISM Restorehealth  *******************************" + Environment.NewLine);
                    RunCommand("cmd.exe", "/C DISM.exe /Online /Cleanup-image /Restorehealth");

                    // DISM startcomponentcleanup
                    EasyLogger.Info("*******************************  DISM Component Cleanup  *******************************" + Environment.NewLine);
                    RunCommand("cmd.exe", "/C DISM.exe /online /cleanup-image /startcomponentcleanup");
                }
            }

            // System File Checker
            if (Default.DaysSFC > 0)
            {
                if (ReturnDateTime(DateTime.Now.AddDays(-Default.DaysSFC), Default.SFCLastRun))
                {
                    Default.SFCLastRun = DateTime.Now;
                    Default.Save();

                    EasyLogger.Info("*******************************  System File Checker  *******************************" + Environment.NewLine);
                    RunCommand("cmd.exe", "/C sfc /scannow");
                }
            }

            EasyLogger.Info("*******************************  Disk Check  *******************************" + Environment.NewLine);

            if (Default.DaysDiskCheck > 0)
            {
                if (ReturnDateTime(DateTime.Now.AddDays(-Default.DaysDiskCheck), Default.DiskCheckLastRun))
                {
                    Default.DiskCheckLastRun = DateTime.Now;
                    Default.Save();

                    ScheduleCheck();

                    DefragDrives(PuranDefragArgs, false);
                }
                else
                {
                    DefragDrives(PuranDefragArgs, true);
                }
            }
            else
            {
                DefragDrives(PuranDefragArgs, true);
            }
        }

        private static void DefragDrives(string PuranDefragArgs, bool Offline)
        {
            EasyLogger.Info("*******************************  Defrag  *******************************" + Environment.NewLine);

            if (PuranDefragArgs != string.Empty && File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\PuranFD.exe") && Offline)
            {
                RunCommand("PuranFD.exe", PuranDefragArgs);
            }
            else
            {
                RunCommand("PuranDC.exe", Path.GetPathRoot(Environment.SystemDirectory) + " -lp -fg -os");

                EasyLogger.Info("*********************  END OF FILE  *********************");

                RunCommand("shutdown.exe", "/t 0 /r");

                Environment.Exit(0);
            }
        }

        private static void ScheduleCheck()
        {
            EasyLogger.Info("Scheduling a disk check to run at next reboot.");

            using (Process process = new Process())
            {
                foreach (string drive in Directory.GetLogicalDrives())
                {
                    RunCommand("CMD.exe", "/c echo Y | chkdsk /F " + drive.Replace("\\", ""));
                }
            }
        }

        private static bool ReturnDateTime(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
                return false;
            else
                return true;
        }

        private static void RunCommand(string filename, string args)
        {
            try
            {
                using (Process process = new Process())
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        WindowStyle = ProcessWindowStyle.Hidden,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        StandardOutputEncoding = Encoding.GetEncoding(437),
                        FileName = filename,
                        Arguments = args
                    };

                    process.StartInfo = startInfo;

                    process.ErrorDataReceived += Proc_ErrorReceived;
                    process.OutputDataReceived += Proc_DataReceived;

                    process.Start();

                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error("Filename: " + filename + " args: " + args + " : " + ex);
            }
        }

        private static void Proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                if (e.Data != null)
                {
                    if (!e.Data.Contains("[=") && !e.Data.Contains("%") && e.Data != string.Empty)
                    {
                        string Output = Regex.Replace(e.Data, "\x00", "");
                        if (Output != string.Empty)
                        {
                            EasyLogger.Info(Output);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error(ex);
            }
        }

        private static void Proc_ErrorReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                if (e.Data != null)
                {
                    if (e.Data != string.Empty)
                    {
                        string Output = Regex.Replace(e.Data, "\x00", "");
                        EasyLogger.Info(Output);
                    }
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error(ex);
            }
        }
    }
}
