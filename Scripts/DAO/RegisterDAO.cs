using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Scripts.Interface;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class RegisterDAO : IRegister
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

        public void Register()
        {
            
        }
    }
}
