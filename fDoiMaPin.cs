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
            if(!ChangePINDAO.Ins.CheckNewPassword(txtNewPass.Text, txtNewPassAgain.Text))
            {
                MessageBox.Show("Đổi PIN thất bại - 2 mật khẩu mới phải trùng nhau.");
                return;
            }

            if(ChangePINDAO.Ins.ChangePIN(txtOldPass.Text, txtNewPass.Text) == 0)
            {
                MessageBox.Show("Đổi PIN thất bại.");
            }
            else
            {
                MessageBox.Show("Đổi PIN thành công.");
                ResetText();
            }
        }

        private void ResetText()
        {
            txtNewPass.Text = "";
            txtOldPass.Text = "";
            txtNewPassAgain.Text = "";
        }
    }
}
