using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsFormsApp2.Scripts.DAO;
using WindowsFormsApp2.Scripts.DTO;

namespace DAO
{
    public class BankingDAO : IBanking
    {
        private static BankingDAO ins;
        public static BankingDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new BankingDAO();
                return ins;
            }

            private set => ins = value;
        }


        private BankingDAO() { }

        public bool CheckMoney(string txtMoney)
        {
            if (txtMoney.Length <= 0)
            {
                return false;
            }

            if (Int64.Parse(txtMoney) <= Int64.Parse(AccountDAO.Ins.TheAccount.SoDu))
            {
                return true;
            }
            
            return false;
        }

        public void ChuyenKhoan(string toSTk, string money)
        {
            string fromSTk = AccountDAO.Ins.TheAccount.SoTK;
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

        public string CheckNameWithSTK(string txtSTK)
        {
            if (txtSTK == "")
            {
                MessageBox.Show("Thử lại!");
                return null;
            }

            string query = "EXEC USP_GetNameUser @soTaiKhoan";
            DataTable table = DataProvider.Ins.ExecuteQuery(query, new object[] { Int64.Parse(txtSTK) });

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không tồn tại!");
                return null;
            }

            if (txtSTK == AccountDAO.Ins.TheAccount.SoTK)
            {
                MessageBox.Show("Không được chuyển tiền cho bản thân.");
                return null;
            }

            return table.Rows[0]["ho_ten"].ToString();
        }

        public int CheckPIN(string txtPIN)
        {
            string query = "USP_CheckPIN @soTaiKhoan , @maPIN";
            return (int)DataProvider.Ins.ExecuteScalar(query, new object[] {AccountDAO.Ins.TheAccount.SoTK , txtPIN });
        }
    }
}
