using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.Interface;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class ThuTucVayDAO : IThuTucVay
    {
        private static ThuTucVayDAO ins;
        public static ThuTucVayDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new ThuTucVayDAO();
                return ins;
            }

            private set => ins = value;
        }

        public string LinkDieuKhoan()
        {
            return "https://mbbank.com.vn/26/273/1236/Chi-tiet/%7B%7Bx.url%7D%7D";
        }

        private List<string> goiVay = new List<string>() {"1.000.000", "10.000.000", "100.000.000" };

        public void InitGoiVay(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (string item in goiVay) 
            {
                cb.Items.Add(item);
            }
        }

        public void Send(string txtCCCD, string txtSDT, string txtGoiVay)
        {
            MessageBox.Show("toDO: save");
        }
    }
}
