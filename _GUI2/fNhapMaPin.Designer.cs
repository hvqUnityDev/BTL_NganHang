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
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã pin ";
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(95, 146);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(274, 22);
            this.txtPIN.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAccept.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAccept.Location = new System.Drawing.Point(95, 218);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(274, 34);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Tiếp tục ";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // fNhapMaPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 353);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(480, 400);
            this.MinimumSize = new System.Drawing.Size(480, 400);
            this.Name = "fNhapMaPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác Nhận Mã Pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btnAccept;
    }
}