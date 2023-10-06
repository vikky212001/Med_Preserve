namespace Med_Preserve.Forms
{
    partial class DeletedUser
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
            this.dgv_DeletedUser = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.med_PreserveDataSet = new Med_Preserve.Med_PreserveDataSet();
            this.userDataTableAdapter = new Med_Preserve.Med_PreserveDataSetTableAdapters.UserDataTableAdapter();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_UName = new System.Windows.Forms.Label();
            this.lb_UID = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Mobile = new System.Windows.Forms.Label();
            this.tb_R_UName = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_UID = new System.Windows.Forms.TextBox();
            this.tb_Mobile = new System.Windows.Forms.TextBox();
            this.bt_Recover = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeletedUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DeletedUser
            // 
            this.dgv_DeletedUser.AutoGenerateColumns = false;
            this.dgv_DeletedUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DeletedUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.Reason});
            this.dgv_DeletedUser.DataSource = this.userDataBindingSource;
            this.dgv_DeletedUser.Location = new System.Drawing.Point(12, 12);
            this.dgv_DeletedUser.Name = "dgv_DeletedUser";
            this.dgv_DeletedUser.Size = new System.Drawing.Size(644, 150);
            this.dgv_DeletedUser.TabIndex = 0;
            this.dgv_DeletedUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DeletedUser_CellClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataMember = "UserData";
            this.userDataBindingSource.DataSource = this.med_PreserveDataSet;
            // 
            // med_PreserveDataSet
            // 
            this.med_PreserveDataSet.DataSetName = "Med_PreserveDataSet";
            this.med_PreserveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataTableAdapter
            // 
            this.userDataTableAdapter.ClearBeforeFill = true;
            // 
            // cb_Name
            // 
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(89, 173);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(127, 21);
            this.cb_Name.TabIndex = 1;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(34, 176);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(35, 13);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Name";
            // 
            // lb_UName
            // 
            this.lb_UName.AutoSize = true;
            this.lb_UName.Location = new System.Drawing.Point(34, 218);
            this.lb_UName.Name = "lb_UName";
            this.lb_UName.Size = new System.Drawing.Size(60, 13);
            this.lb_UName.TabIndex = 3;
            this.lb_UName.Text = "User Name";
            // 
            // lb_UID
            // 
            this.lb_UID.AutoSize = true;
            this.lb_UID.Location = new System.Drawing.Point(270, 176);
            this.lb_UID.Name = "lb_UID";
            this.lb_UID.Size = new System.Drawing.Size(43, 13);
            this.lb_UID.TabIndex = 4;
            this.lb_UID.Text = "User ID";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(29, 261);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 5;
            this.lb_Email.Text = "Email";
            // 
            // lb_Mobile
            // 
            this.lb_Mobile.AutoSize = true;
            this.lb_Mobile.Location = new System.Drawing.Point(270, 265);
            this.lb_Mobile.Name = "lb_Mobile";
            this.lb_Mobile.Size = new System.Drawing.Size(38, 13);
            this.lb_Mobile.TabIndex = 6;
            this.lb_Mobile.Text = "Mobile";
            // 
            // tb_R_UName
            // 
            this.tb_R_UName.Location = new System.Drawing.Point(101, 218);
            this.tb_R_UName.Name = "tb_R_UName";
            this.tb_R_UName.Size = new System.Drawing.Size(100, 20);
            this.tb_R_UName.TabIndex = 7;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(101, 258);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 8;
            // 
            // tb_UID
            // 
            this.tb_UID.Location = new System.Drawing.Point(319, 173);
            this.tb_UID.Name = "tb_UID";
            this.tb_UID.Size = new System.Drawing.Size(100, 20);
            this.tb_UID.TabIndex = 9;
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Location = new System.Drawing.Point(317, 258);
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(100, 20);
            this.tb_Mobile.TabIndex = 10;
            // 
            // bt_Recover
            // 
            this.bt_Recover.Location = new System.Drawing.Point(37, 313);
            this.bt_Recover.Name = "bt_Recover";
            this.bt_Recover.Size = new System.Drawing.Size(75, 23);
            this.bt_Recover.TabIndex = 11;
            this.bt_Recover.Text = "Recover";
            this.bt_Recover.UseVisualStyleBackColor = true;
            this.bt_Recover.Click += new System.EventHandler(this.bt_Recover_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(184, 313);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.bt_Clear.TabIndex = 12;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(319, 313);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 13;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // DeletedUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 383);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Recover);
            this.Controls.Add(this.tb_Mobile);
            this.Controls.Add(this.tb_UID);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_R_UName);
            this.Controls.Add(this.lb_Mobile);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_UID);
            this.Controls.Add(this.lb_UName);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.dgv_DeletedUser);
            this.Name = "DeletedUser";
            this.Text = "DeletedUser";
            this.Load += new System.EventHandler(this.DeletedUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeletedUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DeletedUser;
        private Med_PreserveDataSet med_PreserveDataSet;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private Med_PreserveDataSetTableAdapters.UserDataTableAdapter userDataTableAdapter;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_UName;
        private System.Windows.Forms.Label lb_UID;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Mobile;
        private System.Windows.Forms.TextBox tb_R_UName;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_UID;
        private System.Windows.Forms.TextBox tb_Mobile;
        private System.Windows.Forms.Button bt_Recover;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}