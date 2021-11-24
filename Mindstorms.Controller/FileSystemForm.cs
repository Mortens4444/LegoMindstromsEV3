using Mindstorms.Core;
using System;
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
                else if (lvDirectoryContent.SelectedItems[0].Text.EndsWith(".rsf"))
                {
                    brick.PlaySound(selectedFilenameFullPath);
                }
                else if (lvDirectoryContent.SelectedItems[0].Text.EndsWith(".rgf"))
                {
                    brick.ShowImage(0, 0, selectedFilenameFullPath);
                }
                else if (lvDirectoryContent.SelectedItems[0].Text.EndsWith(".rbf"))
                {
                    brick.Start(selectedFilenameFullPath);
                }
            }
        }

        private void CmdFolderContent_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tsmiDownloadFile.Enabled = lvDirectoryContent.SelectedItems.Count == 1 && lvDirectoryContent.SelectedItems[0].SubItems[1].Text != ListViewExtensions.Directory;
        }

        private void TsmiDownloadFile_Click(object sender, EventArgs e)
        {
            if (lvDirectoryContent.SelectedItems.Count == 1)
            {
                downloadFileDialog.FileName = lvDirectoryContent.SelectedItems[0].Text;
                if (downloadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileSize = Convert.ToInt32(lvDirectoryContent.SelectedItems[0].SubItems[2].Text);
                    var sourceFilenameFullPath = String.Concat(lblWorkingDirectory.Text, "/", lvDirectoryContent.SelectedItems[0].Text);
                    brick.CopyFileFromBrick(sourceFilenameFullPath, downloadFileDialog.FileName, fileSize);
                }
            }
        }

        private void BtnStopProgram_Click(object sender, EventArgs e)
        {
            brick.StopApplication();
        }
    }
}
