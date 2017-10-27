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
    public partial class frmHienThi : Form
    {
        public frmHienThi()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = db.loais;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = db.saches;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = db.KhachHangs;
        }

        private void frmHienThi_Load(object sender, EventArgs e)
        {
            listBoxAdv1.DataSource = db.loais;
            listBoxAdv1.DisplayMember = "Tenloai";
            listBoxAdv1.ValueMember = "Maloai";

            comboBoxEx1.DataSource = db.loais;
            comboBoxEx1.DisplayMember = "Tenloai";
            comboBoxEx1.ValueMember = "Maloai";
            
            dataGridViewX1.DataSource = db.loais;
        }
    }
}
