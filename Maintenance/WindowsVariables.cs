using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Maintenance
{
    internal class WindowsVariables
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

            // User Path
            string NewUserPath = string.Empty;
            string OldUserPath = GetUserPath(@"Environment", "Path");

            string[] sArray = OldUserPath.Split(';');

            foreach (string path in sArray)
            {
                if (!Directory.Exists(path))
                {
                    EasyLogger.Info("Removing: " + path);
                }
                else
                {
                    if (NewUserPath == string.Empty)
                    {
                        NewUserPath += path;
                    }
                    else
                    {
                        NewUserPath += ";" + path;
                    }
                }
            }            

            if (NewUserPath != OldUserPath)
            {
                RunCommand("reg", "export " + @"HKEY_CURRENT_USER\Environment" + "\"" + AppDomain.CurrentDomain.BaseDirectory + "\\Backup\\" + DateTime.Now.ToString("Mdhms") + "_SystemPath.reg" + "\"");

                EditUser(@"Environment", NewUserPath);

                EasyLogger.Info("Updated User Path: " + NewUserPath);
            }

            // System Path
            string NewSystemPath = string.Empty;
            string OldSystemPath = GetSystemPath(@"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", "Path");

            sArray = OldSystemPath.Split(';');

            foreach (string path in sArray)
            {
                if (!Directory.Exists(path))
                {
                    EasyLogger.Info("Removing: " + path);
                }
                else
                {
                    if (NewSystemPath == string.Empty)
                    {
                        NewSystemPath += path;
                    }
                    else
                    {
                        NewSystemPath += ";" + path;
                    }
                }
            }

            if (NewSystemPath != OldSystemPath)
            {
                RunCommand("reg", "export " + @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" + "\"" + AppDomain.CurrentDomain.BaseDirectory + "\\Backup\\" + DateTime.Now.ToString("Mdhms") + "_SystemPath.reg" + "\"");

                EditSystem(@"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", NewSystemPath);

                EasyLogger.Info("Updated System Path: " + NewSystemPath);
            }
        }

        private static string GetUserPath(string path, string value)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(path))
            {
                if (key != null)
                {
                    object o = key.GetValue(value);
                    if (o != null)
                    {
                        return o.ToString();
                    }
                }

                return null;
            }
        }

        private static string GetSystemPath(string path, string value)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path))
            {
                if (key != null)
                {
                    object o = key.GetValue(value);
                    if (o != null)
                    {
                        return o.ToString();
                    }
                }

                return null;
            }
        }

        private static void EditUser(string path, string value)
        {
            RegistryKey myKey = Registry.CurrentUser.OpenSubKey(path, true);
            if (myKey != null)
            {
                myKey.SetValue("Path", value, RegistryValueKind.String);
                myKey.Close();
            }
        }

        private static void EditSystem(string path, string value)
        {
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(path, true);
            if (myKey != null)
            {
                myKey.SetValue("Path", value, RegistryValueKind.String);
                myKey.Close();
            }
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
                EasyLogger.Info(e.Data);
            }
        }
    }
}
