using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Scripts.Interface;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class ChangePINDAO : IChangePIN
    {
        private static ChangePINDAO ins;
        public static ChangePINDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new ChangePINDAO();
                return ins;
            }

            private set => ins = value;
        }

        public bool CheckNewPassword(string txtNewPass, string txtNewPassAgain)
        {
            if (txtNewPass == txtNewPassAgain)
            {
                return true;
            }

            return false;
        }

        public int ChangePIN(string txtOldPass, string txtNewPass)
        {
            string query = "EXEC USP_changePin @soTaiKhoan , @oldPin , @newPin";
            return (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] { AccountDAO.Ins.TheAccount.SoTK, Int64.Parse(txtOldPass), Int64.Parse(txtNewPass) });
        }
    }
}
