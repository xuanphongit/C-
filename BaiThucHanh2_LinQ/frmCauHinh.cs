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
                string server = txtServer.Text;
                string tencsdl = txtTenCSDL.Text;
                string ten = txtTen.Text;
                string pass = txtPass.Text;

                bo.DungChung.Cs = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", server, tencsdl, ten, pass);
                bo.DungChung.Db = new DataClasses1DataContext(bo.DungChung.Cs);
                bo.DungChung.Db.Connection.Open();

                frmMenu f = new frmMenu();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
