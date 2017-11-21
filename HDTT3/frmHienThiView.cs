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
    public partial class frmHienThiView : Form
    {
       
        public frmHienThiView()
        {
            InitializeComponent();
        }

        private void frmHienThiView_Load(object sender, EventArgs e)
        {
            var q = from s in Bo.DungChung.db.Tests
                    where s.tenloai.Equals("Chính trị")
                    select s;
            dataGridViewX1.DataSource = q;  
        }

        private void frmHienThiView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bo.DungChung.f.Dispose();
        }
    }
}
