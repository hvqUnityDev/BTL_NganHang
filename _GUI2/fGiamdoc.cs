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
            Show_KhachHang();
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
            managerBLL.ShowListView_NhanVien(lsvEmployee);
        }

        private void Show_KhachHang()
        {
            ManagerBLL managerBLL = new ManagerBLL();
            managerBLL.ShowListView_KhachHang(lsvCustomer);
        }

        private void Show_ThuTuc()
        {
            ManagerBLL managerBLL = new ManagerBLL();
            managerBLL.ShowListView_ThuTuc(lsvThuTuc);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ManagerBLL managerBLL = new ManagerBLL();
            if ( tabControl1.SelectedIndex == 0){
                managerBLL.Search(cbTypeSearch.Text, txtKeyword.Text, lsvEmployee);
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                managerBLL.Search(cbTypeSearch.Text, txtKeyword.Text, lsvCustomer);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                managerBLL.Search(cbTypeSearch.Text, txtKeyword.Text, lsvThuTuc);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lsvThuTuc_MouseClick(object sender, MouseEventArgs e)
        {
            string txtID = lsvThuTuc.SelectedItems[0].SubItems[0].Text;

            txtIDPicked.Text = txtID;
        }
    }
}
