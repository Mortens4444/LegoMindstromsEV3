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
            this.lblWorkingDirectory = new System.Windows.Forms.Label();
            this.lvDirectoryContent = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdFolderContent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnStopProgram = new System.Windows.Forms.Button();
            this.pMain.SuspendLayout();
            this.gbFilesystem.SuspendLayout();
            this.cmdFolderContent.SuspendLayout();
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
            this.gbFilesystem.Controls.Add(this.btnStopProgram);
            this.gbFilesystem.Controls.Add(this.lblWorkingDirectory);
            this.gbFilesystem.Controls.Add(this.lvDirectoryContent);
            this.gbFilesystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilesystem.Location = new System.Drawing.Point(0, 0);
            this.gbFilesystem.Name = "gbFilesystem";
            this.gbFilesystem.Size = new System.Drawing.Size(800, 450);
            this.gbFilesystem.TabIndex = 8;
            this.gbFilesystem.TabStop = false;
            this.gbFilesystem.Text = "Filesystem";
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
            this.chSize});
            this.lvDirectoryContent.ContextMenuStrip = this.cmdFolderContent;
            this.lvDirectoryContent.FullRowSelect = true;
            this.lvDirectoryContent.HideSelection = false;
            this.lvDirectoryContent.Location = new System.Drawing.Point(7, 36);
            this.lvDirectoryContent.Name = "lvDirectoryContent";
            this.lvDirectoryContent.Size = new System.Drawing.Size(787, 405);
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
            // cmdFolderContent
            // 
            this.cmdFolderContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDownloadFile});
            this.cmdFolderContent.Name = "cmdFolderContent";
            this.cmdFolderContent.Size = new System.Drawing.Size(148, 26);
            this.cmdFolderContent.Opening += new System.ComponentModel.CancelEventHandler(this.CmdFolderContent_Opening);
            // 
            // tsmiDownloadFile
            // 
            this.tsmiDownloadFile.Name = "tsmiDownloadFile";
            this.tsmiDownloadFile.Size = new System.Drawing.Size(147, 22);
            this.tsmiDownloadFile.Text = "Download file";
            this.tsmiDownloadFile.Click += new System.EventHandler(this.TsmiDownloadFile_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiDownloadFile;
        private System.Windows.Forms.SaveFileDialog downloadFileDialog;
    }
}