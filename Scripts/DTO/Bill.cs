using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public class Bill
    {
        private string stk;
        private string name;
        private string soTien;

        public string Stk { get => stk; private set => stk = value; }
        public string Name { get => name; private set => name = value; }
        public string SoTien { get => soTien; private set => soTien = value; }

        public Bill(string stk, string name, string soTien) {
            this.stk = stk;
            this.name = name;
            this.soTien = soTien;
        }
    }
}
