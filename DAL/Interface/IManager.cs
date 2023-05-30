using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DTO;

namespace WindowsFormsApp2.Scripts.Interface
{
    interface IManager
    {
        void ShowListView_NhanVien(ListView lsvNhanVien);
        DataTable ShowListView_ThuTuc(ListView lsvThuTuc);
        void ShowListView_Customer(ListView lsvCustomer);
        void Search(string txtType, string txtKeyword, ListView lsvNhanVien);
        bool Accpect(string id);
    }
}
