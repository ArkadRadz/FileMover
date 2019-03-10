using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileMover
{
    public partial class moverWindow : Form
    {
        private FolderBrowserDialog folderBrowser;
        private string currentDirectory = string.Empty;

        public moverWindow()
        {
            InitializeComponent();
        }

        private void fileMode_CheckedChanged(object sender, EventArgs e)
        {
            availableList.Items.Clear();

            if (currentDirectory != string.Empty)
            {
                loadFiles();
                actionLog.Text = "File mode selected. Press 'Add new' to select a target destination to move files to.";
            }
            else
            {
                actionLog.Text = "File mode selected. Click the location bar to select source directory to move files from.";
            }
        }

        private void directoryMode_CheckedChanged(object sender, EventArgs e)
        {
            availableList.Items.Clear();

            if (currentDirectory != string.Empty)
            {
                loadDirectories();
                actionLog.Text = "Directory mode selected. Press 'Add new' to select a target destination to move files to.";
            } else {
                actionLog.Text = "Directory mode selected. Click the location bar to select source directory to move files from.";
            }
        }

        private void directoryLocation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fileMode.Checked == false && directoryMode.Checked == false)
            {
                MessageBox.Show("Select a mode first");
            }
            else
            {
                folderBrowser = new FolderBrowserDialog();

                if (currentDirectory != string.Empty)
                {
                    folderBrowser.SelectedPath = currentDirectory;
                }

                if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    if (currentDirectory != folderBrowser.SelectedPath)
                    {
                        availableList.Items.Clear();

                        currentDirectory = folderBrowser.SelectedPath;

                        if (fileMode.Checked)
                        {
                            loadFiles();
                        }
                        else
                        {
                            loadDirectories();
                        }

                        directoryLocation.Text = currentDirectory;
                    }
                }
                actionLog.Text = "Selected source directory. Press 'Add new' to add one or more target directories.";
            }
        }

        private void loadDirectories()
        {
            string[] directories = Directory.GetDirectories(currentDirectory);

            foreach (var directory in directories)
            {
                availableList.Items.Add(Path.GetFileName(directory.ToString()));
            }
        }

        private void loadFiles()
        {
            string[] files = Directory.GetFiles(currentDirectory);

            foreach (var file in files)
            {
                availableList.Items.Add(Path.GetFileName(file.ToString()));
            }
        }

        private void availableList_SelectedValueChanged(object sender, EventArgs e)
        {
            fileName.Text = availableList.SelectedItem.ToString();

            try
            {
                pictureBox1.ImageLocation = currentDirectory + "\\" + availableList.SelectedItem.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            if (currentDirectory == string.Empty)
            {
                MessageBox.Show("Select a directory first.");
                return;
            }

            folderBrowser = new FolderBrowserDialog();

            if (currentDirectory != string.Empty)
            {
                folderBrowser.SelectedPath = currentDirectory;
            }

            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                foreach (Control ctrl in foldersPanel.Controls)
                {
                    if (ctrl.Name == Path.GetFileName(folderBrowser.SelectedPath.ToString()))
                    {
                        MessageBox.Show("Directory already present");
                        return;
                    }
                }
                string workingDirectory = folderBrowser.SelectedPath.ToString();
                Button btn = new Button();
                btn.Name = Path.GetFileName(workingDirectory);
                btn.Text = btn.Name;
                btn.AutoSize = true;

                btn.Click += (send, EventArgs) => { moveElement(send, EventArgs, workingDirectory); };

                foldersPanel.Controls.Add(btn);
            }
        }

        private void moveElement(object sender, EventArgs e, string targetDirectory)
        {
            try
            {
                string from = string.Empty;
                string to = string.Empty;
                if (fileMode.Checked)
                {
                    from = Path.Combine(currentDirectory + "\\" + availableList.SelectedItem.ToString());
                    to = Path.Combine(targetDirectory + "\\" + availableList.SelectedItem.ToString());

                    File.Move(from, to);
                } else
                {
                    from = Path.Combine(currentDirectory + "\\" + availableList.SelectedItem.ToString());
                    to = Path.Combine(targetDirectory + "\\" + availableList.SelectedItem.ToString());

                    Directory.Move(from, to);
                }

                int movedItemIndex = availableList.SelectedIndex;

                actionLog.Text = availableList.SelectedItem.ToString() + " moved to " + to;

                availableList.Items.Clear();

                if (fileMode.Checked)
                {
                    loadFiles();
                }
                else
                {
                    loadDirectories();
                }

                if (movedItemIndex >= availableList.Items.Count)
                {
                    availableList.SetSelected(availableList.Items.Count - 1, true);
                }
                else if (availableList.Items.Count < movedItemIndex)
                {
                    availableList.SetSelected(0, true);
                }
                else
                {
                    availableList.SetSelected(movedItemIndex, true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }

        private void previousElementButton_Click(object sender, EventArgs e)
        {
            if (currentDirectory == string.Empty)
            {
                MessageBox.Show("Select a directory first.");
                return;
            }

            if (availableList.SelectedIndex >= 1 && availableList.Items.Count >= 1)
            {
                availableList.SelectedIndex--;
            }
        }

        private void nextElementButton_Click(object sender, EventArgs e)
        {
            if (currentDirectory == string.Empty)
            {
                MessageBox.Show("Select a directory first.");
                return;
            }

            if (availableList.SelectedIndex < availableList.Items.Count-1 && availableList.Items.Count > 1)
            {
                availableList.SelectedIndex++;
            }
        }
    }
}
