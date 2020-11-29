using Microsoft.Win32;
using System.IO;

namespace Maintenance
{
    internal class WindowsVariables
    {
        internal static void DeleteInvalid()
        {
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

            EditUser(@"Environment", NewUserPath);

            if (NewUserPath != OldUserPath)
            {
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

            EditSystem(@"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", NewSystemPath);

            if (NewSystemPath != OldSystemPath)
            {
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
    }
}
