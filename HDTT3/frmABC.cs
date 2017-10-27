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
    public partial class frmABC : Form
    {
        public frmABC()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void frmABC_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = db.loais;
            listBox1.DisplayMember = "tenloai";
            listBox1.ValueMember = "maloai";


            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maloai = listBox1.SelectedValue.ToString();

           
            var q = from s in db.saches
                    
                    where s.maloai.Equals(maloai)
                    select new
                    {
             
                        s.tensach,
                        s.gia
                    };
            dataGridView1.DataSource = q;
            int count = q.Count();
            label1.Text = "Số sách: " + count;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
