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
            Show_VayVon();
        }

        private void Show_VayVon()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            nhanVienBLL.ShowListView_ThuTuc(lsvThuTuc);
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
            if (nhanVienBLL.XacNhan(txtIDPicked))
            {
                Show_VayVon();
            }
        }

        private void lsvThuTuc_Click(object sender, EventArgs e)
        {
            string id = lsvThuTuc.SelectedItems[0].ToString();
            id = id.Substring(id.IndexOf('{')+1, id.IndexOf('}') - id.IndexOf('{')-1);
            txtIDPicked.Text = id;
        }
    }
}
