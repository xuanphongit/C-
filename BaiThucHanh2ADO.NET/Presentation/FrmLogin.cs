using System;
using System.Windows.Forms;
using BaiThucHanh2ADO.NET.Bo;
using BaiThucHanh2ADO.NET.Model;
using BaiThucHanh2ADO.NET.Properties;

namespace BaiThucHanh2ADO.NET.Presentation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        NhanVienBo _nhanVienBo=new NhanVienBo();
        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            if (_nhanVienBo.KiemTraDangNhap(txtUser.Text,txtPass.Text,out DungChung.quyen))
            {
                DungChung.NhanVien = txtUser.Text;
                
                FrmMenu frmMenu=new FrmMenu();
                Hide();
                frmMenu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(Resources.FrmLogin_Error);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
