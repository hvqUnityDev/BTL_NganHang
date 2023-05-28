﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public interface IBanking
    {
        bool CheckMoney(string txtMoney);
        string CheckNameWithSTK(string txtSTK);
        void ChuyenKhoan(string fromSTk, string toSTk, string soTien);
        int CheckPIN(string txtPIN);
    }
}
