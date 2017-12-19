using System;
using System.Windows.Forms;
using KiemTra.Model.Dao;

namespace KiemTra.Presentation
{
    public partial class FrmCauHinh : Form
    {
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                DungChung dc = new DungChung();
                dc.KetNoi(txtSv.Text, txtDb.Text, txtUser.Text, txtPass.Text);
                FrmMain f = new FrmMain();
                Hide();
                f.ShowDialog();
                Close();
            }
            catch (Exception tt)
            {

                MessageBox.Show(tt.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
