using _BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fNapDT : Form
    {
        public fNapDT()
        {
            InitializeComponent();
            MobileRechargeBLL mobileRechargeBLL = new MobileRechargeBLL();
            mobileRechargeBLL.AddHomeNetwork(cbNhaMang);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MobileRechargeBLL mobileRechargeBLL = new MobileRechargeBLL();
            if (mobileRechargeBLL.MobileRecharge(cbNhaMang.SelectedItem.ToString(), txtPhoneNumber.Text, txtMoney.Text) == 1)
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
