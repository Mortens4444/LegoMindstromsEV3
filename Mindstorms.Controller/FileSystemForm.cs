using MessageBoxes;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Resources;
using System;
using System.Collections.Generic;
using System.IO;
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
            lblWorkingDirectory.Text = currentDirectory;
            var folderContent = brick.GetFolderContent(currentDirectory);
            lvDirectoryContent.PopulateWithLegoMindstormEV3FolderContent(folderContent, currentDirectory != "/");
            tsslStatus.Text = $"{lvDirectoryContent.Items.Count} item(s)";
        }

        private void LvDirectoryContent_DoubleClick(object sender, EventArgs e)
        {
            if (lvDirectoryContent.SelectedItems.Count == 1)
            {
                var selectedFilenameFullPath = $"{lblWorkingDirectory.Text}/{lvDirectoryContent.SelectedItems[0].Text}";

                if (lvDirectoryContent.SelectedItems[0].SubItems[1].Text == ListViewExtensions.Directory)
                {
                    ListFolder(lvDirectoryContent.SelectedItems[0].ChangeWorkingDirectory(lblWorkingDirectory.Text));
                }
                else if (selectedFilenameFullPath.EndsWith(Core.Constants.SoundFileExtension))
                {
                    brick.PlaySound(selectedFilenameFullPath);
                }
                else if (selectedFilenameFullPath.EndsWith(Core.Constants.GraphicsFileExtension))
                {
                    brick.ShowImage(0, 0, selectedFilenameFullPath, LCDColor.Black);
                }
                else if (selectedFilenameFullPath.EndsWith(Core.Constants.BinaryFileExtension))
                {
                    brick.Start(selectedFilenameFullPath);
                }
            }
        }

        private void TsmiDownloadFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
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
                            var sourceFilenameFullPath = $"{lblWorkingDirectory.Text}/{item.Text}";
                            var destination = $"{folderBrowserDialog.SelectedPath}/{item.Text}";
                            if (brick.CopyFileFromBrick(sourceFilenameFullPath, destination, fileSize))
                            {
                                numberOfDownloadedFiles++;
                                indices.Add(item.Index);
                            }
                        }
                    }
                    if (numberOfDownloadedFiles > 0)
                    {
                        InfoBox.Show($"Downloading files", $"Successfully downloaded {numberOfDownloadedFiles} file(s)");
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
                    var filenameFullPath = $"{lblWorkingDirectory.Text}/{item.Text}";
                    if (brick.DeleteFile(filenameFullPath))
                    {
                        numberOfDeletedFiles++;
                    }
                }
                if (numberOfDeletedFiles > 0)
                {
                    InfoBox.Show($"Deleting files", $"Successfully deleted {numberOfDeletedFiles} file(s)");
                    ListFolder(lblWorkingDirectory.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        private void TsmiUploadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var fileName = Path.GetFileName(openFileDialog.FileName);
                var destination = $"{lblWorkingDirectory.Text}/{fileName}";
                brick.CopyFileToBrick(openFileDialog.FileName, destination);
                InfoBox.Show($"Uploading file", $"Successfully uploaded file to {destination}");
                ListFolder(lblWorkingDirectory.Text);
            }
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            ListFolder(ResourceUploader.BaseDirectory);
        }
    }
}
