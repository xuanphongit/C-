namespace BaiThucHanh2LinQ
{
    partial class FrmBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.LstBan = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNgayBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSLMua = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSLTrongKho = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CBoHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bbv = new DevComponents.DotNetBar.LabelX();
            this.bc = new DevComponents.DotNetBar.LabelX();
            this.la = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtTongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(34, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Chọn bàn :";
            // 
            // LstBan
            // 
            this.LstBan.FormattingEnabled = true;
            this.LstBan.Location = new System.Drawing.Point(12, 53);
            this.LstBan.Name = "LstBan";
            this.LstBan.Size = new System.Drawing.Size(120, 420);
            this.LstBan.TabIndex = 1;
            this.LstBan.Click += new System.EventHandler(this.LstBan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX4);
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.txtSLMua);
            this.groupBox1.Controls.Add(this.txtSLTrongKho);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.CBoHang);
            this.groupBox1.Controls.Add(this.bbv);
            this.groupBox1.Controls.Add(this.bc);
            this.groupBox1.Controls.Add(this.la);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Location = new System.Drawing.Point(163, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(398, 136);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 6;
            this.buttonX4.Text = "Xóa";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(398, 107);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 5;
            this.buttonX3.Text = "Chuyển Bàn";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(398, 77);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "In Hóa Đơn";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(398, 49);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Bán";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtNhanVien
            // 
            // 
            // 
            // 
            this.txtNhanVien.Border.Class = "TextBoxBorder";
            this.txtNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNhanVien.Location = new System.Drawing.Point(133, 161);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.PreventEnterBeep = true;
            this.txtNhanVien.Size = new System.Drawing.Size(250, 20);
            this.txtNhanVien.TabIndex = 2;
            this.txtNhanVien.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // txtNgayBan
            // 
            // 
            // 
            // 
            this.txtNgayBan.Border.Class = "TextBoxBorder";
            this.txtNgayBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNgayBan.Location = new System.Drawing.Point(133, 135);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.PreventEnterBeep = true;
            this.txtNgayBan.Size = new System.Drawing.Size(250, 20);
            this.txtNgayBan.TabIndex = 2;
            this.txtNgayBan.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // txtSLMua
            // 
            // 
            // 
            // 
            this.txtSLMua.Border.Class = "TextBoxBorder";
            this.txtSLMua.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSLMua.Location = new System.Drawing.Point(133, 106);
            this.txtSLMua.Name = "txtSLMua";
            this.txtSLMua.PreventEnterBeep = true;
            this.txtSLMua.Size = new System.Drawing.Size(250, 20);
            this.txtSLMua.TabIndex = 2;
            this.txtSLMua.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // txtSLTrongKho
            // 
            // 
            // 
            // 
            this.txtSLTrongKho.Border.Class = "TextBoxBorder";
            this.txtSLTrongKho.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSLTrongKho.Location = new System.Drawing.Point(133, 76);
            this.txtSLTrongKho.Name = "txtSLTrongKho";
            this.txtSLTrongKho.PreventEnterBeep = true;
            this.txtSLTrongKho.Size = new System.Drawing.Size(250, 20);
            this.txtSLTrongKho.TabIndex = 2;
            this.txtSLTrongKho.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // txtGia
            // 
            // 
            // 
            // 
            this.txtGia.Border.Class = "TextBoxBorder";
            this.txtGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGia.Location = new System.Drawing.Point(133, 50);
            this.txtGia.Name = "txtGia";
            this.txtGia.PreventEnterBeep = true;
            this.txtGia.Size = new System.Drawing.Size(250, 20);
            this.txtGia.TabIndex = 2;
            this.txtGia.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // CBoHang
            // 
            this.CBoHang.DisplayMember = "Text";
            this.CBoHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBoHang.FormattingEnabled = true;
            this.CBoHang.ItemHeight = 14;
            this.CBoHang.Location = new System.Drawing.Point(133, 19);
            this.CBoHang.Name = "CBoHang";
            this.CBoHang.Size = new System.Drawing.Size(250, 20);
            this.CBoHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBoHang.TabIndex = 1;
            this.CBoHang.SelectedIndexChanged += new System.EventHandler(this.CBoHang_SelectedIndexChanged);
            // 
            // bbv
            // 
            // 
            // 
            // 
            this.bbv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bbv.Location = new System.Drawing.Point(22, 165);
            this.bbv.Name = "bbv";
            this.bbv.Size = new System.Drawing.Size(75, 23);
            this.bbv.TabIndex = 0;
            this.bbv.Text = "Nhân viên";
            // 
            // bc
            // 
            // 
            // 
            // 
            this.bc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bc.Location = new System.Drawing.Point(22, 136);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(75, 23);
            this.bc.TabIndex = 0;
            this.bc.Text = "Ngày bán";
            // 
            // la
            // 
            // 
            // 
            // 
            this.la.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.la.Location = new System.Drawing.Point(22, 107);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(75, 23);
            this.la.TabIndex = 0;
            this.la.Text = "Số lượng mua";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(22, 78);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(105, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Số lượng trong kho";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(22, 49);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Giá :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(22, 20);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên hàng :";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(163, 251);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(514, 198);
            this.dataGridViewX1.TabIndex = 3;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(253, 218);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(211, 23);
            this.labelX8.TabIndex = 4;
            this.labelX8.Text = "Danh sách các mặt hàng của bàn";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(232, 458);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 5;
            this.labelX9.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            // 
            // 
            // 
            this.txtTongTien.Border.Class = "TextBoxBorder";
            this.txtTongTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongTien.Location = new System.Drawing.Point(313, 458);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PreventEnterBeep = true;
            this.txtTongTien.Size = new System.Drawing.Size(177, 20);
            this.txtTongTien.TabIndex = 2;
            this.txtTongTien.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 496);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.LstBan);
            this.Controls.Add(this.labelX1);
            this.Name = "FrmBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ListBox LstBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGia;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBoHang;
        private DevComponents.DotNetBar.LabelX bbv;
        private DevComponents.DotNetBar.LabelX bc;
        private DevComponents.DotNetBar.LabelX la;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNhanVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNgayBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSLMua;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSLTrongKho;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongTien;
    }
}