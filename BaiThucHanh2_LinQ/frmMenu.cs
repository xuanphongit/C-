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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan f = new frmBan();
            this.Hide();
            f.ShowDialog();
            this.Close();
            
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHang f = new frmHang();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void tìmBànChưaThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuaThanhToan f = new frmChuaThanhToan();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void tìmHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimHang f = new frmTimHang();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void thốngKêTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeTheoNgay f = new frmThongKeTheoNgay();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void thốngKêTheoThánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeTheoThang f = new frmThongKeTheoThang();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void thốngKêTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeTheoNam f = new frmThongKeTheoNam();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void hàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangTonKho f = new frmHangTonKho();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
