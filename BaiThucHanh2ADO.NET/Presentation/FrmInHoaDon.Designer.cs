namespace BaiThucHanh2ADO.NET.Presentation
{
    partial class FrmInHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ChiTietHoaDonBeanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBeanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietHoaDonBeanBindingSource
            // 
            this.ChiTietHoaDonBeanBindingSource.DataSource = typeof(BaiThucHanh2ADO.NET.Model.ChiTietHoaDonBean);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietHoaDonBeanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaiThucHanh2ADO.NET.Presentation.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 409);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 409);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmInHoaDon";
            this.Text = "FrmInHoaDon";
            this.Load += new System.EventHandler(this.FrmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBeanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBeanBindingSource;
    }
}