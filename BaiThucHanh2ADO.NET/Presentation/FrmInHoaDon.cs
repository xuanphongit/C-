using System;
using System.Windows.Forms;
using BaiThucHanh2ADO.NET.Model;
using Microsoft.Reporting.WinForms;

namespace BaiThucHanh2ADO.NET.Presentation
{
    public partial class FrmInHoaDon : Form
    {
        public FrmInHoaDon()
        {
            InitializeComponent();
        }

        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", FrmBanHang.DanhSach));
            

           
            ReportParameter manv = new ReportParameter("NhanVien", DungChung.NhanVien);
            ReportParameter tienchu = new ReportParameter("TienChu", FrmBanHang.tienchu);


            reportViewer1.LocalReport.SetParameters(manv);
            reportViewer1.LocalReport.SetParameters(tienchu);
            reportViewer1.RefreshReport();

            
        }
    }
}
