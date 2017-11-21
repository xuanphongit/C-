using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2_LinQ
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            bo.DungChung ch = new bo.DungChung();
            bindingSource1.DataSource = bo.DungChung.db.NHanViens;
            dataGridView1.DataSource = bindingSource1;
            txtMaNv.DataBindings.Add("text", bindingSource1, "manv");
            txtHoTen.DataBindings.Add("text", bindingSource1, "hoten");
            txtDiaChi.DataBindings.Add("text", bindingSource1, "diachi");
            txtMatKhau.DataBindings.Add("text", bindingSource1, "matkhau");
            txtQuyen.DataBindings.Add("text", bindingSource1, "quyen");
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            bo.DungChung.db.SubmitChanges();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit(); ;
                bo.DungChung.db.SubmitChanges();
            }
            catch (Exception tt)
            {
                MessageBox.Show(tt.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string st = Microsoft.VisualBasic.Interaction.InputBox(
            "Nhap ma nhan vien:", "Tim Kiem", "", 100, 100);
            //Sử dụng câu lẹnh LINQ đề tìm nhân viên
            var q = from p in bo.DungChung.db.NHanViens
                    where p.Manv == st
                    select p;
            if (q.Count() == 0)
                MessageBox.Show("Khong tim thay");
            else
                bindingSource1.DataSource = q;
        }
    }
}
