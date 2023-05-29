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
        private List<Customer> listCustomer = new List<Customer>();

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

        void ShowCustomer(ListView lsvCustomer, string query, object[] objects)
        {
            lsvCustomer.Items.Clear();
            listCustomer.Clear();
            var data = DataProvider.Ins.ExecuteQuery(query, objects);

            foreach (DataRow row in data.Rows)
            {
                Customer employee = new Customer(row);
                listCustomer.Add(employee);
            }

            int i = 1;
            foreach (var item in listCustomer)
            {
                ListViewItem lsvItem = new ListViewItem(i.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.DateOfBirth.ToString());
                lsvItem.SubItems.Add(item.SexName.ToString());
                lsvItem.SubItems.Add(item.Address.ToString());
                lsvItem.SubItems.Add(item.SoTaiKhoan.ToString());
                lsvItem.SubItems.Add(item.SoDu.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber.ToString());
                lsvItem.SubItems.Add(item.Email.ToString());
                lsvCustomer.Items.Add(lsvItem);
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
            string query = "USP_getListUser @userRole";
            ShowNhanVien(lsvNhanVien, query, new object[] {1});
        }

        public void ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            string query = "select * from vay_von";
            ShowNhanVien(lsvThuTuc, query, null);
        }

        public void ShowListView_Customer(ListView lsvCustomer)
        {
            string query = "exec USP_GetListCustomer";
            ShowCustomer(lsvCustomer, query, null);
        }

        public void Accpect(string id)
        {
            throw new NotImplementedException();
        }
    }
}
