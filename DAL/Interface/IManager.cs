using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DTO;

namespace WindowsFormsApp2.Scripts.Interface
{
    interface IManager
    {
        void InitTypeSearch(ComboBox cbTypeSearch);
        void ShowListView_NhanVien(ListView lsvNhanVien);
        void Search(string txtType, string txtKeyword, ListView lsvNhanVien);
    }
}
