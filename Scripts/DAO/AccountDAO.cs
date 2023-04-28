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
            string query = $"SELECT dbo.login('{userName}','{passWord}')";
            if ((int)DataProvider.Ins.ExecuteScalar(query) == 1)
            {
                query = "select * from thongtinnguoidung where email = '" + userName + "' and password = '" + passWord + "'";

                DataTable table = DataProvider.Ins.ExecuteQuery(query);
                theAccount = new DTO.Account(table.Rows[0]);

                query = "select * from taikhoan where ID_nguoisudung = '" + theAccount.IDNguoiSuDung + "'";
                table = DataProvider.Ins.ExecuteQuery(query);
                theAccount.SetMoreValue(table.Rows[0]);
                return true;
            }
            return false;
        }

        private DTO.Account theAccount;
        public Account TheAccount { get => theAccount; set => theAccount = value; }

    }
}
