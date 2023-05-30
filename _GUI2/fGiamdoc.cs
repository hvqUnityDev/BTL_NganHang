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
            Show_ThuTuc();
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
            ManagerBLL managerBLL = new ManagerBLL();
            if (managerBLL.XacNhan(txtIDPicked))
            {
                Show_ThuTuc();
            }
        }

        private void lsvThuTuc_MouseClick(object sender, MouseEventArgs e)
        {
            string txtID = lsvThuTuc.SelectedItems[0].SubItems[0].Text;

            txtIDPicked.Text = txtID;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RP_ThuTuc_DaDuyet r = new RP_ThuTuc_DaDuyet();

            ManagerBLL managerBLL = new ManagerBLL();
            r.SetDataSource(managerBLL.RP_ThuTuc_DaDuyet());

            fSaoKe fSaoKe = new fSaoKe();
            fSaoKe.crystalReportViewer.ReportSource = r;
            fSaoKe.ShowDialog(); 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RP_ThuTuc_TuChoi r = new RP_ThuTuc_TuChoi();

            ManagerBLL managerBLL = new ManagerBLL();
            r.SetDataSource(managerBLL.RP_ThuTuc_TuChoi());

            fSaoKe fSaoKe = new fSaoKe();
            fSaoKe.crystalReportViewer.ReportSource = r;
            fSaoKe.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RP_ThuTuc_DangChoDuyet r = new RP_ThuTuc_DangChoDuyet();

            ManagerBLL managerBLL = new ManagerBLL();
            r.SetDataSource(managerBLL.RP_ThuTuc_ChoDuyet());

            fSaoKe fSaoKe = new fSaoKe();
            fSaoKe.crystalReportViewer.ReportSource = r;
            fSaoKe.ShowDialog();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ManagerBLL ManagerBLL = new ManagerBLL();
            string id = lsvEmployee.SelectedItems[0].ToString();
            id = id.Substring(id.IndexOf("{")+1, id.IndexOf("}") - id.IndexOf("{") -1);
            if (ManagerBLL.RemoveEmployee(id)){
                MessageBox.Show("Xoa Thanh Cong");
                ManagerBLL.ShowListView_NhanVien(lsvEmployee);
                return;
            }

            MessageBox.Show("Xóa Thất Bại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerBLL managerBLL = new ManagerBLL();
            if (managerBLL.TuChoi(txtIDPicked))
            {
                Show_ThuTuc();
            }
        }
    }
}
