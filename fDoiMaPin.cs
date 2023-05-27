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
            if(!CheckNewPassword())
            {
                MessageBox.Show("Đổi PIN thất bại - 2 mật khẩu mới phải trùng nhau.");
                return;
            }

            string query = "EXEC USP_changePin @soTaiKhoan , @oldPin , @newPin";
            int n = DataProvider.Ins.ExecuteNonQuery(query, new object[] {AccountDAO.Ins.TheAccount.SoTK , Int64.Parse(txtOldPass.Text), Int64.Parse(txtNewPass.Text) });
            if(n == 0)
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

        private bool CheckNewPassword()
        {
            if(txtNewPass.Text ==txtNewPassAgain.Text)
            {
                return true;
            }

            return false;
        }

    }
}
