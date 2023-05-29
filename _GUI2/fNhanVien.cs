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
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
            InitTypeSearch();
            Show_KhachHang();
        }

        private void InitTypeSearch()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            nhanVienBLL.InitTypeSearch(cbTypeSearch);
        }

        private void Show_KhachHang()
        {
            ManagerBLL managerBLL = new ManagerBLL();
            managerBLL.ShowListView_KhachHang(lsvCustomer);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            if (tabControl1.SelectedIndex == 0)
            {
                nhanVienBLL.Search(cbTypeSearch.Text, txtKeyword.Text, lsvCustomer);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                nhanVienBLL.Search(cbTypeSearch.Text, txtKeyword.Text, lsvThuTuc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            nhanVienBLL.XacNhan(txtIDPicked.Text);
        }
    }
}
