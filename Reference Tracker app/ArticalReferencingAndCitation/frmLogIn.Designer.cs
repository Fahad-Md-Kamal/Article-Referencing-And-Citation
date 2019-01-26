namespace frmDeshboard
{
    partial class frmLogIn
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelPageHeaderlabeHolder = new System.Windows.Forms.Panel();
            this.lblCloseWindow = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGues = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.panelPageHeaderlabeHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 28.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Ivory;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(527, 75);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Login";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPageHeaderlabeHolder
            // 
            this.panelPageHeaderlabeHolder.Controls.Add(this.lblCloseWindow);
            this.panelPageHeaderlabeHolder.Controls.Add(this.lblHeader);
            this.panelPageHeaderlabeHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPageHeaderlabeHolder.Location = new System.Drawing.Point(0, 0);
            this.panelPageHeaderlabeHolder.Name = "panelPageHeaderlabeHolder";
            this.panelPageHeaderlabeHolder.Size = new System.Drawing.Size(527, 75);
            this.panelPageHeaderlabeHolder.TabIndex = 7;
            // 
            // lblCloseWindow
            // 
            this.lblCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseWindow.AutoSize = true;
            this.lblCloseWindow.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCloseWindow.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseWindow.ForeColor = System.Drawing.Color.Snow;
            this.lblCloseWindow.Location = new System.Drawing.Point(501, 0);
            this.lblCloseWindow.Name = "lblCloseWindow";
            this.lblCloseWindow.Size = new System.Drawing.Size(26, 30);
            this.lblCloseWindow.TabIndex = 9;
            this.lblCloseWindow.Text = "X";
            this.lblCloseWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCloseWindow.Click += new System.EventHandler(this.exit_Application);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.BackColor = System.Drawing.Color.Linen;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogIn.Location = new System.Drawing.Point(287, 273);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(161, 51);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(199, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(249, 35);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassword.Location = new System.Drawing.Point(62, 151);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 33);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(199, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 35);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsername.Location = new System.Drawing.Point(57, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 33);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "User Name:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGues
            // 
            this.lblGues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGues.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGues.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGues.Location = new System.Drawing.Point(287, 240);
            this.lblGues.Name = "lblGues";
            this.lblGues.Size = new System.Drawing.Size(161, 24);
            this.lblGues.TabIndex = 4;
            this.lblGues.Text = "Guest Login";
            this.lblGues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGues.Click += new System.EventHandler(this.lblGuest_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRegister.Location = new System.Drawing.Point(287, 202);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(161, 24);
            this.lblRegister.TabIndex = 3;
            this.lblRegister.Text = "Create Account";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(527, 343);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblGues);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panelPageHeaderlabeHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogIn";
            this.panelPageHeaderlabeHolder.ResumeLayout(false);
            this.panelPageHeaderlabeHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelPageHeaderlabeHolder;
        public System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCloseWindow;
        private System.Windows.Forms.Label lblGues;
        private System.Windows.Forms.Label lblRegister;
    }
}