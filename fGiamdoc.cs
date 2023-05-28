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
    public partial class fGiamdoc : Form
    {
        public fGiamdoc()
        {
            InitializeComponent();
            Show_NhanVien();
        }

        private void Show_NhanVien()
        {
            ManagerDAO.Ins.ShowListView_NhanVien(lsvNhanVien);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
