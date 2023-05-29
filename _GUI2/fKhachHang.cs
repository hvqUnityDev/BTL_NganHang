using BLL;
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
using WindowsFormsApp2.Scripts;

namespace WindowsFormsApp2
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
            isShow = true;
            Show_ThongTin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    // ẩn form hiẹn tại 
            fChuyenTien fChuyenTien = new fChuyenTien(); // khai báo biến
            fChuyenTien.ShowDialog();// hiển thi và dừng chờ 
            Show_SoDu(); // khi chuyển tiền đóng thì hiển thị  lại khách hàng 
            this.Show();
        }

        private bool isShow = true;

        private void label2_Click(object sender, EventArgs e)
        {
            Show_SoDu();
        }

        void Show_ThongTin()
        {
            AccountBLL accountBLL = new AccountBLL();
            lbName.Text = accountBLL.GetHoTen();
            lbSTK.Text = accountBLL.GetSoTK();
            lbMoney.Text = accountBLL.GetSoDu(); 

            money = lbMoney.Text;
            Show_SoDu();
        }

        private string money;

        void Show_SoDu()
        {
            if (isShow == true)
            {
                lbMoney.Text = "*****";
                isShow = false;
            }
            else
            {
                lbMoney.Text = money;
                isShow = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPhanHoi fPhanHoi = new fPhanHoi();
            fPhanHoi.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fDoiMaPin fDoiMaPin = new fDoiMaPin();
            fDoiMaPin.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CrystalReport1 r = new CrystalReport1();

            BankingBLL bankingBLL = new BankingBLL();
            r.SetDataSource(bankingBLL.SaoKe());

            fSaoKe fSaoKe = new fSaoKe();
            fSaoKe.crystalReportViewer.ReportSource = r;
            fSaoKe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fNapDT f = new fNapDT();
            f.ShowDialog();
            this.Show();
        }
    }
}