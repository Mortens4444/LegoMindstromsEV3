using MessageBoxes;
using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller
{
    public partial class FileSystemForm : Form
    {
        private readonly Brick brick;

        public FileSystemForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);
        }

        private void FileSystemForm_Shown(object sender, EventArgs e)
        {
            ListFolder(lblWorkingDirectory.Text);
        }

        private void ListFolder(string currentDirectory)
        {
            var folderContent = brick.GetFolderContent(currentDirectory);
            lvDirectoryContent.PopulateWithLegoMindstormEV3FolderContent(folderContent, currentDirectory != "/");
            tsslStatus.Text = $"{lvDirectoryContent.Items.Count} item(s)";
        }

        private void LvDirectoryContent_DoubleClick(object sender, EventArgs e)
        {
            if (lvDirectoryContent.SelectedItems.Count == 1)
            {
                var selectedFilenameFullPath = String.Concat(lblWorkingDirectory.Text, "/", lvDirectoryContent.SelectedItems[0].Text);

                if (lvDirectoryContent.SelectedItems[0].SubItems[1].Text == ListViewExtensions.Directory)
                {
                    lblWorkingDirectory.Text = lvDirectoryContent.SelectedItems[0].ChangeWorkingDirectory(lblWorkingDirectory.Text);
                    ListFolder(lblWorkingDirectory.Text);
                }
                else if (selectedFilenameFullPath.EndsWith(".rsf"))
                {
                    brick.PlaySound(selectedFilenameFullPath);
                }
                else if (selectedFilenameFullPath.EndsWith(".rgf"))
                {
                    brick.ShowImage(0, 0, selectedFilenameFullPath);
                }
                else if (selectedFilenameFullPath.EndsWith(".rbf"))
                {
                    brick.Start(selectedFilenameFullPath);
                }
            }
        }

        private void TsmiDownloadFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int numberOfDownloadedFiles = 0;
                    var indices = new List<int>();
                    for (int i = 0; i < lvDirectoryContent.SelectedItems.Count; i++)
                    {
                        var item = lvDirectoryContent.SelectedItems[i];
                        if (item.SubItems[1].Text != ListViewExtensions.Directory)
                        {
                            var fileSize = Convert.ToInt32(item.SubItems[2].Text);
                            var sourceFilenameFullPath = String.Concat(lblWorkingDirectory.Text, "/", item.Text);
                            var destination = String.Concat(folderBrowserDialog.SelectedPath, "/", item.Text);
                            if (brick.CopyFileFromBrick(sourceFilenameFullPath, destination, fileSize))
                            {
                                numberOfDownloadedFiles++;
                                indices.Add(item.Index);
                            }
                        }
                    }
                    if (numberOfDownloadedFiles > 0)
                    {
                        InfoBox.Show($"Downloading files", $"Succewsfully downloaded {numberOfDownloadedFiles} file(s)");
                        for (int i = indices.Count - 1; i >= 0; i--)
                        {
                            lvDirectoryContent.Items[indices[i]].Selected = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorBox.Show(ex);
                }
            }
        }

        private void BtnStopProgram_Click(object sender, EventArgs e)
        {
            brick.StopApplication();
        }

        private void TsmiDeleteFiles_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfDeletedFiles = 0;
                for (int i = 0; i < lvDirectoryContent.SelectedItems.Count; i++)
                {
                    var item = lvDirectoryContent.SelectedItems[i];
                    var filenameFullPath = String.Concat(lblWorkingDirectory.Text, "/", item.Text);
                    if (brick.DeleteFile(filenameFullPath))
                    {
                        numberOfDeletedFiles++;
                    }
                }
                if (numberOfDeletedFiles > 0)
                {
                    InfoBox.Show($"Deleting files", $"Succewsfully deleted {numberOfDeletedFiles} file(s)");
                    ListFolder(lblWorkingDirectory.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }
    }
}
