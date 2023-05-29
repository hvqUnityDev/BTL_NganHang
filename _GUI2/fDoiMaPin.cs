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

namespace WindowsFormsApp2
{
    public partial class fDoiMaPin : Form
    {

        public fDoiMaPin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void ChangePassword()
        {
            BankingBLL bankingBLL = new BankingBLL();
            if (!bankingBLL.CheckNewPassword(txtNewPass.Text, txtNewPassAgain.Text)) return;
            if (bankingBLL.ChangePIN(txtOldPass.Text, txtNewPass.Text))
            {
                this.Close();
            }
        }
    }
}
