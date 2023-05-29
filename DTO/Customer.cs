using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public class Customer : Employee
    {
        private long soDu;
        private string soTaiKhoan;

        public long SoDu { get => soDu; set => soDu = value; }
        public string SoTaiKhoan { get => soTaiKhoan; set => soTaiKhoan = value; }

        public Customer(string name, string dateOfBirth, string address, string sexName, string phoneNumber, string email) : base(name, dateOfBirth, address, sexName, phoneNumber, email)
        {
            
        }

        public Customer(DataRow row) : base(row) {
            this.soDu = Int64.Parse(row["so_du"].ToString());
            this.SoTaiKhoan = row["so_tai_khoan"].ToString();
        }
    }
}
