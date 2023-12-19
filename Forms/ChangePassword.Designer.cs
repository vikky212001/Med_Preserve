namespace Med_Preserve.Forms
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.tb_CurrPass = new System.Windows.Forms.TextBox();
            this.tb_NewPass = new System.Windows.Forms.TextBox();
            this.tb_ConPass = new System.Windows.Forms.TextBox();
            this.lb_CurrPass = new System.Windows.Forms.Label();
            this.lb_NewPass = new System.Windows.Forms.Label();
            this.lb_ConPass = new System.Windows.Forms.Label();
            this.bt_ChangePass = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_CurrPass
            // 
            this.tb_CurrPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_CurrPass.Location = new System.Drawing.Point(453, 110);
            this.tb_CurrPass.Name = "tb_CurrPass";
            this.tb_CurrPass.Size = new System.Drawing.Size(144, 22);
            this.tb_CurrPass.TabIndex = 0;
            // 
            // tb_NewPass
            // 
            this.tb_NewPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_NewPass.Location = new System.Drawing.Point(453, 147);
            this.tb_NewPass.Name = "tb_NewPass";
            this.tb_NewPass.Size = new System.Drawing.Size(144, 22);
            this.tb_NewPass.TabIndex = 1;
            // 
            // tb_ConPass
            // 
            this.tb_ConPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_ConPass.Location = new System.Drawing.Point(453, 184);
            this.tb_ConPass.Name = "tb_ConPass";
            this.tb_ConPass.Size = new System.Drawing.Size(144, 22);
            this.tb_ConPass.TabIndex = 2;
            // 
            // lb_CurrPass
            // 
            this.lb_CurrPass.AutoSize = true;
            this.lb_CurrPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_CurrPass.Location = new System.Drawing.Point(327, 112);
            this.lb_CurrPass.Name = "lb_CurrPass";
            this.lb_CurrPass.Size = new System.Drawing.Size(120, 19);
            this.lb_CurrPass.TabIndex = 5;
            this.lb_CurrPass.Text = "Current Password";
            // 
            // lb_NewPass
            // 
            this.lb_NewPass.AutoSize = true;
            this.lb_NewPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_NewPass.Location = new System.Drawing.Point(350, 149);
            this.lb_NewPass.Name = "lb_NewPass";
            this.lb_NewPass.Size = new System.Drawing.Size(97, 19);
            this.lb_NewPass.TabIndex = 5;
            this.lb_NewPass.Text = "New Password";
            // 
            // lb_ConPass
            // 
            this.lb_ConPass.AutoSize = true;
            this.lb_ConPass.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_ConPass.Location = new System.Drawing.Point(328, 186);
            this.lb_ConPass.Name = "lb_ConPass";
            this.lb_ConPass.Size = new System.Drawing.Size(120, 19);
            this.lb_ConPass.TabIndex = 5;
            this.lb_ConPass.Text = "Confirm Password";
            // 
            // bt_ChangePass
            // 
            this.bt_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ChangePass.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_ChangePass.Location = new System.Drawing.Point(343, 233);
            this.bt_ChangePass.Name = "bt_ChangePass";
            this.bt_ChangePass.Size = new System.Drawing.Size(130, 30);
            this.bt_ChangePass.TabIndex = 3;
            this.bt_ChangePass.Text = "Change Password";
            this.bt_ChangePass.UseVisualStyleBackColor = true;
            this.bt_ChangePass.Click += new System.EventHandler(this.bt_ChangePass_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancel.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Cancel.Location = new System.Drawing.Point(512, 233);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(70, 30);
            this.bt_Cancel.TabIndex = 4;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(323, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(279, 39);
            this.lb_Title.TabIndex = 125;
            this.lb_Title.Text = "CHANGE PASSWORD";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 488);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_ChangePass);
            this.Controls.Add(this.lb_ConPass);
            this.Controls.Add(this.lb_NewPass);
            this.Controls.Add(this.lb_CurrPass);
            this.Controls.Add(this.tb_ConPass);
            this.Controls.Add(this.tb_NewPass);
            this.Controls.Add(this.tb_CurrPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CurrPass;
        private System.Windows.Forms.TextBox tb_NewPass;
        private System.Windows.Forms.TextBox tb_ConPass;
        private System.Windows.Forms.Label lb_CurrPass;
        private System.Windows.Forms.Label lb_NewPass;
        private System.Windows.Forms.Label lb_ConPass;
        private System.Windows.Forms.Button bt_ChangePass;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label lb_Title;
    }
}