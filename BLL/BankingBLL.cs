using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts;
using WindowsFormsApp2.Scripts.DAO;

namespace BLL
{
    public class BankingBLL
    {     
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

        public string CheckNameWithSTK(string txtSTK)
        {
            if (txtSTK == "")
            {
                MessageBox.Show("Thử lại!");
                return null;
            }

            return BankingDAO.Ins.CheckNameWithSTK(txtSTK);
        }

        public void ChuyenKhoan(string txtSTk, string money) 
        { 
            BankingDAO.Ins.ChuyenKhoan(txtSTk, money);
        }

        public int CheckPIN(string txtPIN)
        {
            if(txtPIN == "" || txtPIN.Length <= 0) {
                return 0;
            }

            return BankingDAO.Ins.CheckPIN(txtPIN);
        }

        public bool CheckNewPassword(string txtNewPass, string txtNewPassAgain)
        {
            if (txtNewPass != txtNewPassAgain || txtNewPass.Length <= 0 || txtNewPassAgain.Length <= 0)
            {
                MessageBox.Show("Đổi PIN thất bại - 2 mật khẩu mới phải trùng nhau.");
                return false;
            }

            return true;
        }

        public bool ChangePIN(string txtOldPass, string txtNewPass)
        {
            BankingDAO bankingDAO = new BankingDAO();
            if (bankingDAO.ChangePIN(txtOldPass, txtNewPass) == 0)
            {
                MessageBox.Show("Đổi PIN thất bại.");
                return false;
            }
            else
            {
                MessageBox.Show("Đổi PIN thành công.");
                return true;
            }
        }

        public DataTable SaoKe()
        {
            return BankingDAO.Ins.SaoKe();
        }
    }
}
