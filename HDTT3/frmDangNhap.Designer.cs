namespace HDTT3
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonX();
            this.btnDangKi = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên Đăng Nhập :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mật Khẩu :";
            // 
            // txtTenDangNhap
            // 
            // 
            // 
            // 
            this.txtTenDangNhap.Border.Class = "TextBoxBorder";
            this.txtTenDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenDangNhap.Location = new System.Drawing.Point(135, 28);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PreventEnterBeep = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(209, 20);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.Location = new System.Drawing.Point(135, 57);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PreventEnterBeep = true;
            this.txtMatKhau.Size = new System.Drawing.Size(209, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnDangNhap.Location = new System.Drawing.Point(135, 98);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(84, 32);
            this.btnDangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangKi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnDangKi.Location = new System.Drawing.Point(253, 98);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(91, 32);
            this.btnDangKi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangKi.TabIndex = 5;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(395, 149);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDangNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.ButtonX btnDangNhap;
        private DevComponents.DotNetBar.ButtonX btnDangKi;
    }
}