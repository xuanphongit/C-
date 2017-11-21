namespace HDTT3
{
    partial class frmCauHinh
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenCsdl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(29, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Server Nam";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(29, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên Csdl";
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.Border.Class = "TextBoxBorder";
            this.txtServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtServer.Location = new System.Drawing.Point(102, 19);
            this.txtServer.Name = "txtServer";
            this.txtServer.PreventEnterBeep = true;
            this.txtServer.Size = new System.Drawing.Size(260, 20);
            this.txtServer.TabIndex = 2;
            this.txtServer.Text = "DESKTOP-8UPVFUS";
            // 
            // txtTenCsdl
            // 
            // 
            // 
            // 
            this.txtTenCsdl.Border.Class = "TextBoxBorder";
            this.txtTenCsdl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenCsdl.Location = new System.Drawing.Point(102, 61);
            this.txtTenCsdl.Name = "txtTenCsdl";
            this.txtTenCsdl.PreventEnterBeep = true;
            this.txtTenCsdl.Size = new System.Drawing.Size(260, 20);
            this.txtTenCsdl.TabIndex = 3;
            this.txtTenCsdl.Text = "Qlcafe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtTenCsdl);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hệ thống";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(190, 193);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Connect";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen.Location = new System.Drawing.Point(102, 104);
            this.txtTen.Name = "txtTen";
            this.txtTen.PreventEnterBeep = true;
            this.txtTen.Size = new System.Drawing.Size(260, 20);
            this.txtTen.TabIndex = 3;
            this.txtTen.Text = "SA";
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPass.Location = new System.Drawing.Point(102, 151);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PreventEnterBeep = true;
            this.txtPass.Size = new System.Drawing.Size(260, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "11091996";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(29, 104);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "User Name";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(29, 151);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Password";
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 230);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCauHinh";
            this.Text = "frmCauHinh";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenCsdl;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}