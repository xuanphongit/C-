using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Bo;


namespace Cafe
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
                string tencsdl = txtTenCsdl.Text;
                string ten = txtTen.Text;
                string pass = txtPass.Text;
                DungChung.cs = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", server, tencsdl, ten, pass);
                DungChung.db = new DataClasses1DataContext(DungChung.cs);
                DungChung.db.Connection.Open();// Ket noi den csdl
                //MessageBox.Show("OK");
                Form1 f = new Form1();

                f.Show();
                this.Hide();
                //f.ShowDialog();
                //this.Close();

            }
            catch (Exception tt)
            {
                MessageBox.Show(tt.Message);
            }

        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {

        }
    }
}
