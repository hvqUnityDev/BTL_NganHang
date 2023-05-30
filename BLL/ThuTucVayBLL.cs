using System;
using System.Collections.Generic;
using System.Data;
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

        public bool Send(string txtSDT, string txtGoiVay, CheckBox ckbDieuKhoan, ComboBox cbGoiVay)
        {
            if (!ckbDieuKhoan.Checked)
            {
                MessageBox.Show("Check Điều Khoản!");
                return false;
            }

            if (txtSDT.Length <= 0 || cbGoiVay.ToString().Length <= 0)
            {
                MessageBox.Show("Hãy điền đủ thông tin!");
                return false;
            }

            return ThuTucVayDAO.Ins.Send(txtSDT, txtGoiVay);
        }

        private List<string> goiVay = new List<string>() { "1.000.000", "10.000.000", "100.000.000" };
        public void InitGoiVay(ComboBox cb)
        {
            cb.Items.Clear();
            DataTable dt = ThuTucVayDAO.Ins.GetGoiVay();
            foreach (DataRow row in dt.Rows)
            {
                cb.Items.Add(row["tensp"]);
            }
        }
    }
}
