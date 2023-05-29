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
    public partial class fNhapMaPin : Form
    {
        public Action DoItWhenCorrectPIN;

        int count;

        public fNhapMaPin()
        {
            InitializeComponent();
            count = 2;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            BankingBLL bankingBLL = new BankingBLL();
            if (bankingBLL.CheckPIN(txtPIN.Text) == 1)
            {
                MessageBox.Show("Thành Công!");
                DoItWhenCorrectPIN?.Invoke();
                DoItWhenCorrectPIN = null;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Thử lại PIN ({count})!");
                count--;
                if(count < 0)
                {
                    this.Close();
                }
            }

            txtPIN.Text = "";
        }

    }
}