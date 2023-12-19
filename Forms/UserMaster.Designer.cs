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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMaster));
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_Search = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.tb_UID = new System.Windows.Forms.TextBox();
            this.bt_Close = new System.Windows.Forms.Button();
            this.lb_Role = new System.Windows.Forms.Label();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.dgv_UserMaster = new System.Windows.Forms.DataGridView();
            this.med_PreserveDataSet = new Med_Preserve.Med_PreserveDataSet();
            this.userDataTableAdapter = new Med_Preserve.Med_PreserveDataSetTableAdapters.UserDataTableAdapter();
            this.lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_UserID.Location = new System.Drawing.Point(135, 102);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(71, 21);
            this.lb_UserID.TabIndex = 36;
            this.lb_UserID.Text = "User ID : ";
            this.lb_UserID.Visible = false;
            // 
            // bt_Clear
            // 
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(448, 451);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(70, 30);
            this.bt_Clear.TabIndex = 11;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(569, 451);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(70, 30);
            this.bt_Delete.TabIndex = 12;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Update.Location = new System.Drawing.Point(329, 451);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(70, 30);
            this.bt_Update.TabIndex = 10;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(213, 451);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(70, 30);
            this.bt_Add.TabIndex = 9;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // lb_R_ConPass
            // 
            this.lb_R_ConPass.AutoSize = true;
            this.lb_R_ConPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_R_ConPass.Location = new System.Drawing.Point(581, 369);
            this.lb_R_ConPass.Name = "lb_R_ConPass";
            this.lb_R_ConPass.Size = new System.Drawing.Size(131, 21);
            this.lb_R_ConPass.TabIndex = 31;
            this.lb_R_ConPass.Text = "Confirm Password";
            // 
            // tb_R_ConPass
            // 
            this.tb_R_ConPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_R_ConPass.Location = new System.Drawing.Point(585, 390);
            this.tb_R_ConPass.Name = "tb_R_ConPass";
            this.tb_R_ConPass.Size = new System.Drawing.Size(150, 22);
            this.tb_R_ConPass.TabIndex = 7;
            // 
            // tb_R_Pass
            // 
            this.tb_R_Pass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_R_Pass.Location = new System.Drawing.Point(402, 390);
            this.tb_R_Pass.Name = "tb_R_Pass";
            this.tb_R_Pass.Size = new System.Drawing.Size(150, 22);
            this.tb_R_Pass.TabIndex = 6;
            // 
            // tb_R_UName
            // 
            this.tb_R_UName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_R_UName.Location = new System.Drawing.Point(232, 390);
            this.tb_R_UName.Name = "tb_R_UName";
            this.tb_R_UName.Size = new System.Drawing.Size(100, 22);
            this.tb_R_UName.TabIndex = 5;
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Mobile.Location = new System.Drawing.Point(555, 316);
            this.tb_Mobile.MaxLength = 10;
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(100, 22);
            this.tb_Mobile.TabIndex = 3;
            this.tb_Mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_KeyPress);
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Email.Location = new System.Drawing.Point(303, 316);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(173, 22);
            this.tb_Email.TabIndex = 2;
            this.tb_Email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Email_Validating);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Name.Location = new System.Drawing.Point(133, 316);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // lb_R_Pass
            // 
            this.lb_R_Pass.AutoSize = true;
            this.lb_R_Pass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_R_Pass.Location = new System.Drawing.Point(398, 371);
            this.lb_R_Pass.Name = "lb_R_Pass";
            this.lb_R_Pass.Size = new System.Drawing.Size(74, 21);
            this.lb_R_Pass.TabIndex = 24;
            this.lb_R_Pass.Text = "Password";
            // 
            // lb_R_UName
            // 
            this.lb_R_UName.AutoSize = true;
            this.lb_R_UName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_R_UName.Location = new System.Drawing.Point(228, 371);
            this.lb_R_UName.Name = "lb_R_UName";
            this.lb_R_UName.Size = new System.Drawing.Size(86, 21);
            this.lb_R_UName.TabIndex = 23;
            this.lb_R_UName.Text = "User Name";
            // 
            // lb_Mobile
            // 
            this.lb_Mobile.AutoSize = true;
            this.lb_Mobile.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Mobile.Location = new System.Drawing.Point(551, 296);
            this.lb_Mobile.Name = "lb_Mobile";
            this.lb_Mobile.Size = new System.Drawing.Size(57, 21);
            this.lb_Mobile.TabIndex = 22;
            this.lb_Mobile.Text = "Mobile";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Email.Location = new System.Drawing.Point(299, 296);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(48, 21);
            this.lb_Email.TabIndex = 21;
            this.lb_Email.Text = "Email";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Name.Location = new System.Drawing.Point(129, 296);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(50, 21);
            this.lb_Name.TabIndex = 20;
            this.lb_Name.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Search.Location = new System.Drawing.Point(610, 102);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(58, 21);
            this.lb_Search.TabIndex = 39;
            this.lb_Search.Text = "Search";
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(673, 104);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(182, 22);
            this.tb_Search.TabIndex = 0;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // tb_UID
            // 
            this.tb_UID.Location = new System.Drawing.Point(212, 105);
            this.tb_UID.Name = "tb_UID";
            this.tb_UID.Size = new System.Drawing.Size(71, 20);
            this.tb_UID.TabIndex = 41;
            this.tb_UID.Visible = false;
            this.tb_UID.TextChanged += new System.EventHandler(this.tb_UID_TextChanged);
            // 
            // bt_Close
            // 
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(686, 451);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(70, 30);
            this.bt_Close.TabIndex = 13;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // lb_Role
            // 
            this.lb_Role.AutoSize = true;
            this.lb_Role.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Role.Location = new System.Drawing.Point(712, 296);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(39, 21);
            this.lb_Role.TabIndex = 43;
            this.lb_Role.Text = "Role";
            // 
            // cmb_Role
            // 
            this.cmb_Role.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Location = new System.Drawing.Point(716, 315);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(121, 29);
            this.cmb_Role.TabIndex = 4;
            this.cmb_Role.Text = "-SELECT-";
            // 
            // dgv_UserMaster
            // 
            this.dgv_UserMaster.AllowUserToAddRows = false;
            this.dgv_UserMaster.AllowUserToDeleteRows = false;
            this.dgv_UserMaster.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_UserMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserMaster.Location = new System.Drawing.Point(112, 130);
            this.dgv_UserMaster.Name = "dgv_UserMaster";
            this.dgv_UserMaster.ReadOnly = true;
            this.dgv_UserMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserMaster.Size = new System.Drawing.Size(743, 150);
            this.dgv_UserMaster.TabIndex = 8;
            this.dgv_UserMaster.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_UserMaster_CellFormatting);
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
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(384, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(198, 39);
            this.lb_Title.TabIndex = 125;
            this.lb_Title.Text = "USER MASTER";
            // 
            // UserMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 633);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.dgv_UserMaster);
            this.Controls.Add(this.cmb_Role);
            this.Controls.Add(this.lb_Role);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.tb_UID);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " User Master";
            this.Load += new System.EventHandler(this.UserMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.TextBox tb_UID;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.DataGridView dgv_UserMaster;
        private Med_PreserveDataSet med_PreserveDataSet;
        private Med_PreserveDataSetTableAdapters.UserDataTableAdapter userDataTableAdapter;
        private System.Windows.Forms.Label lb_Title;
    }
}