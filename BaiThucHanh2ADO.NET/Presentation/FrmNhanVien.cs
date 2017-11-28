using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BaiThucHanh2ADO.NET.Bo;
using BaiThucHanh2ADO.NET.Model;
using BaiThucHanh2ADO.NET.Properties;

namespace BaiThucHanh2ADO.NET.Presentation
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        readonly NhanVienBo _nhanVienBo=new NhanVienBo();
        bool _kq;
        private List<NhanVienBean> _lst;
        public static List<NhanVienBean> DsNHanViens;
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DsNHanViens = _nhanVienBo.GetList();
            dataGridViewX1.DataSource = DsNHanViens;

        }

        private void ThongBao(bool kq)
        {
            if (kq)
            {
                MessageBox.Show(Resources.FrmNhanVien_ThongBao_Ok_ngon_);
            }
            else
            {
                MessageBox.Show(Resources.FrmNhanVien_ThongBao_Not_Ok__);
            }
        }

        public void ResetData(List<NhanVienBean> danhSach)
        {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = danhSach;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtMaNv.Enabled==false)
            {
                txtMaNv.Enabled = true;
                txtMaNv.Text = "";
                txtHoten.Text = "";
                txtDiaChi.Text = "";
                txtPass.Text = "";
                txtQuyen.Text = "";
            }
            else
            {
                
                _lst= _nhanVienBo.Add(DsNHanViens, txtMaNv.Text, txtHoten.Text, txtDiaChi.Text, txtPass.Text, txtQuyen.Text,out _kq);
                ThongBao(_kq);
                ResetData(_lst);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            _lst = _nhanVienBo.Delete(DsNHanViens, txtMaNv.Text, out _kq);
            ThongBao(_kq);
            ResetData(_lst);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            _lst = _nhanVienBo.Update(DsNHanViens, txtMaNv.Text,txtHoten.Text,txtDiaChi.Text,txtPass.Text,txtQuyen.Text, out _kq);
            ThongBao(_kq);
            ResetData(_lst);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            //Nhập mã nhân viên cần tìm
            string st = Microsoft.VisualBasic.Interaction.InputBox(
            "Nhap ma nhan vien:", "Tim Kiem", "", 100, 100);
            //Sử dụng câu lẹnh LINQ đề tìm nhân viên
            var q = from p in DsNHanViens
                    where p.MaNv.Contains(st)
                    select p;
            var nhanVienBeans = q as IList<NhanVienBean> ?? q.ToList();
            if (!nhanVienBeans.Any())
                MessageBox.Show(Resources.FrmNhanVien_buttonX6_Click_Khong_tim_thay);
            else
            {
                ResetData(nhanVienBeans.ToList());
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
            ResetData(DsNHanViens);
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaNv.Enabled = false;
            txtMaNv.Text = dataGridViewX1[0, d].Value.ToString();
            txtHoten.Text = dataGridViewX1[1, d].Value.ToString();
            txtDiaChi.Text = dataGridViewX1[2, d].Value.ToString();
            txtPass.Text = dataGridViewX1[3, d].Value.ToString();
            txtQuyen.Text = dataGridViewX1[4, d].Value.ToString();
        }
    }
}
