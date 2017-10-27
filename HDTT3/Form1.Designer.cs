namespace HDTT3
{
    partial class Form1
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
            this.txtsoluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtsoluong
            // 
            // 
            // 
            // 
            this.txtsoluong.Border.Class = "TextBoxBorder";
            this.txtsoluong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsoluong.Location = new System.Drawing.Point(37, 55);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.PreventEnterBeep = true;
            this.txtsoluong.Size = new System.Drawing.Size(120, 20);
            this.txtsoluong.TabIndex = 0;
            this.txtsoluong.UseWaitCursor = true;
            this.txtsoluong.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(193, 52);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "Tạo";
            this.buttonX1.UseWaitCursor = true;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 437);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtsoluong);
            this.Name = "Form1";
            this.Text = "What\'s up ?";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtsoluong;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}