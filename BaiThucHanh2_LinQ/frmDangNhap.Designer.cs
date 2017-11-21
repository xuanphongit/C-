namespace BaiThucHanh2_LinQ
{
    partial class frmDangNhap
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
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(39, 24);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(211, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(39, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(211, 20);
            this.txtPass.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(103, 107);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Đăng Nhập";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 154);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMaNV);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}