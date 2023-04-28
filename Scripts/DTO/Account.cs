using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Scripts.DTO
{
    public class Account
    {
        private string iDNguoiSuDung;
        private string hoTen;
        private string ngaySinh;
        private string diaChi;
        private string gioiTinh;
        private string sdt;
        private string email;
        private string password;

        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string IDNguoiSuDung { get => iDNguoiSuDung; set => iDNguoiSuDung = value; }
        public string IDTK { get => iDTK; set => iDTK = value; }
        public string SoTK { get => soTK; set => soTK = value; }
        public string Pin { get => pin; set => pin = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string SoDu { get => soDu; set => soDu = value; }

        public Account(string iDNguoiSuDung, string hoTen, string ngaySinh, string diaChi, string gioiTinh, string sdt, string email, string password)
        {
            IDNguoiSuDung = iDNguoiSuDung;
            HoTen = hoTen;  
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            Password = password;
            Email = email;
            Sdt = sdt;
        }

        public Account(DataRow row) {
            IDNguoiSuDung = row["iD_nguoisudung"].ToString();
            HoTen = row["ho_ten"].ToString();
            NgaySinh = row["ngay_sinh"].ToString();
            DiaChi = row["dia_chi"].ToString();
            GioiTinh = row["gioi_tinh"].ToString();
            Sdt = row["sdt"].ToString();
            Password = row["password"].ToString();
            Email = row["email"].ToString();
        }

        private string iDTK;
        private string soTK;
        private string pin;
        private string trangThai;
        private string soDu;

        public void SetMoreValue(DataRow row)
        {
            iDTK = row["IDTK"].ToString();
            SoTK = row["so_tai_khoan"].ToString();
            Pin = row["pin"].ToString();
            SoDu = row["so_du"].ToString();
        }
    }
}
