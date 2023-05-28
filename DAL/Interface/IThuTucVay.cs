using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Scripts.Interface
{
    public interface IThuTucVay
    {
        void InitGoiVay(ComboBox cb);
        string LinkDieuKhoan();
        void Send(string txtCCCD, string txtSDT, string txtGoiVay);
    }
}
