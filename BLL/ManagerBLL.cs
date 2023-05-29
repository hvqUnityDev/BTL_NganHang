using System;
using System.Collections.Generic;
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
            if (lsvThuTuc == null)
            {
                MessageBox.Show("Thử lại!");
                return;
            }

            ManagerDAO.Ins.ShowListView_ThuTuc(lsvThuTuc);
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
    }
}
