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

select *
drop table KhachHang
drop table QuanLySuaChua
drop table HoaDon
drop	table CT_HoaDon
drop table GiaNuoc
create table KhachHang(
MaKH	varchar(30) primary key 	,
TenKH	nvarchar(30) not null,	
DiaChi	nvarchar(50) not null,	
SoDT	varchar(15)	unique(SoDT) not null,
TrangThai varchar(8)

 )
-- tạo ràng buộc ngày KT Lơns hớn ngày bắt đầu.


drop table NhanVien 
create table NhanVien(
MaNV	varchar(15)	primary key		,																						
TenNV	nvarchar(30)	NOT NULL,
DiaChi	nvarchar(50)	NOT NULL,
SoDT	varchar(15)	 unique(SoDT) NOT NULL,
NgaySinh	date	NOT NULL,
GioiTinh	nvarchar(5) 	NOT NULL,
TrangThai  varchar(8) not null,

)


drop table TaiKhoan
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
 
 select *from TaiKhoan
 --Hàm procedure khach Hang
 select*from TaiKhoan
alter PROCEDURE Select_KhachHang
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MaKH, TenKH, DiaChi, SoDT ,TrangThai FROM KhachHang;
END;

Exec  Select_KhachHang
alter PROCEDURE Insert_KhachHang

@MaKH varchar(30),
@TenKH nvarchar(30),
@DiaChi nvarchar(50),
@SoDT varchar(15),
@TrangThai varchar(8)
AS
BEGIN
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT, TrangThai )
VALUES (@MaKH, @TenKH, @DiaChi, @SoDT ,@TrangThai)
END

 --exec themKhachHang

alter PROCEDURE Update_KhachHang
@MaKH varchar(30),
@TenKH nvarchar(30),
@DiaChi nvarchar(50),
@SoDT varchar(15),
@TrangThai varchar(8)

AS
BEGIN
 SET NOCOUNT ON;

UPDATE KhachHang
SET TenKH=@TenKH, DiaChi=@DiaChi, SoDT=@SoDT ,TrangThai=@TrangThai
WHERE MaKH = @MaKH
END

alter PROCEDURE Delete_KhachHang
     @MaKH varchar(30)
AS
BEGIN
   Update KhachHang
   set TrangThai='False'
   Where MaKH=@MaKH
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
 or 
 TrangThai  LIKE '%' +@TuKhoa+ '%'
END
Exec Search_KhachHang @TuKhoa='123456'

alter procedure MaTrungKH
@MaKH varchar(30)
as
begin
select  count(*) from KhachHang
where MaKH=@MaKH
end


alter procedure SoDTTrungKH
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

    SELECT MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh ,TrangThai  FROM NhanVien;
END;

exec  Select_NhanVien


alter procedure MaTrungNV
@MaNV varchar(30)
as
begin
select  count(*) from NhanVien
where MaNV=@MaNV
end



alter procedure SoDTTrung
@SoDT varchar(30)
as
begin
select  count(*) from NhanVien
where SoDT=@SoDT
end


alter PROCEDURE Insert_NhanVien
    @MaNV varchar(15),
    @TenNV nvarchar(30),
    @DiaChi nvarchar(50),
    @SoDT varchar(15),
    @NgaySinh date,
    @GioiTinh nvarchar(5),
	@TrangThai varchar(8)

AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh ,TrangThai)
    VALUES (@MaNV, @TenNV, @DiaChi, @SoDT, @NgaySinh, @GioiTinh, @TrangThai);
END;

--alter PROCEDURE Insert_NhanVien1
--    @MaNV varchar(15),
--    @TenNV nvarchar(30),
--    @DiaChi nvarchar(50),
--    @SoDT varchar(15),
--    @NgaySinh date,
--    @GioiTinh nvarchar(5),
--	@TrangThai varchar(8)

--AS
--BEGIN
--    SET NOCOUNT ON;

--    INSERT INTO NhanVien (MaNV, TenNV, DiaChi, SoDT, NgaySinh, GioiTinh ,TrangThai)
--    VALUES (@MaNV, @TenNV, @DiaChi, @SoDT, @NgaySinh, @GioiTinh, @TrangThai);
--END;


alter PROCEDURE Update_NhanVien
    @MaNV varchar(15),
    @TenNV nvarchar(30),
    @DiaChi nvarchar(50),
    @SoDT varchar(15),
    @NgaySinh date,
    @GioiTinh nvarchar(5),
	@TrangThai varchar(8)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE NhanVien
    SET TenNV = @TenNV, DiaChi = @DiaChi, SoDT = @SoDT, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh ,TrangThai=@TrangThai
    WHERE MaNV = @MaNV;
END;


alter PROCEDURE Delete_NhanVien
     @MaNV varchar(15)
AS
BEGIN
    -- Xóa các chi tiết đặt hàng liên quan

	Update NhanVien
	set TrangThai='False'
	where MaNV=@MaNV
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

alter procedure select_MaKH_GiaNuoc
as
begin
 SET NOCOUNT ON;

    SELECT MaKH
    FROM KhachHang
	where TrangThai='True'
END;

exec  select_MaKH_GiaNuoc

alter PROCEDURE Select_KhachHang_GiaNuoc
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
	where TrangThai='True'
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

alter procedure Quyen
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
alter procedure MatKhauTrung
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

alter PROCEDURE Insert_TK
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

alter procedure select_MaNV_SC
as
begin
 SET NOCOUNT ON;

    SELECT MaNV
    FROM NhanVien
	where TrangThai='True'
	
END;

select *from NhanVien

alter procedure MaTrungSC
@MaSC varchar(15)
as
begin
select  count(*) from QuanLySuaChua
where MaSC=@MaSC
end


exec   MaTrungTK @MaNV='nvsc006'


alter procedure select_MaKH_SC
as
begin
 SET NOCOUNT ON;

    SELECT MaKH
    FROM KhachHang
	where TrangThai='True'
END;

alter PROCEDURE select_TenKH_DiaChi_SC
	@MaKH varchar(15)
   
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TenKH , DiaChi
    FROM KhachHang
    WHERE MaKH=@MaKH
END;

alter PROCEDURE Select_SuaChua
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



alter PROCEDURE Delete_SuaChua
	@MaSC varchar(30)
AS
BEGIN
	DELETE FROM QuanLySuaChua
	WHERE MaSC = @MaSC
END

alter PROCEDURE Search_SC
	@TuKhoa nvarchar(30)

AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM QuanLySuaChua
    WHERE  MaSC like'%'+@TuKhoa+'%' or MaKH like '%'+@TuKhoa+'%'  or MaNV like '%'+@TuKhoa+'%' or 
	TinhTrang like '%'+@TuKhoa+'%' or TrangThai like '%'+@TuKhoa + '%' or NgaySC like '%'+@TuKhoa+'%'
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


alter procedure select_GiaTien_ThanhToan
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

alter PROCEDURE Delete_HD
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
-- check ngày thanh toán
alter PROCEDURE Search_TK_HD
      @ThoiGian int
AS
BEGIN
    SELECT count(*)
    FROM HoaDon HD
    INNER JOIN CT_HoaDon CTHD ON HD.MaHD = CTHD.MaHD
     WHERE
        MONTH(CTHD.NgayThanhToan) = @ThoiGian
        or YEAR(CTHD.NgayThanhToan) = @ThoiGian;
END

-- trigger tự cập nhật số công tơ nước

--
select *from HoaDon
select *from  CT_HoaDon
alter PROCEDURE GetSoCTS
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





create TRIGGER a
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

--tìm kiếm theo ngày số lượng theo ngày 
alter PROCEDURE ThongKeHoaDon
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

-- tìm kiếm theo tháng hoặc năm  trả ra số lượng
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
alter procedure SoNV
as
begin
		select COUNT(*) 
		from TaiKhoan
		where TrangThai='True'
end
exec SoNV






alter PROCEDURE Search_TK_HD
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