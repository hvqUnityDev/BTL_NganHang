﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public interface Element_Banking
    {
        bool CheckMoney(string txtMoney);
        string CheckNameWithSTK(string txtSTK);
        string CheckNameWithSTK(string txtSTK);
        void ChuyenKhoan(string fromSTk, string toSTk, string soTien);
    }
}
