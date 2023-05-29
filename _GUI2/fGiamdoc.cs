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
    public partial class fGiamdoc : Form
    {
        public fGiamdoc()
        {
            InitializeComponent();
            Show_NhanVien();
            InitTypeSearch();
        }

        private void InitTypeSearch()
        {
            ManagerBLL managerBLL = new ManagerBLL();
            managerBLL.InitTypeSearch(cbTypeSearch);
        }

        private void Show_NhanVien()
        {
            ManagerBLL managerBLL = new ManagerBLL();
            managerBLL.ShowListView_NhanVien(lsvNhanVien);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerBLL managerBLL = new ManagerBLL();
            managerBLL.Search(cbTypeSearch.Text, txtKeyword.Text, lsvNhanVien);
        }
    }
}
