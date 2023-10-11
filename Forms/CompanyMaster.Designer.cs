﻿namespace Med_Preserve.Forms
{
    partial class CompanyMaster
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
            this.dgv_CompanyMaster = new System.Windows.Forms.DataGridView();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.companyMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.med_PreserveDataSet = new Med_Preserve.Med_PreserveDataSet();
            this.medPreserveDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyMasterTableAdapter = new Med_Preserve.Med_PreserveDataSetTableAdapters.CompanyMasterTableAdapter();
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_ContactNo = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lb_Logo = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.rtb_Address = new System.Windows.Forms.RichTextBox();
            this.tb_CompanyName = new System.Windows.Forms.TextBox();
            this.tb_ContactNo = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_Browse = new System.Windows.Forms.Button();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bt_Clear = new System.Windows.Forms.Button();
            this.tb_SrNo = new System.Windows.Forms.TextBox();
            this.lb_SrNo = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompanyMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medPreserveDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CompanyMaster
            // 
            this.dgv_CompanyMaster.AutoGenerateColumns = false;
            this.dgv_CompanyMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CompanyMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srNoDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.logoDataGridViewImageColumn});
            this.dgv_CompanyMaster.DataSource = this.companyMasterBindingSource;
            this.dgv_CompanyMaster.Location = new System.Drawing.Point(13, 13);
            this.dgv_CompanyMaster.Name = "dgv_CompanyMaster";
            this.dgv_CompanyMaster.Size = new System.Drawing.Size(644, 157);
            this.dgv_CompanyMaster.TabIndex = 0;
            this.dgv_CompanyMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CompanyMaster_CellClick);
            // 
            // srNoDataGridViewTextBoxColumn
            // 
            this.srNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo";
            this.srNoDataGridViewTextBoxColumn.HeaderText = "SrNo";
            this.srNoDataGridViewTextBoxColumn.Name = "srNoDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // logoDataGridViewImageColumn
            // 
            this.logoDataGridViewImageColumn.DataPropertyName = "Logo";
            this.logoDataGridViewImageColumn.HeaderText = "Logo";
            this.logoDataGridViewImageColumn.Name = "logoDataGridViewImageColumn";
            // 
            // companyMasterBindingSource
            // 
            this.companyMasterBindingSource.DataMember = "CompanyMaster";
            this.companyMasterBindingSource.DataSource = this.med_PreserveDataSet;
            // 
            // med_PreserveDataSet
            // 
            this.med_PreserveDataSet.DataSetName = "Med_PreserveDataSet";
            this.med_PreserveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medPreserveDataSetBindingSource
            // 
            this.medPreserveDataSetBindingSource.DataSource = this.med_PreserveDataSet;
            this.medPreserveDataSetBindingSource.Position = 0;
            // 
            // companyMasterTableAdapter
            // 
            this.companyMasterTableAdapter.ClearBeforeFill = true;
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Location = new System.Drawing.Point(13, 219);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(82, 13);
            this.lb_CompanyName.TabIndex = 1;
            this.lb_CompanyName.Text = "Company Name";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(13, 253);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(45, 13);
            this.lb_Address.TabIndex = 2;
            this.lb_Address.Text = "Address";
            // 
            // lb_ContactNo
            // 
            this.lb_ContactNo.AutoSize = true;
            this.lb_ContactNo.Location = new System.Drawing.Point(440, 222);
            this.lb_ContactNo.Name = "lb_ContactNo";
            this.lb_ContactNo.Size = new System.Drawing.Size(61, 13);
            this.lb_ContactNo.TabIndex = 3;
            this.lb_ContactNo.Text = "Contact No";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lb_Logo
            // 
            this.lb_Logo.AutoSize = true;
            this.lb_Logo.Location = new System.Drawing.Point(470, 256);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(31, 13);
            this.lb_Logo.TabIndex = 4;
            this.lb_Logo.Text = "Logo";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Location = new System.Drawing.Point(507, 253);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(150, 100);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 5;
            this.pb_Logo.TabStop = false;
            // 
            // rtb_Address
            // 
            this.rtb_Address.Location = new System.Drawing.Point(117, 253);
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(250, 78);
            this.rtb_Address.TabIndex = 6;
            this.rtb_Address.Text = "";
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.Location = new System.Drawing.Point(117, 216);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(165, 20);
            this.tb_CompanyName.TabIndex = 7;
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.Location = new System.Drawing.Point(507, 219);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(121, 20);
            this.tb_ContactNo.TabIndex = 8;
            this.tb_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNo_KeyPress);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(95, 402);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 9;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(196, 402);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 10;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(387, 402);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 11;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(485, 402);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 12;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_Browse
            // 
            this.bt_Browse.Location = new System.Drawing.Point(543, 359);
            this.bt_Browse.Name = "bt_Browse";
            this.bt_Browse.Size = new System.Drawing.Size(75, 23);
            this.bt_Browse.TabIndex = 13;
            this.bt_Browse.Text = "Browse";
            this.bt_Browse.UseVisualStyleBackColor = true;
            this.bt_Browse.Click += new System.EventHandler(this.bt_Browse_Click);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(13, 340);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 14;
            this.lb_Email.Text = "Email";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(117, 340);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(165, 20);
            this.tb_Email.TabIndex = 15;
            this.tb_Email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Email_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(292, 402);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.bt_Clear.TabIndex = 16;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tb_SrNo
            // 
            this.tb_SrNo.Location = new System.Drawing.Point(117, 190);
            this.tb_SrNo.Name = "tb_SrNo";
            this.tb_SrNo.Size = new System.Drawing.Size(73, 20);
            this.tb_SrNo.TabIndex = 18;
            // 
            // lb_SrNo
            // 
            this.lb_SrNo.AutoSize = true;
            this.lb_SrNo.Location = new System.Drawing.Point(61, 193);
            this.lb_SrNo.Name = "lb_SrNo";
            this.lb_SrNo.Size = new System.Drawing.Size(34, 13);
            this.lb_SrNo.TabIndex = 17;
            this.lb_SrNo.Text = "Sr No";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(387, 186);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(205, 20);
            this.tb_Search.TabIndex = 20;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(326, 190);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(41, 13);
            this.lb_Search.TabIndex = 19;
            this.lb_Search.Text = "Search";
            // 
            // CompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.tb_SrNo);
            this.Controls.Add(this.lb_SrNo);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.bt_Browse);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_ContactNo);
            this.Controls.Add(this.tb_CompanyName);
            this.Controls.Add(this.rtb_Address);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.lb_Logo);
            this.Controls.Add(this.lb_ContactNo);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_CompanyName);
            this.Controls.Add(this.dgv_CompanyMaster);
            this.Name = "CompanyMaster";
            this.Text = "CompanyMaster";
            this.Load += new System.EventHandler(this.CompanyMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompanyMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medPreserveDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CompanyMaster;
        private Med_PreserveDataSet med_PreserveDataSet;
        private System.Windows.Forms.BindingSource medPreserveDataSetBindingSource;
        private System.Windows.Forms.BindingSource companyMasterBindingSource;
        private Med_PreserveDataSetTableAdapters.CompanyMasterTableAdapter companyMasterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoDataGridViewImageColumn;
        private System.Windows.Forms.Label lb_CompanyName;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_ContactNo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lb_Logo;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.RichTextBox rtb_Address;
        private System.Windows.Forms.TextBox tb_CompanyName;
        private System.Windows.Forms.TextBox tb_ContactNo;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Browse;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.TextBox tb_SrNo;
        private System.Windows.Forms.Label lb_SrNo;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
    }
}