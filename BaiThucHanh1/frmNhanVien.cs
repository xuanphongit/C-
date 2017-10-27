using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class frmNhanVien : Form
    {
        
        public static List<NhanVien> dsin = new List<NhanVien>();
        public frmNhanVien()
        {
            InitializeComponent();
        }
        Bo.NhanVienBo nhanvienbo = new Bo.NhanVienBo();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dsin= nhanvienbo.getNhanVien();
            NapDuLieu(dsin);
        }
        private void NapDuLieu(List<NhanVien> q)
        {
            dataGridViewX1.DataSource = q;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtNhanVien.Text = dataGridViewX1[0, d].Value.ToString();
            txtHoTen.Text = dataGridViewX1[1, d].Value.ToString();
            txtDiaChi.Text = dataGridViewX1[2, d].Value.ToString();
            txtMatKhau.Text = dataGridViewX1[3, d].Value.ToString();
            txtQuyen.Text = dataGridViewX1[4, d].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            NhanVien nv = LayThongTin();
            bool ktraMa=nhanvienbo.kTraMa(nv.Manv);
            if (ktraMa)
            {
                MessageBox.Show("Trùng mã");
            }
            else
            {
                bool kTraNhap = nhanvienbo.Them(nv.Manv, nv.HoTen, nv.DiaChi, nv.MatKhau, nv.Quyen);
                if (kTraNhap)
                {
                    //MessageBox.Show("Thêm thành công");
                    dsin = nhanvienbo.getNhanVien();
                    NapDuLieu(dsin);
                }
                else
                {
                    MessageBox.Show("Lổi thêm");

                }
            }
           
        }
        private NhanVien LayThongTin()
        {
            NhanVien nv = new NhanVien();
            nv.Manv = txtNhanVien.Text;
            nv.HoTen = txtHoTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.Quyen = txtQuyen.Text;
            return nv;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kTraXoa = nhanvienbo.Xoa(txtNhanVien.Text);
            if (kTraXoa)
            {
                //MessageBox.Show("Xóa thành công");

                dsin = nhanvienbo.getNhanVien();
                NapDuLieu(dsin);
                txtNhanVien.Text="";
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                txtMatKhau.Text = "";
                txtQuyen.Text = "";
            }
            else
            {
                MessageBox.Show("Lổi xóa");

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = LayThongTin();
            bool kTraLuu = nhanvienbo.Sua(nv.Manv, nv.HoTen, nv.DiaChi, nv.MatKhau, nv.Quyen);
            if (kTraLuu)
            {
                //MessageBox.Show("Lưu thành công");
                dsin = nhanvienbo.getNhanVien();
                NapDuLieu(dsin);
            }
            else
            {
                MessageBox.Show("Lổi lưu");

            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            NhanVien nv = LayThongTin();
            string key = Microsoft.VisualBasic.Interaction.InputBox("Nhập giá cần tăng", "Tăng giá", "");
            dsin = nhanvienbo.TimKiem(key);
            //dataGridViewX1.DataSource = dsin;
            NapDuLieu(dsin);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            new frmIn().ShowDialog();
        }
    }
}
