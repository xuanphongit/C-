using System;
using System.Linq;
using System.Windows.Forms;

namespace BaiThucHanh2LinQ
{
    public partial class FrmThongKeNgay : Form
    {
        public FrmThongKeNgay()
        {
            InitializeComponent();
        }

        private void FrmThongKeNgay_Load(object sender, EventArgs e)
        {
            var ngay = DateTime.Now;//Lấy ngày hiện tại
            labelX1.Text = "Ngày: " + ngay.ToShortDateString();
            //Lấy về các hóa đơn của ngày hiện tại
            var q = CauHinh.Db.Qtks.Where(p => p.NgayBan.Value.Day == ngay.Day);
            if (q.Count() != 0)
            { //Tính tổng thành tiền của hàng bán trong ngày
                long tongtien = q.Sum(p => p.ThanhTien);
                labelX2.Text = "Tổng tiền:" + tongtien.ToString();
            }
            else
                labelX2.Text = "Tổng tiền: 0";
            dataGridViewX1.DataSource = q;
        }

        private void MC_DateChanged(object sender, DateRangeEventArgs e)
        {
            var ngay = e.Start;
            labelX1.Text = "Ngày: " + ngay.ToShortDateString();
            var q = CauHinh.Db.Qtks.Where(p => p.NgayBan.Value.Day == ngay.Day);
            if (q.Count() != 0)
            {
                long tongtien = q.Sum(p => p.ThanhTien);
                labelX2.Text = "Tổng tiền:" + tongtien.ToString();
            }
            else
                labelX2.Text = "Tổng tiền: 0";
            dataGridViewX1.DataSource = q;
        }
    }
}
