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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new frmDangNhap().ShowDialog();
            this.Close();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNhapSuaXoa().ShowDialog();
            this.Close();
        }
    }
}
