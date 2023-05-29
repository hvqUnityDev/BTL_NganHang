﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DAO;

namespace BLL
{
    public class AccountBLL
    {
        public string GetDateOfBirth()
        {
            return AccountDAO.Ins.TheAccount.NgaySinh;
        }

        public string GetName()
        {
            return AccountDAO.Ins.TheAccount.HoTen;
        }

        public string GetAddress()
        {
            return AccountDAO.Ins.TheAccount.DiaChi;
        }

        public string GetSoDu()
        {
            return AccountDAO.Ins.TheAccount.SoDu;
        }

        public string GetSoTK()
        {
            return AccountDAO.Ins.TheAccount.SoTK;
        }

        public bool Login(string username, string password)
        {
            if(username == null || password == null) return false;
            if(username.Length <= 0 || password.Length <= 0) return false; 

            if(!AccountDAO.Ins.Login(username, password)) return false;

            return true;
        }

        public void Register(string txtName, string txtDateOfBirth, string txtAddress, string txtSex, string txtSDT, string txtEmail, string txtPassword, string txtPasswordAgain, string txtPIN, string txtPINAgain, string txtSTK)
        {
            if (txtName.Length <= 0
                || txtAddress.Length <= 0
                || txtSex.Length <= 0
                || txtSDT.Length <= 0
                || txtEmail.Length <= 0
                || txtPassword.Length <= 0
                || txtPasswordAgain.Length <= 0
                || txtPIN.Length <= 0
                || txtPINAgain.Length <= 0
                || txtSTK.Length <= 0)
            {
                MessageBox.Show("Xin hãy điền đủ thông tin!");
                return;
            }

            if(!AccountDAO.Ins.Register( txtName, txtDateOfBirth, txtAddress,  txtSex,  txtSDT,  txtEmail,  txtPassword,  txtPIN,  txtSTK))
            {
                MessageBox.Show("Đăng kí thất bại");
                return;
            }

            MessageBox.Show("Đăng kí thành công!");

        }
    }
}
