create database SQL_QLTTTN_DA1
go
use SQL_QLTTTN_DA1
go



drop table GiaNuoc
create table GiaNuoc(
MaDK	varchar(10)	primary key ,
MaKH varchar(30) constraint fk_GiaNuoc foreign key(MaKH) references KhachHang(MaKH) not null,
MaNuocSD varchar(20) Not Null ,
GiaTien	float	check(GiaTien>0) not null)

create table KhachHang(
MaKH	varchar(30) primary key 	,
TenKH	nvarchar(30) not null,	
DiaChi	nvarchar(50) not null,	
SoDT	varchar(15)	unique(SoDT) not null,

 )
-- tạo ràng buộc ngày KT Lơns hớn ngày bắt đầu.



create table NhanVien(
MaNV	varchar(15)	primary key		,																						
TenNV	nvarchar(30)	NOT NULL,
DiaChi	nvarchar(50)	NOT NULL,
SoDT	varchar(15)	 unique(SoDT) NOT NULL,
NgaySinh	date	NOT NULL,
GioiTinh	nvarchar(5) 	NOT NULL,

)


--drop table TaiKhoan
create table TaiKhoan(
MaNV	varchar(15)	constraint fk_TaiKhoan foreign key (MaNV) references NhanVien(MaNV)  not null,
TenDN	varchar(20)	not null,
MatKhau	varchar(20)	primary key ,
ChucVu  nvarchar(20) not null,
TrangThai Nvarchar(30))


drop table CT_HoaDon
drop table HoaDon
create table HoaDon(
MaHD	int identity primary key  ,
MaKH	varchar(30) constraint fk_HoaDon foreign key (MaKH) references KhachHang(MaKH)  not null,	
MaNV	varchar(15)	 foreign key (MaNV) references NhanVien(MaNV)  not null, 
--NgayThanhToan	date	not null ,
HinhThucTT nvarchar(30) not null


)

create table CT_HoaDon(
MaCTHD int identity primary key  ,
MaHD int constraint fk_CT_HoaDon foreign key(MaHD) references HoaDon(MaHD) not null,
SoCTT float,
SoCTS float,
GiaTien float,
Thue int ,
NgayThanhToan	date	not null ,
TongTien	float	 not null ,
)


--drop table QuanLySuaChua
drop table QuanLySuaChua
create table QuanLySuaChua(
MaSC  varchar(30) primary key ,
MaKH	varchar(30) constraint fk_QUANLYSUACHUA foreign key (MaKH) references KhachHang(MaKH)  not null, 
TinhTrang	nvarchar(50) 	not null ,
NgaySC	date	not null ,
MaNV varchar(15) foreign key (MaNV) references NhanVien(MaNV) not null,
TrangThai	Nvarchar(20)  not null	)
 

 -- thêm dữ liệu Giá nước
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN001', 'KH001','NKD' , 3.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN002', 'KH002','NDS' ,2.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN003', 'KH003','NKD' ,5.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN004', 'KH002','NDS' ,2.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN005', 'KH002','NDS' ,2.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN006', 'KH002','NDS' ,2.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN007', 'KH002','NDS' ,2.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN008', 'KH002','NDS' ,2.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN009', 'KH002','NDS' ,2.000);
INSERT INTO GiaNuoc (MaDK, MaKH,MaNuocSD, GiaTien) VALUES ('MN010', 'KH003','NKD' ,3.000);



-- KhachHang table
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH0011', N'NGuyễn Văn Anh', N'Số 1 , tòa A , Phúc Hưng', '0912345678');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH002', N'Trần Thị Bình', N'Số 2 , tòa A , Phúc Hưng', '0987654321');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH003', N'Lê Văn Cường', N'Số 3 , tòa A , Phúc Hưng', '0909090909');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH004', N'Phạm Thị Dương', N'Số 4 , tòa A , Phúc Hưng', '0912121212');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH005', N'Đỗ Văn Luyện', N'Số 5 , tòa A , Phúc Hưng', '0969696961');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH006', N' Nguyễn Văn Luyện', N'Số 6 , tòa A , Phúc Hưng', '0969696962');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH007', N'Hoàng Văn Đô', N'Số 7 , tòa A , Phúc Hưng', '0969696963');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH008', N' Nguyễn Hoàng Minh', N'Số 8 , tòa A , Phúc Hưng', '0969696964');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH009', N'Đỗ Anh Trung', N'Số 9 , tòa A , Phúc Hưng', '0969696965');
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT) VALUES ('KH010', N'Đỗ Văn Nam', N'Số 10 , tòa A , Phúc Hưng', '0969696966');

select * from KhachHang

-- NhanVien table
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV001', N'Nguyễn Thị Hương ', N'Hưng Yên', '0912345678', '1990-01-01', N'Nữ');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV002', N'Hoàng Văn Long', N' Hà Nội', '0987654321', '1995-02-03', 'Nam');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV003', N'Lê Thị Loan', 'Hà Nam', '0909090909', '1988-05-10', N'Nữ');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV004', N'Phạm Anh Khoa', 'Cao Bằng', '0912121212', '1993-07-15', 'Nam');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV005', N'Đỗ  Thị Loan', 'Hưng Yên', '096969696', '1993-07-15', 'Nam');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV006', N'Phạm Văn Nam', N'Hưng Yên', '0912121212', '1993-07-15', 'Nam');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV007', N'Phạm Văn HOàng', N'Hưng Yên', '0912121212', '1993-07-15', 'Nam');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV008', N'Văn Long', N'Hưng Yên', '0912121212', '1993-07-15', 'Nam');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV009', N'Huỳnh Đông', N'Hà Nam', '0912121212', '1993-07-15', 'Nam');
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh) VALUES ('NV010', N'Đông Á', N'Hà Nam', '0912121212', '1993-07-15', 'Nam');

-- Tài khoản

INSERT INTO TaiKhoan (MaNV, TenDN, MatKhau, ChucVu, TrangThai)
VALUES ('NV001', 'admin', '123456', 'Admin', 'True'),
('NV002', 'nv0022', '111', 'user', 'True'),
('NV003', 'nv0023', '222', 'user', 'True'),
('NV004', 'nv0024', '333', 'user', 'True'),
('NV005', 'nv0025', '444', 'user', 'True'),
('NV006', 'nv0026', '555', 'user', 'True'),
('NV007', 'nv0027', '666', 'user', 'True'),
('NV008', 'nv0028', '777', 'user', 'True'),
('NV009', 'nv0029', '888', 'user', 'True'),
('NV010', 'nv0020', '999', 'user', 'True');


-- ql sửa chữa
INSERT INTO QuanLySuaChua (MaSC, MaKH, TinhTrang, NgaySC, MaNV, TrangThai)
VALUES ('SC001', 'KH001', N'Hỏng đồng hồ', '05/13/2023', 'NV001', N'Chưa hoàn thành'),
 ('SC002', 'KH002',  N'Hỏng đồng hồ',  '04/13/2023', 'NV002', N'Hoàn thành'),
 ('SC003', 'KH003',  N'Vỡ ống nước',  '05/10/2023', 'NV003', N'Hoàn thành'),
 ('SC004', 'KH002', N'Hỏng đồng hồ',  '11/11/2023', 'NV004', N' Hoàn thành'),
 ('SC005', 'KH005',  N'Vỡ ống nước',  '02/01/2023', 'NV001', N'Hoàn thành'),
 ('SC006', 'KH002',  N'Hỏng đồng hồ',  '01/12/2023', 'NV002', N'Chưa hoàn thành'),
 ('SC007', 'KH003',  N'Vỡ ống nước',  '05/15/2023', 'NV003', N'Chưa hoàn thành'),
 ('SC008', 'KH004',  N'Hỏng đồng hồ',  '05/05/2023', 'NV004', N'Hoàn thành'),
 ('SC009', 'KH002',  N'Hỏng đồng hồ',  '05/13/2023', 'NV001', N'Chưa hoàn thành'),
('SC010', 'KH003',   N'Vỡ ống nước',  '02/13/2023', 'NV002', N'Chưa hoàn thành')

-- HoaDon
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH001', 'NV001', '2023-05-01', N'Tiền mặt');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH002', 'NV002', '2023-05-02',  N'Chuyển khoản');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH003', 'NV003', '2023-05-03',  N'Chuyển khoản');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH004', 'NV004', '2023-05-04',  N'Tiền mặt');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH005', 'NV001', '2023-05-05',  N'Chuyển khoản');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH006', 'NV002', '2023-05-06',  N'Chuyển khoản');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH007', 'NV003', '2023-05-07',  N'Tiền mặt');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH008', 'NV004', '2023-05-08',  N'Chuyển khoản');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH009', 'NV001', '2023-05-09',  N'Chuyển khoản');
INSERT INTO HoaDon (MaKH, MaNV, NgayThanhToan, HinhThucTT) VALUES ('KH010', 'NV002', '2023-05-10',  N'Tiền mặt');

-- CT_HoaDon
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (1, 0, 5, 100000, 10, 115500);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (2, 0, 8, 150000, 15, 196500);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (3, 0, 6, 120000, 12, 135360);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (4, 0, 9, 180000, 18, 225720);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (5, 0, 4, 80000, 8, 87680);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (6, 0, 7, 140000, 14, 165760);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (7, 0, 10, 200000, 20, 250800);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (8, 0, 3, 60000, 6, 65520);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (9, 0, 8, 160000, 16, 190080);
INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue, TongTien) VALUES (10, 0, 5, 100000, 10, 115500);
 --Hàm procedure khach Hang
 select*from TaiKhoan
CREATE PROCEDURE Select_KhachHang
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MaKH, TenKH, DiaChi, SoDT FROM KhachHang;
END;

Exec  Select_KhachHang
alter PROCEDURE Insert_KhachHang

@MaKH varchar(30),
@TenKH nvarchar(30),
@DiaChi nvarchar(50),
@SoDT varchar(15)
AS
BEGIN
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT)
VALUES (@MaKH, @TenKH, @DiaChi, @SoDT)
END

 --exec themKhachHang

alter PROCEDURE Update_KhachHang
@MaKH varchar(30),
@TenKH nvarchar(30),
@DiaChi nvarchar(50),
@SoDT varchar(15)

AS
BEGIN
 SET NOCOUNT ON;

UPDATE KhachHang
SET TenKH=@TenKH, DiaChi=@DiaChi, SoDT=@SoDT
WHERE MaKH = @MaKH
END

CREATE PROCEDURE Delete_KhachHang
     @MaKH varchar(30)
AS
BEGIN
    -- Xóa các chi tiết đặt hàng liên quan
    DELETE FROM GiaNuoc
    WHERE MaKH = @MaKH;
    -- Xóa các thanh toán liên quan
    DELETE FROM HoaDon
    WHERE MaKH = @MaKH;

	DELETE FROM QuanLySuaChua
    WHERE MaKH = @MaKH;
    -- Xóa đơn hàng chính
    DELETE FROM KhachHang
     WHERE MaKH = @MaKH;
END;

alter PROCEDURE Search_KhachHang
@TuKhoa nvarchar(50)
AS
BEGIN
SELECT * FROM KhachHang
WHERE 
SoDT=@TuKhoa
or
 MaKH  LIKE '%'+@TuKhoa+'%'

 or 
 DiaChi  LIKE '%' +@TuKhoa+ '%'
END
Exec Search_KhachHang @TuKhoa='123456'

Create procedure MaTrungKH
@MaKH varchar(30)
as
begin
select  count(*) from KhachHang
where MaKH=@MaKH
end


create procedure SoDTTrungKH
@SoDT varchar(15)
as
begin
select  count(*) from KhachHang
where SoDT=@SoDT
end
Exec Search_KhachHang @TuKhoa=' tòa A'

 --Hàm procedure NhanVien


 

 alter PROCEDURE Select_NhanVien
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh FROM NhanVien;
END;

exec  Select_NhanVien


create procedure MaTrungNV
@MaNV varchar(30)
as
begin
select  count(*) from NhanVien
where MaNV=@MaNV
end



create procedure SoDTTrung
@SoDT varchar(30)
as
begin
select  count(*) from NhanVien
where SoDT=@SoDT
end


create PROCEDURE Insert_NhanVien
    @MaNV varchar(15),
    @TenNV nvarchar(30),
    @DiaChi nvarchar(50),
    @SoDT varchar(15),
    @NgaySinh date,
    @GioiTinh nvarchar(5)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh)
    VALUES (@MaNV, @TenNV, @DiaChi, @SoDT, @NgaySinh, @GioiTinh);
END;


alter PROCEDURE Update_NhanVien
    @MaNV varchar(15),
    @TenNV nvarchar(30),
    @DiaChi nvarchar(50),
    @SoDT varchar(15),
    @NgaySinh date,
    @GioiTinh nvarchar(5)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE NhanVien
    SET TenNV = @TenNV, DiaChi = @DiaChi, SoDT = @SoDT, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh
    WHERE MaNV = @MaNV;
END;


alter PROCEDURE Delete_NhanVien
     @MaNV varchar(15)
AS
BEGIN
    -- Xóa các chi tiết đặt hàng liên quan

	DELETE FROM QuanLySuaChua
    WHERE MaNV = @MaNV;
    DELETE FROM HoaDon
    WHERE MaNV = @MaNV;
    -- Xóa các thanh toán liên quan
    DELETE FROM TaiKhoan
    WHERE MaNV = @MaNV;
    -- Xóa đơn hàng chính
    DELETE FROM NhanVien
    WHERE MaNV = @MaNV;
END;

alter PROCEDURE Search_NhanVien
	@TuKhoa nvarchar(30)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh
    FROM NhanVien
    WHERE MaNV LIKE '%'+@TuKhoa+'%' or DiaChi LIKE '%'+ @TuKhoa+'%'or SoDT LIKE '%'+ @TuKhoa+'%' or GioiTinh LIKE '%'+ @TuKhoa+'%'
END;

exec Search_NhanVien @TuKhoa=N'Hưng Yên'

--Hàm Giá nước
-- lấy về thông tin thông qua mã khách hàng
alter procedure MaDKTrung
@MaDK varchar(20)
as
begin
select  count(*) from GiaNuoc
where MaDK=@MaDK
end

exec MaDKTrung @MaDK='MN001'

create procedure select_MaKH_GiaNuoc
as
begin
 SET NOCOUNT ON;

    SELECT MaKH
    FROM KhachHang
END;

exec  select_MaKH_GiaNuoc

CREATE PROCEDURE Select_KhachHang_GiaNuoc
	@MaKH varchar(15)
   
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TenKH
    FROM KhachHang 
    WHERE MaKH=@MaKH
END;

alter PROCEDURE Select_GiaNuoc
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaDK , MaKH ,MaNuocSD,GiaTien FROM GiaNuoc;
END;

 Exec Select_GiaNuoc
 
alter PROCEDURE Insert_GiaNuoc
    @MaDK varchar(10),
    @MaKH nvarchar(30),
	@MaNuocSD varchar(20),
    @GiaTien float
   
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO GiaNuoc(MaDK,MaKH ,MaNuocSD,GiaTien)
    VALUES (@MaDK ,@MaKH ,@MaNuocSD,@GiaTien);
END;


Alter PROCEDURE Update_GiaNuoc
     @MaDK varchar(10),
    @MaKH nvarchar(30),
	@MaNuocSD varchar(20),
    @GiaTien float
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE GiaNuoc
    SET GiaTien=@GiaTien, MaNuocSD=@MaNuocSD
    WHERE MaDK = @MaDK;
END;


alter PROCEDURE Delete_GiaNuoc
     @MaDK varchar(10)
AS
BEGIN
   
    DELETE FROM GiaNuoc
    WHERE MaDK = @MaDK;
END;

alter PROCEDURE Search_GiaNuoc
	@TuKhoa nvarchar(30)

AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM GiaNuoc
    WHERE  MaDK like'%'+@TuKhoa+'%' or MaKH like '%'+@TuKhoa+'%'  or MaNuocSD like '%'+@TuKhoa+'%'
END;
Exec Search_GiaNuoc @TuKhoa='nds01'


--Taikhoan
alter procedure select_MaNV_TaiKhoan
as
begin
 SET NOCOUNT ON;

    SELECT MaNV
    FROM NhanVien
END;


alter procedure MaTrungTK
@MaNV varchar(15)
as
begin
select  count(*) from TaiKhoan
where MaNV=@MaNV or MatKhau=@MaNV
end


exec   MaTrungTK @MaNV='nvsc006'


alter PROCEDURE select_TenNV_TaiKhoan
	@MaNV varchar(15)
   
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TenNV
    FROM NhanVien 
    WHERE MaNV=@MaNV
END;
Exec select_TenNV_TaiKhoan @MaNV='nvsc006'



alter procedure select_DangNhap
	@TenDN	varchar(20)	,
	@MatKhau	varchar(20)
	 
as
begin
	Set Nocount on;
	Select count(*) from TaiKhoan
	where TenDN=@TenDN and MatKhau=@MatKhau  and TrangThai=N'True'
end;
 
exec select_DangNhap @TenDN='admin12' ,@MatKhau='_admin23'

select*from TaiKhoan

Exec select_DangNhap @TenDN=  'long123' ,@MatKhau='12345'


--hàm lấy ra quyền

create procedure Quyen
	@TenDN	varchar(20)	,
	@MatKhau	varchar(20)
	 
as
begin
	Set Nocount on;
	Select ChucVu from TaiKhoan
	where TenDN=@TenDN and MatKhau=@MatKhau  and TrangThai=N'True'
end;
exec Quyen @TenDN='admin12' ,@MatKhau='_admin23'


-- kiểm tra mật khẩu trùng
create procedure MatKhauTrung
	@MatKhau	varchar(20)
as
begin

Set Nocount on;
	Select count(*) from TaiKhoan
	where MatKhau=@MatKhau 
end;

exec MatKhauTrung @MatKhau='_admin2'
alter PROCEDURE Select_TK
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaNV, TenDN ,MatKhau,ChucVu,TrangThai FROM TaiKhoan;
END;

 Exec  Select_TK

create PROCEDURE Insert_TK
	@MaNV	varchar(15)	,
	@TenDN	varchar(20)	,
	@MatKhau	varchar(20),
	@ChucVu  nvarchar(20) ,
	@TrangThai Nvarchar(30)
   
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO TaiKhoan(MaNV, TenDN ,MatKhau,ChucVu,TrangThai)
    VALUES (@MaNV ,@TenDN ,@MatKhau,@ChucVu,@TrangThai);
END;


alter PROCEDURE Update_TaiKhoan
  	@MaNV	varchar(15)	,
	@TenDN	varchar(20)	,
	@MatKhau	varchar(20),
	@ChucVu  nvarchar(20) ,
	@TrangThai Nvarchar(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE TaiKhoan
    SET TenDN=@TenDN ,ChucVu=@ChucVu, TrangThai=@TrangThai
    WHERE MatKhau = @MatKhau;
END;


alter PROCEDURE Delete_TaiKhoan
     @MatKhau	varchar(20)
AS
BEGIN
   
	
   
    DELETE  FROM TaiKhoan
    WHERE MatKhau=@MatKhau;
END

alter PROCEDURE Search_TaiKhoan
	@TuKhoa nvarchar(30)

AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM TaiKhoan
    WHERE  ChucVu like'%'+@TuKhoa+'%' or TrangThai like '%'+@TuKhoa+'%'  or MaNV like '%'+@TuKhoa+'%'
END;
Exec Search_GiaNuoc @TuKhoa='nds01'



-- quản lý sửa chữa

Create procedure select_MaNV_SC
as
begin
 SET NOCOUNT ON;

    SELECT MaNV
    FROM NhanVien
END;


create procedure MaTrungSC
@MaSC varchar(15)
as
begin
select  count(*) from QuanLySuaChua
where MaSC=@MaSC
end


exec   MaTrungTK @MaNV='nvsc006'


create procedure select_MaKH_SC
as
begin
 SET NOCOUNT ON;

    SELECT MaKH
    FROM KhachHang
END;

create PROCEDURE select_TenKH_DiaChi_SC
	@MaKH varchar(15)
   
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TenKH , DiaChi
    FROM KhachHang
    WHERE MaKH=@MaKH
END;

CREATE PROCEDURE Select_SuaChua
AS
BEGIN
    SELECT * FROM QuanLySuaChua
END



	
-- thêm sua chữa
alter PROCEDURE Insert_SuaChua
	@MaSC varchar(30),
	@MaKH varchar(30),
	@TinhTrang nvarchar(50),
	@NgaySC date,
	@MaNV varchar(15),
	@TrangThai varchar(20)
AS
BEGIN
	INSERT INTO QuanLySuaChua(MaSC, MaKH, TinhTrang, NgaySC, MaNV, TrangThai)
	VALUES(@MaSC, @MaKH, @TinhTrang, @NgaySC, @MaNV, @TrangThai)
END



alter PROCEDURE Update_SuaChua
	@MaSC varchar(30),
	@MaKH varchar(30),
	@TinhTrang nvarchar(50),
	@NgaySC date,
	@MaNV varchar(15),
	@TrangThai Nvarchar(20)
AS
BEGIN
	UPDATE QuanLySuaChua
	SET MaKH = @MaKH, TinhTrang = @TinhTrang, NgaySC = @NgaySC, MaNV = @MaNV, TrangThai = @TrangThai
	WHERE MaSC = @MaSC
END



CREATE PROCEDURE Delete_SuaChua
	@MaSC varchar(30)
AS
BEGIN
	DELETE FROM QuanLySuaChua
	WHERE MaSC = @MaSC
END

create PROCEDURE Search_SC
	@TuKhoa nvarchar(30)

AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM QuanLySuaChua
    WHERE  MaSC like'%'+@TuKhoa+'%' or MaKH like '%'+@TuKhoa+'%'  or MaNV like '%'+@TuKhoa+'%' or 
	TinhTrang like '%'+@TuKhoa+'%' or TrangThai like '%'+@TuKhoa+'%' or NgaySC like '%'+@TuKhoa+'%'
END;

Select* from HoaDon
Select * from CT_HoaDon

alter PROCEDURE InsertHoaDonAndCT_HoaDon
(
  @MaKH varchar(30),
  @MaNV varchar(15),
  --@NgayThanhToan date,
  --@HinhThucTT nvarchar(30),
  @SoCTT float,
  @SoCTS float,
  @GiaTien float,
  @Thue int,
   @NgayThanhToan date,
  @HinhThucTT nvarchar(30),
  @TongTien float
)
AS
BEGIN
  BEGIN TRANSACTION; -- Bắt đầu giao dịch

  DECLARE @MaHD int;

  -- Thêm dữ liệu vào bảng HoaDon
  INSERT INTO HoaDon (MaKH, MaNV, HinhThucTT)
  VALUES (@MaKH, @MaNV,  @HinhThucTT);

  SET @MaHD = SCOPE_IDENTITY(); -- Lấy giá trị của MaHD sau khi thêm

  -- Thêm dữ liệu vào bảng CT_HoaDon
  INSERT INTO CT_HoaDon (MaHD, SoCTT, SoCTS, GiaTien, Thue,NgayThanhToan, TongTien)
  VALUES (@MaHD, @SoCTT, @SoCTS, @GiaTien, @Thue,@NgayThanhToan, @TongTien);

  COMMIT; -- Lưu các thay đổi vào cơ sở dữ liệu
END;

delete from HoaDon
delete from CT_HoaDon
EXEC InsertHoaDonAndCT_HoaDon 'KH001', 'NV001', '2023-05-21', 'Online', 1.5, 2.5, 100.99, 10, 120.99;



alter PROCEDURE GetHoaDonAndCT_HoaDon
AS
BEGIN
  SELECT
    H.MaHD,
    H.MaKH,
    H.MaNV,
	--H.NgayThanhToan,
    --H.HinhThucTT,
    --C.MaCTHD,
    C.SoCTT,
    C.SoCTS,
    C.GiaTien,
    C.Thue,
	C.NgayThanhToan,
	 H.HinhThucTT,
    C.TongTien
  FROM
    HoaDon H
    INNER JOIN CT_HoaDon C ON H.MaHD = C.MaHD;
END;

EXEC GetHoaDonAndCT_HoaDon;


create procedure select_GiaTien_ThanhToan
	@MaKH varchar(30)
as
begin
 SET NOCOUNT ON;

    SELECT GiaTien
    FROM KhachHang as kh inner join GiaNuoc as gn on kh.MaKH=gn.MaKH
	where kh.MaKH=@MaKH
END;
select * from GiaNuoc


alter PROCEDURE UpdateHoaDonAndCT_HoaDon
(
  --@MaCTHD int,
  @MaHD int,
  @MaKH varchar(30),
  @MaNV varchar(15),
  --@NgayThanhToan date,
  --@HinhThucTT nvarchar(30),
  @SoCTT float,
  @SoCTS float,
  @GiaTien float,
  @Thue int,
   @NgayThanhToan date,
  @HinhThucTT nvarchar(30),
  @TongTien float

)
AS
BEGIN
  BEGIN TRANSACTION; -- Bắt đầu giao dịch

  -- Cập nhật dữ liệu trong bảng HoaDon
  UPDATE HoaDon
  SET MaKH = @MaKH,
      MaNV = @MaNV,
	    --NgayThanhToan = @NgayThanhToan,
      HinhThucTT = @HinhThucTT
  WHERE MaHD = @MaHD;

  -- Cập nhật dữ liệu trong bảng CT_HoaDon
  UPDATE CT_HoaDon
  SET SoCTT = @SoCTT,
      SoCTS = @SoCTS,
      GiaTien = @GiaTien,
      Thue = @Thue,
	    NgayThanhToan = @NgayThanhToan,
	  TongTien=@TongTien
  WHERE MaCTHD = @MaHD;

  COMMIT; -- Lưu các thay đổi vào cơ sở dữ liệu
END;

select *from HoaDon
select *from CT_HoaDon

EXEC UpdateHoaDonAndCT_HoaDon
	@MaCTHD=3,
	@MaHD=3,
    @MaKH = 'KH001',
    @MaNV = 'NV001',
    @NgayThanhToan = '2023-05-22',
    @HinhThucTT = 'Online',
    @SoCTT = 10.5,
    @SoCTS = 5.5,
    @GiaTien = 100.0,
    @Thue = 10,
    @TongTien = 1000.0;

CREATE PROCEDURE Delete_HD
    @MaHD INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRANSACTION;
        
    -- Xóa dữ liệu trong bảng CT_HoaDon
    DELETE FROM CT_HoaDon WHERE MaHD = @MaHD;
        
    -- Xóa dữ liệu trong bảng HoaDon
    DELETE FROM HoaDon WHERE MaHD = @MaHD;
        
    COMMIT TRANSACTION;
    
    -- Không cần xử lý lỗi vì không kiểm tra lỗi
END

exec Delete_HD @MaHD=3


alter PROCEDURE SearchHoaDonAndCT_HoaDon
    @MaHD INT ,
	@MaKH nvarchar(50)
AS
BEGIN
    SELECT HD.MaHD,MaKH,MaNV,SoCTT,SoCTS,GiaTien,Thue,NgayThanhToan,HinhThucTT,TongTien
    FROM HoaDon HD
    INNER JOIN CT_HoaDon CTHD ON HD.MaHD = CTHD.MaHD
    WHERE HD.MaHD=@MaHD
	or HD.MaKH like'%'+@MaKH+'%'
	or HD.HinhThucTT  like'%'+@MaKH+'%'
END

exec SearchHoaDonAndCT_HoaDon @MaKH='Online'


-- trigger tự cập nhật số công tơ nước

--
select *from HoaDon
select *from  CT_HoaDon
CREATE PROCEDURE GetSoCTS
    @MaKH varchar(30)
AS
BEGIN
    SELECT TOP 1 SoCTS
    FROM CT_HoaDon
    INNER JOIN HoaDon ON CT_HoaDon.MaHD = HoaDon.MaHD
    WHERE HoaDon.MaKH = @MaKH
    ORDER BY NgayThanhToan DESC
END

drop trigger trg_UpdateSoCTT_MaKH




-- Tạo trigger sau khi cập nhật trường SoCTS trong bảng CT_HoaDon
drop TRIGGER update_new





alter TRIGGER a
ON CT_HoaDon 
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra nếu SoCTS đã được cập nhật
    IF UPDATE(SoCTS)
    BEGIN
        -- Lấy MaHD, MaKH của bản ghi đang được cập nhật
        DECLARE @MaHD INT, @MaKH VARCHAR(30)
        SELECT @MaHD = CT_HoaDon.MaHD, @MaKH = HoaDon.MaKH
        FROM CT_HoaDon
        INNER JOIN HoaDon ON CT_HoaDon.MaHD = HoaDon.MaHD
        WHERE CT_HoaDon.MaHD IN (SELECT MaHD FROM inserted)

        -- Lấy giá trị mới của SoCTS
        DECLARE @SoCTS FLOAT
        SELECT @SoCTS = SoCTS FROM inserted

        -- Cập nhật trường SoCTT của bản ghi tiếp theo có cùng MaKH
        UPDATE CT_HoaDon
        SET SoCTT = @SoCTS
        WHERE MaHD = (SELECT MIN(MaHD) FROM CT_HoaDon WHERE MaHD > @MaHD AND MaHD IN (SELECT MaHD FROM HoaDon WHERE MaKH = @MaKH))

        -- Cập nhật lại trường TongTien theo công thức
        UPDATE CT_HoaDon
        SET TongTien = (@SoCTS - SoCTT) * GiaTien + (@SoCTS - SoCTT) * GiaTien * Thue / 100
        WHERE MaHD = @MaHD

        -- Cập nhật lại trường TongTien của các bản ghi có cùng MaKH trong bảng HoaDon
        UPDATE CT_HoaDon
        SET TongTien = (SoCTS - SoCTT) * GiaTien + ((SoCTS - SoCTT) * GiaTien) * Thue/100
        WHERE MaHD IN (SELECT MaHD FROM HoaDon WHERE MaKH = @MaKH)
    END
END



-- thống kê

--tìm kiếm theo ngày
CREATE PROCEDURE ThongKeHoaDon
    @NgayThanhToan date
AS
BEGIN
    SELECT
        COUNT(DISTINCT HoaDon.MaKH) AS SoKhachHang,
        SUM(CT_HoaDon.SoCTS - CT_HoaDon.SoCTT) AS NuocSuDung,
        SUM(CT_HoaDon.TongTien) AS TongTien
    FROM
        HoaDon
    INNER JOIN CT_HoaDon ON HoaDon.MaHD = CT_HoaDon.MaHD
    WHERE
        CT_HoaDon.NgayThanhToan = @NgayThanhToan;
END;

DECLARE @PaymentDate date = '2023-05-26';

EXEC ThongKeHoaDon @NgayThanhToan = @PaymentDate;


select *from CT_HoaDon

-- tìm kiếm theo tháng hoặc năm
alter PROCEDURE ThongKeHoaDonTheoThang
    @ThoiGian int
   
AS
BEGIN
    SELECT
        COUNT(DISTINCT HoaDon.MaKH) AS SoKhachHang,
        SUM(CT_HoaDon.SoCTS - CT_HoaDon.SoCTT) AS NuocSuDung,
        SUM(CT_HoaDon.TongTien) AS TongTien
    FROM
        HoaDon
    INNER JOIN CT_HoaDon ON HoaDon.MaHD = CT_HoaDon.MaHD
    WHERE
        MONTH(CT_HoaDon.NgayThanhToan) = @ThoiGian
        or YEAR(CT_HoaDon.NgayThanhToan) = @ThoiGian;
END;


DECLARE @Month int = 6; -- Example: May
DECLARE @Year int = 2023; -- Example: 2023

DECLARE @PaymentDate date = 6;
EXEC ThongKeHoaDonTheoThang @Thang = @Month, @Nam = @Year;

--thống kê theo mã khách hàng
--CREATE PROCEDURE ThongKeHoaDonMK
--    @MaKH varchar(30)
--AS
--BEGIN
--    SELECT
--        COUNT(DISTINCT HoaDon.MaKH) AS SoKhachHang,
--        SUM(CT_HoaDon.SoCTS - CT_HoaDon.SoCTT) AS NuocSuDung,
--        SUM(CT_HoaDon.TongTien) AS TongTien
--    FROM
--        HoaDon
--    INNER JOIN CT_HoaDon ON HoaDon.MaHD = CT_HoaDon.MaHD
--    WHERE
--        MaKH = @MaKH;
--END;

--EXEC ThongKeHoaDonMK @MaKH='KH001';


select *from TaiKhoan
--thống kê số nhânviên cònhoạt động
create procedure SoNV
as
begin
		select COUNT(*) 
		from TaiKhoan
		where TrangThai='True'
end
exec SoNV






create PROCEDURE Search_TK_HD
      @ThoiGian int
AS
BEGIN
    SELECT HD.MaHD,MaKH,MaNV,SoCTT,SoCTS,GiaTien,Thue,NgayThanhToan,HinhThucTT,TongTien
    FROM HoaDon HD
    INNER JOIN CT_HoaDon CTHD ON HD.MaHD = CTHD.MaHD
     WHERE
        MONTH(CTHD.NgayThanhToan) = @ThoiGian
        or YEAR(CTHD.NgayThanhToan) = @ThoiGian;
END


--CT_HoaDon.NgayThanhToan = @NgayThanhToan;
-- thống kê theo ngày tháng
create PROCEDURE Search_TK_DT
      @NgayThanhToan date
AS
BEGIN
    SELECT HD.MaHD,MaKH,MaNV,SoCTT,SoCTS,GiaTien,Thue,NgayThanhToan,HinhThucTT,TongTien
    FROM HoaDon HD
    INNER JOIN CT_HoaDon CTHD ON HD.MaHD = CTHD.MaHD
     WHERE
        CTHD.NgayThanhToan = @NgayThanhToan;
END