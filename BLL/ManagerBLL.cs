using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DAO;

namespace BLL
{
    public class ManagerBLL
    {

        private List<string> typesSearch = new List<string>() { "Họ Tên", "SĐT", "Email" };
        public void InitTypeSearch(ComboBox cbTypeSearch)
        {
            cbTypeSearch.Items.Clear();
            foreach (var item in typesSearch)
            {
                cbTypeSearch.Items.Add(item);
            }
        }

        public void Search(string txtTypeSearcht, string txtKeyword, ListView lsvNhanVien)
        {
            if (txtTypeSearcht == null || txtKeyword == null 
                || txtTypeSearcht.Length <= 0 
                || txtKeyword.Length <= 0 
                || lsvNhanVien == null)
            {
                MessageBox.Show("Thử lại!");
                return; 
            }

            ManagerDAO.Ins.Search(txtTypeSearcht, txtKeyword, lsvNhanVien);
        }

        public void ShowListView_NhanVien(ListView lsvNhanVien)
        {
            if(lsvNhanVien == null)
            {
                MessageBox.Show("Thử lại!");
                return;
            }

            ManagerDAO.Ins.ShowListView_NhanVien(lsvNhanVien);
        }

        public void ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            if (lsvThuTuc == null) return;
            DataTable data = ManagerDAO.Ins.ShowListView_ThuTuc_DataTable(lsvThuTuc);

            lsvThuTuc.Items.Clear();
            List<ThuTuc> listThuTuc = new List<ThuTuc>();
            foreach (DataRow row in data.Rows)
            {
                ThuTuc thuTuc = new ThuTuc(row);
                listThuTuc.Add(thuTuc);
            }

            foreach (var item in listThuTuc)
            {
                ListViewItem lsvItem = new ListViewItem(item.Id.ToString());
                lsvItem.SubItems.Add(item.Name);
                lsvItem.SubItems.Add(item.Stk);
                lsvItem.SubItems.Add(item.Sdt);
                lsvItem.SubItems.Add(item.Tensp);
                lsvItem.SubItems.Add(item.NgayVay);
                lsvItem.SubItems.Add(item.Status);
                lsvThuTuc.Items.Add(lsvItem);
            }
        }

        public void ShowListView_KhachHang(ListView lsvCustomer)
        {
            if (lsvCustomer == null)
            {
                MessageBox.Show("Thử lại!");
                return;
            }

            ManagerDAO.Ins.ShowListView_Customer(lsvCustomer);
        }

        public DataTable RP_ThuTuc_DaDuyet()
        {
            return ManagerDAO.Ins.RP_ThuTuc_DaDuyet();
        }

        public DataTable RP_ThuTuc_TuChoi()
        {
            return ManagerDAO.Ins.RP_ThuTuc_TuChoi();
        }

        public DataTable RP_ThuTuc_ChoDuyet()
        {
            return ManagerDAO.Ins.RP_ThuTuc_ChoDuyet();
        }

        public bool RemoveEmployee(string id)
        {
            if (id == null || id.Length <= 0) return false;
            return ManagerDAO.Ins.RemoveEmployee(id);
        }

        public bool XacNhan(TextBox txtIDPicked)
        {
            if (txtIDPicked == null || txtIDPicked.Text.Length <= 0)
            {
                MessageBox.Show("Chọn thủ tục");
                return false;
            }

            if (!ManagerDAO.Ins.Accpect(txtIDPicked.Text.ToString()))
            {
                MessageBox.Show("Xác Nhận Thất Bại!");
                return false;
            }

            MessageBox.Show("Xác Nhận Thành Công, Tiền đã chuyển cho khách hàng!");
            txtIDPicked.Text = "";
            return true;
        }

        public bool TuChoi(TextBox txtIDPicked)
        {
            if (txtIDPicked == null || txtIDPicked.Text.Length <= 0)
            {
                MessageBox.Show("Chọn thủ tục");
                return false;
            }

            if (!ManagerDAO.Ins.Refuse(txtIDPicked.Text.ToString()))
            {
                MessageBox.Show("Xác Nhận Thất Bại!");
                return false;
            }

            MessageBox.Show("Từ Chối Thành Công");
            txtIDPicked.Text = "";
            return true;
        }
    }
}
