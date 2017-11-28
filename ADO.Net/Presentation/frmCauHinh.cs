using System;
using System.Windows.Forms;


namespace ADO.Net.Presentation
{
    public partial class FrmCauHinh : Form
    {
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Model.DungChung dc = new Model.DungChung();
                dc.KetNoi(txtSv.Text,txtDb.Text, txtUn.Text, txtPass.Text);
                FrmLogin f = new FrmLogin();
                Hide();
                f.ShowDialog();
                Close();
            }
            catch (Exception tt)
            {

                MessageBox.Show(tt.Message);
            }
        }
    }
}
