using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public class Employee
    {
        protected string id;
        protected string name;
        protected string dateOfBirth;
        protected string address;
        protected string sexName;
        protected string phoneNumber;
        protected string email;

        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string SexName { get => sexName; set => sexName = value; }
        public string Address { get => address; set => address = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Name { get => name; set => name = value; }
        public string ID { get => id; set => id = value; }

        public Employee(string name, string dateOfBirth, string address, string sexName, string phoneNumber, string email)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.sexName = sexName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public Employee(DataRow row)
        {
            this.id = row["id_nguoisudung"].ToString();
            this.name = row["ho_ten"].ToString();
            this.dateOfBirth = row["ngay_sinh"].ToString();
            this.address = row["dia_chi"].ToString();
            this.sexName = row["gioi_tinh"].ToString();
            this.phoneNumber = row["SDT"].ToString();
            this.email = row["email"].ToString();
        }

    }
}
