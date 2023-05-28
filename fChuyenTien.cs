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
using WindowsFormsApp2.Scripts.DAO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isChecked)
            {
                MessageBox.Show("Kiểm tra lại!");
                return;
            }
            if (!BankingDAO.Ins.CheckMoney(numMoney.Text)) return;

            this.Hide();
            fNhapMaPin nhapMaPin= new fNhapMaPin();
            nhapMaPin.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(BankingDAO.Ins.CheckNameWithSTK(txtSTK.Text) != null)
            {
                txtName.Text = BankingDAO.Ins.CheckNameWithSTK(txtSTK.Text);
                isChecked = true;
            }
            else
            {
                txtName.Text = "";
                isChecked = false;
            }
        }
    }
}
