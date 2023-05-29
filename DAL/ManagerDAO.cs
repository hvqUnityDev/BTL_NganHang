using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DTO;
using WindowsFormsApp2.Scripts.Interface;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class ManagerDAO : IManager
    {
        private List<Employee> listEmployee = new List<Employee>();

        private static ManagerDAO ins;
        public static ManagerDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new ManagerDAO();
                return ins;
            }

            private set => ins = value;
        }

        void ShowNhanVien(ListView lsvNhanVien, string query, object[] objects)
        {
            lsvNhanVien.Items.Clear();
            listEmployee.Clear();
            var data = DataProvider.Ins.ExecuteQuery(query, objects);

            foreach (DataRow row in data.Rows)
            {
                Employee employee = new Employee(row);
                listEmployee.Add(employee);
            }

            int i = 1;
            foreach (var item in listEmployee)
            {
                ListViewItem lsvItem = new ListViewItem(i.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.DateOfBirth.ToString());
                lsvItem.SubItems.Add(item.SexName.ToString());
                lsvItem.SubItems.Add(item.Address.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber.ToString());
                lsvItem.SubItems.Add(item.Email.ToString());
                lsvNhanVien.Items.Add(lsvItem);
                i++;
            }
        }

        private void SearchWithName(string keyWord, ListView lsv)
        {
            MessageBox.Show("TODO: search with name");
        }

        private void SearchWithSDT(string keyWord, ListView lsv)
        {
            string query = "exec USP_getListUserWithSDT @SDT";
            ShowNhanVien(lsv, query, new object[] { keyWord });
        }
        private void SearchWithEmail(string keyWord, ListView lsv)
        {
            string query = "exec USP_getListUserWithEmail @email";
            ShowNhanVien(lsv, query, new object[] {keyWord});
        }

        public void Search(string txtType, string txtKeyword, ListView lsv)
        {
            switch (txtType)
            {
                case "Họ Tên":
                    SearchWithName(txtKeyword, lsv);
                    break;
                case "SĐT":
                    SearchWithSDT(txtKeyword, lsv);
                    break;
                case "Email":
                    SearchWithEmail(txtKeyword, lsv);
                    break;
                default:
                    MessageBox.Show("Kiểu không đúng!");
                    break;
            }
        }

        public void ShowListView_NhanVien(ListView lsvNhanVien)
        {
            string query = "select * from thongtinnguoidung where idquyen = 2";
            ShowNhanVien(lsvNhanVien, query, null);
        }

        public void ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            string query = "select * from vay_von";
            ShowNhanVien(lsvThuTuc, query, null);
        }

        public void ShowListView_Customer(ListView lsvCustomer)
        {
            string query = "select * from thongtinnguoidung where idquyen = 1";
            ShowNhanVien(lsvCustomer, query, null);
        }
    }
}
