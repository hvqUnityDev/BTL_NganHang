using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.Interface;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class MobileRechargeDAO : IMobileRecharge
    {
        private static MobileRechargeDAO ins;
        public static MobileRechargeDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new MobileRechargeDAO();
                return ins;
            }

            private set => ins = value;
        }

        private List<string> NetworkNames = new List<string>() {"Viettel", "Mobifone", "Vinaphone" };

        public void AddHomeNetwork(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (string networkName in NetworkNames)
            {
                cb.Items.Add(networkName);
            }
        }

        public int MobileRecharge(string networkName, string phoneNumber, string money)
        {
            string query = "exec USP_MobileRecharge @soTaiKhoanGoc = 1970, @soTien = 30";
            return (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] { phoneNumber, money});
        }
    }
}
