using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class AccountDAO
    {
        private static AccountDAO ins;
        public static AccountDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new AccountDAO();
                return ins;
            }

            private set => ins = value;
        }

        private AccountDAO() { }

        public bool Login(string username, string password) {

            string query = $"SELECT dbo.login('{username}','{password}')";
            if ((int)DataProvider.Ins.ExecuteScalar(query) == 1)
                return true;
            return false;
        }

    }
}
