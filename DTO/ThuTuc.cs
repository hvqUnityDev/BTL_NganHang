using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuTuc
    {
        private string id;
        private string name;
        private string stk;
        private string sdt;
        private string tensp;
        private string ngayVay;
        private string status;

        public ThuTuc(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.name = row["ho_ten"].ToString();
            this.stk = row["so_tai_khoan"].ToString();
            this.sdt = row["sdt"].ToString();
            this.tensp = row["tensp"].ToString();
            this.ngayVay = row["ngay_vay"].ToString();
            this.status = row["status_name"].ToString();
        }

        public string Status { get => status; set => status = value; }
        public string NgayVay { get => ngayVay; set => ngayVay = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Stk { get => stk; set => stk = value; }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
    }
}
