using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class ChuyenKhoanDAO
    {
        private static ChuyenKhoanDAO ins;
        public static ChuyenKhoanDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new ChuyenKhoanDAO();
                return ins;
            }

            private set => ins = value;
        }


        private ChuyenKhoanDAO() { }

        public void ChuyenKhoan(string fromSTk, string toSTk, string soTien)
        {
            fromSTk = AccountDAO.Ins.TheAccount.SoTK;
            toSTk = "1973973973";
            string query = "select Count(*) from taikhoan where so_tai_khoan = '"+ toSTk + "'";

            int value = (int)DataProvider.Ins.ExecuteScalar(query);

            if(value == 1)
            {
                //UPDATE taikhoan SET so_du = 10 WHERE so_tai_khoan = '1970190190';
                value = Int32.Parse(AccountDAO.Ins.TheAccount.SoDu);
                query = "";
            }
        }

        bool UpdateMoney(string stk, string soTien)
        {
            string query = "SET so_du = " + soTien + " WHERE so_tai_khoan = '" + stk + "'";
            int value = (int)DataProvider.Ins.ExecuteNonQuery(query);
            if( value == 1)
            {
                return true;
            }

            return false;
        }
    }
}
