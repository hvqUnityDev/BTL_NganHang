using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.Interface
{
    interface Element_ChangePIN
    {
        bool CheckNewPassword(string txtNewPass, string txtNewPassAgain;
        int ChangePIN(string txtOldPass, string txtNewPass);
    }
}
