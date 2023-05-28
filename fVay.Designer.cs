namespace WindowsFormsApp2
{
    partial class fVay
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
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbGoiVay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbDieuKhoan = new System.Windows.Forms.CheckBox();
            this.linkDieuKhoan = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(300, 149);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(262, 22);
            this.txtCCCD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CCCD";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "THỦ TỤC VAY TIỀN";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(300, 203);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(262, 22);
            this.txtSDT.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SDT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(300, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tiếp tục ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbGoiVay
            // 
            this.cbGoiVay.FormattingEnabled = true;
            this.cbGoiVay.Location = new System.Drawing.Point(300, 256);
            this.cbGoiVay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGoiVay.Name = "cbGoiVay";
            this.cbGoiVay.Size = new System.Drawing.Size(261, 24);
            this.cbGoiVay.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gói Vay";
            // 
            // ckbDieuKhoan
            // 
            this.ckbDieuKhoan.AutoSize = true;
            this.ckbDieuKhoan.Location = new System.Drawing.Point(300, 302);
            this.ckbDieuKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbDieuKhoan.Name = "ckbDieuKhoan";
            this.ckbDieuKhoan.Size = new System.Drawing.Size(18, 17);
            this.ckbDieuKhoan.TabIndex = 6;
            this.ckbDieuKhoan.UseVisualStyleBackColor = true;
            // 
            // linkDieuKhoan
            // 
            this.linkDieuKhoan.AutoSize = true;
            this.linkDieuKhoan.Location = new System.Drawing.Point(324, 303);
            this.linkDieuKhoan.Name = "linkDieuKhoan";
            this.linkDieuKhoan.Size = new System.Drawing.Size(99, 16);
            this.linkDieuKhoan.TabIndex = 7;
            this.linkDieuKhoan.TabStop = true;
            this.linkDieuKhoan.Text = "Điều khoản vay";
            this.linkDieuKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // fVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 515);
            this.Controls.Add(this.linkDieuKhoan);
            this.Controls.Add(this.ckbDieuKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGoiVay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCCCD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fVay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbDieuKhoan;
        private System.Windows.Forms.LinkLabel linkDieuKhoan;
        private System.Windows.Forms.ComboBox cbGoiVay;
    }
}