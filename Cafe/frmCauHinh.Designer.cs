namespace Cafe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtTenCsdl = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(198, 26);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "DESKTOP-8UPVFUS";
            // 
            // txtTenCsdl
            // 
            this.txtTenCsdl.Location = new System.Drawing.Point(198, 54);
            this.txtTenCsdl.Name = "txtTenCsdl";
            this.txtTenCsdl.Size = new System.Drawing.Size(100, 20);
            this.txtTenCsdl.TabIndex = 5;
            this.txtTenCsdl.Text = "Qlcafe";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(198, 83);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 6;
            this.txtTen.Text = "SA";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(198, 110);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 7;
            this.txtPass.Text = "11091996";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTenCsdl);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCauHinh";
            this.Text = "frmCauHinh";
            this.Load += new System.EventHandler(this.frmCauHinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtTenCsdl;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button1;
    }
}