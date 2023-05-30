using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Scripts.DTO;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class AccountDAO : IAccount
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

        private Account theAccount;
        public Account TheAccount { get => theAccount; private set => theAccount = value; }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            if ((int)DataProvider.Ins.ExecuteScalar(query, new object[] { userName, passWord }) == 1)
            {
                query = "EXEC USP_GetInfoWithUserNameAndPassword @userName , @passWord ";

                DataTable table = DataProvider.Ins.ExecuteQuery(query, new object[] { userName, passWord });
                theAccount = new DTO.Account(table.Rows[0]);
                return true;
            }

            return false;
        }

        public bool Register(string txtName, string txtDateOfBirth, string txtAddress, string txtSex, string txtSDT, string txtEmail, string txtPassword, string txtPIN, string txtSTK)
        {
            //var a = txtDateOfBirth.Split('/');
            //txtDateOfBirth = a[a.Length - 1];
            //for (int i = a.Length - 2; i >= 0; i--)
            //{
            //    txtDateOfBirth += "-" + a[i] ;
            //}

            //txtDateOfBirth = '\'' + txtDateOfBirth + '\'';


            string query = "exec USP_register @ho_ten , @ngay_sinh , @dia_chi , @gioi_tinh , @SDT , @email , @passWord , @PIN , @soTaiKhoan ";
            //string query = "exec USP_registerW @ho_ten , @dia_chi , @gioi_tinh , @SDT , @email , @passWord , @PIN , @soTaiKhoan ";

            int value = (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] { txtName, txtDateOfBirth, txtAddress, txtSex, txtSDT, txtEmail, txtPassword, txtPIN, txtSTK });
            return value == 0 ? false : true;
        }

        public bool UpdateInfo(string txtName, string txtBirth, string txtAddress, string txtSex, string txtSDT, string txtEmail, string txtPassword)
        {
            if (!Login(AccountDAO.Ins.theAccount.Email, txtPassword)) return false;

            string query = "USP_update  @userName , @ho_ten , @dia_chi , @gioi_tinh , @SDT , @Password";
            int value = (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] { txtEmail, txtName, txtAddress,  txtSex, txtSDT, txtPassword });

            return value == 0 ? false : true;
        }
    }
}
