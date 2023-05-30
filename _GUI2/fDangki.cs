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
    public partial class fDangki : Form
    {
        public fDangki()
        {
            InitializeComponent();
            SetValueCb();
        }

        void SetValueCb()
        {
            cbSex.Items.Clear();
            cbSex.Items.Add("Nam");
            cbSex.Items.Add("Nu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            AccountBLL accountBLL = new AccountBLL();

            

            accountBLL.Register
                (txtName.Text,
                "2002-01-16",
                txtAddress.Text,
                cbSex.Text,
                txtSDT.Text,
                txtEmail.Text,
                txtPassword.Text,
                txtPasswordAgain.Text,
                txtPIN.Text,
                txtPINAgain.Text,
                txtSTK.Text);
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
