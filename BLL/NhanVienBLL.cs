using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp2.Scripts;
using WindowsFormsApp2.Scripts.DAO;
using WindowsFormsApp2.Scripts.DTO;

namespace BLL
{
    public class NhanVienBLL 
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

        public void Search(string txtTypeSearch, string txtKeyword, ListView lsv)
        {
            if (txtTypeSearch == null || txtKeyword == null
                || txtTypeSearch.Length <= 0
                || txtKeyword.Length <= 0
                || lsv == null)
            {
                MessageBox.Show("Thử lại!");
                return;
            }
                
            NhanVienDAO.Ins.Search(txtTypeSearch, txtKeyword, lsv);
        }

        public void ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            if (lsvThuTuc == null) return;
            DataTable data = NhanVienDAO.Ins.ShowListView_ThuTuc(lsvThuTuc);

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

        public bool XacNhan(TextBox txtIDPicked)
        {
            if (txtIDPicked == null || txtIDPicked.Text.Length <= 0)
            {
                MessageBox.Show("Chọn thủ tục");
                return false;
            }

            if (!NhanVienDAO.Ins.Accpect(txtIDPicked.Text.ToString()))
            {
                MessageBox.Show("Xác Nhận Thất Bại!");
                return false;
            }

            MessageBox.Show("Xác Nhận Thành Công, Hãy đợi Giám Đốc Ngân Hàng Duyệt!");
            txtIDPicked.Text = "";
            return true;
        }
    }
}
