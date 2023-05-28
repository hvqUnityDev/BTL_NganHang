using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public class Customer : Employee
    {
        public Customer(string name, string dateOfBirth, string address, string sexName, string phoneNumber, string email) : base(name, dateOfBirth, address, sexName, phoneNumber, email)
        {
            
        }


    }
}
