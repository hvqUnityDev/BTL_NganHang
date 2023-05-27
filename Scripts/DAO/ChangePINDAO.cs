using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class ChangePINDAO
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

        public int ChangePIN()
        {
            string query = "EXEC USP_changePin @soTaiKhoan , @oldPin , @newPin";
            return (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] { AccountDAO.Ins.TheAccount.SoTK, Int64.Parse(txtOldPass.Text), Int64.Parse(txtNewPass.Text) });
        }
    }
}
