using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts;
using WindowsFormsApp2.Scripts.DAO;

namespace BLL
{
    public class MobileRechargeBLL
    {
        private List<string> NetworkNames = new List<string>() { "Viettel", "Mobifone", "Vinaphone" };
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
            if(!NetworkNames.Contains(networkName))
            {
                return 0;
            }

            if(networkName.Length <= 0
                || phoneNumber.Length <= 0
                || money.Length <= 0) 
            {
                return 0;
            }

            return MobileRechargeDAO.Ins.MobileRecharge(networkName, phoneNumber, money);
        }
    }
}
