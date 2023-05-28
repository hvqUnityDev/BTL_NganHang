﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Scripts.Interface
{
    public interface IMobileRecharge
    {
        int MobileRecharge(string networkName, string phoneNumber, string money);
        void AddHomeNetwork(ComboBox cb);
    }
}
