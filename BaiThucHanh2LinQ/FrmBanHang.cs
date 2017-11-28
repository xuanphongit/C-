using System;
using System.Linq;
using System.Windows.Forms;
using BaiThucHanh2LinQ.Properties;

namespace BaiThucHanh2LinQ
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
        }
        public static string Tenban, Maban;//Lưu lại mã bàn, tên bàn
        void HienThiHoaDon()
        { //Lấy về thông tin của hóa đơn của bàn vừa chọn trên LstBan
            var q = CauHinh.Db.VHienThiHoaDons.Where(
            p => p.MaBan == LstBan.SelectedValue.ToString());
            if (q.Count() != 0)//Tính tổng tiền của hóa đơn
                txtTongTien.Text = q.Sum(p => p.ThanhTien).ToString();
            dataGridViewX1.DataSource = q; //Hiển thị hóa đơn ra lưới
        }
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahang = CBoHang.SelectedValue.ToString();//Lấy về mã hàng vừa chọn
                                                             //Tìm ra hàng có số lượng =0 và đơn vị tính <> ly của hàng có mã vừa chọn
            int d = CauHinh.Db.Hangs.Where(p => p.MaHang == mahang &&
            p.DonViTinh.ToUpper() != "LY" && p.SoLuong == 0).Count();
            if (d != 0)
            {
                MessageBox.Show(Resources.FrmBanHang_CBoHang_SelectedIndexChanged_Het_hang);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Hang h = CauHinh.Db.Hangs.Single(p => p.MaHang
                                                  == CBoHang.SelectedValue.ToString());
//Nếu đơn vị tính = Ly và số luợng trong kho <> 0
if (h.DonViTinh.ToUpper() != "LY" && h.SoLuong != 0)
            {//Giảm số lượng
                h.SoLuong = h.SoLuong - int.Parse(txtSLMua.Text);
                CauHinh.Db.SubmitChanges(); //Cập nhật vào CSDL
            }
            //Nếu bàn này chưa lập hóa đơn thì tạo ra 1 hóa đơn
            if (CauHinh.Db.HoaDons.Where(p => p.MaBan ==
            LstBan.SelectedValue.ToString() && p.DaTraTien == false).Count() == 0)
            {
                //Lưu cac hang vua ban vào bảng HoaDon
                long maxSoHd = 1;
                if (CauHinh.Db.HoaDons.Count() != 0)
                {
                    maxSoHd = CauHinh.Db.HoaDons.Max(p => p.MaHD);
                    maxSoHd = maxSoHd + 1;
                }
                HoaDon hd = new HoaDon();
                hd.MaHD = maxSoHd;
                hd.MaNv = txtNhanVien.Text;
                hd.NgayBan = DateTime.Now;
                hd.MaBan = LstBan.SelectedValue.ToString();
                hd.DaTraTien = false;
                CauHinh.Db.HoaDons.InsertOnSubmit(hd);
                CauHinh.Db.SubmitChanges();
            }
            //Tao chi tiet hoa don
            //Tao ra MaCtHd
            long maxSoCtHd = 1;
            if (CauHinh.Db.ChiTietHoaDons.Count() != 0)
            {
                maxSoCtHd = CauHinh.Db.ChiTietHoaDons.Max(p =>
                p.MaCtHd);
                maxSoCtHd = maxSoCtHd + 1;
            }
            //Lay so hoa don cua bang hoa don
            long shd = CauHinh.Db.HoaDons.Single(p => p.MaBan ==
            LstBan.SelectedValue.ToString() && p.DaTraTien == false).MaHD;
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaCtHd = maxSoCtHd;
            cthd.MaHang = CBoHang.SelectedValue.ToString();
            cthd.MaHD = shd;
            cthd.SoLuongMua = int.Parse(txtSLMua.Text);
            cthd.ThanhTien = cthd.SoLuongMua *
            long.Parse(txtGia.Text);

            CauHinh.Db.ChiTietHoaDons.InsertOnSubmit(cthd);
            CauHinh.Db.SubmitChanges();
            //Hien thi hoa don
            HienThiHoaDon();
        }

        private void LstBan_Click(object sender, EventArgs e)
        {
            Tenban = LstBan.Text;//Lưu lại mã bàn và tên bà vừa chọn
            Maban = LstBan.SelectedValue.ToString();
            HienThiHoaDon();
        }
        long _socthd;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _socthd = long.Parse
                (dataGridViewX1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (CauHinh.Db.ChiTietHoaDons.Where(p => p.MaCtHd ==
_socthd).Count() == 0)
                MessageBox.Show(Resources.FrmBanHang_buttonX4_Click_Ban_phai_chon_mat_hang_can_xoa_tren_luoi);
            else
            {
                ChiTietHoaDon cthd = CauHinh.Db.ChiTietHoaDons.Single(p =>
                p.MaCtHd == _socthd);
                CauHinh.Db.ChiTietHoaDons.DeleteOnSubmit(cthd);
                CauHinh.Db.SubmitChanges();
                HienThiHoaDon();
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmInHoaDon inHoaDon =new FrmInHoaDon();
            inHoaDon.ShowDialog();
            Show();

        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            //Buộc dữ liệu vào ListBox
            LstBan.DataSource = CauHinh.Db.Bans;
            LstBan.DisplayMember = "Tenban";
            LstBan.ValueMember = "maban";
            //Buộc dữ liệu vào ComboBox
            CBoHang.DataSource = CauHinh.Db.Hangs;
            CBoHang.DisplayMember = "Tenhang";
            CBoHang.ValueMember = "mahang";
            CBoHang.Text = "";
            //Buộc dữ liệu vào các TextBox
            txtGia.DataBindings.Add("text", CauHinh.Db.Hangs, "gia");
            txtSLTrongKho.DataBindings.Add("text", CauHinh.Db.Hangs, "Soluong");
            //Hiển thi thông tin của manv, manv lấy từ
            txtNhanVien.Text = CauHinh.Manv;
            //Ngày bán là ngày hiện tại
            txtNgayBan.Text = DateTime.Now.ToShortDateString();
        }
    }
}
