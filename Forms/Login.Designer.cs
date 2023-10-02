namespace Med_Preserve
{
    partial class Login
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
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.tb_UName = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.lb_UName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(142, 98);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(100, 20);
            this.tb_Pass.TabIndex = 11;
            // 
            // tb_UName
            // 
            this.tb_UName.Location = new System.Drawing.Point(142, 53);
            this.tb_UName.Name = "tb_UName";
            this.tb_UName.Size = new System.Drawing.Size(100, 20);
            this.tb_UName.TabIndex = 10;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(194, 149);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 9;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(92, 149);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 8;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Location = new System.Drawing.Point(54, 101);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(53, 13);
            this.lb_Pass.TabIndex = 7;
            this.lb_Pass.Text = "Password";
            // 
            // lb_UName
            // 
            this.lb_UName.AutoSize = true;
            this.lb_UName.Location = new System.Drawing.Point(54, 61);
            this.lb_UName.Name = "lb_UName";
            this.lb_UName.Size = new System.Drawing.Size(60, 13);
            this.lb_UName.TabIndex = 6;
            this.lb_UName.Text = "User Name";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_UName);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_UName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.TextBox tb_UName;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.Label lb_UName;
    }
}

