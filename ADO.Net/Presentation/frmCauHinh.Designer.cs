namespace ADO.Net.Presentation
{
    partial class FrmCauHinh
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSv = new System.Windows.Forms.TextBox();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSv
            // 
            this.txtSv.Location = new System.Drawing.Point(26, 28);
            this.txtSv.Name = "txtSv";
            this.txtSv.Size = new System.Drawing.Size(220, 20);
            this.txtSv.TabIndex = 1;
            this.txtSv.Text = "TTTL";
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(26, 54);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(220, 20);
            this.txtDb.TabIndex = 1;
            this.txtDb.Text = "QlSach";
            // 
            // txtUn
            // 
            this.txtUn.Location = new System.Drawing.Point(26, 80);
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(220, 20);
            this.txtUn.TabIndex = 1;
            this.txtUn.Text = "SA";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(26, 106);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(220, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "11091996";
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUn);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.txtSv);
            this.Controls.Add(this.button1);
            this.Name = "FrmCauHinh";
            this.Text = "frmCauHinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSv;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.TextBox txtPass;
    }
}