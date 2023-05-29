using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public interface IAccount
    {
        bool Login(string username, string password);
    }
}
