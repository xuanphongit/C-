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
    
    public partial class frmLinQ : Form
    {       
        public static List<sach> dsin=new List<HDTT3.sach>();
        public frmLinQ()
        {
            InitializeComponent();
        }
        //DataClasses1DataContext db = new DataClasses1DataContext();
        Bo.LoaiBo loai = new Bo.LoaiBo();
        Bo.SachBo sach = new Bo.SachBo();
        private     void frmLinQ_Load(object sender, EventArgs e)
        {
            //select *from sach
            //var q = from p in db.saches 
            //    select p;
            //dataGridViewX1.DataSource = q;

            //select masach,tensach,gia from sach
            //var q = from p in db.saches
            //        select new { p.masach, p.tensach, p.gia };
            //dataGridViewX1.DataSource = q.Take(10);

            //select masach,ten sach,gia sap xep theo gia
            //var q = from s in db.saches
            //        orderby s.gia descending
            //        select new { s.maloai, s.tensach, s.gia };
            //dataGridViewX1.DataSource = q;

            //select from sach where maloai= Y hoc
            //var q = from s in db.saches
            //        where s.maloai.Equals("Y hoc")
            //        select s;
            //dataGridViewX1.DataSource = q;

            //select * from sach where tensach like N'%tin%'
            //var q = from s in db.saches
            //        where s.tensach.ToLower().Contains("liệu")
            //        select s;
            //dataGridViewX1.DataSource = q;
            
            listBoxAdv1.DataSource = loai.getLoai();
            listBoxAdv1.DisplayMember = "tenloai";
            listBoxAdv1.ValueMember = "maloai";

            dsin = sach.getSach();
            dataGridViewX1.DataSource = dsin;
            
        }

        private void metroStatusBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void listBoxAdv1_ItemClick(object sender, EventArgs e)
        {
            String maloai = listBoxAdv1.SelectedValue.ToString();

            var q = sach.getSach(maloai);
                    

            dataGridViewX1.DataSource = q;
            dsin = q;

            int count = q.Count();
            if (count > 0)
            {
                lblTotal.Text = "Tổng sách : " + count;

                long tongSoLuong = (long)q.Sum(ss => ss.soluong);
                lblTongsoluong.Text = "Tổng số lượng: " + tongSoLuong.ToString("0,0");

                long Max = (long)q.Max(max => max.gia);
                lblMax.Text = "Max giá: " + Max.ToString("0,0");

                long Min = (long)q.Min(min => min.gia);
                lblMin.Text = "Min giá :" + Min.ToString("0,0");

                long thanhTien = (long)q.Sum(tien => tien.gia*tien.soluong);
                lblTien.Text = "Thành tiền :" + thanhTien.ToString("0, 0");
            }
            else
            {
                lblTotal.Text = "0";
                lblTongsoluong.Text = "0";
                lblMax.Text = "0";
                lblMin.Text = "0";
                lblTien.Text = "0";

            }
            
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals("13"))//Nhấn nút Enter
            {
                String maloai = listBoxAdv1.SelectedValue.ToString();
                List<sach> TimKiem = sach.getSach(maloai, txtTim.Text.ToString());
                dataGridViewX1.DataSource = TimKiem;
                dsin = TimKiem;
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = sach.getSach();
            dsin = sach.getSach();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            new frmIn().Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String maloai = listBoxAdv1.SelectedValue.ToString();
            List<sach> TimKiem = sach.getSach(maloai,txtTim.Text.ToString());
            dataGridViewX1.DataSource = TimKiem;
            dsin = TimKiem;
        }
    }
}
