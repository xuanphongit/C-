using System;
using System.Linq;
using System.Windows.Forms;
using BaiThucHanh2LinQ.Properties;

namespace BaiThucHanh2LinQ
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CauHinh ch = new CauHinh();
            var q = from p in CauHinh.Db.NHanViens
                    where p.Manv == txtName.Text && p.MatKhau == txtPass.Text
                    select p;
            if (q.Count() == 0)
                MessageBox.Show(Resources.FrmLogin_btnLogin_Click_Đăng_nhập_không_thành_công);
            else
            { //Lưu lại các thông tin của nhân viên đăng nhập
                CauHinh.Manv = txtName.Text;
                CauHinh.Hoten = q.First().HoTen;
                CauHinh.Quyen = q.First().Quyen;
                FrmMenu f = new FrmMenu();
                Hide();
                f.ShowDialog();
                Close();
            
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
