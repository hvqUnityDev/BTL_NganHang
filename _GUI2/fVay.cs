using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fVay : Form
    {
        public fVay()
        {
            InitializeComponent();
            ThuTucVayBLL thuTucVayBLL = new ThuTucVayBLL();
            thuTucVayBLL.InitGoiVay(cbGoiVay);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkDieuKhoan.LinkVisited = true;
            ThuTucVayBLL thuTucVayBLL = new ThuTucVayBLL();
            System.Diagnostics.Process.Start(thuTucVayBLL.LinkDieuKhoan());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThuTucVayBLL thuTucVayBLL = new ThuTucVayBLL();
            if(thuTucVayBLL.Send(txtSDT.Text, cbGoiVay.Text.ToString(), ckbDieuKhoan, cbGoiVay))
            {
                MessageBox.Show("Xin hãy đợi nhân viên xác nhận!");
                txtSDT.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
            
        }
    }
}
