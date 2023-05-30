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

            foreach (var item in listEmployee)
            {
                ListViewItem lsvItem = new ListViewItem(item.ID.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.DateOfBirth.ToString());
                lsvItem.SubItems.Add(item.SexName.ToString());
                lsvItem.SubItems.Add(item.Address.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber.ToString());
                lsvItem.SubItems.Add(item.Email.ToString());
                lsvNhanVien.Items.Add(lsvItem);
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

            foreach (var item in listCustomer)
            {
                ListViewItem lsvItem = new ListViewItem(item.ID.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.DateOfBirth.ToString());
                lsvItem.SubItems.Add(item.SexName.ToString());
                lsvItem.SubItems.Add(item.Address.ToString());
                lsvItem.SubItems.Add(item.SoTaiKhoan.ToString());
                lsvItem.SubItems.Add(item.SoDu.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber.ToString());
                lsvItem.SubItems.Add(item.Email.ToString());
                lsvCustomer.Items.Add(lsvItem);
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
            ShowNhanVien(lsvNhanVien, query, new object[] {2});
        }

        public void ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            
        }

        public DataTable ShowListView_ThuTuc_DataTable(ListView lsvThuTuc)
        {
            string query = "exec USP_GetVayVon_WithIDStatus @idStatus";
            return DataProvider.Ins.ExecuteQuery(query, new object[] { 2 });
        }

        public void ShowListView_Customer(ListView lsvCustomer)
        {
            string query = "exec USP_GetListUser @userRole";
            ShowCustomer(lsvCustomer, query, new object[] {1});
        }

        public bool Accpect(string id)
        {
            string query = "USP_HandleVayVon_ForGiamDoc_ChapNhan @idVayVon";
            int value = DataProvider.Ins.ExecuteNonQuery(query, new object[] { id });
            return value > 0;
        }

        public bool Refuse(string id)
        {
            string query = "USP_HandleVayVon_ForGiamDoc_TuChoi @idVayVon";
            int value = DataProvider.Ins.ExecuteNonQuery(query, new object[] { id });
            return value > 0;
        }

        public DataTable RP_ThuTuc_DaDuyet()
        {
            string query = "USP_GetVayVon_WithIDStatus @idStatus ";
            return DataProvider.Ins.ExecuteQuery(query, new object[] { 3 });
        }

        public DataTable RP_ThuTuc_TuChoi()
        {
            string query = "USP_GetVayVon_WithIDStatus @idStatus ";
            return DataProvider.Ins.ExecuteQuery(query, new object[] { 4 });
        }

        public DataTable RP_ThuTuc_ChoDuyet()
        {
            string query = "USP_GetVayVon_WithIDStatus @idStatus ";
            return DataProvider.Ins.ExecuteQuery(query, new object[] { 2 });
        }

        public bool RemoveEmployee(string id)
        {
            string query = "USP_DeleteNguoiDung @id";
            int value = DataProvider.Ins.ExecuteNonQuery(query, new object[] {Int16.Parse(id) });
            return value > 0;
        }

        DataTable IManager.ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            throw new NotImplementedException();
        }
    }
}
