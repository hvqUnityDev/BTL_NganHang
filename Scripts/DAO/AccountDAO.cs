using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Scripts.DTO;

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

        public bool Login(string userName, string passWord) {
            
            string query = "USP_Login @userName , @passWord";

            if ((int)DataProvider.Ins.ExecuteScalar(query, new object[] {userName, passWord}) == 1)
            { 
                query = "EXEC USP_GetInfoWithUserNameAndPassword @userName , @passWord ";

                DataTable table = DataProvider.Ins.ExecuteQuery(query, new object[] {userName, passWord});
                theAccount = new DTO.Account(table.Rows[0]);
                return true;
            }

            return false;
        }

        private DTO.Account theAccount;
        public Account TheAccount { get => theAccount; set => theAccount = value; }

    }
}
