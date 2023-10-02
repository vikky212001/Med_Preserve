namespace Med_Preserve.Forms
{
    partial class UserMaster
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
            this.lb_UID = new System.Windows.Forms.Label();
            this.lb_UserID = new System.Windows.Forms.Label();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.lb_R_ConPass = new System.Windows.Forms.Label();
            this.tb_R_ConPass = new System.Windows.Forms.TextBox();
            this.tb_R_Pass = new System.Windows.Forms.TextBox();
            this.tb_R_UName = new System.Windows.Forms.TextBox();
            this.tb_Mobile = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_R_Pass = new System.Windows.Forms.Label();
            this.lb_R_UName = new System.Windows.Forms.Label();
            this.lb_Mobile = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.med_PreserveDataSet = new Med_Preserve.Med_PreserveDataSet();
            this.sensorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataTableAdapter = new Med_Preserve.Med_PreserveDataSetTableAdapters.SensorDataTableAdapter();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataTableAdapter = new Med_Preserve.Med_PreserveDataSetTableAdapters.UserDataTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_UID
            // 
            this.lb_UID.AutoSize = true;
            this.lb_UID.Location = new System.Drawing.Point(87, 256);
            this.lb_UID.Name = "lb_UID";
            this.lb_UID.Size = new System.Drawing.Size(0, 13);
            this.lb_UID.TabIndex = 37;
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Location = new System.Drawing.Point(35, 261);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(52, 13);
            this.lb_UserID.TabIndex = 36;
            this.lb_UserID.Text = "User ID : ";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(242, 404);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.bt_Clear.TabIndex = 35;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(484, 404);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 34;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(366, 404);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 33;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(126, 404);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 32;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            // 
            // lb_R_ConPass
            // 
            this.lb_R_ConPass.AutoSize = true;
            this.lb_R_ConPass.Location = new System.Drawing.Point(345, 323);
            this.lb_R_ConPass.Name = "lb_R_ConPass";
            this.lb_R_ConPass.Size = new System.Drawing.Size(91, 13);
            this.lb_R_ConPass.TabIndex = 31;
            this.lb_R_ConPass.Text = "Confirm Password";
            // 
            // tb_R_ConPass
            // 
            this.tb_R_ConPass.Location = new System.Drawing.Point(348, 351);
            this.tb_R_ConPass.Name = "tb_R_ConPass";
            this.tb_R_ConPass.Size = new System.Drawing.Size(100, 20);
            this.tb_R_ConPass.TabIndex = 30;
            // 
            // tb_R_Pass
            // 
            this.tb_R_Pass.Location = new System.Drawing.Point(187, 351);
            this.tb_R_Pass.Name = "tb_R_Pass";
            this.tb_R_Pass.Size = new System.Drawing.Size(100, 20);
            this.tb_R_Pass.TabIndex = 29;
            // 
            // tb_R_UName
            // 
            this.tb_R_UName.Location = new System.Drawing.Point(32, 351);
            this.tb_R_UName.Name = "tb_R_UName";
            this.tb_R_UName.Size = new System.Drawing.Size(100, 20);
            this.tb_R_UName.TabIndex = 28;
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Location = new System.Drawing.Point(366, 210);
            this.tb_Mobile.MaxLength = 10;
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(100, 20);
            this.tb_Mobile.TabIndex = 27;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(161, 202);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 26;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(32, 202);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 25;
            // 
            // lb_R_Pass
            // 
            this.lb_R_Pass.AutoSize = true;
            this.lb_R_Pass.Location = new System.Drawing.Point(184, 323);
            this.lb_R_Pass.Name = "lb_R_Pass";
            this.lb_R_Pass.Size = new System.Drawing.Size(53, 13);
            this.lb_R_Pass.TabIndex = 24;
            this.lb_R_Pass.Text = "Password";
            // 
            // lb_R_UName
            // 
            this.lb_R_UName.AutoSize = true;
            this.lb_R_UName.Location = new System.Drawing.Point(43, 323);
            this.lb_R_UName.Name = "lb_R_UName";
            this.lb_R_UName.Size = new System.Drawing.Size(60, 13);
            this.lb_R_UName.TabIndex = 23;
            this.lb_R_UName.Text = "User Name";
            // 
            // lb_Mobile
            // 
            this.lb_Mobile.AutoSize = true;
            this.lb_Mobile.Location = new System.Drawing.Point(311, 176);
            this.lb_Mobile.Name = "lb_Mobile";
            this.lb_Mobile.Size = new System.Drawing.Size(38, 13);
            this.lb_Mobile.TabIndex = 22;
            this.lb_Mobile.Text = "Mobile";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(158, 176);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 21;
            this.lb_Email.Text = "Email";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(29, 176);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(35, 13);
            this.lb_Name.TabIndex = 20;
            this.lb_Name.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // med_PreserveDataSet
            // 
            this.med_PreserveDataSet.DataSetName = "Med_PreserveDataSet";
            this.med_PreserveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorDataBindingSource
            // 
            this.sensorDataBindingSource.DataMember = "SensorData";
            this.sensorDataBindingSource.DataSource = this.med_PreserveDataSet;
            // 
            // sensorDataTableAdapter
            // 
            this.sensorDataTableAdapter.ClearBeforeFill = true;
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataMember = "UserData";
            this.userDataBindingSource.DataSource = this.med_PreserveDataSet;
            // 
            // userDataTableAdapter
            // 
            this.userDataTableAdapter.ClearBeforeFill = true;
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
            // isDeletedDataGridViewCheckBoxColumn
            // 
            this.isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            // 
            // UserMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_UID);
            this.Controls.Add(this.lb_UserID);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.lb_R_ConPass);
            this.Controls.Add(this.tb_R_ConPass);
            this.Controls.Add(this.tb_R_Pass);
            this.Controls.Add(this.tb_R_UName);
            this.Controls.Add(this.tb_Mobile);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_R_Pass);
            this.Controls.Add(this.lb_R_UName);
            this.Controls.Add(this.lb_Mobile);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Name);
            this.Name = "UserMaster";
            this.Text = "UserMaster";
            this.Load += new System.EventHandler(this.UserMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_UID;
        private System.Windows.Forms.Label lb_UserID;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label lb_R_ConPass;
        private System.Windows.Forms.TextBox tb_R_ConPass;
        private System.Windows.Forms.TextBox tb_R_Pass;
        private System.Windows.Forms.TextBox tb_R_UName;
        private System.Windows.Forms.TextBox tb_Mobile;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_R_Pass;
        private System.Windows.Forms.Label lb_R_UName;
        private System.Windows.Forms.Label lb_Mobile;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Med_PreserveDataSet med_PreserveDataSet;
        private System.Windows.Forms.BindingSource sensorDataBindingSource;
        private Med_PreserveDataSetTableAdapters.SensorDataTableAdapter sensorDataTableAdapter;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private Med_PreserveDataSetTableAdapters.UserDataTableAdapter userDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
    }
}