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

        

        public void Send(string txtCCCD, string txtSDT, string txtGoiVay)
        {
            MessageBox.Show("toDO: save");
        }
    }
}
