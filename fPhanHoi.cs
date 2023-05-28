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
    public partial class fPhanHoi : Form
    {
        public fPhanHoi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FeedBackDAO.Ins.SendFeedBack();
            this.Close();
        }
    }
}
