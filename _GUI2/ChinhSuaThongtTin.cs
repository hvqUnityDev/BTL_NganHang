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
    public partial class ChinhSuaThongtTin : Form
    {
        public ChinhSuaThongtTin()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            cbSex.Items.Clear();
            cbSex.Items.Add("Nam");
            cbSex.Items.Add("Nu");

            AccountBLL accountBLL = new AccountBLL();
            accountBLL.FillData(txtName, dtBirth, txtAddress, cbSex, txtSDT, txtEmail);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            if(accountBLL.UpdateInfo(txtName.Text,
                dtBirth.Text,
                txtAddress.Text,
                cbSex.Text,
                txtSDT.Text,
                txtEmail.Text,
                txtPassword.Text
                ))
            {
                txtName.Text = "";
                dtBirth.Text = "";
                txtAddress.Text = "";
                cbSex.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                this.Hide();
            }
        }
    }
}
