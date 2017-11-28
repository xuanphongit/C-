using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.Net.Bo;
using ADO.Net.Model;
using ADO.Net.Properties;

namespace ADO.Net.Presentation
{
    public partial class FrmLogin : Form
    {
        public KhachHangBo Bo1 = new KhachHangBo();
        public FrmLogin()
        {
            InitializeComponent();
        }

        List<KhachHangBean> _ds;
        private void buttonX1_Click(object sender, EventArgs e)
        {
          
            bool kq = Bo1.KiemTra(_ds,txtTen.Text, txtPass.Text);
            if (kq)
            {
                FrmLoai f = new FrmLoai();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(Resources.FrmLogin_buttonX1_Click_Sai_rồi_nhé_);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _ds = Bo1.GetList();
        }
    }
}
