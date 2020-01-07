using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.ServiceProcess;
using System.Windows.Forms;
using static Maintenance.Input;
using static Maintenance.Properties.Settings;

namespace Maintenance
{
    public partial class SettingsForm : Form
    {
        #region Entry Point and Settings

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

            DISMDays.Text = Default.DaysDism.ToString();

            SFCDays.Text = Default.DaysSFC.ToString();

            DiskCheckDays.Text = Default.DaysDiskCheck.ToString();

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

            DISMDays.TextChanged += DISMDays_TextChanged;
            SFCDays.TextChanged += SFCDays_TextChanged;
            DiskCheckDays.TextChanged += DiskCheckDays_TextChanged;

            DISMForceRun.CheckedChanged += DISMForceRun_CheckedChanged;
            SFCForceRun.CheckedChanged += SFCForceRun_CheckedChanged;
            DiskCheckForceRun.CheckedChanged += DiskCheckForceRun_CheckedChanged;
        }

        private void DISMForceRun_CheckedChanged(object sender, EventArgs e)
        {
            Default.DISMLastRun = Default.DISMLastRun.AddMonths(-6);
            Default.Save();
        }

        private void SFCForceRun_CheckedChanged(object sender, EventArgs e)
        {
            Default.SFCLastRun = Default.SFCLastRun.AddMonths(-6);
            Default.Save();
        }

        private void DiskCheckForceRun_CheckedChanged(object sender, EventArgs e)
        {
            Default.DiskCheckLastRun = Default.DiskCheckLastRun.AddMonths(-6);
            Default.Save();
        }

        private void DISMDays_TextChanged(object sender, EventArgs e)
        {
            Default.DaysDism = Convert.ToInt32(DISMDays.Text);
            Default.Save();
        }

        private void SFCDays_TextChanged(object sender, EventArgs e)
        {
            Default.DaysSFC = Convert.ToInt32(SFCDays.Text);
            Default.Save();
        }

        private void DiskCheckDays_TextChanged(object sender, EventArgs e)
        {
            Default.DaysDiskCheck = Convert.ToInt32(DiskCheckDays.Text);
            Default.Save();
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
                    EasyLogger.Error(selected + " : " + ex);
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
                    EasyLogger.Error(selected + " : " + ex);
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
                            EasyLogger.Error(selected + " : " + ex);
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
    }
}
