use hoc
drop database ql_nganhang

CREATE DATABASE QL_NGANHANG
GO

USE QL_NGANHANG
GO

--bang QUYỀN--
CREATE TABLE quyen (
ID_quyen INT PRIMARY KEY IDENTITY(1,1) ,
ten_quyen NVARCHAR(255)
);

 --bang thông tin người dùng--
 CREATE TABLE thongtinnguoidung(
  ID_nguoisudung INT PRIMARY KEY IDENTITY(1,1) NOT NULL , 
  ho_ten NVARCHAR(255) NOT NULL,
  ngay_sinh date NOT NULL,
  dia_chi NVARCHAR(255) NOT NULL,
  gioi_tinh NVARCHAR(255) NOT NULL,
  SDT NVARCHAR(20) NOT NULL,
  email NVARCHAR(255) NOT NULL,
  password NVARCHAR(255) NOT NULL,
  ID_quyen INT NOT NULL,
  FOREIGN KEY (ID_quyen) REFERENCES quyen(ID_quyen)
  )
select * from thongtinnguoidung

  --BỎ IDTK cho so_tai_khoan làm khóa chính
CREATE TABLE TaiKhoan (
  so_tai_khoan CHAR(255) NOT NULL primary key,
  pin INT NOT NULL,
  so_du FLOAT NOT NULL,
  ngay_mo_tai_khoan date,
  ID_nguoisudung INT NOT NULL,
  FOREIGN KEY (ID_nguoisudung) REFERENCES thongtinnguoidung(ID_nguoisudung)
);

 --bang giao dich--
CREATE TABLE GiaoDich (
  IDGiaoDich INT PRIMARY KEY IDENTITY(1,1) ,
  so_tien FLOAT NOT NULL,
  ngay_gd date NOT NULL,
  so_tai_khoan CHAR(255) NOT NULL,
  so_tai_khoan_nhan CHAR(255),
  text CHAR(255),
  FOREIGN KEY (so_tai_khoan) REFERENCES TaiKhoan(so_tai_khoan)
);

--bang san pham--
CREATE TABLE SanPham (
  IDSP INT PRIMARY KEY IDENTITY(1,1),
  tenSP NVARCHAR(255) NOT NULL,
  giaSP INT NOT NULL
);

CREATE TABLE status (
  ID INT PRIMARY KEY IDENTITY(1,1),
  status_name NVarCHAR(255)
)

CREATE TABLE vay_von (
    Id INT NOT NULL IDENTITY(1,1),
    id_nguoisudung  INT NOT NULL,
    IDSP INT ,
    ngay_vay date,
    Id_status INT,
    FOREIGN KEY(Id_status) REFERENCES status(ID),
    FOREIGN KEY(IDSP) REFERENCES SanPham(IDSP),
    FOREIGN KEY(id_nguoisudung) REFERENCES thongtinnguoidung(id_nguoisudung)
);


--Nhap du lieu cho bang quyen--
insert into quyen values( N'nhân viên')
insert into quyen values (N'khách hàng')
insert into quyen values( N'giám đốc')
select * from quyen


--nhap du lieu cho bang thông tin người dùng----
insert into thongtinnguoidung values( N'trần văn H', '1990-08-01', N'nghệ an', N'nam', '0363338021', N'tu1990@gmail.com', '123123123',1)
insert into thongtinnguoidung values( N'trần thị P',  '1996-12-20', N'thanh hóa', N'nữ', '0902040942', N'phuong1996@gmail.com', '12345678',1)
insert into thongtinnguoidung values( N'bùi thị A', '2002-10-20', N'vinh', N'nữ', '0335215726', N'anh2002@gmail.com', '999999999',1)
insert into thongtinnguoidung values( N'lê thị H', '1992-02-19', N'thanh hóa', N'nữ', '0363520149', N'hop1992@gmail.com', '888888888',2)
insert into thongtinnguoidung values( N'nguyễn xuân T', '2000-01-10', N'hà nội', N'nam', '09502040942', N'tien2000@gmail.com', '55555555',3)

select * from thongtinnguoidung

--nhap du lieu cho bang tai khoan--
insert into TaiKhoan values('1974', 974974, 350000,		'2023-01-02', 1)
insert into TaiKhoan values('1970', 190190, 20000000,	'2023-02-20', 2)
insert into TaiKhoan values('1971', 971971, 10000000,	'2022-10-20', 3)
insert into TaiKhoan values('1972', 972972, 500000,		'2022-10-10', 4)
insert into TaiKhoan values('1973', 973973, 1000000,	'2023-01-19', 5)


select * from TaiKhoan

--nhap du lieu cho bang giao dich--
insert into GiaoDich values( '1000000', '2023-04-19', '1970', '1080', 'TRAN VAN H CHUYEN TIEN')
insert into GiaoDich values( '500000', '2023-04-19', '1971', '1081', 'LE THI H CHUYEN TIEN')
insert into GiaoDich values( '500000', '2023-04-17', '1972', '1082', 'KHUONG THI D CHUYEN TIEN')
insert into GiaoDich values( '200000', '2023-03-04', '1973', '1083', 'VU TUAN A CHUYEN TIEN')
insert into GiaoDich values( '1000000', '2023-10-04', '1974', '1084', 'NGHUYEN THI T CHUYEN TIEN')

select * from GiaoDich


--nhap du lieu cho bang san pham--
insert into SanPham values( N'gói vay 1 triệu', 1000000)
insert into SanPham values( N'gói vay 10 triệu', 10000000)
insert into SanPham values( N'gói vay 30 triệu', 30000000)
insert into SanPham values( N'gói vay 50 triệu', 50000000)
insert into SanPham values( N'gói vay 100 triệu', 100000000)
select * from SanPham


insert into status values(N'Đang chờ xác nhận')
insert into status values(N'Đang chờ duyệt')
insert into status values(N'Hoàn thành')
insert into status values(N'Từ chối')
select * from status


insert into vay_von values( 2, 1, '2023-05-20',1)
insert into vay_von values( 2, 3, '2023-05-28',2)
insert into vay_von values( 2, 4, '2023-04-10',3)
select * from vay_von

--CÂU TRUY VẤN--
-----------------------------------------------------------
use QL_NGANHANG
Go


 --LOGIN METHOD
CREATE PROC USP_Login 
@userName nvarchar(255), @passWord nvarchar(255)
as
begin 
	 SELECT count(thongtinnguoidung.ID_nguoisudung) 
	 FROM thongtinnguoidung 
	 WHERE thongtinnguoidung.email = @userName AND thongtinnguoidung.password = @passWord;
end 

EXEC USP_Login @userName = 'hop1992@gmail.com' , @passWord = '888888888'

-------------------------------------------------------------------------
CREATE PROC USP_GetInfoWithUserNameAndPassword
@userName nvarchar(255), @passWord nvarchar(255)
as
begin 
	SELECT * FROM thongtinnguoidung 
	inner join TaiKhoan on TaiKhoan.ID_nguoisudung = thongtinnguoidung.ID_nguoisudung 
	WHERE thongtinnguoidung.email = @userName AND thongtinnguoidung.password = @passWord;
end 

EXEC USP_GetInfoWithUserNameAndPassword @userName = 'hop1992@gmail.com' , @passWord = '888888888'

select * from taikhoan

-- Register
----------------------------------------------------------------------------------
CREATE PROC USP_register
	@userName nvarchar(255), 
	@passWord nvarchar(255),
	@ho_ten NVARCHAR(255), 
	@ngay_sinh DATE, 
	@dia_chi NVARCHAR(255),
	@gioi_tinh NVARCHAR(255), 
	@SDT NVARCHAR(20),
	@id_quyen INT,
	@PIN int,
	@soTaiKhoan char(255)
AS
BEGIN
	insert into thongtinnguoidung(ho_ten, ngay_sinh, dia_chi, gioi_tinh, SDT, email, password,ID_quyen) 
	values(@ho_ten, @ngay_sinh, @dia_chi, @gioi_tinh, @SDT,@userName, @passWord, @id_quyen)

	declare @site_value int;
	select @site_value = id_nguoisudung from thongtinnguoidung where @SDT = SDT

	insert into taikhoan (so_tai_khoan, pin, so_du, ngay_mo_tai_khoan, id_nguoisudung)
	values(@soTaiKhoan, @PIN, 0, getdate(), @site_value)
END

exec USP_register @username = 'a' ,
	@passWord = 'a',
	@ho_ten = 'a', 
	@ngay_sinh = '2020-02-02', 
	@dia_chi = 'aa',
	@gioi_tinh = 'nam', 
	@SDT = '111',
	@id_quyen = 1,
	@PIN = 999,
	@soTaiKhoan = '1000'

select * from thongtinnguoidung
select * from taikhoan

--UPDATE---------------------------------------------------------
CREATE PROC USP_update
 @userName nvarchar(255), 
 @passWord nvarchar(255), 
 @ho_ten NVARCHAR(255), 
 @ngay_sinh DATE, 
 @dia_chi NVARCHAR(255),
 @gioi_tinh NVARCHAR(255), 
 @SDT NVARCHAR(20) 
AS
BEGIN
	UPDATE thongtinnguoidung 
	SET ho_ten = @ho_ten, ngay_sinh = @ngay_sinh, dia_chi = @dia_chi, gioi_tinh = @gioi_tinh, SDT = @SDT, email = @userName, passWord = @passWord
	WHERE @userName = thongtinnguoidung.email 
END

---show vay_von-------------------------------------------------------
CREATE PROC USP_GetVay
AS
BEGIN
SELECT * FROM vay_von
END

 --SHOW USERS----------------------------------------------
CREATE PROC USP_getListUser @userRole INT
AS
BEGIN
SELECT * 
FROM thongtinnguoidung
WHERE  @userRole = thongtinnguoidung.ID_quyen
END

USP_getListUser @userRole = 1

-----------------------------------------------
CREATE PROC USP_GetListCustomer
AS
BEGIN
SELECT thongtinnguoidung.ID_nguoisudung, ho_ten, ngay_sinh, dia_chi, gioi_tinh, so_tai_khoan, so_du, SDT, Email
FROM thongtinnguoidung inner join taikhoan on thongtinnguoidung.id_nguoisudung = taikhoan.id_nguoisudung
WHERE  thongtinnguoidung.ID_quyen = 2
END

exec USP_GetListCustomer

  -- WITH EMAIL
CREATE PROC USP_getListUserWithEmail @email NVARCHAR(255)
AS
BEGIN
	SELECT * FROM thongtinnguoidung
	WHERE thongtinnguoidung.email LIKE '%' + @email + '%'
end

select * from thongtinnguoidung

exec USP_getListUserWithEmail @email = 'n'

  -- WITH SDT
CREATE PROC USP_getListUserWithSDT @SDT NVARCHAR(20)
AS
BEGIN
SELECT * 
FROM thongtinnguoidung
WHERE  thongtinnguoidung.SDT  LIKE '%' + @SDT + '%'

END

-- with name
CREATE PROC USP_getListUserWithName @Name NVARCHAR(20)
AS
BEGIN
SELECT * 
FROM thongtinnguoidung
WHERE  thongtinnguoidung.ho_ten  LIKE '%' + @Name + '%'
END


EXEC USP_getListUser @userRole = 2

--PIN CHANGE--
CREATE PROC USP_changePin  @soTaiKhoan INT,@oldPin INT,@newPin INT
AS
BEGIN 

	UPDATE TaiKhoan 
	SET pin = @newPin
	WHERE @soTaiKhoan = TaiKhoan.so_tai_khoan AND @oldPin = TaiKhoan.pin 
	
END

EXEC USP_changePin @soTaiKhoan = 1970 , @oldPin = 190191, @newPin = 91           

---------------

CREATE PROC USP_GetNameUser @soTaiKhoan INT
AS
BEGIN
SELECT ho_ten FROM thongtinnguoidung 
	
	inner join TaiKhoan on TaiKhoan.ID_nguoisudung = thongtinnguoidung.ID_nguoisudung 
	WHERE @soTaiKhoan = TaiKhoan.so_tai_khoan
END

EXEC USP_GetNameUser @soTaiKhoan = 1970

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

select * from ls

-- SAVE BANKING

CREATE PROC USP_saveBanking @from CHAR(255), @to CHAR(255), @money FLOAT, @ngay_gd date, @text CHAR(255)
AS 
BEGIN 
insert into GiaoDich(so_tien,ngay_gd,so_tai_khoan,so_tai_khoan_nhan,text) values (@money,@ngay_gd,@from,@to,@text)
END
