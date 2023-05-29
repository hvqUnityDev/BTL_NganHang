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
using WindowsFormsApp2.Scripts;
using WindowsFormsApp2.Scripts.DTO;

namespace WindowsFormsApp2
{
    public partial class fChuyenTien : Form
    {
        private bool isChecked = false;
        public fChuyenTien()
        {
            InitializeComponent();
        }

        // comment

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isChecked)
            {
                MessageBox.Show("Kiểm tra lại!");
                return;
            }
            BankingBLL bankingBLL = new BankingBLL();
            if (!bankingBLL.CheckMoney(numMoney.Text)) {
                MessageBox.Show("Thử lại!");
                return;
            }

            this.Hide();
            fNhapMaPin nhapMaPin = new fNhapMaPin();
            nhapMaPin.DoItWhenCorrectPIN = Banking;
            nhapMaPin.ShowDialog(); 
        }

        private void Banking()
        {
            BankingBLL bankingBLL = new BankingBLL();
            bankingBLL.ChuyenKhoan(txtSTK.Text, numMoney.Value.ToString());
            MessageBox.Show($"ChuyenKhoan {txtSTK.Text} {numMoney.Value}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BankingBLL bankingBLL = new BankingBLL();
            string s = bankingBLL.CheckNameWithSTK(txtSTK.Text);
            if (s != null)
            {
                txtName.Text = s;
                isChecked = true;
            }
            else
            {
                txtName.Text = "";
                isChecked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
