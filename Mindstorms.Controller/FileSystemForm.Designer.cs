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
            this.components = new System.ComponentModel.Container();
            this.pMain = new System.Windows.Forms.Panel();
            this.gbFilesystem = new System.Windows.Forms.GroupBox();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnStopProgram = new System.Windows.Forms.Button();
            this.lblWorkingDirectory = new System.Windows.Forms.Label();
            this.lvDirectoryContent = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdFolderContent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDownloadFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pMain.SuspendLayout();
            this.gbFilesystem.SuspendLayout();
            this.cmdFolderContent.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbFilesystem);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(800, 450);
            this.pMain.TabIndex = 0;
            // 
            // gbFilesystem
            // 
            this.gbFilesystem.Controls.Add(this.btnProjects);
            this.gbFilesystem.Controls.Add(this.btnStopProgram);
            this.gbFilesystem.Controls.Add(this.lblWorkingDirectory);
            this.gbFilesystem.Controls.Add(this.lvDirectoryContent);
            this.gbFilesystem.Controls.Add(this.statusStrip);
            this.gbFilesystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilesystem.Location = new System.Drawing.Point(0, 0);
            this.gbFilesystem.Name = "gbFilesystem";
            this.gbFilesystem.Size = new System.Drawing.Size(800, 450);
            this.gbFilesystem.TabIndex = 8;
            this.gbFilesystem.TabStop = false;
            this.gbFilesystem.Text = "Filesystem";
            // 
            // btnProjects
            // 
            this.btnProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjects.Location = new System.Drawing.Point(698, 11);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(56, 23);
            this.btnProjects.TabIndex = 6;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.BtnProjects_Click);
            // 
            // btnStopProgram
            // 
            this.btnStopProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopProgram.Image = global::Mindstorms.Controller.Properties.Resources.stop;
            this.btnStopProgram.Location = new System.Drawing.Point(760, 11);
            this.btnStopProgram.Name = "btnStopProgram";
            this.btnStopProgram.Size = new System.Drawing.Size(33, 23);
            this.btnStopProgram.TabIndex = 4;
            this.btnStopProgram.UseVisualStyleBackColor = true;
            this.btnStopProgram.Click += new System.EventHandler(this.BtnStopProgram_Click);
            // 
            // lblWorkingDirectory
            // 
            this.lblWorkingDirectory.AutoSize = true;
            this.lblWorkingDirectory.Location = new System.Drawing.Point(6, 20);
            this.lblWorkingDirectory.Name = "lblWorkingDirectory";
            this.lblWorkingDirectory.Size = new System.Drawing.Size(12, 13);
            this.lblWorkingDirectory.TabIndex = 3;
            this.lblWorkingDirectory.Text = "/";
            // 
            // lvDirectoryContent
            // 
            this.lvDirectoryContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDirectoryContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chType,
            this.chSize,
            this.chHash});
            this.lvDirectoryContent.ContextMenuStrip = this.cmdFolderContent;
            this.lvDirectoryContent.FullRowSelect = true;
            this.lvDirectoryContent.HideSelection = false;
            this.lvDirectoryContent.Location = new System.Drawing.Point(7, 36);
            this.lvDirectoryContent.Name = "lvDirectoryContent";
            this.lvDirectoryContent.Size = new System.Drawing.Size(787, 386);
            this.lvDirectoryContent.TabIndex = 2;
            this.lvDirectoryContent.UseCompatibleStateImageBehavior = false;
            this.lvDirectoryContent.View = System.Windows.Forms.View.Details;
            this.lvDirectoryContent.DoubleClick += new System.EventHandler(this.LvDirectoryContent_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 264;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            // 
            // chHash
            // 
            this.chHash.Text = "Hash";
            // 
            // cmdFolderContent
            // 
            this.cmdFolderContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDownloadFiles,
            this.tsmiUploadFile,
            this.tsmiDeleteFiles});
            this.cmdFolderContent.Name = "cmdFolderContent";
            this.cmdFolderContent.Size = new System.Drawing.Size(161, 70);
            // 
            // tsmiDownloadFiles
            // 
            this.tsmiDownloadFiles.Name = "tsmiDownloadFiles";
            this.tsmiDownloadFiles.Size = new System.Drawing.Size(160, 22);
            this.tsmiDownloadFiles.Text = "Download file(s)";
            this.tsmiDownloadFiles.Click += new System.EventHandler(this.TsmiDownloadFile_Click);
            // 
            // tsmiUploadFile
            // 
            this.tsmiUploadFile.Name = "tsmiUploadFile";
            this.tsmiUploadFile.Size = new System.Drawing.Size(160, 22);
            this.tsmiUploadFile.Text = "Upload file";
            this.tsmiUploadFile.Click += new System.EventHandler(this.TsmiUploadFile_Click);
            // 
            // tsmiDeleteFiles
            // 
            this.tsmiDeleteFiles.Name = "tsmiDeleteFiles";
            this.tsmiDeleteFiles.Size = new System.Drawing.Size(160, 22);
            this.tsmiDeleteFiles.Text = "Delete file(s)";
            this.tsmiDeleteFiles.Click += new System.EventHandler(this.TsmiDeleteFiles_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip.Location = new System.Drawing.Point(3, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(794, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FileSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMain);
            this.Name = "FileSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File system";
            this.Shown += new System.EventHandler(this.FileSystemForm_Shown);
            this.pMain.ResumeLayout(false);
            this.gbFilesystem.ResumeLayout(false);
            this.gbFilesystem.PerformLayout();
            this.cmdFolderContent.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

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
    }
}