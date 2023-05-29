using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void Accpect(string id)
        {
            MessageBox.Show("Accpect ThuTuc NV");
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

        public void ShowListView_ThuTuc(ListView lsvThuTuc)
        {
            throw new NotImplementedException();
        }
    }
}
