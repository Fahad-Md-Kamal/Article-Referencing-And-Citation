namespace frmDeshboard
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.panelCaption = new System.Windows.Forms.Panel();
            this.lblMessageName = new System.Windows.Forms.Label();
            this.lblCloseApplication = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.panelBodyHolder = new System.Windows.Forms.Panel();
            this.panelCaption.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.panelBodyHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCaption
            // 
            this.panelCaption.BackColor = System.Drawing.Color.Transparent;
            this.panelCaption.Controls.Add(this.lblMessageName);
            this.panelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaption.Location = new System.Drawing.Point(0, 0);
            this.panelCaption.Name = "panelCaption";
            this.panelCaption.Size = new System.Drawing.Size(522, 36);
            this.panelCaption.TabIndex = 0;
            // 
            // lblMessageName
            // 
            this.lblMessageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessageName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageName.ForeColor = System.Drawing.Color.White;
            this.lblMessageName.Location = new System.Drawing.Point(0, 0);
            this.lblMessageName.Name = "lblMessageName";
            this.lblMessageName.Size = new System.Drawing.Size(522, 36);
            this.lblMessageName.TabIndex = 1;
            this.lblMessageName.Text = "Caption";
            this.lblMessageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCloseApplication
            // 
            this.lblCloseApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseApplication.AutoSize = true;
            this.lblCloseApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseApplication.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCloseApplication.ForeColor = System.Drawing.Color.Transparent;
            this.lblCloseApplication.Location = new System.Drawing.Point(488, 2);
            this.lblCloseApplication.Name = "lblCloseApplication";
            this.lblCloseApplication.Size = new System.Drawing.Size(31, 32);
            this.lblCloseApplication.TabIndex = 1;
            this.lblCloseApplication.Text = "X";
            this.lblCloseApplication.Click += new System.EventHandler(this.CloseApplicaition_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(78, 131);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(105, 42);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = ".";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(338, 134);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(105, 42);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ".";
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.Transparent;
            this.panelMessage.Controls.Add(this.lblCaption);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMessage.Location = new System.Drawing.Point(0, 36);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(522, 85);
            this.panelMessage.TabIndex = 2;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(522, 85);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "This is custom Messagebox";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBodyHolder
            // 
            this.panelBodyHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelBodyHolder.Controls.Add(this.btnRight);
            this.panelBodyHolder.Controls.Add(this.panelMessage);
            this.panelBodyHolder.Controls.Add(this.btnLeft);
            this.panelBodyHolder.Controls.Add(this.panelCaption);
            this.panelBodyHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBodyHolder.Location = new System.Drawing.Point(0, 23);
            this.panelBodyHolder.Name = "panelBodyHolder";
            this.panelBodyHolder.Size = new System.Drawing.Size(522, 181);
            this.panelBodyHolder.TabIndex = 3;
            // 
            // MsgBox
            // 
            this.AcceptButton = this.btnLeft;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnRight;
            this.ClientSize = new System.Drawing.Size(522, 204);
            this.Controls.Add(this.lblCloseApplication);
            this.Controls.Add(this.panelBodyHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBox";
            this.panelCaption.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.panelBodyHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCaption;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblCloseApplication;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Label lblMessageName;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel panelBodyHolder;
    }
}