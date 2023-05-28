using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DTO;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class ManagerDAO
    {
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

        private List<Employee> listEmployee = new List<Employee>();
        public void ShowListView_NhanVien(ListView lsvNhanVien)
        {
            string query = "select * from thongtinnguoidung";

            lsvNhanVien.Items.Clear();
            listEmployee.Clear();
            var data = DataProvider.Ins.ExecuteQuery(query);

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

    }
}
