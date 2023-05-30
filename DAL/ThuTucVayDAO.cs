using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetGoiVay()
        {
            string query = "USP_GetGoiVay";
            return DataProvider.Ins.ExecuteQuery(query);
        }

        public bool Send(string txtSDT, string txtGoiVay)
        {
            string query = "USP_GetIDGoiVay @txtGoiVay ";
            DataTable dt = DataProvider.Ins.ExecuteQuery(query, new object[] { txtGoiVay });
            int id = Int16.Parse(dt.Rows[0]["IDSP"].ToString());

            query = "USP_CreateVayVon @idGoiVay , @SDT ";
            int value = (int)DataProvider.Ins.ExecuteNonQuery(query, new object[] {id, txtSDT });
            return value == 0 ? false :true;
        }
    }
}
