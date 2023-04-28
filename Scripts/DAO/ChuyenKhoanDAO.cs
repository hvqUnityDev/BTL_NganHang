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
            string query = "select * from taikhoan where so_tai_khoan = '"+ fromSTk + "' or so_tai_khoan = '"+ toSTk + "'";

            DataTable dataTable = DataProvider.Ins.ExecuteQuery(query);

        }
    }
}
