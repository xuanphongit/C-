using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDTT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SinhVien n1 = new SinhVien(1, "phong", 10, 15);
            //MessageBox.Show(n1.getTen());
                                
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            long a = long.Parse(txtsoluong.Text.ToString());
           
            for (int i = 0; i < a; i++)
            {
                TextBox t = new TextBox();
                t.Location = new Point(37, i*30 + 80);
                t.Size = new Size(120, 10);
                this.Controls.Add(t);
            }
        }
        
        
    }
}
