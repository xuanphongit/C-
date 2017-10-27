using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void sideNavItem1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

          
      
            

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Button btnAbc = new Button();
            btnAbc.Location = new System.Drawing.Point(105, 126);
            btnAbc.Name = "button1";
            btnAbc.Size = new System.Drawing.Size(75, 23);
            btnAbc.Text = "button1";
            btnAbc.UseVisualStyleBackColor = true;


            Panel DanhMuc = new Panel();
            DanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            DanhMuc.Location = new System.Drawing.Point(168, 3);
            DanhMuc.Name = "panel1";
            DanhMuc.Size = new System.Drawing.Size(487, 400);
            DanhMuc.TabIndex = 13;
            DanhMuc.Controls.Add(btnAbc);
            this.Controls.Add(DanhMuc);

        }
    }
}
