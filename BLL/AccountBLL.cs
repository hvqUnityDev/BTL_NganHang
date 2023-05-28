using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Scripts.DAO;

namespace BLL
{
    public class AccountBLL
    {
        public string GetHoTen()
        {
            return AccountDAO.Ins.TheAccount.HoTen;
        }

        public string GetSoDu()
        {
            return AccountDAO.Ins.TheAccount.SoDu;
        }

        public string GetSoTK()
        {
            return AccountDAO.Ins.TheAccount.SoTK;
        }

        public bool Login(string username, string password)
        {
            if(username == null || password == null) return false;
            if(username.Length <= 0 || password.Length <= 0) return false; 

            AccountDAO accountDAO = new AccountDAO();
            if(!accountDAO.Login(username, password)) return false;

            return true;
        }
    }
}
