namespace Med_Preserve.Forms
{
    partial class DownloadData
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_LogName = new System.Windows.Forms.Label();
            this.cmb_LogName = new System.Windows.Forms.ComboBox();
            this.bt_Download = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb_Progress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_Title.Location = new System.Drawing.Point(386, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(179, 34);
            this.lb_Title.TabIndex = 76;
            this.lb_Title.Text = "Download Data";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Title.Visible = false;
            // 
            // lb_LogName
            // 
            this.lb_LogName.AutoSize = true;
            this.lb_LogName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_LogName.Location = new System.Drawing.Point(26, 129);
            this.lb_LogName.Name = "lb_LogName";
            this.lb_LogName.Size = new System.Drawing.Size(94, 19);
            this.lb_LogName.TabIndex = 78;
            this.lb_LogName.Text = "Logger Name";
            // 
            // cmb_LogName
            // 
            this.cmb_LogName.FormattingEnabled = true;
            this.cmb_LogName.Location = new System.Drawing.Point(126, 130);
            this.cmb_LogName.Name = "cmb_LogName";
            this.cmb_LogName.Size = new System.Drawing.Size(151, 21);
            this.cmb_LogName.TabIndex = 77;
            // 
            // bt_Download
            // 
            this.bt_Download.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bt_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Download.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Download.Location = new System.Drawing.Point(840, 118);
            this.bt_Download.Name = "bt_Download";
            this.bt_Download.Size = new System.Drawing.Size(98, 30);
            this.bt_Download.TabIndex = 90;
            this.bt_Download.Text = "DOWNLOAD";
            this.bt_Download.UseVisualStyleBackColor = true;
            this.bt_Download.Click += new System.EventHandler(this.bt_Download_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 425);
            this.dataGridView1.TabIndex = 91;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 75);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(908, 23);
            this.progressBar1.TabIndex = 92;
            // 
            // tb_Progress
            // 
            this.tb_Progress.Location = new System.Drawing.Point(340, 127);
            this.tb_Progress.Name = "tb_Progress";
            this.tb_Progress.Size = new System.Drawing.Size(225, 20);
            this.tb_Progress.TabIndex = 93;
            // 
            // DownloadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 594);
            this.Controls.Add(this.tb_Progress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Download);
            this.Controls.Add(this.lb_LogName);
            this.Controls.Add(this.cmb_LogName);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownloadData";
            this.Text = "DownloadData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadData_FormClosing);
            this.Load += new System.EventHandler(this.DownloadData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_LogName;
        private System.Windows.Forms.ComboBox cmb_LogName;
        private System.Windows.Forms.Button bt_Download;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tb_Progress;
    }
}