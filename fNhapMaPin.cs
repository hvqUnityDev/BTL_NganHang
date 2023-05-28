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
    public partial class fNhapMaPin : Form
    {
        int count = 3;

        public fNhapMaPin()
        {
            InitializeComponent();
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(BankingDAO.Ins.CheckPIN(txtPIN.Text) == 1)
            {
                MessageBox.Show("Thành Công!");
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
        }
    }
}