using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2_LinQ
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bo.DungChung ch = new bo.DungChung();
            var q = from p in bo.DungChung.db.NHanViens
                    where p.Manv == txtMaNV.Text && p.MatKhau == txtPass.Text
                    select p;
            if (q.Count() == 0)
                MessageBox.Show("Đăng nhập không thành công");
            else
            { //Lưu lại các thông tin của nhân viên đăng nhập
                bo.DungChung.manv = txtMaNV.Text;
                bo.DungChung.hoten = q.First().HoTen;
                bo.DungChung.quyen = q.First().Quyen;
                frmMenu f = new frmMenu();
                this.Hide();
                f.ShowDialog();
                this.Close();

            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
