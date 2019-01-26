namespace frmDeshboard
{
    partial class frmArticles
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
            this.PanelFullPageHolder = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelControlHolder = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelText = new System.Windows.Forms.Panel();
            this.txtRefrence = new System.Windows.Forms.TextBox();
            this.txtWordEditor = new System.Windows.Forms.TextBox();
            this.panelDatagridViewHolder = new System.Windows.Forms.Panel();
            this.panelButtonAndComboBoxHolder = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbRefrenceType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddToText = new System.Windows.Forms.Button();
            this.btnCreateRefrence = new System.Windows.Forms.Button();
            this.DGVRefList = new System.Windows.Forms.DataGridView();
            this.lblRefrences = new System.Windows.Forms.Label();
            this.DGVArticlesList = new System.Windows.Forms.DataGridView();
            this.lblOtherDocs = new System.Windows.Forms.Label();
            this.panelButtonHolder = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDeleteText = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateText = new System.Windows.Forms.Button();
            this.panelCheckboxHolder = new System.Windows.Forms.Panel();
            this.chkPrintWithRef = new System.Windows.Forms.CheckBox();
            this.PanelFullPageHolder.SuspendLayout();
            this.panelControlHolder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelText.SuspendLayout();
            this.panelDatagridViewHolder.SuspendLayout();
            this.panelButtonAndComboBoxHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRefList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticlesList)).BeginInit();
            this.panelButtonHolder.SuspendLayout();
            this.panelCheckboxHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFullPageHolder
            // 
            this.PanelFullPageHolder.Controls.Add(this.lblHeader);
            this.PanelFullPageHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFullPageHolder.Location = new System.Drawing.Point(0, 0);
            this.PanelFullPageHolder.Name = "PanelFullPageHolder";
            this.PanelFullPageHolder.Size = new System.Drawing.Size(1176, 100);
            this.PanelFullPageHolder.TabIndex = 9;
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
            this.lblHeader.Text = "Text Editor";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControlHolder
            // 
            this.panelControlHolder.Controls.Add(this.tableLayoutPanel1);
            this.panelControlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlHolder.Location = new System.Drawing.Point(0, 100);
            this.panelControlHolder.Name = "panelControlHolder";
            this.panelControlHolder.Size = new System.Drawing.Size(1176, 673);
            this.panelControlHolder.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Bisque;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.996601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.60204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.46599F));
            this.tableLayoutPanel1.Controls.Add(this.PanelText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDatagridViewHolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelButtonHolder, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelCheckboxHolder, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelText
            // 
            this.PanelText.Controls.Add(this.txtRefrence);
            this.PanelText.Controls.Add(this.txtWordEditor);
            this.PanelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelText.Location = new System.Drawing.Point(61, 3);
            this.PanelText.Name = "PanelText";
            this.PanelText.Size = new System.Drawing.Size(788, 599);
            this.PanelText.TabIndex = 0;
            // 
            // txtRefrence
            // 
            this.txtRefrence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRefrence.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefrence.Location = new System.Drawing.Point(0, 495);
            this.txtRefrence.Multiline = true;
            this.txtRefrence.Name = "txtRefrence";
            this.txtRefrence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRefrence.Size = new System.Drawing.Size(788, 104);
            this.txtRefrence.TabIndex = 1;
            // 
            // txtWordEditor
            // 
            this.txtWordEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtWordEditor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordEditor.Location = new System.Drawing.Point(0, 0);
            this.txtWordEditor.Multiline = true;
            this.txtWordEditor.Name = "txtWordEditor";
            this.txtWordEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWordEditor.Size = new System.Drawing.Size(788, 495);
            this.txtWordEditor.TabIndex = 0;
            // 
            // panelDatagridViewHolder
            // 
            this.panelDatagridViewHolder.Controls.Add(this.panelButtonAndComboBoxHolder);
            this.panelDatagridViewHolder.Controls.Add(this.DGVRefList);
            this.panelDatagridViewHolder.Controls.Add(this.lblRefrences);
            this.panelDatagridViewHolder.Controls.Add(this.DGVArticlesList);
            this.panelDatagridViewHolder.Controls.Add(this.lblOtherDocs);
            this.panelDatagridViewHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatagridViewHolder.Location = new System.Drawing.Point(855, 3);
            this.panelDatagridViewHolder.Name = "panelDatagridViewHolder";
            this.panelDatagridViewHolder.Size = new System.Drawing.Size(318, 599);
            this.panelDatagridViewHolder.TabIndex = 3;
            // 
            // panelButtonAndComboBoxHolder
            // 
            this.panelButtonAndComboBoxHolder.Controls.Add(this.txtSearch);
            this.panelButtonAndComboBoxHolder.Controls.Add(this.cmbRefrenceType);
            this.panelButtonAndComboBoxHolder.Controls.Add(this.btnSearch);
            this.panelButtonAndComboBoxHolder.Controls.Add(this.btnAddToText);
            this.panelButtonAndComboBoxHolder.Controls.Add(this.btnCreateRefrence);
            this.panelButtonAndComboBoxHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonAndComboBoxHolder.Location = new System.Drawing.Point(0, 450);
            this.panelButtonAndComboBoxHolder.Name = "panelButtonAndComboBoxHolder";
            this.panelButtonAndComboBoxHolder.Size = new System.Drawing.Size(318, 149);
            this.panelButtonAndComboBoxHolder.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(115, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 35);
            this.txtSearch.TabIndex = 3;
            // 
            // cmbRefrenceType
            // 
            this.cmbRefrenceType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbRefrenceType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbRefrenceType.FormattingEnabled = true;
            this.cmbRefrenceType.Items.AddRange(new object[] {
            "-- Select Refrence Style --",
            "Harvard - Citation",
            "APA - Citation",
            "Chicago Style - Citation"});
            this.cmbRefrenceType.Location = new System.Drawing.Point(3, 121);
            this.cmbRefrenceType.Name = "cmbRefrenceType";
            this.cmbRefrenceType.Size = new System.Drawing.Size(307, 25);
            this.cmbRefrenceType.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.btnSearch.Location = new System.Drawing.Point(5, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddToText
            // 
            this.btnAddToText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddToText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddToText.FlatAppearance.BorderSize = 0;
            this.btnAddToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.btnAddToText.Location = new System.Drawing.Point(3, 45);
            this.btnAddToText.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddToText.Name = "btnAddToText";
            this.btnAddToText.Size = new System.Drawing.Size(307, 34);
            this.btnAddToText.TabIndex = 1;
            this.btnAddToText.Text = "Add To Text";
            this.btnAddToText.UseVisualStyleBackColor = false;
            this.btnAddToText.Click += new System.EventHandler(this.btnAddToText_Click);
            // 
            // btnCreateRefrence
            // 
            this.btnCreateRefrence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateRefrence.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateRefrence.FlatAppearance.BorderSize = 0;
            this.btnCreateRefrence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRefrence.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateRefrence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.btnCreateRefrence.Location = new System.Drawing.Point(3, 84);
            this.btnCreateRefrence.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateRefrence.Name = "btnCreateRefrence";
            this.btnCreateRefrence.Size = new System.Drawing.Size(307, 34);
            this.btnCreateRefrence.TabIndex = 2;
            this.btnCreateRefrence.Text = "Create Refrence";
            this.btnCreateRefrence.UseVisualStyleBackColor = false;
            this.btnCreateRefrence.Click += new System.EventHandler(this.btnCreateRefrence_Click);
            // 
            // DGVRefList
            // 
            this.DGVRefList.BackgroundColor = System.Drawing.Color.White;
            this.DGVRefList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRefList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVRefList.Location = new System.Drawing.Point(0, 251);
            this.DGVRefList.Name = "DGVRefList";
            this.DGVRefList.Size = new System.Drawing.Size(318, 199);
            this.DGVRefList.TabIndex = 0;
            this.DGVRefList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRefList_CellClick);
            // 
            // lblRefrences
            // 
            this.lblRefrences.BackColor = System.Drawing.Color.DarkCyan;
            this.lblRefrences.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRefrences.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRefrences.ForeColor = System.Drawing.Color.Ivory;
            this.lblRefrences.Location = new System.Drawing.Point(0, 200);
            this.lblRefrences.Name = "lblRefrences";
            this.lblRefrences.Size = new System.Drawing.Size(318, 51);
            this.lblRefrences.TabIndex = 3;
            this.lblRefrences.Text = "Available Refrences";
            this.lblRefrences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVArticlesList
            // 
            this.DGVArticlesList.BackgroundColor = System.Drawing.Color.White;
            this.DGVArticlesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticlesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVArticlesList.Location = new System.Drawing.Point(0, 46);
            this.DGVArticlesList.Name = "DGVArticlesList";
            this.DGVArticlesList.Size = new System.Drawing.Size(318, 154);
            this.DGVArticlesList.TabIndex = 2;
            this.DGVArticlesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVArticlesList_CellClick);
            // 
            // lblOtherDocs
            // 
            this.lblOtherDocs.BackColor = System.Drawing.Color.DarkCyan;
            this.lblOtherDocs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOtherDocs.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOtherDocs.ForeColor = System.Drawing.Color.Ivory;
            this.lblOtherDocs.Location = new System.Drawing.Point(0, 0);
            this.lblOtherDocs.Name = "lblOtherDocs";
            this.lblOtherDocs.Size = new System.Drawing.Size(318, 46);
            this.lblOtherDocs.TabIndex = 4;
            this.lblOtherDocs.Text = "Your All Documents";
            this.lblOtherDocs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonHolder
            // 
            this.panelButtonHolder.Controls.Add(this.btnPrint);
            this.panelButtonHolder.Controls.Add(this.btnDeleteText);
            this.panelButtonHolder.Controls.Add(this.btnSave);
            this.panelButtonHolder.Controls.Add(this.btnUpdateText);
            this.panelButtonHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonHolder.Location = new System.Drawing.Point(61, 608);
            this.panelButtonHolder.Name = "panelButtonHolder";
            this.panelButtonHolder.Size = new System.Drawing.Size(788, 62);
            this.panelButtonHolder.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.btnPrint.Location = new System.Drawing.Point(587, 8);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(182, 45);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Article";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDeleteText
            // 
            this.btnDeleteText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteText.FlatAppearance.BorderSize = 0;
            this.btnDeleteText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.btnDeleteText.Location = new System.Drawing.Point(5, 8);
            this.btnDeleteText.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteText.Name = "btnDeleteText";
            this.btnDeleteText.Size = new System.Drawing.Size(154, 45);
            this.btnDeleteText.TabIndex = 2;
            this.btnDeleteText.Text = "Delete Document";
            this.btnDeleteText.UseVisualStyleBackColor = false;
            this.btnDeleteText.Click += new System.EventHandler(this.btnDeleteText_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.btnSave.Location = new System.Drawing.Point(393, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Text";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveDocument);
            // 
            // btnUpdateText
            // 
            this.btnUpdateText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdateText.FlatAppearance.BorderSize = 0;
            this.btnUpdateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.btnUpdateText.Location = new System.Drawing.Point(212, 8);
            this.btnUpdateText.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateText.Name = "btnUpdateText";
            this.btnUpdateText.Size = new System.Drawing.Size(125, 48);
            this.btnUpdateText.TabIndex = 1;
            this.btnUpdateText.Text = "Update Text";
            this.btnUpdateText.UseVisualStyleBackColor = false;
            this.btnUpdateText.Click += new System.EventHandler(this.UpdateText);
            // 
            // panelCheckboxHolder
            // 
            this.panelCheckboxHolder.Controls.Add(this.chkPrintWithRef);
            this.panelCheckboxHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCheckboxHolder.Location = new System.Drawing.Point(855, 608);
            this.panelCheckboxHolder.Name = "panelCheckboxHolder";
            this.panelCheckboxHolder.Size = new System.Drawing.Size(318, 62);
            this.panelCheckboxHolder.TabIndex = 1;
            // 
            // chkPrintWithRef
            // 
            this.chkPrintWithRef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkPrintWithRef.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrintWithRef.Location = new System.Drawing.Point(59, 13);
            this.chkPrintWithRef.Name = "chkPrintWithRef";
            this.chkPrintWithRef.Size = new System.Drawing.Size(237, 40);
            this.chkPrintWithRef.TabIndex = 0;
            this.chkPrintWithRef.Text = "Print With Refrence";
            this.chkPrintWithRef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrintWithRef.UseVisualStyleBackColor = true;
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 773);
            this.Controls.Add(this.panelControlHolder);
            this.Controls.Add(this.PanelFullPageHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArticles";
            this.Text = "frmArticles";
            this.PanelFullPageHolder.ResumeLayout(false);
            this.panelControlHolder.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelText.ResumeLayout(false);
            this.PanelText.PerformLayout();
            this.panelDatagridViewHolder.ResumeLayout(false);
            this.panelButtonAndComboBoxHolder.ResumeLayout(false);
            this.panelButtonAndComboBoxHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRefList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticlesList)).EndInit();
            this.panelButtonHolder.ResumeLayout(false);
            this.panelCheckboxHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFullPageHolder;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelControlHolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelText;
        private System.Windows.Forms.Button btnUpdateText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelButtonHolder;
        private System.Windows.Forms.Panel panelDatagridViewHolder;
        private System.Windows.Forms.DataGridView DGVRefList;
        private System.Windows.Forms.DataGridView DGVArticlesList;
        private System.Windows.Forms.Label lblOtherDocs;
        private System.Windows.Forms.Label lblRefrences;
        private System.Windows.Forms.Panel panelCheckboxHolder;
        private System.Windows.Forms.Button btnAddToText;
        private System.Windows.Forms.Button btnCreateRefrence;
        private System.Windows.Forms.TextBox txtWordEditor;
        private System.Windows.Forms.Panel panelButtonAndComboBoxHolder;
        private System.Windows.Forms.ComboBox cmbRefrenceType;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtRefrence;
        private System.Windows.Forms.CheckBox chkPrintWithRef;
        private System.Windows.Forms.Button btnDeleteText;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}