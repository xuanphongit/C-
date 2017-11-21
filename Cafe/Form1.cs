using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<QuanLiCafe> ds = new List<QuanLiCafe>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            listBox1.DataSource = HDTT3.Bo.DungChung.db.Bans;
            listBox1.DisplayMember = "TenBan";
            listBox1.ValueMember = "MaBan";
            var q = from s in HDTT3.Bo.DungChung.db.QuanLiCafes
                    where s.DaTraTien == false
                    select
                    s;
            ds = q.ToList();
            dataGridView1.DataSource = ds;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maban = listBox1.SelectedValue.ToString();
            var q = from s in HDTT3.Bo.DungChung.db.QuanLiCafes
                    where s.MaBan.Equals(maban) && s.DaTraTien == false
                    select s;
            ds = q.ToList();
            dataGridView1.DataSource = ds;
        }
    }
}
