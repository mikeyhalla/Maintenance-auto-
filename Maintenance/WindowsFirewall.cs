using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Maintenance
{
    internal class WindowsFirewall
    {
        internal static void DeleteInvalid()
        {
            Directory.CreateDirectory("Backup");
            foreach (string file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Backup\\"))
            {
                FileInfo fileInfo = new FileInfo(file);
                bool DatabaseBackedUpStatus = fileInfo.LastWriteTime <= DateTime.Now.AddDays(-30);
                if (DatabaseBackedUpStatus)
                {
                    File.Delete(file);
                }
            }

            string datetime = DateTime.Now.ToString("Mdhms");
            RunCommand("netsh", "advfirewall export " + "\"" + AppDomain.CurrentDomain.BaseDirectory + "\\Backup\\" + datetime + "_FirwallPolicy.wfw" + "\"");


            RunCommand("netsh", "advfirewall firewall show rule name=all verbose");
        }

        private static void RunCommand(string filename, string args)
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

                process.EnableRaisingEvents = true;
                process.EnableRaisingEvents = true;
                process.StartInfo = startInfo;

                process.ErrorDataReceived += Proc_DataReceived;
                process.OutputDataReceived += Proc_DataReceived;

                process.Start();

                process.BeginErrorReadLine();
                process.BeginOutputReadLine();

                process.WaitForExit();
            }
        }

        private static void Proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.StartsWith("Program:"))
                {
                    string file = e.Data.Replace("Program:", "").TrimStart();

                    if (Path.IsPathRooted(file) && !Path.GetDirectoryName(file).StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.Windows)))
                    {
                        if (!File.Exists(file))
                        {
                            try
                            {
                                EasyLogger.Info("Removing (inbound/outbound) " + file + " from Windows Firewall...");
                                RunCommand("netsh", "advfirewall firewall delete rule name=all program= " + "\"" + file + "\"");
                            }
                            catch (Exception ex)
                            {
                                EasyLogger.Error(ex.Message);
                            }
                        }
                    }
                }
            }
        }
    }
}
