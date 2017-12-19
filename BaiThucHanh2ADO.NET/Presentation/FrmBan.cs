using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiThucHanh2ADO.NET.Bo;
using BaiThucHanh2ADO.NET.Model;
using BaiThucHanh2ADO.NET.Properties;

namespace BaiThucHanh2ADO.NET.Presentation
{
    public partial class FrmBan : Form
    {
        public FrmBan()
        {
            InitializeComponent();
        }
        BanBo BanBo=new BanBo();
        List<BanBean> ds=new List<BanBean>();
        private void FrmBan_Load(object sender, EventArgs e)
        {
            ds = BanBo.GetList();
            dataGridViewX1.DataSource = ds;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaBan.Enabled = false;
            txtTenBan.Text = dataGridViewX1[1, d].Value.ToString();
            txtSoGhe.Text = dataGridViewX1[2, d].Value.ToString();
            txtMaBan.Text = dataGridViewX1[0, d].Value.ToString();
        }
        private void ThongBao(bool kq)
        {
            if (kq)
            {
                MessageBox.Show(Resources.FrmNhanVien_ThongBao_Ok_ngon_);
            }
            else
            {
                MessageBox.Show(Resources.FrmNhanVien_ThongBao_Not_Ok__);
            }
        }
        public void ResetData(List<BanBean> danhSach)
        {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = danhSach;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (!txtMaBan.Enabled)
            {
                txtMaBan.Enabled = true;
                txtMaBan.Text = "";
                txtTenBan.Text = "";
                txtSoGhe.Text = "";
            }
            else
            {
                
                BanBo.Them(ds,txtMaBan.Text,txtTenBan.Text,int.Parse(txtSoGhe.Text));
                ResetData(ds);

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            BanBo.Xoa(ds,txtMaBan.Text);
            ResetData(ds);
            txtMaBan.Text = "";
            txtTenBan.Text = "";
            txtSoGhe.Text = "";
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            BanBo.Update(ds,txtMaBan.Text,txtTenBan.Text,int.Parse(txtSoGhe.Text));
            ResetData(ds);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            String key = Microsoft.VisualBasic.Interaction.InputBox("Nhập giá cần tăng", "Tăng giá", "");
            List<BanBean> LstimKiem = BanBo.TimKiem(ds, key);
            ResetData(LstimKiem);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ResetData(ds);
        }
    }
}
