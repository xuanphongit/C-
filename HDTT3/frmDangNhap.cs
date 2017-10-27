using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDTT3
{
    public partial class frmDangNhap : Form
    {
        Bo.TaiKhoanBo taikhoan = new Bo.TaiKhoanBo();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txtTenDangNhap.Text;
            string matkhau = maHoa();
            if (taikhoan.DangKiTaiKhoan(tentaikhoan,matkhau))
            {
                MessageBox.Show("Đăng Kí Thành Công", "Đăng Kí Tài Khoản");
            }
            else
            {
                MessageBox.Show("Đăng Kí Thất bại, thử lại", "Lổi đăng nhập");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txtTenDangNhap.Text;
            string matkhau = maHoa();
            if (taikhoan.kTraDangNhap(tentaikhoan, matkhau))
            {
                this.Hide();
                new frmMenu().ShowDialog();
                this.Close();


            }
            else
                MessageBox.Show("Đăng Nhập Thất bại, thử lại", "Lổi đăng nhập");
        }
        private string maHoa()
        {
            string matkhau = txtMatKhau.Text;
            string matkhauMD5 = taikhoan.MaHoa("xuanphongit", matkhau);
            return matkhauMD5;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
