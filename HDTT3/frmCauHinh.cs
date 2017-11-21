using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDTT3
{
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //string st=string.format("{0}+{1}+{2}",a,b,a+b);
            //Data sourch=Data Source=DESKTOP-8UPVFUS;Initial Catalog=QLNV;Persist Security Info=True;User ID=SA;Password=11091996
            try
            {

                string server = txtServer.Text;
                string tencsdl = txtTenCsdl.Text;
                string ten = txtTen.Text;
                string pass = txtPass.Text;
                Bo.DungChung.cs = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",server,tencsdl,ten,pass);
                Bo.DungChung.db = new DataClasses1DataContext(Bo.DungChung.cs);
                Bo.DungChung.db.Connection.Open();// Ket noi den csdl
                //MessageBox.Show("OK");
                frmHienThiView f = new frmHienThiView();
                
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
