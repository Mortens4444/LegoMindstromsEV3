namespace Mindstorms.Controller
{
    partial class FileSystemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pMain = new Panel();
            gbFilesystem = new GroupBox();
            tbFolder = new TextBox();
            btnCreateFolder = new Button();
            btnProjects = new Button();
            btnStopProgram = new Button();
            lblWorkingDirectory = new Label();
            lvDirectoryContent = new ListView();
            chName = new ColumnHeader();
            chType = new ColumnHeader();
            chSize = new ColumnHeader();
            chHash = new ColumnHeader();
            cmdFolderContent = new ContextMenuStrip(components);
            tsmiViewFileContent = new ToolStripMenuItem();
            tsmiDownloadFiles = new ToolStripMenuItem();
            tsmiDeleteFiles = new ToolStripMenuItem();
            separator = new ToolStripSeparator();
            tsmiUploadFile = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            tsslStatus = new ToolStripStatusLabel();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialog = new OpenFileDialog();
            pMain.SuspendLayout();
            gbFilesystem.SuspendLayout();
            cmdFolderContent.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(gbFilesystem);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 0);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(933, 519);
            pMain.TabIndex = 0;
            // 
            // gbFilesystem
            // 
            gbFilesystem.Controls.Add(tbFolder);
            gbFilesystem.Controls.Add(btnCreateFolder);
            gbFilesystem.Controls.Add(btnProjects);
            gbFilesystem.Controls.Add(btnStopProgram);
            gbFilesystem.Controls.Add(lblWorkingDirectory);
            gbFilesystem.Controls.Add(lvDirectoryContent);
            gbFilesystem.Controls.Add(statusStrip);
            gbFilesystem.Dock = DockStyle.Fill;
            gbFilesystem.Location = new Point(0, 0);
            gbFilesystem.Margin = new Padding(4, 3, 4, 3);
            gbFilesystem.Name = "gbFilesystem";
            gbFilesystem.Padding = new Padding(4, 3, 4, 3);
            gbFilesystem.Size = new Size(933, 519);
            gbFilesystem.TabIndex = 8;
            gbFilesystem.TabStop = false;
            gbFilesystem.Text = "Filesystem";
            // 
            // tbFolder
            // 
            tbFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbFolder.Location = new Point(526, 14);
            tbFolder.Margin = new Padding(4, 3, 4, 3);
            tbFolder.Name = "tbFolder";
            tbFolder.Size = new Size(186, 23);
            tbFolder.TabIndex = 8;
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateFolder.Location = new Point(720, 13);
            btnCreateFolder.Margin = new Padding(4, 3, 4, 3);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(88, 27);
            btnCreateFolder.TabIndex = 7;
            btnCreateFolder.Text = "Create folder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += BtnCreateFolder_Click;
            // 
            // btnProjects
            // 
            btnProjects.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProjects.Location = new Point(814, 13);
            btnProjects.Margin = new Padding(4, 3, 4, 3);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(65, 27);
            btnProjects.TabIndex = 6;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += BtnProjects_Click;
            // 
            // btnStopProgram
            // 
            btnStopProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStopProgram.Image = Properties.Resources.stop;
            btnStopProgram.Location = new Point(887, 13);
            btnStopProgram.Margin = new Padding(4, 3, 4, 3);
            btnStopProgram.Name = "btnStopProgram";
            btnStopProgram.Size = new Size(38, 27);
            btnStopProgram.TabIndex = 4;
            btnStopProgram.UseVisualStyleBackColor = true;
            btnStopProgram.Click += BtnStopProgram_Click;
            // 
            // lblWorkingDirectory
            // 
            lblWorkingDirectory.AutoSize = true;
            lblWorkingDirectory.Location = new Point(7, 23);
            lblWorkingDirectory.Margin = new Padding(4, 0, 4, 0);
            lblWorkingDirectory.Name = "lblWorkingDirectory";
            lblWorkingDirectory.Size = new Size(12, 15);
            lblWorkingDirectory.TabIndex = 3;
            lblWorkingDirectory.Text = "/";
            // 
            // lvDirectoryContent
            // 
            lvDirectoryContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvDirectoryContent.Columns.AddRange(new ColumnHeader[] { chName, chType, chSize, chHash });
            lvDirectoryContent.ContextMenuStrip = cmdFolderContent;
            lvDirectoryContent.FullRowSelect = true;
            lvDirectoryContent.Location = new Point(8, 42);
            lvDirectoryContent.Margin = new Padding(4, 3, 4, 3);
            lvDirectoryContent.Name = "lvDirectoryContent";
            lvDirectoryContent.Size = new Size(917, 445);
            lvDirectoryContent.TabIndex = 2;
            lvDirectoryContent.UseCompatibleStateImageBehavior = false;
            lvDirectoryContent.View = View.Details;
            lvDirectoryContent.DoubleClick += LvDirectoryContent_DoubleClick;
            // 
            // chName
            // 
            chName.Text = "Name";
            chName.Width = 264;
            // 
            // chType
            // 
            chType.Text = "Type";
            // 
            // chSize
            // 
            chSize.Text = "Size";
            // 
            // chHash
            // 
            chHash.Text = "Hash";
            // 
            // cmdFolderContent
            // 
            cmdFolderContent.Items.AddRange(new ToolStripItem[] { tsmiViewFileContent, tsmiDownloadFiles, tsmiDeleteFiles, separator, tsmiUploadFile });
            cmdFolderContent.Name = "cmdFolderContent";
            cmdFolderContent.Size = new Size(182, 98);
            cmdFolderContent.Opening += CmdFolderContent_Opening;
            // 
            // tsmiViewFileContent
            // 
            tsmiViewFileContent.Name = "tsmiViewFileContent";
            tsmiViewFileContent.ShortcutKeys = Keys.F3;
            tsmiViewFileContent.Size = new Size(181, 22);
            tsmiViewFileContent.Text = "View file content";
            tsmiViewFileContent.Click += TsmiViewFileContent_Click;
            // 
            // tsmiDownloadFiles
            // 
            tsmiDownloadFiles.Name = "tsmiDownloadFiles";
            tsmiDownloadFiles.Size = new Size(181, 22);
            tsmiDownloadFiles.Text = "Download file(s)";
            tsmiDownloadFiles.Click += TsmiDownloadFile_Click;
            // 
            // tsmiDeleteFiles
            // 
            tsmiDeleteFiles.Name = "tsmiDeleteFiles";
            tsmiDeleteFiles.Size = new Size(181, 22);
            tsmiDeleteFiles.Text = "Delete file(s)";
            tsmiDeleteFiles.Click += TsmiDeleteFiles_Click;
            // 
            // separator
            // 
            separator.Name = "separator";
            separator.Size = new Size(178, 6);
            // 
            // tsmiUploadFile
            // 
            tsmiUploadFile.Name = "tsmiUploadFile";
            tsmiUploadFile.Size = new Size(181, 22);
            tsmiUploadFile.Text = "Upload file";
            tsmiUploadFile.Click += TsmiUploadFile_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { tsslStatus });
            statusStrip.Location = new Point(4, 494);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(925, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            tsslStatus.Name = "tsslStatus";
            tsslStatus.Size = new Size(0, 17);
            // 
            // FileSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FileSystemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File system";
            Shown += FileSystemForm_Shown;
            pMain.ResumeLayout(false);
            gbFilesystem.ResumeLayout(false);
            gbFilesystem.PerformLayout();
            cmdFolderContent.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbFilesystem;
        private System.Windows.Forms.Button btnStopProgram;
        private System.Windows.Forms.Label lblWorkingDirectory;
        private System.Windows.Forms.ListView lvDirectoryContent;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ContextMenuStrip cmdFolderContent;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownloadFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteFiles;
        private System.Windows.Forms.ColumnHeader chHash;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiUploadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewFileContent;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnCreateFolder;
    }
}