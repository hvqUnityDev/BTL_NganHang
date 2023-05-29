using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DAO;

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

        public void XacNhan(string txtIDPicked)
        {
            if (txtIDPicked == null || txtIDPicked.Length <= 0)
            {
                MessageBox.Show("Chọn thủ tục");
                return;
            }

            NhanVienDAO.Ins.Accpect(txtIDPicked);

        }
    }
}
