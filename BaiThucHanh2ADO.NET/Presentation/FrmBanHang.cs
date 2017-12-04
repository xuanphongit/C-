using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BaiThucHanh2ADO.NET.Bo;
using BaiThucHanh2ADO.NET.Model;
using BaiThucHanh2ADO.NET.Properties;

namespace BaiThucHanh2ADO.NET.Presentation
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
        }
        HienThiHoaDonBo _hienThiHoaDonBo=new HienThiHoaDonBo();
        HangBo _hangBo=new HangBo();
        BanBo _banBo=new BanBo();
        HoaDonBo _hoaDonBo=new HoaDonBo();
        ChiTietHoaDonBo _chiTietHoaDonBo=new ChiTietHoaDonBo();

        public static List<HienThiHoaDonBean> DanhSach=new List<HienThiHoaDonBean>();
        List<HangBean> _danhSachHang=new List<HangBean>();
        List<BanBean> _danhSachBan=new List<BanBean>();
        List<HoaDonBean> _danhSacHoaDonBeans=new List<HoaDonBean>();
        List<ChiTietHoaDonBean> _danhSaChiTietHoaDonBeans=new List<ChiTietHoaDonBean>();
        public  static  List<ChiTietHoaDonBean> DanhSachChiTietHoaDonBeansByMaBan=new List<ChiTietHoaDonBean>();
        public static string Tenban, Maban;
        public static long maHd;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private bool _finished;
        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            _danhSachBan = _banBo.GetList();
            _danhSachHang = _hangBo.GetList();
            _danhSacHoaDonBeans = _hoaDonBo.GetList();
            _danhSaChiTietHoaDonBeans = _chiTietHoaDonBo.GetList();
            _finished = false;
            LstBan.DataSource = _danhSachBan;
            LstBan.DisplayMember = "TenBan";
            LstBan.ValueMember = "MaBan";

            CboTenHang.DataSource = _danhSachHang;
            CboTenHang.DisplayMember = "TenHang";
            CboTenHang.ValueMember = "MaHang";
            CboTenHang.Text = "";
            _finished = true;
            txtNhanVien.Text = DungChung.NhanVien;
            txtNgayBan.Text= DateTime.Now.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_finished)
            {
                string maHang = CboTenHang.SelectedValue.ToString();
                HangBean hangBean = _hangBo.GetHang(_danhSachHang, maHang);

                txtGia.Text = hangBean.Gia.ToString();
                txtSLTrongKho.Text = hangBean.SoLuong.ToString();
               
                if (hangBean.SoLuong==0)
                {
                    MessageBox.Show(Resources.FrmBanHang_CboTenHang_SelectedIndexChanged_Hết_hàng_);
                }
            }
           
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            string maHang = CboTenHang.SelectedValue.ToString();
            
            HangBean hangBean = _hangBo.GetHang(_danhSachHang, maHang);
            bool kq=_hangBo.MuaHang(_danhSachHang, maHang, long.Parse(txtSLTrongKho.Text), long.Parse(txtSLMua.Text));
            //OK
            long maxSoHd = _hoaDonBo.KiemTraHoaDon(_danhSacHoaDonBeans, LstBan.SelectedValue.ToString());
            if (maxSoHd==0)
            {
               
                _hoaDonBo.Add(_danhSacHoaDonBeans, maxSoHd+1, DungChung.NhanVien, LstBan.SelectedValue.ToString(), DateTime.Now, false);
            }
            long maxSoCtHd = 1;
            if (_danhSaChiTietHoaDonBeans.Any())
            {
                maxSoCtHd = _chiTietHoaDonBo.GetMax(_danhSaChiTietHoaDonBeans);
                maxSoCtHd++;
            }
            //Lay so hoa don cua bang hoa don
            long shd = _hoaDonBo.KiemTraHoaDon(_danhSacHoaDonBeans, LstBan.SelectedValue.ToString());
            _chiTietHoaDonBo.Add(_danhSaChiTietHoaDonBeans,maxSoCtHd,CboTenHang.SelectedValue.ToString(),shd,long.Parse(txtSLMua.Text),long.Parse(txtSLMua.Text)*long.Parse(txtGia.Text));
            HienThiHoaDon();

        }

        private void LstBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tenban = LstBan.Text;//Lưu lại mã bàn và tên bà vừa chọn
            Maban = LstBan.SelectedValue.ToString();
            HienThiHoaDon();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            maHd = _hoaDonBo.KiemTraHoaDon(_danhSacHoaDonBeans, LstBan.SelectedValue.ToString());
            DanhSachChiTietHoaDonBeansByMaBan = _chiTietHoaDonBo.GetListByMaHd(_danhSaChiTietHoaDonBeans,
                _hoaDonBo.KiemTraHoaDon(_danhSacHoaDonBeans, LstBan.SelectedValue.ToString()));
            FrmInHoaDon f=new FrmInHoaDon();
            Hide();
            f.ShowDialog();

            Show();
            
        }

        public void HienThiHoaDon()
        { //Lấy về thông tin của hóa đơn của bàn vừa chọn trên LstBan
           
            DanhSach = _hienThiHoaDonBo.GetList(LstBan.SelectedValue.ToString());
            dataGridView1.DataSource = DanhSach; //Hiển thị hóa đơn ra lưới
        }
    }
}
