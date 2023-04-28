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
    public partial class fChuyenTien : Form
    {
        public fChuyenTien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            fNhapMaPin nhapMaPin= new fNhapMaPin();
            this.Hide();
            nhapMaPin.ShowDialog(); 
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
