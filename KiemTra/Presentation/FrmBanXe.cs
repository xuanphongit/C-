using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KiemTra.Model.Bean;
using KiemTra.Model.Bo;

namespace KiemTra.Presentation
{
    public partial class FrmBanXe : Form
    {
        private List<HangBean> dsHangBeans;
        private List<OToBean> dsOToBeans,dsOToTheoHang;
        private List<HoaDonBean> dsHoaDonBeans;
        public static List<HoaDonBean> dsHoaDonBeansChuaThanhToan;
        public FrmBanXe()
        {
            InitializeComponent();
        }
        private bool _finished;
        private long SoLuongTrongKho,SoLuongMua;
        private void button1_Click(object sender, System.EventArgs e)
        {

            SoLuongMua = long.Parse(txtNhapSoLuong.Text);
            SoLuongTrongKho = long.Parse(txtSoLuong.Text);
            if (SoLuongMua>SoLuongTrongKho)
            {
                MessageBox.Show("Khong Du Hang");
            }
            else
            {
                long MaHoaDon = HoaDonBo.GetMaHoaDon(dsHoaDonBeans);
                OToBo.MuaHang(dsOToBeans,MaXe,long.Parse(txtNhapSoLuong.Text) );
                HoaDonBo.Insert(dsHoaDonBeans,
                    MaHoaDon,MaXe,
                    long.Parse(txtNhapSoLuong.Text),
                    long.Parse(txtThanhTien.Text),
                    false
                    );
            }
            resetData(dsHoaDonBeans);
        }

        private void resetData(List<HoaDonBean> ds)
        {
         
                dsHoaDonBeansChuaThanhToan = HoaDonBo.TimHoaDonChuaThanhToan(ds);
                dataGridView1.DataSource = dsHoaDonBeansChuaThanhToan;
            
            
        }
        private long MaHang;
        private void FrmBanXe_Load(object sender, System.EventArgs e)
        {
            dsOToBeans = OToBo.FindAll();
            dsHangBeans = HangBo.FindAll();
            dsHoaDonBeans = HoaDonBo.FindAll();
            _finished = false;
            listBox1.DataSource = dsHangBeans;
            listBox1.DisplayMember = "TenHang";
            listBox1.ValueMember = "MaHang";
           
            listBox1.SelectedValue = "1";
            _finished = true;
            
            resetData(dsHoaDonBeans);

        }

        private long MaXe;
        private void CboTenXe_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ok)
            {
                string maHang = CboTenXe.SelectedValue.ToString();
                
                MaXe = long.Parse(maHang);
                OToBean oToBean=OToBo.FindById(dsOToBeans,MaXe);
                txtMaXe.Text = oToBean.MaXe.ToString();
                txtSoLuong.Text=oToBean.SoLuongTrongKho.ToString();
                txtGia.Text=oToBean.Gia.ToString();
                txtNhapSoLuong.Text = "";
                txtThanhTien.Text = "";
                SoLuongTrongKho = oToBean.SoLuongTrongKho;
            }

        }

        private void txtNhapSoLuong_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //resetData(dsHoaDonBeans);
            FrmIn f=new FrmIn();
            f.ShowDialog();
            
        }

        private void txtNhapSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txtThanhTien.Text = (long.Parse(txtGia.Text) * long.Parse(txtNhapSoLuong.Text)).ToString();
            }
        }

        private bool ok = false;

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_finished)
            {
                ok = false;
                MaHang = long.Parse(listBox1.SelectedValue.ToString());
                dsOToTheoHang = OToBo.FindByHang(dsOToBeans, MaHang);
                CboTenXe.DataSource = dsOToTheoHang;
                CboTenXe.DisplayMember = "TenXe";
                CboTenXe.ValueMember = "MaXe";
                CboTenXe.Text = "";
                ok = true;
            }
        }
    }
}
