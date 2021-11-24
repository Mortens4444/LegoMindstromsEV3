namespace Mindstorms.Controller
{
    partial class ButtonForm
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
            this.gbButtonStates = new System.Windows.Forms.GroupBox();
            this.lblButtonStates = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbButtonEvent = new System.Windows.Forms.ComboBox();
            this.gbButtonStates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbButtonStates
            // 
            this.gbButtonStates.Controls.Add(this.cbButtonEvent);
            this.gbButtonStates.Controls.Add(this.lblButtonStates);
            this.gbButtonStates.Controls.Add(this.btnDown);
            this.gbButtonStates.Controls.Add(this.btnRight);
            this.gbButtonStates.Controls.Add(this.btnCenter);
            this.gbButtonStates.Controls.Add(this.btnLeft);
            this.gbButtonStates.Controls.Add(this.btnUp);
            this.gbButtonStates.Controls.Add(this.btnBack);
            this.gbButtonStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbButtonStates.Location = new System.Drawing.Point(0, 0);
            this.gbButtonStates.Name = "gbButtonStates";
            this.gbButtonStates.Size = new System.Drawing.Size(180, 146);
            this.gbButtonStates.TabIndex = 6;
            this.gbButtonStates.TabStop = false;
            // 
            // lblButtonStates
            // 
            this.lblButtonStates.AutoSize = true;
            this.lblButtonStates.Location = new System.Drawing.Point(6, 124);
            this.lblButtonStates.Name = "lblButtonStates";
            this.lblButtonStates.Size = new System.Drawing.Size(0, 13);
            this.lblButtonStates.TabIndex = 12;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDown.Location = new System.Drawing.Point(76, 102);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(23, 23);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRight.Location = new System.Drawing.Point(105, 73);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(23, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCenter.Location = new System.Drawing.Point(76, 73);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(23, 23);
            this.btnCenter.TabIndex = 2;
            this.btnCenter.UseVisualStyleBackColor = false;
            this.btnCenter.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLeft.Location = new System.Drawing.Point(47, 73);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(23, 23);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUp.Location = new System.Drawing.Point(76, 44);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(23, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(16, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Btn_Click);
            // 
            // cbButtonEvent
            // 
            this.cbButtonEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbButtonEvent.FormattingEnabled = true;
            this.cbButtonEvent.Location = new System.Drawing.Point(47, 16);
            this.cbButtonEvent.Name = "cbButtonEvent";
            this.cbButtonEvent.Size = new System.Drawing.Size(127, 21);
            this.cbButtonEvent.TabIndex = 13;
            // 
            // ButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 146);
            this.Controls.Add(this.gbButtonStates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ButtonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buttons";
            this.Shown += new System.EventHandler(this.ButtonForm_Shown);
            this.gbButtonStates.ResumeLayout(false);
            this.gbButtonStates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbButtonStates;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblButtonStates;
        private System.Windows.Forms.ComboBox cbButtonEvent;
    }
}