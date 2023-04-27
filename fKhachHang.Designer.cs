namespace WindowsFormsApp2
{
    partial class fKhachHang
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
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPhanHoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Location = new System.Drawing.Point(-4, 29);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(163, 71);
            this.btnChuyenTien.TabIndex = 0;
            this.btnChuyenTien.Text = "CHUYỂN TIỀN ";
            this.btnChuyenTien.UseVisualStyleBackColor = true;
            this.btnChuyenTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "NẠP TIỀN ĐIỆN THOẠI ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "VAY ONLINE ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnPhanHoi
            // 
            this.btnPhanHoi.Location = new System.Drawing.Point(12, 348);
            this.btnPhanHoi.Name = "btnPhanHoi";
            this.btnPhanHoi.Size = new System.Drawing.Size(38, 31);
            this.btnPhanHoi.TabIndex = 3;
            this.btnPhanHoi.Text = "?";
            this.btnPhanHoi.UseVisualStyleBackColor = true;
            this.btnPhanHoi.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "TO THI TUYET NHUNG";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(321, 137);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(126, 26);
            this.lbMoney.TabIndex = 5;
            this.lbMoney.Text = "9999,99999";
            this.lbMoney.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChuyenTien);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(31, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPhanHoi);
            this.Name = "fKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPhanHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}