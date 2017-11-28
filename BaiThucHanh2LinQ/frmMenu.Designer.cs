namespace BaiThucHanh2LinQ
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnQuanLi = new System.Windows.Forms.ToolStripMenuItem();
            this.MnBan = new System.Windows.Forms.ToolStripMenuItem();
            this.MnHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnTimBanChuaThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.MnTimHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MnTimKiemBanTrong = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThongKeTheoNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThongKeTheoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThongKeTheoNam = new System.Windows.Forms.ToolStripMenuItem();
            this.MnHangTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.MnHuyDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnQuanLi,
            this.MnBanHang,
            this.MnTimKiem,
            this.MnThongKe,
            this.MnHuyDangNhap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnQuanLi
            // 
            this.MnQuanLi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnBan,
            this.MnHang,
            this.MnNhanVien,
            this.MnThoat});
            this.MnQuanLi.Name = "MnQuanLi";
            this.MnQuanLi.Size = new System.Drawing.Size(57, 20);
            this.MnQuanLi.Text = "Quản lí";
            // 
            // MnBan
            // 
            this.MnBan.Name = "MnBan";
            this.MnBan.Size = new System.Drawing.Size(129, 22);
            this.MnBan.Text = "Bàn";
            // 
            // MnHang
            // 
            this.MnHang.Name = "MnHang";
            this.MnHang.Size = new System.Drawing.Size(129, 22);
            this.MnHang.Text = "Hàng";
            // 
            // MnNhanVien
            // 
            this.MnNhanVien.Name = "MnNhanVien";
            this.MnNhanVien.Size = new System.Drawing.Size(129, 22);
            this.MnNhanVien.Text = "Nhân Viên";
            this.MnNhanVien.Click += new System.EventHandler(this.MnNhanVien_Click);
            // 
            // MnThoat
            // 
            this.MnThoat.Name = "MnThoat";
            this.MnThoat.Size = new System.Drawing.Size(129, 22);
            this.MnThoat.Text = "Thoát";
            this.MnThoat.Click += new System.EventHandler(this.MnThoat_Click);
            // 
            // MnBanHang
            // 
            this.MnBanHang.Name = "MnBanHang";
            this.MnBanHang.Size = new System.Drawing.Size(71, 20);
            this.MnBanHang.Text = "Bán Hàng";
            this.MnBanHang.Click += new System.EventHandler(this.MnBanHang_Click);
            // 
            // MnTimKiem
            // 
            this.MnTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnTimBanChuaThanhToan,
            this.MnTimHang,
            this.MnTimKiemBanTrong});
            this.MnTimKiem.Name = "MnTimKiem";
            this.MnTimKiem.Size = new System.Drawing.Size(69, 20);
            this.MnTimKiem.Text = "Tìm kiếm";
            // 
            // MnTimBanChuaThanhToan
            // 
            this.MnTimBanChuaThanhToan.Name = "MnTimBanChuaThanhToan";
            this.MnTimBanChuaThanhToan.Size = new System.Drawing.Size(208, 22);
            this.MnTimBanChuaThanhToan.Text = "Tìm bàn chưa thanh toán";
            // 
            // MnTimHang
            // 
            this.MnTimHang.Name = "MnTimHang";
            this.MnTimHang.Size = new System.Drawing.Size(208, 22);
            this.MnTimHang.Text = "Tìm hàng";
            // 
            // MnTimKiemBanTrong
            // 
            this.MnTimKiemBanTrong.Name = "MnTimKiemBanTrong";
            this.MnTimKiemBanTrong.Size = new System.Drawing.Size(208, 22);
            this.MnTimKiemBanTrong.Text = "Tìm kiếm bàn trống";
            // 
            // MnThongKe
            // 
            this.MnThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnThongKeTheoNgay,
            this.MnThongKeTheoThang,
            this.MnThongKeTheoNam,
            this.MnHangTonKho});
            this.MnThongKe.Name = "MnThongKe";
            this.MnThongKe.Size = new System.Drawing.Size(69, 20);
            this.MnThongKe.Text = "Thống kê";
            // 
            // MnThongKeTheoNgay
            // 
            this.MnThongKeTheoNgay.Name = "MnThongKeTheoNgay";
            this.MnThongKeTheoNgay.Size = new System.Drawing.Size(185, 22);
            this.MnThongKeTheoNgay.Text = "Thống kê theo ngày";
            this.MnThongKeTheoNgay.Click += new System.EventHandler(this.MnThongKeTheoNgay_Click);
            // 
            // MnThongKeTheoThang
            // 
            this.MnThongKeTheoThang.Name = "MnThongKeTheoThang";
            this.MnThongKeTheoThang.Size = new System.Drawing.Size(185, 22);
            this.MnThongKeTheoThang.Text = "Thống kê theo tháng";
            // 
            // MnThongKeTheoNam
            // 
            this.MnThongKeTheoNam.Name = "MnThongKeTheoNam";
            this.MnThongKeTheoNam.Size = new System.Drawing.Size(185, 22);
            this.MnThongKeTheoNam.Text = "Thống kê theo năm";
            // 
            // MnHangTonKho
            // 
            this.MnHangTonKho.Name = "MnHangTonKho";
            this.MnHangTonKho.Size = new System.Drawing.Size(185, 22);
            this.MnHangTonKho.Text = "Hàng tồn kho";
            // 
            // MnHuyDangNhap
            // 
            this.MnHuyDangNhap.Name = "MnHuyDangNhap";
            this.MnHuyDangNhap.Size = new System.Drawing.Size(101, 20);
            this.MnHuyDangNhap.Text = "Hủy đăng nhập";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 370);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnQuanLi;
        private System.Windows.Forms.ToolStripMenuItem MnBan;
        private System.Windows.Forms.ToolStripMenuItem MnHang;
        private System.Windows.Forms.ToolStripMenuItem MnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MnThoat;
        private System.Windows.Forms.ToolStripMenuItem MnBanHang;
        private System.Windows.Forms.ToolStripMenuItem MnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem MnTimBanChuaThanhToan;
        private System.Windows.Forms.ToolStripMenuItem MnTimHang;
        private System.Windows.Forms.ToolStripMenuItem MnTimKiemBanTrong;
        private System.Windows.Forms.ToolStripMenuItem MnThongKe;
        private System.Windows.Forms.ToolStripMenuItem MnThongKeTheoNgay;
        private System.Windows.Forms.ToolStripMenuItem MnThongKeTheoThang;
        private System.Windows.Forms.ToolStripMenuItem MnThongKeTheoNam;
        private System.Windows.Forms.ToolStripMenuItem MnHangTonKho;
        private System.Windows.Forms.ToolStripMenuItem MnHuyDangNhap;
    }
}

