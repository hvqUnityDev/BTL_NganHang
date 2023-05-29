using BLL;
using CrystalDecisions.CrystalReports.Engine;
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

            lbName.Text = accountBLL.GetName();
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
            RP_SaoKe r = new RP_SaoKe();

            BankingBLL bankingBLL = new BankingBLL();
            r.SetDataSource(bankingBLL.SaoKe());

            fSaoKe fSaoKe = new fSaoKe();
            fSaoKe.crystalReportViewer.ReportSource = r;

            AccountBLL accountBLL = new AccountBLL();

            TextObject txt;
            txt = (TextObject)r.ReportDefinition.ReportObjects["txtName"];
            txt.Text = accountBLL.GetName();

            txt = (TextObject)r.ReportDefinition.ReportObjects["txtSTK"];
            txt.Text = accountBLL.GetSoTK();

            txt = (TextObject)r.ReportDefinition.ReportObjects["txtDateOfBirth"];
            txt.Text = accountBLL.GetDateOfBirth();

            txt = (TextObject)r.ReportDefinition.ReportObjects["txtAddress"];
            txt.Text = accountBLL.GetAddress();

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