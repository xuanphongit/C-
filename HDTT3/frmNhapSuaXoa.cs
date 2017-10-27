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
    public partial class frmNhapSuaXoa : Form
    {
        Bo.SachBo sach = new Bo.SachBo();
        Bo.LoaiBo loai = new Bo.LoaiBo();
        public frmNhapSuaXoa()
        {
            InitializeComponent();
        }

        private void frmNhapSuaXoa_Load(object sender, EventArgs e)
        {

            cboMa.DataSource = loai.getLoai();
            cboMa.DisplayMember = "tenloai";
            cboMa.ValueMember = "maloai";


            String maloai = cboMa.SelectedValue.ToString();
            var q = sach.getSach(maloai);
            dataGridViewX1.DataSource = q;


           
           
        }

        private void cboMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maloai = cboMa.SelectedValue.ToString();
            var q = sach.getSach(maloai);
            dataGridViewX1.DataSource = q;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maloai = cboMa.SelectedValue.ToString();
            bool kTraThem=sach.ThemSach(txtMa.Text,
                txtTenSach.Text,
                txtTacGia.Text,
                long.Parse(txtGia.Text),
                long.Parse(txtSoLuong.Text),
                txtSoTap.Text,
                dateTimePicker1.Value,
                maloai);
            if (kTraThem)
            {
                //MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Lổi thêm");
            }
            
            dataGridViewX1.DataSource = sach.getSach(maloai);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String maloai = cboMa.SelectedValue.ToString();
            bool kTraLuu= sach.SuaSach(txtMa.Text,
                txtTenSach.Text,
                txtTacGia.Text,
                long.Parse(txtGia.Text),
                long.Parse(txtSoLuong.Text),
                txtSoTap.Text,
                dateTimePicker1.Value,
                maloai);
            if (kTraLuu)
            {
                //MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lổi lưu");
            }
            dataGridViewX1.DataSource = sach.getSach(maloai);
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMa.Text = dataGridViewX1[0, d].Value.ToString();
            txtTenSach.Text = dataGridViewX1[1, d].Value.ToString();
            txtTacGia.Text = dataGridViewX1[2, d].Value.ToString();
            txtSoLuong.Text = dataGridViewX1[3, d].Value.ToString();
            txtGia.Text = dataGridViewX1[4, d].Value.ToString();
            txtSoTap.Text = dataGridViewX1[5, d].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridViewX1[8, d].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String masach = txtMa.Text;
            String maloai = cboMa.SelectedValue.ToString();
            bool kTraXoa = sach.Xoa(masach);
            if (kTraXoa)
            {
                //MessageBox.Show("Xóa thành công");
                txtMa.Text = "";
                txtTenSach.Text = "";
                txtTacGia.Text = "";
                txtGia.Text = "";
                txtSoLuong.Text = "";
                txtSoTap.Text = "";
                
    
            }
            else
            {
                MessageBox.Show("Lổi xóa");
            }
            dataGridViewX1.DataSource = sach.getSach(maloai);
        }

        private void btnNangGia_Click(object sender, EventArgs e)
        {
            String maloai = cboMa.SelectedValue.ToString();
            long gia = long.Parse(Microsoft.VisualBasic.Interaction.InputBox("Nhập giá cần tăng", "Tăng giá", ""));
            bool kTraTang = sach.TangGia(maloai, gia);
            if (kTraTang)
            {
                //MessageBox.Show("Nâng thành công");
            }
            else
            {
                MessageBox.Show("Lổi nâng giá");
            }
            dataGridViewX1.DataSource = sach.getSach(maloai);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
