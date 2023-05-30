using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts;
using WindowsFormsApp2.Scripts.DAO;
using WindowsFormsApp2.Scripts.Interface;

namespace DAL
{
    public class NhanVienDAO : IManager
    {
        private static NhanVienDAO ins;
        public static NhanVienDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new NhanVienDAO();
                return ins;
            }

            private set => ins = value;
        }

        public bool Accpect(string id)
        {
            string query = "USP_HandleVayVon_ForNhanVien_ChapNhan @idVayVon";
            int value = (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] {Int16.Parse(id)});
        
            return value > 0;
        }

        public void Search(string txtType, string txtKeyword, ListView lsvNhanVien)
        {
            MessageBox.Show("Search nv");
        }

        public void ShowListView_Customer(ListView lsvCustomer)
        {
            throw new NotImplementedException();
        }

        public void ShowListView_NhanVien(ListView lsvNhanVien)
        {
            throw new NotImplementedException();
        }

        public DataTable ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            string query = "exec USP_GetVayVon_WithIDStatus @idStatus";
            return DataProvider.Ins.ExecuteQuery(query, new object[] {1});
        }

    }
}
