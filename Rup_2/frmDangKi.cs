using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rup_2
{
    public partial class frmDangKi : Form
    {
        Bo.TaiKhoanBo TK = new Bo.TaiKhoanBo();
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            var q = TK.getList();
            txtTen.Text=q.First().Ten;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            bool Type=true;
            if (cboType.SelectedText.Equals("Thường")) ;
            {
                Type = false;
            }
            string DangKi = TK.DangKi(txtTen.Text, txtMK.Text, Type);
           
             MessageBox.Show(DangKi.ToString());
          
        }
    }
}
