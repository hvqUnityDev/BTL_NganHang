namespace WindowsFormsApp2
{
    partial class flogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxpassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxUseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 392);
            this.panel1.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(466, 165);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 43);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát ";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(269, 165);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(134, 43);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Đăng nhập ";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxpassWord);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 56);
            this.panel3.TabIndex = 1;
            // 
            // tbxpassWord
            // 
            this.tbxpassWord.Location = new System.Drawing.Point(200, 15);
            this.tbxpassWord.Name = "tbxpassWord";
            this.tbxpassWord.Size = new System.Drawing.Size(304, 26);
            this.tbxpassWord.TabIndex = 2;
            this.tbxpassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = " Mật khẩu: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxUseName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 56);
            this.panel2.TabIndex = 0;
            // 
            // tbxUseName
            // 
            this.tbxUseName.Location = new System.Drawing.Point(200, 15);
            this.tbxUseName.Name = "tbxUseName";
            this.tbxUseName.Size = new System.Drawing.Size(304, 26);
            this.tbxUseName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = " Tên đăng nhập:  ";
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 266);
            this.Controls.Add(this.panel1);
            this.Name = "flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.flogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxpassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxUseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlogin;
    }
}

