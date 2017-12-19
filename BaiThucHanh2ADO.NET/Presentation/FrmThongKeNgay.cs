using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BaiThucHanh2ADO.NET.Bo;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Presentation
{
    public partial class FrmThongKeNgay : Form
    {
        public FrmThongKeNgay()
        {
            InitializeComponent();
        }
        VThongKeBo VThongKeBo=new VThongKeBo();
        
        public static DateTime Ngay;
        public List<VThongKeBean> Ds=new List<VThongKeBean>();
        public static List<VThongKeBean> DsNgay = new List<VThongKeBean>();
        private void FrmThongKeNgay_Load(object sender, EventArgs e)
        {
            Ds = VThongKeBo.GetList();
            Ngay = DateTime.Now;
            txtNgay.Text = "Ngày: " + Ngay.ToShortDateString();
            DsNgay = VThongKeBo.GetListByDate(Ds, Ngay);
            if (DsNgay.Any())
            {
                long tongtien = DsNgay.Sum(p => p.ThanhTien);
                txtTongTien.Text = "Tổng tiền:" + tongtien;
            }
            else
            {
                txtTongTien.Text = "Tổng tiền : 0";
            }
            dataGridView1.DataSource = DsNgay;
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MC_DateChanged(object sender, DateRangeEventArgs e)
        {
            Ngay = e.Start;
            txtNgay.Text = "Ngày: " + Ngay.ToShortDateString();
            DsNgay = VThongKeBo.GetListByDate(Ds, Ngay);
            if (DsNgay.Any())
            {
                long tongtien = DsNgay.Sum(p => p.ThanhTien);
                txtTongTien.Text = "Tổng tiền:" + tongtien;
            }
            else
            {
                txtTongTien.Text = "Tổng tiền : 0";
            }
            dataGridView1.DataSource = DsNgay;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInThongKeNgay f=new FrmInThongKeNgay();
            f.ShowDialog();
        }
    }
}
