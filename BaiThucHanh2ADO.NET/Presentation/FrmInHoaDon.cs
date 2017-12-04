using System;
using System.Windows.Forms;
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
            ReportParameter MaHoaDon = new ReportParameter("MaHoaDon", FrmBanHang.maHd.ToString());
            reportViewer1.LocalReport.SetParameters(MaHoaDon);
            reportViewer1.RefreshReport();

            
        }
    }
}
