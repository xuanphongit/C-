using System;
using System.Windows.Forms;

namespace BaiThucHanh2LinQ
{
    public partial class FrmInNhanVien : Form
    {
        public FrmInNhanVien()
        {
            InitializeComponent();
        }

        private void FrmInNhanVien_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", FrmNhanVien.DsNHanViens));
            reportViewer1.RefreshReport();
          
        }
    }
}
