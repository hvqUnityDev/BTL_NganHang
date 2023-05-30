using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Scripts.Interface
{
    public interface IThuTucVay
    {
        bool Send(string txtSDT, string txtGoiVay);
        DataTable GetGoiVay();
    }
}
