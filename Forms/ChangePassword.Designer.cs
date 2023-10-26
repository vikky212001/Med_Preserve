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
            this.tb_CurrPass = new System.Windows.Forms.TextBox();
            this.tb_NewPass = new System.Windows.Forms.TextBox();
            this.tb_ConPass = new System.Windows.Forms.TextBox();
            this.lb_CurrPass = new System.Windows.Forms.Label();
            this.lb_NewPass = new System.Windows.Forms.Label();
            this.lb_ConPass = new System.Windows.Forms.Label();
            this.bt_ChangePass = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_CurrPass
            // 
            this.tb_CurrPass.Location = new System.Drawing.Point(160, 20);
            this.tb_CurrPass.Name = "tb_CurrPass";
            this.tb_CurrPass.Size = new System.Drawing.Size(144, 20);
            this.tb_CurrPass.TabIndex = 0;
            // 
            // tb_NewPass
            // 
            this.tb_NewPass.Location = new System.Drawing.Point(160, 56);
            this.tb_NewPass.Name = "tb_NewPass";
            this.tb_NewPass.Size = new System.Drawing.Size(144, 20);
            this.tb_NewPass.TabIndex = 1;
            // 
            // tb_ConPass
            // 
            this.tb_ConPass.Location = new System.Drawing.Point(160, 93);
            this.tb_ConPass.Name = "tb_ConPass";
            this.tb_ConPass.Size = new System.Drawing.Size(144, 20);
            this.tb_ConPass.TabIndex = 2;
            // 
            // lb_CurrPass
            // 
            this.lb_CurrPass.AutoSize = true;
            this.lb_CurrPass.Location = new System.Drawing.Point(23, 20);
            this.lb_CurrPass.Name = "lb_CurrPass";
            this.lb_CurrPass.Size = new System.Drawing.Size(90, 13);
            this.lb_CurrPass.TabIndex = 3;
            this.lb_CurrPass.Text = "Current Password";
            // 
            // lb_NewPass
            // 
            this.lb_NewPass.AutoSize = true;
            this.lb_NewPass.Location = new System.Drawing.Point(23, 59);
            this.lb_NewPass.Name = "lb_NewPass";
            this.lb_NewPass.Size = new System.Drawing.Size(78, 13);
            this.lb_NewPass.TabIndex = 4;
            this.lb_NewPass.Text = "New Password";
            // 
            // lb_ConPass
            // 
            this.lb_ConPass.AutoSize = true;
            this.lb_ConPass.Location = new System.Drawing.Point(23, 96);
            this.lb_ConPass.Name = "lb_ConPass";
            this.lb_ConPass.Size = new System.Drawing.Size(91, 13);
            this.lb_ConPass.TabIndex = 5;
            this.lb_ConPass.Text = "Confirm Password";
            // 
            // bt_ChangePass
            // 
            this.bt_ChangePass.Location = new System.Drawing.Point(47, 130);
            this.bt_ChangePass.Name = "bt_ChangePass";
            this.bt_ChangePass.Size = new System.Drawing.Size(112, 23);
            this.bt_ChangePass.TabIndex = 6;
            this.bt_ChangePass.Text = "Change Password";
            this.bt_ChangePass.UseVisualStyleBackColor = true;
            this.bt_ChangePass.Click += new System.EventHandler(this.bt_ChangePass_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(216, 130);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 193);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_ChangePass);
            this.Controls.Add(this.lb_ConPass);
            this.Controls.Add(this.lb_NewPass);
            this.Controls.Add(this.lb_CurrPass);
            this.Controls.Add(this.tb_ConPass);
            this.Controls.Add(this.tb_NewPass);
            this.Controls.Add(this.tb_CurrPass);
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
    }
}