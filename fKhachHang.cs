using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    // ẩn form hiẹn tại 
            fChuyenTien fChuyenTien = new fChuyenTien(); // khai báo biến
            fChuyenTien.ShowDialog();// hiển thi và dừng chờ 
            this.Show(); // khi chuyển tiền đóng thì hiển thị  lại khách hàng 
        }

        private bool isShow = true;

        private void label2_Click(object sender, EventArgs e)
        {
            Show();

        }

        void Show()
        {
            if (isShow == true)
            {
                lbMoney.Text = "*****";
                isShow = false;
            }
            else
            {
                lbMoney.Text = 99999.ToString();
                isShow = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPhanHoi fPhanHoi = new fPhanHoi();
            fPhanHoi.ShowDialog();
            this.Show();
        }
    }
}
