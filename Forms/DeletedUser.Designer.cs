﻿namespace Med_Preserve.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletedUser));
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
            this.lb_reason = new System.Windows.Forms.Label();
            this.rtb_Reason = new System.Windows.Forms.RichTextBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.bt_pDelete = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeletedUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DeletedUser
            // 
            this.dgv_DeletedUser.AllowUserToAddRows = false;
            this.dgv_DeletedUser.AllowUserToDeleteRows = false;
            this.dgv_DeletedUser.AutoGenerateColumns = false;
            this.dgv_DeletedUser.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.dgv_DeletedUser.Location = new System.Drawing.Point(90, 128);
            this.dgv_DeletedUser.Name = "dgv_DeletedUser";
            this.dgv_DeletedUser.ReadOnly = true;
            this.dgv_DeletedUser.Size = new System.Drawing.Size(745, 150);
            this.dgv_DeletedUser.TabIndex = 0;
            this.dgv_DeletedUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DeletedUser_CellClick);
            this.dgv_DeletedUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DeletedUser_CellFormatting);
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
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
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
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Name.Location = new System.Drawing.Point(116, 299);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(45, 19);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Name";
            // 
            // lb_UName
            // 
            this.lb_UName.AutoSize = true;
            this.lb_UName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_UName.Location = new System.Drawing.Point(318, 296);
            this.lb_UName.Name = "lb_UName";
            this.lb_UName.Size = new System.Drawing.Size(78, 19);
            this.lb_UName.TabIndex = 3;
            this.lb_UName.Text = "User Name";
            // 
            // lb_UID
            // 
            this.lb_UID.AutoSize = true;
            this.lb_UID.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_UID.Location = new System.Drawing.Point(118, 105);
            this.lb_UID.Name = "lb_UID";
            this.lb_UID.Size = new System.Drawing.Size(55, 19);
            this.lb_UID.TabIndex = 4;
            this.lb_UID.Text = "User ID";
            this.lb_UID.Visible = false;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Email.Location = new System.Drawing.Point(117, 336);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(44, 19);
            this.lb_Email.TabIndex = 5;
            this.lb_Email.Text = "Email";
            // 
            // lb_Mobile
            // 
            this.lb_Mobile.AutoSize = true;
            this.lb_Mobile.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Mobile.Location = new System.Drawing.Point(344, 336);
            this.lb_Mobile.Name = "lb_Mobile";
            this.lb_Mobile.Size = new System.Drawing.Size(52, 19);
            this.lb_Mobile.TabIndex = 6;
            this.lb_Mobile.Text = "Mobile";
            // 
            // tb_R_UName
            // 
            this.tb_R_UName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_R_UName.Location = new System.Drawing.Point(402, 294);
            this.tb_R_UName.Name = "tb_R_UName";
            this.tb_R_UName.Size = new System.Drawing.Size(100, 22);
            this.tb_R_UName.TabIndex = 2;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Email.Location = new System.Drawing.Point(167, 334);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(140, 22);
            this.tb_Email.TabIndex = 3;
            // 
            // tb_UID
            // 
            this.tb_UID.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_UID.Location = new System.Drawing.Point(179, 103);
            this.tb_UID.Name = "tb_UID";
            this.tb_UID.Size = new System.Drawing.Size(100, 22);
            this.tb_UID.TabIndex = 9;
            this.tb_UID.Visible = false;
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Mobile.Location = new System.Drawing.Point(402, 334);
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(100, 22);
            this.tb_Mobile.TabIndex = 4;
            // 
            // bt_Recover
            // 
            this.bt_Recover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Recover.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Recover.Location = new System.Drawing.Point(167, 391);
            this.bt_Recover.Name = "bt_Recover";
            this.bt_Recover.Size = new System.Drawing.Size(75, 30);
            this.bt_Recover.TabIndex = 5;
            this.bt_Recover.Text = "Recover";
            this.bt_Recover.UseVisualStyleBackColor = true;
            this.bt_Recover.Click += new System.EventHandler(this.bt_Recover_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Clear.Location = new System.Drawing.Point(314, 391);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(70, 30);
            this.bt_Clear.TabIndex = 6;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancel.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Cancel.Location = new System.Drawing.Point(449, 391);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(70, 30);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // lb_reason
            // 
            this.lb_reason.AutoSize = true;
            this.lb_reason.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_reason.Location = new System.Drawing.Point(537, 294);
            this.lb_reason.Name = "lb_reason";
            this.lb_reason.Size = new System.Drawing.Size(54, 19);
            this.lb_reason.TabIndex = 14;
            this.lb_reason.Text = "Reason";
            // 
            // rtb_Reason
            // 
            this.rtb_Reason.Enabled = false;
            this.rtb_Reason.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rtb_Reason.Location = new System.Drawing.Point(605, 286);
            this.rtb_Reason.Name = "rtb_Reason";
            this.rtb_Reason.Size = new System.Drawing.Size(203, 97);
            this.rtb_Reason.TabIndex = 15;
            this.rtb_Reason.Text = "";
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(669, 100);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(149, 22);
            this.tb_Search.TabIndex = 0;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(610, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Name.Location = new System.Drawing.Point(167, 296);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_Name.TabIndex = 1;
            // 
            // bt_pDelete
            // 
            this.bt_pDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pDelete.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_pDelete.Location = new System.Drawing.Point(669, 391);
            this.bt_pDelete.Name = "bt_pDelete";
            this.bt_pDelete.Size = new System.Drawing.Size(90, 30);
            this.bt_pDelete.TabIndex = 8;
            this.bt_pDelete.Text = "Permanent Delete";
            this.bt_pDelete.UseVisualStyleBackColor = true;
            this.bt_pDelete.Click += new System.EventHandler(this.bt_pDelete_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(377, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(213, 39);
            this.lb_Title.TabIndex = 125;
            this.lb_Title.Text = "DELETED USER";
            // 
            // DeletedUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 488);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.bt_pDelete);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.rtb_Reason);
            this.Controls.Add(this.lb_reason);
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
            this.Controls.Add(this.dgv_DeletedUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletedUser";
            this.Text = "Deleted User";
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
        private System.Windows.Forms.Label lb_reason;
        private System.Windows.Forms.RichTextBox rtb_Reason;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button bt_pDelete;
        private System.Windows.Forms.Label lb_Title;
    }
}