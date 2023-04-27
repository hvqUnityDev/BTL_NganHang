namespace WindowsFormsApp2
{
    partial class fNhapMaPin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fTiepTuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập mã pin ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 26);
            this.textBox1.TabIndex = 1;
            // 
            // fTiepTuc
            // 
            this.fTiepTuc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.fTiepTuc.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.fTiepTuc.Location = new System.Drawing.Point(57, 168);
            this.fTiepTuc.Name = "fTiepTuc";
            this.fTiepTuc.Size = new System.Drawing.Size(409, 42);
            this.fTiepTuc.TabIndex = 2;
            this.fTiepTuc.Text = "Tiếp tục ";
            this.fTiepTuc.UseVisualStyleBackColor = false;
            this.fTiepTuc.Click += new System.EventHandler(this.button1_Click);
            // 
            // fNhapMaPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.fTiepTuc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "fNhapMaPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fVayTien";
            this.Load += new System.EventHandler(this.fnhapmapin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button fTiepTuc;
    }
}