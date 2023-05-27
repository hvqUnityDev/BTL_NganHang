CREATE DATABASE QL_NGANHANG
GO
USE QL_NGANHANG
GO

select * from thongtinnguoidung
select * from  nguoisudung
select * from  TaiKhoan

UPDATE taikhoan SET so_du = 10 WHERE so_tai_khoan = '1970190190';

 --bang thông tin người dùng--
 CREATE TABLE thongtinnguoidung(
  ID_nguoisudung CHAR(255) PRIMARY KEY,
  ho_ten NVARCHAR(255) NOT NULL,
  ngay_sinh INT NOT NULL,
  dia_chi NVARCHAR(255) NOT NULL,
  gioi_tinh NVARCHAR(255) NOT NULL,
  SDT NVARCHAR(20) NOT NULL,
  email NVARCHAR(255) NOT NULL,
  password NVARCHAR(255) NOT NULL
);

--bang QUYỀN--
CREATE TABLE quyen (
ID_quyen CHAR(255) PRIMARY KEY,
ten_quyen NVARCHAR(255)
);

--bang người sử dụng--
CREATE TABLE nguoisudung(
ID_nguoisudung CHAR(255) NOT NULL,
ID_quyen CHAR(255) NOT NULL,
PRIMARY KEY (ID_nguoisudung	),
 CONSTRAINT fk_thongtinnguoidung FOREIGN KEY (ID_nguoisudung) REFERENCES thongtinnguoidung(ID_nguoisudung),
 FOREIGN KEY (ID_quyen) REFERENCES quyen(ID_quyen)
 );
 
 --bang tai khoan--
CREATE TABLE TaiKhoan (
  IDTK INT PRIMARY KEY,
  so_tai_khoan NVARCHAR(20) NOT NULL,
  pin INT NOT NULL,
  trangthai NVARCHAR(255) NOT NULL,
  so_du FLOAT NOT NULL,
  loai_tai_khoan NVARCHAR(255) NOT NULL,
  ngay_mo_tai_khoan INT NOT NULL,
  ID_nguoisudung CHAR(255) NOT NULL,
  FOREIGN KEY (ID_nguoisudung) REFERENCES thongtinnguoidung(ID_nguoisudung)
);

 --bang giao dich--
CREATE TABLE GiaoDich (
  IDGiaoDich INT PRIMARY KEY,
  so_tien FLOAT NOT NULL,
  ngay_gd INT NOT NULL,
  IDTK INT NOT NULL,
  FOREIGN KEY (IDTK) REFERENCES TaiKhoan(IDTK)
);

--bang san pham--
CREATE TABLE SanPham (
  IDSP INT PRIMARY KEY,
  tenSP NVARCHAR(255) NOT NULL,
  giaSP INT NOT NULL,
  so_luong INT NOT NULL
);

--bang san pham chi tiet--
CREATE TABLE SanPhamChiTiet (
  IDSP INT NOT NULL,
  giaSP INT NOT NULL,
  so_luong INT NOT NULL
  PRIMARY KEY (IDSP),
  CONSTRAINT fk_SanPham FOREIGN KEY (IDSP) REFERENCES SanPham(IDSP)
);

--bang bill--
CREATE TABLE Bill (
  ID_Bill INT PRIMARY KEY,
  ID_nguoisudung CHAR(255),
  so_tien INT NOT NULL,
  FOREIGN KEY (ID_nguoisudung) REFERENCES nguoisudung(ID_nguoisudung)
);

--bang billinfo--
CREATE TABLE BillInfo (
  ID_BillInfo INT PRIMARY KEY,
  ID_Bill INT NOT NULL,
  IDSP INT NOT NULL,
  so_tien INT NOT NULL,
  FOREIGN KEY (ID_Bill) REFERENCES Bill(ID_Bill),
  FOREIGN KEY (IDSP) REFERENCES SanPham(IDSP)
);

--nhap du lieu cho bang thông tin người dùng----
insert into thongtinnguoidung values('ID01', N'trần văn H', 08011990, N'nghệ an', N'nam', '0363338021', N'tu1990@gmail.com', '123123123')
insert into thongtinnguoidung values('ID02', N'trần thị P', 20121996, N'thanh hóa', N'nữ', '0902040942', N'phuong1996@gmail.com', '12345678')
insert into thongtinnguoidung values('ID03', N'bùi thị A', 20102002, N'vinh', N'nữ', '0335215726', N'anh2002@gmail.com', '999999999')
insert into thongtinnguoidung values('ID04', N'lê thị H', 19021992, N'thanh hóa', N'nữ', '0363520149', N'hop1992@gmail.com', '888888888')
insert into thongtinnguoidung values('ID05', N'nguyễn xuân T', 01102000, N'hà nội', N'nam', '09502040942', N'tien2000@gmail.com', '55555555')

select * from thongtinnguoidung

--Nhap du lieu cho bang quyen--
insert into quyen values('Q1', N'Cho vay')
insert into quyen values('Q2', N'Phát hành thẻ tín dụng')
insert into quyen values('Q3', N'Mở tài khoản ')
insert into quyen values('Q4', N'Nhận tiền gửi')
insert into quyen values('Q5', N'Thực hiện dịch vụ thanh toán ')

select * from quyen

--nhap du lieu cho bang nguoi su dung--
insert into nguoisudung values('ID01', 'Q1')
insert into nguoisudung values('ID02', 'Q2')
insert into nguoisudung values('ID03', 'Q3')
insert into nguoisudung values('ID04', 'Q4')
insert into nguoisudung values('ID05', 'Q5')
insert into nguoisudung values('ID05', 'Q5')

select * from quyen
select * from nguoisudung

--nhap du lieu cho bang tai khoan--
insert into TaiKhoan values(1970, '1970190190', 190190, N'hoạt động', '20000000', 'visa', 20022023, 'ID01')
insert into TaiKhoan values(1971, '1971971971', 971971, N'hoạt động', '10000000', 'napas', 20102022, 'ID02')
insert into TaiKhoan values(1972, '1972972972', 972972, N'hoạt động', '500000', 'napas', 10102022, 'ID03')
insert into TaiKhoan values(1973, '1973973973', 973973, N'hoạt động', '1000000', 'napas', 19012023, 'ID04')
insert into TaiKhoan values(1974, '1974974974', 974974, N'hoạt động', '350000', 'napas', 01022023, 'ID05')
insert into TaiKhoan values(1975, '197497497411', 974974, N'hoạt động', '350000', 'napas', 01022023, 'ID06')


select * from TaiKhoan

--nhap du lieu cho bang giao dich--
insert into GiaoDich values(141, '1000000', 19042023, 1970)
insert into GiaoDich values(142, '500000', 19042023, 1971)
insert into GiaoDich values(143, '500000', 17042023, 1972)
insert into GiaoDich values(144, '200000', 03042023, 1973)
insert into GiaoDich values(145, '1000000', 10042023, 1974)

select * from GiaoDich


--nhap du lieu cho bang san pham--
insert into SanPham values(010, N'bảo hiểm nhân thọ', 30000000, 100)
insert into SanPham values(020, N'bảo hiểm hỗn hợp', 25000000, 300)
insert into SanPham values(030, N'bảo hiểm tiết kiệp', 25000000, 200)
insert into SanPham values(040, N'bảo hiểm trọn đời', 30000000, 100)
insert into SanPham values(050, N'bảo hiểm tử kỳ', 30000000, 100)

select * from SanPham

--nhap du lieu cho bang san pham chi tiet--
insert into SanPhamChiTiet values(010, 30000000, 100)
insert into SanPhamChiTiet values(020, 25000000, 300)
insert into SanPhamChiTiet values(030, 25000000, 200)
insert into SanPhamChiTiet values(040, 30000000, 100)
insert into SanPhamChiTiet values(050, 30000000, 100)

select * from SanPhamChiTiet

--nhap du lieu cho bang bill--
insert into Bill values(101, 'ID01', 50000000)
insert into Bill values(102, 'ID02', 60000000)
insert into Bill values(103, 'ID03', 40000000)
insert into Bill values(104, 'ID04', 40000000)
insert into Bill values(105, 'ID05', 50000000)


select * from Bill

--nhap du lieu cho bang bill infor--
insert into BillInfo values(1101, 101, 010, 50000000)
insert into BillInfo values(1102, 102, 020, 60000000)
insert into BillInfo values(1103, 103, 040, 40000000)
insert into BillInfo values(1104, 104, 030, 40000000)
insert into BillInfo values(1105, 105, 010, 50000000)

select * from BillInfo

--CÂU TRUY VẤN--
-----------------------------------------------------------
use QL_NGANHANG
Go


 --LOGIN METHOD

CREATE FUNCTION dbo.login (@userName nvarchar(255) , @passWord nvarchar(255))
RETURNS Int AS
BEGIN
	 DECLARE @count int;
	 SELECT @count = count(thongtinnguoidung.ID_nguoisudung) 
	 FROM thongtinnguoidung 
	 WHERE thongtinnguoidung.email = @userName AND thongtinnguoidung.password = @passWord;

	 IF @count > 0 RETURN 1;

	 RETURN 0;
END

SELECT dbo.login (@userName = 'anh2002@gmail.com' , @password = '99949999999')

SELECT dbo.login('anh2002@gmail.com','999999999')

select * from thongtinnguoidung where email = 'anh2002@gmail.com'and password = '999999999'
select * from taikhoan where ID_nguoisudung = 'id03'

select count(*) from taikhoan where so_tai_khoan = '1971971971' or so_tai_khoan = '1973973973'