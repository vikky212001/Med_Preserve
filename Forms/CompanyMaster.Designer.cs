namespace Med_Preserve.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyMaster));
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
            this.dgv_CompanyMaster = new System.Windows.Forms.DataGridView();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.med_PreserveDataSet = new Med_Preserve.Med_PreserveDataSet();
            this.companyMasterTableAdapter = new Med_Preserve.Med_PreserveDataSetTableAdapters.CompanyMasterTableAdapter();
            this.lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompanyMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_CompanyName.Location = new System.Drawing.Point(122, 310);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(108, 19);
            this.lb_CompanyName.TabIndex = 1;
            this.lb_CompanyName.Text = "Company Name";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Address.Location = new System.Drawing.Point(172, 356);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(58, 19);
            this.lb_Address.TabIndex = 3;
            this.lb_Address.Text = "Address";
            // 
            // lb_ContactNo
            // 
            this.lb_ContactNo.AutoSize = true;
            this.lb_ContactNo.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_ContactNo.Location = new System.Drawing.Point(445, 309);
            this.lb_ContactNo.Name = "lb_ContactNo";
            this.lb_ContactNo.Size = new System.Drawing.Size(81, 19);
            this.lb_ContactNo.TabIndex = 2;
            this.lb_ContactNo.Text = "Contact No";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lb_Logo
            // 
            this.lb_Logo.AutoSize = true;
            this.lb_Logo.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Logo.Location = new System.Drawing.Point(743, 288);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(41, 19);
            this.lb_Logo.TabIndex = 4;
            this.lb_Logo.Text = "Logo";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Location = new System.Drawing.Point(695, 310);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(150, 100);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 5;
            this.pb_Logo.TabStop = false;
            // 
            // rtb_Address
            // 
            this.rtb_Address.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rtb_Address.Location = new System.Drawing.Point(236, 351);
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(262, 78);
            this.rtb_Address.TabIndex = 3;
            this.rtb_Address.Text = "";
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_CompanyName.Location = new System.Drawing.Point(236, 307);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(165, 22);
            this.tb_CompanyName.TabIndex = 1;
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_ContactNo.Location = new System.Drawing.Point(532, 307);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(121, 22);
            this.tb_ContactNo.TabIndex = 2;
            this.tb_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNo_KeyPress);
            // 
            // bt_Add
            // 
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Add.Location = new System.Drawing.Point(253, 501);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(70, 30);
            this.bt_Add.TabIndex = 6;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Update.Location = new System.Drawing.Point(354, 501);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(70, 30);
            this.bt_Update.TabIndex = 7;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Delete.Location = new System.Drawing.Point(545, 501);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(70, 30);
            this.bt_Delete.TabIndex = 9;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Close.Location = new System.Drawing.Point(643, 501);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(70, 30);
            this.bt_Close.TabIndex = 10;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_Browse
            // 
            this.bt_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Browse.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Browse.Location = new System.Drawing.Point(736, 416);
            this.bt_Browse.Name = "bt_Browse";
            this.bt_Browse.Size = new System.Drawing.Size(70, 30);
            this.bt_Browse.TabIndex = 5;
            this.bt_Browse.Text = "Browse";
            this.bt_Browse.UseVisualStyleBackColor = true;
            this.bt_Browse.Click += new System.EventHandler(this.bt_Browse_Click);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Email.Location = new System.Drawing.Point(186, 445);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(44, 19);
            this.lb_Email.TabIndex = 14;
            this.lb_Email.Text = "Email";
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Email.Location = new System.Drawing.Point(236, 444);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(262, 22);
            this.tb_Email.TabIndex = 4;
            this.tb_Email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Email_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bt_Clear
            // 
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Clear.Location = new System.Drawing.Point(450, 501);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(70, 30);
            this.bt_Clear.TabIndex = 8;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tb_SrNo
            // 
            this.tb_SrNo.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_SrNo.Location = new System.Drawing.Point(185, 97);
            this.tb_SrNo.Name = "tb_SrNo";
            this.tb_SrNo.Size = new System.Drawing.Size(73, 22);
            this.tb_SrNo.TabIndex = 12;
            this.tb_SrNo.Visible = false;
            // 
            // lb_SrNo
            // 
            this.lb_SrNo.AutoSize = true;
            this.lb_SrNo.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_SrNo.Location = new System.Drawing.Point(134, 100);
            this.lb_SrNo.Name = "lb_SrNo";
            this.lb_SrNo.Size = new System.Drawing.Size(45, 19);
            this.lb_SrNo.TabIndex = 12;
            this.lb_SrNo.Text = "Sr No";
            this.lb_SrNo.Visible = false;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(650, 100);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(205, 22);
            this.tb_Search.TabIndex = 0;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Search.Location = new System.Drawing.Point(591, 102);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(53, 19);
            this.lb_Search.TabIndex = 12;
            this.lb_Search.Text = "Search";
            // 
            // dgv_CompanyMaster
            // 
            this.dgv_CompanyMaster.AllowUserToAddRows = false;
            this.dgv_CompanyMaster.AllowUserToDeleteRows = false;
            this.dgv_CompanyMaster.AutoGenerateColumns = false;
            this.dgv_CompanyMaster.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_CompanyMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CompanyMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srNoDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.logoDataGridViewImageColumn,
            this.createdDateDataGridViewTextBoxColumn});
            this.dgv_CompanyMaster.DataSource = this.companyMasterBindingSource;
            this.dgv_CompanyMaster.Location = new System.Drawing.Point(111, 128);
            this.dgv_CompanyMaster.Name = "dgv_CompanyMaster";
            this.dgv_CompanyMaster.ReadOnly = true;
            this.dgv_CompanyMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CompanyMaster.Size = new System.Drawing.Size(744, 150);
            this.dgv_CompanyMaster.TabIndex = 11;
            // 
            // srNoDataGridViewTextBoxColumn
            // 
            this.srNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo";
            this.srNoDataGridViewTextBoxColumn.HeaderText = "SrNo";
            this.srNoDataGridViewTextBoxColumn.Name = "srNoDataGridViewTextBoxColumn";
            this.srNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logoDataGridViewImageColumn
            // 
            this.logoDataGridViewImageColumn.DataPropertyName = "Logo";
            this.logoDataGridViewImageColumn.HeaderText = "Logo";
            this.logoDataGridViewImageColumn.Name = "logoDataGridViewImageColumn";
            this.logoDataGridViewImageColumn.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // companyMasterTableAdapter
            // 
            this.companyMasterTableAdapter.ClearBeforeFill = true;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(353, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(261, 39);
            this.lb_Title.TabIndex = 125;
            this.lb_Title.Text = "COMPANY MASTER";
            // 
            // CompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 633);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.dgv_CompanyMaster);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompanyMaster";
            this.Text = "Company Master";
            this.Load += new System.EventHandler(this.CompanyMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompanyMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dgv_CompanyMaster;
        private Med_PreserveDataSet med_PreserveDataSet;
        private System.Windows.Forms.BindingSource companyMasterBindingSource;
        private Med_PreserveDataSetTableAdapters.CompanyMasterTableAdapter companyMasterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lb_Title;
    }
}