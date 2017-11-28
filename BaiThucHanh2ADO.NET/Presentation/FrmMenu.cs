using System;
using System.Windows.Forms;

namespace BaiThucHanh2ADO.NET.Presentation
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien=new FrmNhanVien();
            Hide();
            frmNhanVien.ShowDialog();
            Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin=new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanHang f=new FrmBanHang();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
