namespace BaiThucHanh2_LinQ
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtTenCSDL = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(136, 27);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(337, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "DESKTOP-8UPVFUS";
            // 
            // txtTenCSDL
            // 
            this.txtTenCSDL.Location = new System.Drawing.Point(136, 71);
            this.txtTenCSDL.Name = "txtTenCSDL";
            this.txtTenCSDL.Size = new System.Drawing.Size(337, 20);
            this.txtTenCSDL.TabIndex = 0;
            this.txtTenCSDL.Text = "Qlcafe";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(136, 114);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(337, 20);
            this.txtTen.TabIndex = 0;
            this.txtTen.Text = "SA";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(136, 161);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(337, 20);
            this.txtPass.TabIndex = 0;
            this.txtPass.Text = "11091996";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTenCSDL);
            this.Controls.Add(this.txtServer);
            this.Name = "frmCauHinh";
            this.Text = "frmCauHinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtTenCSDL;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button1;
    }
}