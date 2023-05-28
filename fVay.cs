using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DAO;

namespace WindowsFormsApp2
{
    public partial class fVay : Form
    {
        public fVay()
        {
            InitializeComponent();
            ThuTucVayDAO.Ins.InitGoiVay(cbGoiVay);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkDieuKhoan.LinkVisited = true;
            System.Diagnostics.Process.Start(ThuTucVayDAO.Ins.LinkDieuKhoan());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ckbDieuKhoan.Checked)
            {
                MessageBox.Show("Check Điều Khoản!");
                return;
            }

            if(txtSDT.Text.Length <= 0 || txtCCCD.Text.Length <= 0 || cbGoiVay.Text.ToString().Length <= 0) 
            {
                MessageBox.Show("Hãy điền đủ thông tin!");
                return;
            }

            ThuTucVayDAO.Ins.Send(txtCCCD.Text, txtSDT.Text, cbGoiVay.Text.ToString());
        }
    }
}
