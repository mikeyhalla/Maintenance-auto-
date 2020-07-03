using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static Maintenance.Input;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public partial class SettingsForm : Form
    {
        #region Entry Point and Settings

        Process process;
        bool StopRequested;

        public SettingsForm()
        {
            InitializeComponent();

            GetSettings();
        }

        private void GetSettings()
        {
            foreach (var item in Default.DirectoriesToDelete)
            {
                DirToDelBox.Items.Add(item);
            }

            foreach (var item in Default.FilesToDelete)
            {
                FilesToDelBox.Items.Add(item);
            }

            foreach (var item in Default.FilesToHide)
            {
                FilesHideBox.Items.Add(item);
            }

            foreach (var item in Default.PathFilesToDelete)
            {
                PathFilesDelBox.Items.Add(item);
            }

            foreach (var item in Default.PathFilesToDeleteOlder)
            {
                PathFilesDelOldBox.Items.Add(item);
            }

            foreach (var item in Default.DirectoriesToHide)
            {
                PathHideListBox.Items.Add(item);
            }

            foreach (var item in Default.ServicesToDisable)
            {
                ServicesDisableBox.Items.Add(item);
            }

            foreach (var item in Default.ServicesToManual)
            {
                ServicesManualBox.Items.Add(item);
            }

            foreach (var item in Default.TasksToDisable)
            {
                TasksDisableBox.Items.Add(item);
            }

            foreach (var item in Default.ExclusionList)
            {
                ExclusionListBox.Items.Add(item);
            }

            LoggingBox.Checked = Default.LoggingEnabled;

            Subscribe();
        }

        #endregion Entry Point and Settings

        #region Subscriptions

        private void Subscribe()
        {
            LoggingBox.CheckedChanged += LoggingBox_CheckedChanged;

            FilesToDelBox.KeyDown += FilesToDelBox_KeyDown;
            FilesHideBox.KeyDown += FilesHideBox_KeyDown;
            DirToDelBox.KeyDown += DirToDelBox_KeyDown;
            PathFilesDelBox.KeyDown += PathFilesDelBox_KeyDown;
            PathFilesDelOldBox.KeyDown += PathFilesDelOldBox_KeyDown;
            PathHideListBox.KeyDown += PathHideListBox_KeyDown;
            ServicesDisableBox.KeyDown += ServicsDisableBox_KeyDown;
            ServicesManualBox.KeyDown += ServicesManualBox_KeyDown;
            TasksDisableBox.KeyDown += TasksDisableBox_KeyDown;
            TasksTextBox.KeyDown += TasksTextBox_KeyDown;
            ExclusionListBox.KeyDown += ExclusionListBox_KeyDown;
            ExclusionListTextBox.KeyDown += ExclusionListTextBox_KeyDown;
        }

        private void FilesToDelBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(FilesToDelBox, Default.FilesToDelete);
            }
        }

        private void FilesHideBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(FilesHideBox, Default.FilesToHide);
            }
        }

        private void DirToDelBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(DirToDelBox, Default.DirectoriesToDelete);
            }
        }

        private void PathFilesDelBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(PathFilesDelBox, Default.PathFilesToDelete);
            }
        }

        private void PathFilesDelOldBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(PathFilesDelOldBox, Default.PathFilesToDeleteOlder);
            }
        }

        private void PathHideListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(PathHideListBox, Default.DirectoriesToHide);
            }
        }

        private void ServicsDisableBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(ServicesDisableBox, Default.ServicesToDisable);
            }
        }

        private void ServicesManualBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(ServicesManualBox, Default.ServicesToManual, true);
            }
        }

        private void TasksDisableBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(TasksDisableBox, Default.TasksToDisable);
            }
        }

        private void TasksTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesTextBox(TasksTextBox, TasksDisableBox, Default.TasksToDisable);
            }
        }

        private void ExclusionListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesComboBox(ExclusionListBox, Default.ExclusionList);
            }
        }

        private void ExclusionListTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTexValuesTextBox(ExclusionListTextBox, ExclusionListBox, Default.ExclusionList);
            }
        }

        #endregion Subscriptions

        #region CheckBoxes and Help Button

        private void LoggingBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LoggingBox.Checked)
            {
                Default.LoggingEnabled = true;
            }
            else
            {
                Default.LoggingEnabled = false;
            }

            Default.Save();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xCONFLiCTiONx/Maintenance#help");
        }

        #endregion CheckBoxes and Help Button

        #region Add Buttons

        private void DirDelBrowse_Click(object sender, EventArgs e)
        {
            DirectoryBrowser(DirToDelBox, Default.DirectoriesToDelete);
        }

        private void FilesDelBrowse_Click(object sender, EventArgs e)
        {
            FileBrowser(FilesToDelBox, Default.FilesToDelete);
        }

        private void FilesHideBrowse_Click(object sender, EventArgs e)
        {
            FileBrowser(FilesHideBox, Default.FilesToHide);
        }

        private void PathFilesDelBrowse_Click(object sender, EventArgs e)
        {
            DirectoryBrowser(PathFilesDelBox, Default.PathFilesToDelete);
        }

        private void PathFilesDelOldBrowse_Click(object sender, EventArgs e)
        {
            DirectoryBrowser(PathFilesDelOldBox, Default.PathFilesToDeleteOlder, true);
        }

        private void PathHideBrowse_Click(object sender, EventArgs e)
        {
            DirectoryBrowser(PathHideListBox, Default.DirectoriesToHide);
        }

        private void ExclusionListAdd_Click(object sender, EventArgs e)
        {
            bool ItemExists = false;

            var selected = ExclusionListTextBox.Text;
            if (selected != string.Empty)
            {
                foreach (string item in ExclusionListBox.Items)
                {
                    if (item == selected)
                    {
                        ItemExists = true;
                        break;
                    }
                }
                if (!ItemExists)
                {
                    ExclusionListBox.Items.Add(selected);
                    Default.ExclusionList.Add(selected);
                }

                ExclusionListTextBox.Text = string.Empty;
            }

            Default.Save();
        }

        #endregion Add Buttons

        #region Remove Buttons

        private void DirDelRemove_Click(object sender, EventArgs e)
        {
            if (DirToDelBox.SelectedItem != null)
            {
                foreach (var item in Default.DirectoriesToDelete)
                {
                    if (item == DirToDelBox.SelectedItem.ToString())
                    {
                        Default.DirectoriesToDelete.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                DirToDelBox.Items.Clear();
                DirToDelBox.Text = string.Empty;

                foreach (var item in Default.DirectoriesToDelete)
                {
                    DirToDelBox.Items.Add(item);
                }
            }
        }

        private void FilesDelRemove_Click(object sender, EventArgs e)
        {
            if (FilesToDelBox.SelectedItem != null)
            {
                foreach (var item in Default.FilesToDelete)
                {
                    if (item == FilesToDelBox.SelectedItem.ToString())
                    {
                        Default.FilesToDelete.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                FilesToDelBox.Items.Clear();
                FilesToDelBox.Text = string.Empty;

                foreach (var item in Default.FilesToDelete)
                {
                    FilesToDelBox.Items.Add(item);
                }
            }
        }

        private void FilesHideRemove_Click(object sender, EventArgs e)
        {
            if (FilesHideBox.SelectedItem != null)
            {
                foreach (var item in Default.FilesToHide)
                {
                    if (item == FilesHideBox.SelectedItem.ToString())
                    {
                        Default.FilesToHide.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                FilesHideBox.Items.Clear();
                FilesHideBox.Text = string.Empty;

                foreach (var item in Default.FilesToHide)
                {
                    FilesHideBox.Items.Add(item);
                }
            }
        }

        private void PathFilesDelRemove_Click(object sender, EventArgs e)
        {
            if (PathFilesDelBox.SelectedItem != null)
            {
                foreach (var item in Default.PathFilesToDelete)
                {
                    if (item == PathFilesDelBox.SelectedItem.ToString())
                    {
                        Default.PathFilesToDelete.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                PathFilesDelBox.Items.Clear();
                PathFilesDelBox.Text = string.Empty;

                foreach (var item in Default.PathFilesToDelete)
                {
                    PathFilesDelBox.Items.Add(item);
                }
            }
        }

        private void PathFilesDelOldRemove_Click(object sender, EventArgs e)
        {
            if (PathFilesDelOldBox.SelectedItem != null)
            {
                foreach (var item in Default.PathFilesToDeleteOlder)
                {
                    if (item == PathFilesDelOldBox.SelectedItem.ToString())
                    {
                        Default.PathFilesToDeleteOlder.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                PathFilesDelOldBox.Items.Clear();
                PathFilesDelOldBox.Text = string.Empty;

                foreach (var item in Default.PathFilesToDeleteOlder)
                {
                    PathFilesDelOldBox.Items.Add(item);
                }
            }
        }

        private void PathHideRemove_Click(object sender, EventArgs e)
        {
            if (PathHideListBox.SelectedItem != null)
            {
                foreach (var item in Default.DirectoriesToHide)
                {
                    if (item == PathHideListBox.SelectedItem.ToString())
                    {
                        Default.DirectoriesToHide.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                PathHideListBox.Items.Clear();
                PathHideListBox.Text = string.Empty;

                foreach (var item in Default.DirectoriesToHide)
                {
                    PathHideListBox.Items.Add(item);
                }
            }
        }

        private void ServicesDisableRemove_Click(object sender, EventArgs e)
        {
            if (ServicesDisableBox.SelectedItem != null)
            {
                foreach (var item in Default.ServicesToDisable)
                {
                    if (item == ServicesDisableBox.SelectedItem.ToString())
                    {
                        Default.ServicesToDisable.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                ServicesDisableBox.Items.Clear();
                ServicesDisableBox.Text = string.Empty;

                foreach (var item in Default.ServicesToDisable)
                {
                    ServicesDisableBox.Items.Add(item);
                }
            }
        }

        private void ServicesManualRemove_Click(object sender, EventArgs e)
        {
            if (ServicesManualBox.SelectedItem != null)
            {
                foreach (var item in Default.ServicesToManual)
                {
                    if (item == ServicesManualBox.SelectedItem.ToString())
                    {
                        Default.ServicesToManual.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                ServicesManualBox.Items.Clear();
                ServicesManualBox.Text = string.Empty;

                foreach (var item in Default.ServicesToManual)
                {
                    ServicesManualBox.Items.Add(item);
                }
            }
        }

        private void TasksDisableRemove_Click(object sender, EventArgs e)
        {
            if (TasksDisableBox.SelectedItem != null)
            {
                foreach (var item in Default.TasksToDisable)
                {
                    if (item == TasksDisableBox.SelectedItem.ToString())
                    {
                        Default.TasksToDisable.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                TasksDisableBox.Items.Clear();
                TasksDisableBox.Text = string.Empty;

                foreach (var item in Default.TasksToDisable)
                {
                    TasksDisableBox.Items.Add(item);
                }
            }
        }

        private void ExclusionListRemove_Click(object sender, EventArgs e)
        {
            if (ExclusionListBox.SelectedItem != null)
            {
                foreach (var item in Default.ExclusionList)
                {
                    if (item == ExclusionListBox.SelectedItem.ToString())
                    {
                        Default.ExclusionList.Remove(item);
                        break;
                    }
                }
                Default.Save();
                Default.Reload();

                ExclusionListBox.Items.Clear();
                ExclusionListBox.Text = string.Empty;

                foreach (var item in Default.ExclusionList)
                {
                    ExclusionListBox.Items.Add(item);
                }
            }
        }

        #endregion Remove Buttons

        #region Services and Tasks Buttons

        private void ServicesDisableButton_Click(object sender, EventArgs e)
        {
            bool ItemExists = false;

            var selected = ServicesTextBox.Text;

            if (selected != string.Empty)
            {
                try
                {
                    ServiceController sc = new ServiceController(selected);

                    var displayName = sc.DisplayName;

                    foreach (string item in ServicesDisableBox.Items)
                    {
                        if (item == selected + ';' + displayName)
                        {
                            ItemExists = true;
                            break;
                        }
                    }

                    if (!ItemExists)
                    {
                        ServicesDisableBox.Items.Add(selected + ';' + displayName);
                        Default.ServicesToDisable.Add(selected + ';' + displayName);
                    }
                }
                catch (Exception ex)
                {
                    EasyLogger.Error(selected + " : " + ex + Environment.NewLine);
                    BeginInvoke(new MethodInvoker(() => Console(selected + " : " + ex.Message)));
                }

                ServicesTextBox.Text = string.Empty;
            }

            Default.Save();
        }

        private void ServicesManualButton_Click(object sender, EventArgs e)
        {
            bool ItemExists = false;

            var selected = ServicesTextBox.Text;

            if (selected != string.Empty)
            {
                try
                {
                    ServiceController sc = new ServiceController(selected);

                    var displayName = sc.DisplayName;

                    foreach (string item in ServicesManualBox.Items)
                    {
                        if (item == selected + ';' + displayName)
                        {
                            ItemExists = true;
                            break;
                        }
                    }

                    if (!ItemExists)
                    {
                        ServicesManualBox.Items.Add(selected + ';' + displayName);
                        Default.ServicesToManual.Add(selected + ';' + displayName);
                    }
                }
                catch (Exception ex)
                {
                    EasyLogger.Error(selected + " : " + ex + Environment.NewLine);
                    BeginInvoke(new MethodInvoker(() => Console(selected + " : " + ex.Message)));
                }

                ServicesTextBox.Text = string.Empty;
            }

            Default.Save();
        }

        private void TasksDisableButton_Click(object sender, EventArgs e)
        {
            bool ItemExists = false;

            var selected = TasksTextBox.Text;
            if (selected != string.Empty)
            {
                foreach (string item in TasksDisableBox.Items)
                {
                    if (item == selected)
                    {
                        ItemExists = true;
                        break;
                    }
                }
                if (!ItemExists)
                {
                    TasksDisableBox.Items.Add(selected);
                    Default.TasksToDisable.Add(selected);
                }

                TasksTextBox.Text = string.Empty;
            }

            Default.Save();
        }

        #endregion Services and Tasks Buttons

        #region File and Folder Browser Dialogs

        private void DirectoryBrowser(ComboBox comboBox, StringCollection collection, bool AskDays = false)
        {
            using (FolderBrowserDialog browserDialog = new FolderBrowserDialog())
            {
                DialogResult result = browserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selected = browserDialog.SelectedPath;
                    string value = string.Empty;

                    // AskDays
                    if (AskDays)
                    {
                        if (InputBox("Days to keep", "How many days until delete:", ref value) == DialogResult.OK)
                        {
                            selected = value + ", " + selected;
                        }
                    }

                    bool ItemExists = false;

                    if (selected != string.Empty)
                    {
                        foreach (string item in comboBox.Items)
                        {
                            if (item == selected)
                            {
                                ItemExists = true;
                                break;
                            }
                        }
                        if (!ItemExists)
                        {
                            comboBox.Items.Add(selected);
                            collection.Add(selected);
                        }
                    }

                    Default.Save();
                }
            }
        }
        private void FileBrowser(ComboBox comboBox, StringCollection collection)
        {
            using (OpenFileDialog browserDialog = new OpenFileDialog())
            {
                DialogResult result = browserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selected = browserDialog.FileName;

                    bool ItemExists = false;

                    if (selected != string.Empty)
                    {
                        foreach (string item in comboBox.Items)
                        {
                            if (item == selected)
                            {
                                ItemExists = true;
                                break;
                            }
                        }
                        if (!ItemExists)
                        {
                            comboBox.Items.Add(selected);
                            collection.Add(selected);
                        }
                    }

                    Default.Save();
                }
            }
        }

        #endregion File and Folder Browser Dialogs

        #region File and Folder Add Text (Key:Enter)

        private void AddTexValuesComboBox(ComboBox comboBox, StringCollection collection, bool isService = false)
        {
            string selected = comboBox.Text;

            bool ItemExists = false;

            if (selected != string.Empty)
            {
                foreach (string item in comboBox.Items)
                {
                    if (item == selected)
                    {
                        ItemExists = true;
                        break;
                    }
                }
                if (!ItemExists)
                {
                    if (!isService)
                    {
                        comboBox.Items.Add(selected);
                        collection.Add(selected);
                    }
                    else
                    {
                        try
                        {
                            ServiceController sc = new ServiceController(selected);
                            var displayName = sc.DisplayName;

                            foreach (string item in comboBox.Items)
                            {
                                if (item == selected + ';' + displayName)
                                {
                                    ItemExists = true;
                                    break;
                                }
                            }
                            if (!ItemExists)
                            {
                                comboBox.Items.Add(selected + ';' + displayName);
                                collection.Add(selected + ';' + displayName);
                            }
                        }
                        catch (Exception ex)
                        {
                            EasyLogger.Error(selected + " : " + ex + Environment.NewLine);
                            BeginInvoke(new MethodInvoker(() => Console(selected + " : " + ex.Message)));
                        }
                    }
                }

                comboBox.Text = string.Empty;
            }

            Default.Save();
        }

        private void AddTexValuesTextBox(TextBox textBox, ComboBox comboBox, StringCollection collection)
        {
            string selected = textBox.Text;

            bool ItemExists = false;

            if (selected != string.Empty)
            {
                foreach (string item in comboBox.Items)
                {
                    if (item == selected)
                    {
                        ItemExists = true;
                        break;
                    }
                }
                if (!ItemExists)
                {
                    comboBox.Items.Add(selected);
                    collection.Add(selected);
                }

                textBox.Text = string.Empty;
            }

            Default.Save();
        }

        #endregion File and Folder Add Text (Key:Enter)

        #region Full System Checkup

        private void DiskCheck_Click(object sender, EventArgs e)
        {
            StopRequested = false;
            StopCheckup.Enabled = true;
            FullCheckup.Enabled = false;
            DiskCheck.Enabled = false;

            Thread th = new Thread(StartDiskCheck)
            {
                IsBackground = true
            };
            th.Start();
        }

        private void StartDiskCheck()
        {
            EasyLogger.Info("Running disk check(s)...");
            BeginInvoke(new MethodInvoker(() => Console("Running disk check(s)...")));

            string[] SysDrives = Directory.GetLogicalDrives().Where(d => Directory.Exists(d)).ToArray();

            foreach (string drive in SysDrives)
            {
                if (StopRequested)
                {
                    break;
                }
                RunCommand("cmd.exe", "/C echo y|ChkDsk.exe " + string.Concat(drive.Replace("\\", ""), " /x /f"), "Check Disk");
            }

            DiskCheck.Enabled = true;
            FullCheckup.Enabled = true;
        }

        private void FullCheckup_Click(object sender, EventArgs e)
        {
            StopCheckup.Enabled = true;
            DiskCheck.Enabled = false;
            FullCheckup.Enabled = false;

            Thread th = new Thread(StartCheckup)
            {
                IsBackground = true
            };
            th.Start();
        }

        private void StartCheckup()
        {
            StopRequested = false;
            EasyLogger.Info("*******************************  Flush DNS  *******************************" + Environment.NewLine);
            BeginInvoke(new MethodInvoker(() => Console("*******************************  Flush DNS  *******************************")));
            RunCommand("ipconfig.exe", "/flushdns", "Flush DNS");
            if (StopRequested)
            {
                FullCheckup.Enabled = true;
                DiskCheck.Enabled = true;
                return;
            }

            RunCommand("ipconfig.exe", "/registerdns", "Register DNS");
            if (StopRequested)
            {
                FullCheckup.Enabled = true;
                DiskCheck.Enabled = true;
                return;
            }

            EasyLogger.Info("*******************************  Sync Time  *******************************" + Environment.NewLine);
            BeginInvoke(new MethodInvoker(() => Console("*******************************  Sync Time  *******************************")));

            RunCommand("net.exe", "start w32time", "w32time");
            if (StopRequested)
            {
                FullCheckup.Enabled = true;
                DiskCheck.Enabled = true;
                return;
            }
            RunCommand("w32tm.exe", "/resync /force", "w32time");
            if (StopRequested)
            {
                FullCheckup.Enabled = true;
                DiskCheck.Enabled = true;
                return;
            }

            EasyLogger.Info("*******************************  DISM Checkup  *******************************" + Environment.NewLine);
            BeginInvoke(new MethodInvoker(() => Console("*******************************  DISM Checkup  *******************************")));

            RunCommand("DISM.exe", "/online /Cleanup-Image /StartComponentCleanup /ResetBase /RestoreHealth", "DISM");
            if (StopRequested)
            {
                FullCheckup.Enabled = true;
                DiskCheck.Enabled = true;
                return;
            }
            RunCommand("DISM.exe", "/online /Cleanup-Image /StartComponentCleanup", "DISM");
            if (StopRequested)
            {
                FullCheckup.Enabled = true;
                DiskCheck.Enabled = true;
                return;
            }

            EasyLogger.Info("*******************************  System File Checker  *******************************" + Environment.NewLine);
            BeginInvoke(new MethodInvoker(() => Console("*******************************  System File Checker  *******************************")));
            RunCommand("sfc.exe", "/scannow", "SFC");
            if (StopRequested)
            {
                FullCheckup.Enabled = true;
                DiskCheck.Enabled = true;
                return;
            }
        }

        private void StopCheckup_Click(object sender, EventArgs e)
        {
            StopRequested = true;
            StopCheckup.Enabled = false;
            int errors = 0;

            try
            {
                BeginInvoke(new MethodInvoker(() => Console("Stop Checkup requested...")));

                process.Kill();
                process.ErrorDataReceived -= Proc_ErrorReceived;
                process.OutputDataReceived -= Proc_DataReceived;
            }
            catch
            {
                errors++;
            }

            if (errors == 0)
            {
                BeginInvoke(new MethodInvoker(() => Console("Checkup has successfully stopped...")));
            }
        }

        private void RunCommand(string filename, string args, string PName)
        {
            try
            {
                process = new Process();

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = filename;
                process.StartInfo.Arguments = args;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardError = true;

                process.EnableRaisingEvents = true;
                process.ErrorDataReceived += Proc_ErrorReceived;
                process.OutputDataReceived += Proc_DataReceived;

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                int ECode = process.ExitCode;

                BeginInvoke(new MethodInvoker(() => Console(PName + " completed with exit code: " + ECode)));

                process.Dispose();
            }
            catch
            {
            }
        }

        private void Console(string output)
        {
            ConsoleOut.Text += output + Environment.NewLine;
            ConsoleOut.SelectionStart = ConsoleOut.TextLength;
            ConsoleOut.ScrollToCaret();
        }

        private void ClearConsole_Click(object sender, EventArgs e)
        {
            ConsoleOut.Clear();
        }

        private void Proc_DataReceived(object sender, DataReceivedEventArgs e)
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
                            BeginInvoke(new MethodInvoker(() => Console(Output)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error(ex + Environment.NewLine);
                BeginInvoke(new MethodInvoker(() => Console(ex.Message)));
            }
        }

        private void Proc_ErrorReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                if (e.Data != null)
                {
                    if (e.Data != string.Empty)
                    {
                        string Output = Regex.Replace(e.Data, "\x00", "");
                        EasyLogger.Info(Output);
                        BeginInvoke(new MethodInvoker(() => Console(Output)));
                    }
                }
            }
            catch (Exception ex)
            {
                EasyLogger.Error(ex + Environment.NewLine);
                BeginInvoke(new MethodInvoker(() => Console(ex.Message)));
            }
        }
        #endregion Full System Checkup
    }
}
