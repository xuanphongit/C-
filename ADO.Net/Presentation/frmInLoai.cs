﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Net.Presentation
{
    public partial class FrmInLoai : Form
    {
        public FrmInLoai()
        {
            InitializeComponent();
        }

        private void frmInLoai_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", FrmLoai.LstIn));
            this.reportViewer1.RefreshReport();
        }
    }
}
