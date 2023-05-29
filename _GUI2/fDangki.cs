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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length <= 0 
                || txtAddress.Text.Length <= 0 
                || txtEmail.Text.Length <= 0 
                || txtPassword.Text.Length <= 0 
                || txtPasswordAgain.Text.Length <= 0
                || txtPIN.Text.Length <= 0
                || txtPINAgain.Text.Length <= 0) {
                MessageBox.Show("Xin hãy điền đủ thông tin!");
                return;
            }

            if(txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("Hai mật khẩu không trùng nhau!");
                return;
            }

            if (txtPIN.Text != txtPINAgain.Text)
            {
                MessageBox.Show("Hai PIN không trùng nhau!");
                return;
            }
        }
    }
}
