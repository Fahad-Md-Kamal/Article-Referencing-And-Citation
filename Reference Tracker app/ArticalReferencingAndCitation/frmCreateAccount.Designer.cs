namespace frmDeshboard
{
    partial class frmCreateAccount
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
            this.panelHeaderlabelHolder = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.UserControlPanel = new System.Windows.Forms.Panel();
            this.btnEditUserInformation = new System.Windows.Forms.Button();
            this.lblHaveAccount = new System.Windows.Forms.LinkLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.panelUsersListDataGrideViewHolder = new System.Windows.Forms.Panel();
            this.dgvUsersData = new System.Windows.Forms.DataGridView();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.panelHeaderlabelHolder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.UserControlPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.panelUsersListDataGrideViewHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).BeginInit();
            this.pnlDataGridView.SuspendLayout();
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
            this.lblHeader.Size = new System.Drawing.Size(1176, 100);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Create New Account";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeaderlabelHolder
            // 
            this.panelHeaderlabelHolder.Controls.Add(this.lblExit);
            this.panelHeaderlabelHolder.Controls.Add(this.lblHeader);
            this.panelHeaderlabelHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderlabelHolder.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderlabelHolder.Name = "panelHeaderlabelHolder";
            this.panelHeaderlabelHolder.Size = new System.Drawing.Size(1176, 100);
            this.panelHeaderlabelHolder.TabIndex = 5;
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.DarkCyan;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(1137, 2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(35, 37);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Bisque;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panelUserInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminPanel, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.557292F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.44271F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 768);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.Bisque;
            this.panelUserInfo.Controls.Add(this.UserControlPanel);
            this.panelUserInfo.Controls.Add(this.txtPassword);
            this.panelUserInfo.Controls.Add(this.lblPassword);
            this.panelUserInfo.Controls.Add(this.txtAddress);
            this.panelUserInfo.Controls.Add(this.lblAddress);
            this.panelUserInfo.Controls.Add(this.txtEmail);
            this.panelUserInfo.Controls.Add(this.lblEmail);
            this.panelUserInfo.Controls.Add(this.txtUserId);
            this.panelUserInfo.Controls.Add(this.lblUserId);
            this.panelUserInfo.Controls.Add(this.txtContact);
            this.panelUserInfo.Controls.Add(this.lblContact);
            this.panelUserInfo.Controls.Add(this.txtLastName);
            this.panelUserInfo.Controls.Add(this.lblLastName);
            this.panelUserInfo.Controls.Add(this.txtFirstName);
            this.panelUserInfo.Controls.Add(this.lblFirstName);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserInfo.Location = new System.Drawing.Point(61, 38);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(640, 727);
            this.panelUserInfo.TabIndex = 7;
            // 
            // UserControlPanel
            // 
            this.UserControlPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserControlPanel.Controls.Add(this.btnEditUserInformation);
            this.UserControlPanel.Controls.Add(this.lblHaveAccount);
            this.UserControlPanel.Controls.Add(this.btnSubmit);
            this.UserControlPanel.Location = new System.Drawing.Point(357, 508);
            this.UserControlPanel.Name = "UserControlPanel";
            this.UserControlPanel.Size = new System.Drawing.Size(268, 102);
            this.UserControlPanel.TabIndex = 4;
            // 
            // btnEditUserInformation
            // 
            this.btnEditUserInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditUserInformation.BackColor = System.Drawing.Color.Linen;
            this.btnEditUserInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUserInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.btnEditUserInformation.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEditUserInformation.Location = new System.Drawing.Point(4, 50);
            this.btnEditUserInformation.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditUserInformation.Name = "btnEditUserInformation";
            this.btnEditUserInformation.Size = new System.Drawing.Size(94, 41);
            this.btnEditUserInformation.TabIndex = 1;
            this.btnEditUserInformation.Text = "Update";
            this.btnEditUserInformation.UseVisualStyleBackColor = false;
            this.btnEditUserInformation.Click += new System.EventHandler(this.UserUpdateData);
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHaveAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaveAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblHaveAccount.LinkColor = System.Drawing.Color.Gray;
            this.lblHaveAccount.Location = new System.Drawing.Point(66, 12);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(179, 23);
            this.lblHaveAccount.TabIndex = 3;
            this.lblHaveAccount.TabStop = true;
            this.lblHaveAccount.Text = "Already Have Account";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.BackColor = System.Drawing.Color.Linen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSubmit.Location = new System.Drawing.Point(174, 50);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 41);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.SaveData);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(224, 377);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(401, 35);
            this.txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPassword.Location = new System.Drawing.Point(98, 377);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 33);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(224, 315);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(401, 35);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAddress.Location = new System.Drawing.Point(94, 315);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(124, 33);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(224, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(401, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEmail.Location = new System.Drawing.Point(93, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 33);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtUserId.Location = new System.Drawing.Point(224, 129);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(401, 35);
            this.txtUserId.TabIndex = 2;
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblUserId.Location = new System.Drawing.Point(93, 129);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(124, 33);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User ID:";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtContact.Location = new System.Drawing.Point(224, 191);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(401, 35);
            this.txtContact.TabIndex = 3;
            // 
            // lblContact
            // 
            this.lblContact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblContact.Location = new System.Drawing.Point(93, 191);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(124, 33);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contact:";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(224, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(401, 35);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblLastName.Location = new System.Drawing.Point(94, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(124, 33);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(224, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(401, 35);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblFirstName.Location = new System.Drawing.Point(94, 5);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(124, 33);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.panelUsersListDataGrideViewHolder);
            this.AdminPanel.Controls.Add(this.pnlDataGridView);
            this.AdminPanel.Controls.Add(this.cmbUserType);
            this.AdminPanel.Controls.Add(this.btnDelete);
            this.AdminPanel.Controls.Add(this.btnUpdate);
            this.AdminPanel.Controls.Add(this.btnSave);
            this.AdminPanel.Controls.Add(this.lblAdminPanel);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanel.Location = new System.Drawing.Point(707, 38);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(405, 727);
            this.AdminPanel.TabIndex = 8;
            // 
            // panelUsersListDataGrideViewHolder
            // 
            this.panelUsersListDataGrideViewHolder.Controls.Add(this.dgvUsersData);
            this.panelUsersListDataGrideViewHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersListDataGrideViewHolder.Location = new System.Drawing.Point(0, 121);
            this.panelUsersListDataGrideViewHolder.Name = "panelUsersListDataGrideViewHolder";
            this.panelUsersListDataGrideViewHolder.Size = new System.Drawing.Size(405, 331);
            this.panelUsersListDataGrideViewHolder.TabIndex = 5;
            // 
            // dgvUsersData
            // 
            this.dgvUsersData.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvUsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersData.GridColor = System.Drawing.Color.Bisque;
            this.dgvUsersData.Location = new System.Drawing.Point(0, 0);
            this.dgvUsersData.Name = "dgvUsersData";
            this.dgvUsersData.Size = new System.Drawing.Size(405, 331);
            this.dgvUsersData.TabIndex = 3;
            this.dgvUsersData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCellClick);
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Controls.Add(this.btnSearch);
            this.pnlDataGridView.Controls.Add(this.txtSearch);
            this.pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataGridView.Location = new System.Drawing.Point(0, 60);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(405, 61);
            this.pnlDataGridView.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSearch.Location = new System.Drawing.Point(5, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.SearchData);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(114, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 35);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbUserType
            // 
            this.cmbUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUserType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.cmbUserType.Location = new System.Drawing.Point(5, 464);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(397, 29);
            this.cmbUserType.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Linen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.Location = new System.Drawing.Point(5, 558);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.DeleteData);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.Linen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdate.Location = new System.Drawing.Point(152, 558);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.AdminUpdateData);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Linen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.Location = new System.Drawing.Point(310, 558);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveData);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblAdminPanel.ForeColor = System.Drawing.Color.Ivory;
            this.lblAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(405, 60);
            this.lblAdminPanel.TabIndex = 1;
            this.lblAdminPanel.Text = "Admin Control";
            this.lblAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 868);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelHeaderlabelHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateAccount";
            this.Text = "frmCreateAccount";
            this.panelHeaderlabelHolder.ResumeLayout(false);
            this.panelHeaderlabelHolder.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.UserControlPanel.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.panelUsersListDataGrideViewHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).EndInit();
            this.pnlDataGridView.ResumeLayout(false);
            this.pnlDataGridView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelHeaderlabelHolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.LinkLabel lblHaveAccount;
        private System.Windows.Forms.Button btnEditUserInformation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel UserControlPanel;
        private System.Windows.Forms.Panel panelUsersListDataGrideViewHolder;
        private System.Windows.Forms.DataGridView dgvUsersData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblExit;
    }
}