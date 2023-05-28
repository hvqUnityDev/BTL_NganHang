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
    public partial class fNapDT : Form
    {
        public fNapDT()
        {
            InitializeComponent();
            MobileRechargeDAO.Ins.AddHomeNetwork(cbNhaMang);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MobileRechargeDAO.Ins.MobileRecharge(cbNhaMang.SelectedItem.ToString(), txtPhoneNumber.Text, txtMoney.Text) == 1)
            {
                MessageBox.Show("TODO: Nạp tiền thành công!");
            }
            else
            {
                MessageBox.Show("TODO: Nạp tiền thất bại!");
            }
        }
    }
}
