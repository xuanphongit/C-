using System;
using System.Windows.Forms;

namespace BaiThucHanh2LinQ
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MnNhanVien_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNhanVien f=new FrmNhanVien();
            f.ShowDialog();
            Show();

        }

        private void MnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void MnThongKeTheoNgay_Click(object sender, EventArgs e)
        {
            FrmThongKeNgay f=new FrmThongKeNgay();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void MnBanHang_Click(object sender, EventArgs e)
        {
            FrmBanHang frmBanHang=new FrmBanHang();
            Hide();
            frmBanHang.ShowDialog();
            Show();
        }
    }
}
