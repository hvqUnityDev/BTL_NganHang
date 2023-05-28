CREATE DATABASE QL_NGANHANG
GO

USE QL_NGANHANG
GO

 --bang thông tin người dùng--
 CREATE TABLE thongtinnguoidung(
  ID_nguoisudung INT PRIMARY KEY NOT NULL,
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
ID_quyen INT PRIMARY KEY,
ten_quyen NVARCHAR(255)
);

--bang người sử dụng--
CREATE TABLE nguoisudung(
ID_nguoiDung INT primary key NOT NULL,
ID_quyen CHAR(255) NOT NULL,
CONSTRAINT ID_nguoiDung FOREIGN KEY(ID_nguoiDung) references thongtinnguoidung(ID_nguoisudung)
 );
 
 
 select * from nguoisudung
 
 --bang tai khoan--

  --BỎ IDTK cho so_tai_khoan làm khóa chính
CREATE TABLE TaiKhoan (
  so_tai_khoan CHAR(255) PRIMARY KEY NOT NULL,
  pin INT NOT NULL,
  trangthai NVARCHAR(255) NOT NULL,
  so_du FLOAT NOT NULL,
  loai_tai_khoan NVARCHAR(255) NOT NULL,
  ngay_mo_tai_khoan INT NOT NULL,
  ID_nguoisudung INT NOT NULL,
  FOREIGN KEY (ID_nguoisudung) REFERENCES thongtinnguoidung(ID_nguoisudung)
);

 --bang giao dich--
CREATE TABLE GiaoDich (
  IDGiaoDich INT PRIMARY KEY,
  so_tien FLOAT,
  so_tien FLOAT NOT NULL,
  ngay_gd INT NOT NULL,
  so_tai_khoan CHAR(255) NOT NULL,
  FOREIGN KEY (so_tai_khoan) REFERENCES TaiKhoan(so_tai_khoan)
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
  ID_nguoiDung INT,
  so_tien INT NOT NULL,
  FOREIGN KEY (ID_nguoiDung) REFERENCES thongtinnguoidung (ID_nguoisudung)
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
CREATE TABLE vay_von (
    can_cuoc INT PRIMARY KEY,
    sdt VARCHAR(255),
    tien_vay FLOAT,
    ngay_vay DATE
);


--nhap du lieu cho bang thông tin người dùng----
insert into thongtinnguoidung values(1, N'trần văn H', 08011990, N'nghệ an', N'nam', '0363338021', N'tu1990@gmail.com', '123123123')
insert into thongtinnguoidung values(2, N'trần thị P', 20121996, N'thanh hóa', N'nữ', '0902040942', N'phuong1996@gmail.com', '12345678')
insert into thongtinnguoidung values(3, N'bùi thị A', 20102002, N'vinh', N'nữ', '0335215726', N'anh2002@gmail.com', '999999999')
insert into thongtinnguoidung values(4, N'lê thị H', 19021992, N'thanh hóa', N'nữ', '0363520149', N'hop1992@gmail.com', '888888888')
insert into thongtinnguoidung values(5, N'nguyễn xuân T', 01102000, N'hà nội', N'nam', '09502040942', N'tien2000@gmail.com', '55555555')

select * from thongtinnguoidung

--Nhap du lieu cho bang quyen--
insert into quyen values(01, N'Cho vay')
insert into quyen values(02, N'Phát hành thẻ tín dụng')
insert into quyen values(03, N'Mở tài khoản ')
insert into quyen values(04, N'Nhận tiền gửi')
insert into quyen values(05, N'Thực hiện dịch vụ thanh toán ')

select * from quyen

--nhap du lieu cho bang nguoi su dung--
insert into nguoisudung values(1, 01)
insert into nguoisudung values(2, 02)
insert into nguoisudung values(3, 03)
insert into nguoisudung values(4, 04)
insert into nguoisudung values(5, 05)

select * from nguoisudung

--nhap du lieu cho bang tai khoan--
insert into TaiKhoan values(1970,  190190, N'hoạt động', '20000000', 'visa', 20022023, 1)
insert into TaiKhoan values(1971,  971971, N'hoạt động', '10000000', 'napas', 20102022, 2)
insert into TaiKhoan values(1972,  972972, N'hoạt động', '500000', 'napas', 10102022, 3)
insert into TaiKhoan values(1973,  973973, N'hoạt động', '1000000', 'napas', 19012023, 4)
insert into TaiKhoan values(1974,  974974, N'hoạt động', '350000', 'napas', 01022023, 5)


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
insert into Bill values(101, 1, 50000000)
insert into Bill values(102, 2, 60000000)
insert into Bill values(103, 3, 40000000)
insert into Bill values(104, 4, 40000000)
insert into Bill values(105, 5, 50000000)


select * from Bill

--nhap du lieu cho bang bill infor--
insert into BillInfo values(1101, 101, 010, 50000000)
insert into BillInfo values(1102, 102, 020, 60000000)
insert into BillInfo values(1103, 103, 040, 40000000)
insert into BillInfo values(1104, 104, 030, 40000000)
insert into BillInfo values(1105, 105, 010, 50000000)

select * from BillInfo


insert into vay_von values(0402016407, '0363338021', 100000000, '20/05/2023')
insert into vay_von values(0402016408, '0902040942', 250000000, '28/05/2023')
insert into vay_von values(0402016409, '0335215726', 300000000, '10/04/2023')

select * from vay_von


--CÂU TRUY VẤN--
-----------------------------------------------------------
use QL_NGANHANG
Go


 --LOGIN METHOD
 drop proc USP_Login
CREATE PROC USP_Login 
@userName nvarchar(255), @passWord nvarchar(255)
as
begin 
	 SELECT count(thongtinnguoidung.ID_nguoisudung) 
	 FROM thongtinnguoidung 
	 WHERE thongtinnguoidung.email = @userName AND thongtinnguoidung.password = @passWord;
end 

EXEC USP_Login @userName = 'hop1992@gmail.com' , @passWord = '888888888'

drop proc USP_GetInfoWithUserNameAndPassword
CREATE PROC USP_GetInfoWithUserNameAndPassword
@userName nvarchar(255), @passWord nvarchar(255)
as
begin 
	SELECT * FROM nguoisudung 
	inner join  thongtinnguoidung on nguoisudung.ID_nguoiDung = thongtinnguoidung.ID_nguoisudung
	inner join TaiKhoan on TaiKhoan.ID_nguoisudung = nguoisudung.ID_nguoiDung 
	WHERE thongtinnguoidung.email = @userName AND thongtinnguoidung.password = @passWord;
end 

EXEC USP_GetInfoWithUserNameAndPassword @userName = 'hop1992@gmail.com' , @passWord = '888888888'

select * from taikhoan

-- Register

CREATE PROC USP_register
 @userName nvarchar(255), @passWord nvarchar(255), @ho_ten NVARCHAR(255), @ngay_sinh INT, @dia_chi NVARCHAR(255),@gioi_tinh NVARCHAR(255), @SDT NVARCHAR(20) 
AS
BEGIN
insert into thongtinnguoidung(ho_ten, ngay_sinh, dia_chi, gioi_tinh, SDT, email, password) values(@ho_ten, @ngay_sinh, @dia_chi, @gioi_tinh, @SDT,@userName, @passWord)
END

 --SHOW USERS
CREATE PROC USP_getListUser @userRole INT
AS
BEGIN
SELECT * 
FROM nguoisudung
inner join thongtinnguoidung on nguoisudung.ID_nguoiDung = thongtinnguoidung.ID_nguoisudung
WHERE  @userRole = nguoisudung.ID_quyen

END
  -- WITH EMAIL
CREATE PROC USP_getListUserWithEmail @email NVARCHAR(255)
AS
BEGIN
SELECT * 
FROM nguoisudung
inner join thongtinnguoidung on nguoisudung.ID_nguoiDung = thongtinnguoidung.ID_nguoisudung
WHERE  @email = nguoisudung.email

  -- WITH SDT
CREATE PROC USP_getListUserWithEmail @SDT NVARCHAR(20)
AS
BEGIN
SELECT * 
FROM nguoisudung
inner join thongtinnguoidung on nguoisudung.ID_nguoiDung = thongtinnguoidung.ID_nguoisudung
WHERE  @SDT = nguoisudung.SDT

END

EXEC USP_getListUser @userRole = 2

 --SHOW USER
CREATE PROC USP_getuser @userid INT
AS
BEGIN
SELECT * FROM nguoisudung inner join  thongtinnguoidung on nguoisudung.ID_nguoiDung = thongtinnguoidung.ID_nguoisudung
WHERE @userid = ID_nguoiDung
END


--PIN CHANGE--
CREATE PROC USP_changePin  @soTaiKhoan INT,@oldPin INT,@newPin INT
AS
BEGIN 

	UPDATE TaiKhoan 
	SET pin = @newPin
	WHERE @soTaiKhoan = TaiKhoan.so_tai_khoan AND @oldPin = TaiKhoan.pin 
	
END

EXEC USP_changePin @soTaiKhoan = 1970 , @oldPin = 190191, @newPin = 91           

select * from TaiKhoan
SELECT * FROM nguoisudung 
	inner join  thongtinnguoidung on nguoisudung.ID_nguoiDung = thongtinnguoidung.ID_nguoisudung
	inner join TaiKhoan on TaiKhoan.ID_nguoisudung = nguoisudung.ID_nguoiDung 
	WHERE thongtinnguoidung.email = 'tu1990@gmail.com' AND thongtinnguoidung.password = 123123123

---------------
drop proc USP_GetNameUser

CREATE PROC USP_GetNameUser @soTaiKhoan INT
AS
BEGIN
SELECT ho_ten FROM nguoisudung 
	inner join  thongtinnguoidung on nguoisudung.ID_nguoiDung = thongtinnguoidung.ID_nguoisudung
	inner join TaiKhoan on TaiKhoan.ID_nguoisudung = nguoisudung.ID_nguoiDung 
	WHERE @soTaiKhoan = TaiKhoan.so_tai_khoan
END

EXEC USP_GetNameUser @soTaiKhoan = 1970

----------------------------
create table ls 
(
	id char(20),
	stknhan char(20),
	sotien char(20),
	ngaygd char(20)
)
go
select * from ls

insert into ls values('141', '1970', '1000000', '19042023')
insert into ls values('142', '1971', '500000', '19042023')
insert into ls values('143', '1972', '500000', '17042023')
insert into ls values('144', '1973', '200000', '03042023')
insert into ls values('145', '1974', '1000000', '10042023')

exec USP_Banking @soTaiKhoanGoc = 1970, @soTaiKhoanNhan = 1974 ,@soTien = 50

-- LOAN --

CREATE PROC USP_searchLoan @can_cuoc INT 
AS
BEGIN 
	SELECT * 
	FROM vay_von 
	WHERE @can_cuoc = vay_von.can_cuoc
END

select * from thongtinnguoidung

use QL_NGANHANG
select * from GiaoDich

SELECT * from thongtinnguoidung

select so_du from taikhoan where id_nguoisudung = 1 
-------------------------BANKIng-----------
CREATE PROC USP_Banking @soTaiKhoanGoc INT,@soTaiKhoanNhan INT,@soTien INT
AS
BEGIN 

    UPDATE TaiKhoan 
    SET so_du = so_du - @soTien
    WHERE TaiKhoan.so_tai_khoan = @soTaiKhoanGoc

    UPDATE TaiKhoan 
    SET so_du = so_du + @soTien
    WHERE TaiKhoan.so_tai_khoan = @soTaiKhoanNhan
    
END
select * from taikhoan

exec USP_Banking @soTaiKhoanGoc = 1970, @soTaiKhoanNhan = 1974 ,@soTien = 50

-----------Nap Dien Thoai - TODO: update vao ls giao dich---------
CREATE PROC USP_MobileRecharge @soTaiKhoanGoc INT,@soTien INT
AS
BEGIN 

    UPDATE TaiKhoan 
    SET so_du = so_du - @soTien
    WHERE TaiKhoan.so_tai_khoan = @soTaiKhoanGoc
END

exec USP_MobileRecharge @soTaiKhoanGoc = 1970, @soTien = 30

------------check correct PIN ------------

CREATE PROC USP_CheckPIN @soTaiKhoan INT,@maPIN int
AS
BEGIN 

	select count(*) from Taikhoan where so_tai_khoan = @soTaiKhoan and @maPIN = pin
END

exec USP_CheckPIN @soTaiKhoan = 1970, @maPIN = 2

select * from Taikhoan