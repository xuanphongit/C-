using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BaiThucHanh2LinQ.Properties;

namespace BaiThucHanh2LinQ
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        public static List<NHanVien> DsNHanViens;
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            CauHinh ch = new CauHinh();
            bindingSource1.DataSource = CauHinh.Db.NHanViens;
            DsNHanViens = CauHinh.Db.NHanViens.ToList();
            dataGridViewX1.DataSource = bindingSource1;
            txtMaNv.DataBindings.Add("text", bindingSource1, "manv");
            txtHoten.DataBindings.Add("text", bindingSource1, "hoten");
            txtDiaChi.DataBindings.Add("text", bindingSource1, "diachi");
            txtPass.DataBindings.Add("text", bindingSource1, "matkhau");
            txtQuyen.DataBindings.Add("text", bindingSource1, "quyen");

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();//Xóa dòng hiện tại
            CauHinh.Db.SubmitChanges();//Lưu vào CSDL
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                CauHinh.Db.SubmitChanges();
            }
            catch (Exception tt)
            {
                MessageBox.Show(tt.Message);
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            //Nhập mã nhân viên cần tìm
            string st = Microsoft.VisualBasic.Interaction.InputBox(
            "Nhap ma nhan vien:", "Tim Kiem", "", 100, 100);
            //Sử dụng câu lẹnh LINQ đề tìm nhân viên
            var q = from p in CauHinh.Db.NHanViens
                    where p.Manv.Contains(st)
                    select p;
            if (q.Count() == 0)
                MessageBox.Show(Resources.FrmNhanVien_buttonX6_Click_Khong_tim_thay);
            else
            {
                bindingSource1.DataSource = q;
                DsNHanViens = q.ToList();
            }
               
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            FrmInNhanVien f=new FrmInNhanVien();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CauHinh.Db.NHanViens;
            DsNHanViens = CauHinh.Db.NHanViens.ToList();
            dataGridViewX1.DataSource = bindingSource1;
        }
    }
}
