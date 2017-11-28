using System;
using System.Linq;
using System.Windows.Forms;

namespace BaiThucHanh2LinQ
{
    public partial class FrmInHoaDon : Form
    {
        public FrmInHoaDon()
        {
            InitializeComponent();
        }

        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            //Lấy về hóa đơn của bàn chọn ở FrmBanHang
           
        }

        private void FrmInHoaDon_Load_1(object sender, EventArgs e)
        {
            //CauHinh Ch=new CauHinh();
            var q = CauHinh.Db.VHienThiHoaDons.Where(p => p.MaBan == FrmBanHang.Maban);
            InHoaDon2 r = new InHoaDon2();
            r.SetDataSource(q.ToList());//Nạp nguồn dữ liệu vào Report
                                        //Truyền tham số cho RinHoaDon, tham số lấy từ tên bàn chọn ở FrmBanHang
            r.SetParameterValue("Tenban", FrmBanHang.Tenban);
            crystalReportViewer1.ReportSource = r;//Hiển thi Report
            CauHinh.Db.SubmitChanges();//Cập nhật lại hóa đơn
        }
    }
}
