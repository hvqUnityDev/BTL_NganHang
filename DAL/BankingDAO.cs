using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp2.Scripts;
using WindowsFormsApp2.Scripts.DAO;
using WindowsFormsApp2.Scripts.DTO;

namespace DAL
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
        public void ChuyenKhoan(string toSTk, string money, string date, string text)
        {
            string fromSTk = AccountDAO.Ins.TheAccount.SoTK;
            string query = "USP_saveBanking @from , @to , @money , @ngay_gd , @text ";
            DataProvider.Ins.ExecuteNonQuery(query, new object[] { Int64.Parse(fromSTk), Int64.Parse(toSTk), Int64.Parse(money) * 1.0f, date, text });
        }


        public string CheckNameWithSTK(string txtSTK)
        {
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
            return (int)DataProvider.Ins.ExecuteScalar(query, new object[] {AccountDAO.Ins.TheAccount.SoTK , Int32.Parse(txtPIN) });
        }

        public int ChangePIN(string txtOldPass, string txtNewPass)
        {
            string query = "EXEC USP_changePin @soTaiKhoan , @oldPin , @newPin";
            return (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] { AccountDAO.Ins.TheAccount.SoTK, Int64.Parse(txtOldPass), Int64.Parse(txtNewPass) });
        }

        public DataTable SaoKe()
        {
            string query = "usp_saoke @id ";
            return DataProvider.Ins.ExecuteQuery(query, new object[] { AccountDAO.Ins.TheAccount.SoTK });
        }
    }
}
