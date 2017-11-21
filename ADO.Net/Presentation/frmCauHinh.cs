using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADO.Net.Presentation
{
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Model.DungChung dc = new Model.DungChung();
                dc.KetNoi(txtSv.Text,txtDb.Text, txtUn.Text, txtPass.Text);
                frmLoai f = new frmLoai();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception tt)
            {

                MessageBox.Show(tt.Message);
            }
        }
    }
}
