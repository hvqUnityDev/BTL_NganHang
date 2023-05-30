using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public interface IBanking
    {
        string CheckNameWithSTK(string txtSTK);
        void ChuyenKhoan(string toSTk, string soTien, string date, string text);
        int ChangePIN(string txtOldPass, string txtNewPass);
        int CheckPIN(string txtPIN);
        DataTable SaoKe();
    }
}
