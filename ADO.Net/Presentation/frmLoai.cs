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

namespace ADO.Net.Presentation
{
    public partial class frmLoai : Form
    {
        public frmLoai()
        {
            InitializeComponent();
        }
        List<Model.LoaiBean> ds;
        LoaiBo loai = new LoaiBo();
        public static List<Model.LoaiBean> LstIn = new List<Model.LoaiBean>();
        private void frmLoai_Load(object sender, EventArgs e)
        {
            ds = loai.getloai();
            Reset(ds);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Enabled==false)
            {
                txtMaLoai.Enabled = true;
            }
            else
            {
                bool kq = true;
                loai.Add(ds, txtMaLoai.Text, txtTenLoai.Text, out kq);
                ThongBaoKetQua(kq);
                Reset(ds);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int d = e.RowIndex;
            //txtMaLoai.Text = dataGridView1[0, d].Value.ToString();
            //txtTenLoai.Text = dataGridView1[1, d].Value.ToString();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaLoai.Enabled = false;
            txtMaLoai.Text = dataGridView1[0, d].Value.ToString();
            txtTenLoai.Text = dataGridView1[1, d].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("M có thích xóa ko! ", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs==DialogResult.Yes)
            {
                bool kq = true;
                loai.Del(ds, txtMaLoai.Text, out kq);
                ThongBaoKetQua(kq);

                txtMaLoai.Text = "";
                txtTenLoai.Text = "";

                Reset(ds);
            }
            else
            {
                MessageBox.Show("Ok hên đó");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool kq = true;
            loai.Update(ds, txtMaLoai.Text, txtTenLoai.Text, out kq);
            ThongBaoKetQua(kq); ;
            Reset(ds);
        }
        private void Reset(List<Model.LoaiBean> ds)
        {
            LstIn = ds;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
        }
        private void ThongBaoKetQua(bool kq)
        {
            if (kq)
            {
                MessageBox.Show("Ok Ngon!");
            }
            else
            {
                MessageBox.Show("Thua!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Model.LoaiBean> LstTimKiem = new List<Model.LoaiBean>();
            string key = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên loại cần tìm", "Tìm Kiếm", "");
            LstTimKiem= loai.TimKiem(ds, key);
            Reset(LstTimKiem);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmInLoai f = new frmInLoai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
