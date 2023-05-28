using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DAO;

namespace BLL
{
    public class ThuTucVayBLL
    {
        public string LinkDieuKhoan()
        {
            return "https://mbbank.com.vn/26/273/1236/Chi-tiet/%7B%7Bx.url%7D%7D";
        }

        public void Send(string txtCCCD, string txtSDT, string txtGoiVay, CheckBox ckbDieuKhoan, ComboBox cbGoiVay)
        {
            if (!ckbDieuKhoan.Checked)
            {
                MessageBox.Show("Check Điều Khoản!");
                return;
            }

            if (txtSDT.Length <= 0 || txtCCCD.Length <= 0 || cbGoiVay.ToString().Length <= 0)
            {
                MessageBox.Show("Hãy điền đủ thông tin!");
                return;
            }

            ThuTucVayDAO.Ins.Send(txtCCCD, txtSDT, txtGoiVay);
        }

        private List<string> goiVay = new List<string>() { "1.000.000", "10.000.000", "100.000.000" };
        public void InitGoiVay(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (string item in goiVay)
            {
                cb.Items.Add(item);
            }
        }
    }
}
