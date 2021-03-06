CREATE DATABASE QLPKVL
go
use QLPKVL
go

Create function tangmakhachhang()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Makh) from KHACHHANG
	if exists (select Makh from KHACHHANG)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,3,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='KH' + '00' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
				set @Id='KH' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='KH' +  Convert(varchar(3),@Max)
	Return @Id
End

go

Create function tangmanhanvien()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Manhanvien) from NHANVIEN
	if exists (select Manhanvien from NHANVIEN)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,3,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='NV' + '00' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
				set @Id='NV' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='NV' +  Convert(varchar(3),@Max)
	Return @Id
End

go

Create function tangmanhacungcap()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Mancc) from NHACC
	if exists (select Mancc from NHACC)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,4,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='NCC' + '00' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
				set @Id='NCC' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='NCC' +  Convert(varchar(3),@Max)
	Return @Id
End


go

Create function tangmaloaisanpham()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Maloaisanpham) from LOAISANPHAM
	if exists (select Maloaisanpham from LOAISANPHAM)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,4,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='LSP' + '00' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
				set @Id='LSP' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='LSP' +  Convert(varchar(3),@Max)
	Return @Id
End

go

Create function tangmadonvitinh()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Madonvitinh) from DONVITINH
	if exists (select Madonvitinh from DONVITINH)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,4,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='DVT' + '00' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
				set @Id='DVT' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='DVT' +  Convert(varchar(3),@Max)
	Return @Id
End

go

Create function tangmasanpham()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Masp) from SANPHAM
	if exists (select Masp from SANPHAM)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,3,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='SP' + '00' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
				set @Id='SP' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='SP' +  Convert(varchar(3),@Max)
	Return @Id
End

go

Create function tangmahoadon()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Mahd) from HOADON
	if exists (select Mahd from HOADON)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,3,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='HD' + '00' + Convert(varchar(1),@Max)
	else if (@Max < 100)
				set @Id='HD' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='HD' +  Convert(varchar(3),@Max)
	Return @Id
End

go

Create function tangmachitiethoadon()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Machitiethoadon) from CHITIETHD
	if exists (select Machitiethoadon from CHITIETHD)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,5,4)) + 1
	else
				set @Max=1
	
	if (@Max < 10)
				set @Id='CTHD' + '000' + Convert(varchar(1),@Max)
	else if (@Max < 100)
				set @Id='CTHD' + '00' + Convert(varchar(2),@Max)
	else if (@Max < 1000)
				set @Id='CTHD' + '0' + Convert(varchar(3),@Max)			
	else
				set @Id ='CTHD' +  Convert(varchar(4),@Max)
	Return @Id
End

go

Create function tangmaphieunhap()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Mapn) from PHIEUNHAP
	if exists (select Mapn from PHIEUNHAP)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,3,3)) + 1
	else
				set @Max=1
	if (@Max < 10)
				set @Id='PN' + '00' + Convert(varchar(1),@Max)
	else if (@Max < 100)
				set @Id='PN' + '0' + Convert(varchar(2),@Max)
	else
				set @Id ='PN' +  Convert(varchar(3),@Max)
	Return @Id
End

go

Create function tangmachitietphieunhap()
		returns varchar(10)
As
Begin
	Declare @Id varchar(10)
	Declare @MaxMa varchar(10)
	Declare @Max float
	Select @MaxMa = MAX(Mactphieunhap) from CTPHIEUNHAP
	if exists (select Mactphieunhap from CTPHIEUNHAP)
				set @Max = CONVERT(float, SUBSTRING(@MaxMa,5,4)) + 1
	else
				set @Max=1
	
	if (@Max < 10)
				set @Id='CTPN' + '000' + Convert(varchar(1),@Max)
	else if (@Max < 100)
				set @Id='CTPN' + '00' + Convert(varchar(2),@Max)
	else if (@Max < 1000)
				set @Id='CTPN' + '0' + Convert(varchar(3),@Max)			
	else
				set @Id ='CTPN' +  Convert(varchar(4),@Max)
	Return @Id
End

go

--NHANVIEN
CREATE TABLE NHANVIEN (
	Manhanvien varchar(10) primary key default dbo.tangmanhanvien(),
	Tendangnhap varchar(30) not null,
	Pass nchar(30) not null,
	Phanquyen int not null
)
insert into NHANVIEN values ('NV001','admin','123456','1')
insert into NHANVIEN values ('NV002','quoc','123456','2')

go

-- KHACH HANG
CREATE TABLE KHACHHANG (
	Makh varchar(10) primary key default dbo.tangmakhachhang(),
	Hoten nvarchar(30) not null,
	Diachi nvarchar(100),
	Sdt nchar(11),
)
insert into KHACHHANG values ('KH001',N'Phạm Huy',N'46 LÊ LỢI ĐÀ NẴNG','0908298333')
insert into KHACHHANG values ('KH002',N'Trần Phúc',N'11 Quang Trung Đà Nẵng','0779002223')
insert into KHACHHANG values ('KH003',N'Nguyễn Hùng',N'47 Âu Cơ Đà Nẵng','0362888000')
insert into KHACHHANG values ('KH004',N'Châu Tú',N'33 Hoàng Thị Loan Đà Nẵng','0982689237')
insert into KHACHHANG values ('KH005',N'Bùi Duy',N'74 Trần Phú Đà Nẵng','0908298333')
insert into KHACHHANG values ('KH006',N'Nguyễn Thị Nga',N'23 Trần Phú Đà Nẵng','0339299922')
insert into KHACHHANG values ('KH007',N'Vũ Văn Tú',N'66 Ngô Quyền Đà Nẵng','0908298333')
insert into KHACHHANG values ('KH008',N'Trần Thị Bích',N'658 Nguyễn Lương Bằng Đà Nẵng','0934999222')
insert into KHACHHANG values ('KH009',N'Lâm Văn Hùng',N'264 Tôn Đức Thắng Đà Nẵng','0909888777')
insert into KHACHHANG values ('KH010',N'Nguyễn Tấn Tài',N'98 Trần Cao Vân Đà Nẵng','0903999888')


go

-- NHA CUNG CAP
CREATE TABLE NHACC (
	Mancc varchar(10) primary key default dbo.tangmanhacungcap(),
	Tenncc nvarchar(30) not null,
	Diachi nvarchar(100),
	Sdt varchar(11),
)
insert into NHACC values ('NCC001',N'Phú Tài',N'641 Điện Biên Phủ Đà Nẵng','035512213')
insert into NHACC values ('NCC002',N'Phú Mỹ',N'105 Lý Thái Tổ','0892293399')
insert into NHACC values ('NCC003',N'Công ty TNHH  Vĩnh Điện',N'192 Nguyễn Tri Phương Đà Nẵng','0192888999')
insert into NHACC values ('NCC004',N'Phú Đốc',N'99 Tôn Đức Thắng Đà Nẵng','0533912344')
insert into NHACC values ('NCC005',N'Công ty TNHH Đức Thọ',N'123 Tô Hiệu Đà Nẵng','0988777222')
insert into NHACC values ('NCC006',N'Nam Công',N'323 Núi Thành Đà Nẵng','0982777666')
insert into NHACC values ('NCC007',N'Hoàn Hảo',N'80 Phạm Như Sương Đà Nẵng','0779299211')
insert into NHACC values ('NCC008',N'Nam Tửu',N'645 Tôn Đức Thắng Đà Nẵng','093599821')
insert into NHACC values ('NCC009',N'Thành Công',N'12 Đống Đa Đà Nẵng','0779888212')
insert into NHACC values ('NCC010',N'Vĩnh Hảo',N'48 Cao Thắng Đà Nẵng','0351777291')

go

-- LOAI SAN PHAM
CREATE TABLE LOAISANPHAM (
	Maloaisanpham varchar(10) primary key default dbo.tangmaloaisanpham(),
	Tenloaisanpham nvarchar(50) not null,
)
insert into LOAISANPHAM values ('LSP001',N'Xây dựng')
insert into LOAISANPHAM values ('LSP002',N'Dân dụng')
insert into LOAISANPHAM values ('LSP003',N'Bán chạy')
insert into LOAISANPHAM values ('LSP004',N'Vãng lai')

go

-- DON VI TINH
CREATE TABLE DONVITINH (
	Madonvitinh varchar(10) primary key default dbo.tangmadonvitinh(),
	Tendonvitinh nvarchar(50) not null,
)
insert into DONVITINH values ('DVT001',N'Cái')
insert into DONVITINH values ('DVT002',N'Bình')
insert into DONVITINH values ('DVT003',N'Cây')
insert into DONVITINH values ('DVT004',N'Dây')
insert into DONVITINH values ('DVT005',N'Cuộn')
insert into DONVITINH values ('DVT006',N'3')
insert into DONVITINH values ('DVT007',N'3,5')

go

-- SAN PHAM
CREATE TABLE SANPHAM(
	Masp varchar(10) primary key default dbo.tangmasanpham(),
	Tensanpham nvarchar(50) not null,
	Maloaisanpham varchar(10) foreign key references LOAISANPHAM(Maloaisanpham),
	Soluongton int not null,
	Madonvitinh varchar(10) foreign key references DONVITINH(Madonvitinh),
	Dongiaban varchar(30),
)
insert into SANPHAM values('SP001',N'Thép','LSP001','70','DVT004','10000')
insert into SANPHAM values('SP002',N'Đinh rút nhôm 50mm','LSP001','5000','DVT003','1000')
insert into SANPHAM values('SP003',N'Đinh bê tông','LSP001','5000','DVT003','800')
insert into SANPHAM values('SP004',N'Keo dính','LSP003','50','DVT002','30000')
insert into SANPHAM values('SP005',N'TW','LSP004','400','DVT006','25000')
insert into SANPHAM values('SP006',N'TW','LSP004','300','DVT007','30000')
insert into SANPHAM values('SP007',N'NUI','LSP004','250','DVT007','35000')
insert into SANPHAM values('SP008',N'Vòi R/C RÊ','LSP004','10','DVT001','130000')
insert into SANPHAM values('SP009',N'Vòi R/C LOTUSS','LSP004','5','DVT006','160000')
insert into SANPHAM values('SP010',N'Đuổi 2U HT','LSP003','400','DVT001','15000')

go

-- HOADON
CREATE TABLE HOADON(
	Mahd varchar(10) primary key default dbo.tangmahoadon(),
	Makh varchar(10) foreign key references KHACHHANG(Makh),
	Ngaylaphd date,
	Tongtien varchar(30),
	Manhanvien varchar(10) foreign key references NHANVIEN(Manhanvien),
)
insert into HOADON values ('HD001','KH001','2019-01-11','600000','NV002')
insert into HOADON values ('HD002','KH002','2019-01-17','150000','NV002')
insert into HOADON values ('HD003','KH003','2019-01-19','250000','NV002')
insert into HOADON values ('HD004','KH004','2019-01-30','160000','NV002')
insert into HOADON values ('HD005','KH005','2019-02-21','160000','NV002')
insert into HOADON values ('HD006','KH006','2019-02-25','375000','NV002')
insert into HOADON values ('HD007','KH007','2019-03-01','160000','NV002')
insert into HOADON values ('HD008','KH008','2019-03-21','350000','NV002')
insert into HOADON values ('HD009','KH009','2019-03-25','150000','NV002')
insert into HOADON values ('HD010','KH010','2019-04-11','100000','NV002')

go

-- CHI TIET HOA DON
CREATE TABLE CHITIETHD(
	Machitiethoadon varchar(10) primary key default dbo.tangmachitiethoadon(),
	Mahd varchar(10) foreign key references HOADON(Mahd),
	Masp varchar(10) foreign key references SANPHAM(Masp),
	Soluong int not null,
	Dongia varchar(30),
	Thanhtien varchar(30)
)
insert into CHITIETHD values ('CTHD0001','HD001','SP006','20','30000','600000')
insert into CHITIETHD values ('CTHD0002','HD001','SP010','10','15000','150000')
insert into CHITIETHD values ('CTHD0003','HD001','SP005','10','25000','250000')
insert into CHITIETHD values ('CTHD0004','HD002','SP003','200','800','160000')
insert into CHITIETHD values ('CTHD0005','HD002','SP009','1','160000','160000')
insert into CHITIETHD values ('CTHD0006','HD002','SP010','25','15000','375000')
insert into CHITIETHD values ('CTHD0007','HD003','SP009','2','160000','160000')
insert into CHITIETHD values ('CTHD0008','HD003','SP007','10','35000','350000')
insert into CHITIETHD values ('CTHD0009','HD003','SP004','5','30000','150000')
insert into CHITIETHD values ('CTHD0010','HD004','SP002','100','1000','100000')

go

-- PHIEUNHAP
CREATE TABLE PHIEUNHAP(
	Mapn varchar(10) primary key default dbo.tangmaphieunhap(),
	Mancc varchar(10) foreign key references NHACC(Mancc),
	Ngaylap date,
	Tongtien varchar(30),
)
insert into PHIEUNHAP values ('PN001','NCC001','2019-01-03','1400000')
insert into PHIEUNHAP values ('PN002','NCC003','2019-01-03','420000')
insert into PHIEUNHAP values ('PN003','NCC002','2019-01-03','1300000')
insert into PHIEUNHAP values ('PN004','NCC005','2019-01-20','1400000')
insert into PHIEUNHAP values ('PN005','NCC010','2019-01-20','7500000')
insert into PHIEUNHAP values ('PN006','NCC007','2019-01-20','7000000')
insert into PHIEUNHAP values ('PN007','NCC004','2019-02-11','1200000')
insert into PHIEUNHAP values ('PN008','NCC002','2019-02-11','2400000')
insert into PHIEUNHAP values ('PN009','NCC005','2019-02-11','1800000')
insert into PHIEUNHAP values ('PN010','NCC008','2019-02-11','1400000')

go

-- CHITIETPHIEUNHAP
CREATE TABLE CTPHIEUNHAP(
	Mactphieunhap varchar(10) primary key default dbo.tangmachitietphieunhap(),
	Mapn varchar(10) foreign key references PHIEUNHAP(Mapn),
	Masp varchar(10) foreign key references SANPHAM(Masp),
	Soluong int not null,
	Dongianhap varchar(30),
	Thanhtien varchar(30),
)
insert into CTPHIEUNHAP values ('CTPN0001','PN001','SP009','10','140000','1400000')
insert into CTPHIEUNHAP values ('CTPN0002','PN001','SP001','60','7000','420000')
insert into CTPHIEUNHAP values ('CTPN0003','PN002','SP008','10','130000','1300000')
insert into CTPHIEUNHAP values ('CTPN0004','PN002','SP009','10','140000','1400000')
insert into CTPHIEUNHAP values ('CTPN0005','PN002','SP005','300','25000','7500000')
insert into CTPHIEUNHAP values ('CTPN0006','PN003','SP007','200','35000','7000000')
insert into CTPHIEUNHAP values ('CTPN0007','PN003','SP004','40','30000','1200000')
insert into CTPHIEUNHAP values ('CTPN0008','PN004','SP002','3000','800','2400000')
insert into CTPHIEUNHAP values ('CTPN0009','PN004','SP003','3000','600','1800000')
insert into CTPHIEUNHAP values ('CTPN0010','PN004','SP010','10','140000','1400000')


go

--TRIGGER
--Cap nhat lai so luong ton kho khi them sp vao phieu nhap chi tiet
create trigger setlaiSoLuongTonKhoSauKhiThemSPvaoPNCT
on CTPHIEUNHAP
for insert
as
begin
	SET NOCOUNT ON 
	declare @MaSP_Last varchar(10);
	declare @SoLuongNhap int;
	set @MaSP_Last=(select top 1 Masp from inserted order by Mactphieunhap desc);
	set @SoLuongNhap=(select top 1 Soluong from inserted order by Mactphieunhap desc);

	declare @SoLuongTonKhoHienTai int;
	set @SoLuongTonKhoHienTai=(select Soluongton from SANPHAM where Masp=@MaSP_Last);
	declare @SoluongTonKhoMoi int;
	set @SoluongTonKhoMoi=@SoLuongTonKhoHienTai+@SoLuongNhap;

	update SANPHAM set Soluongton=@SoluongTonKhoMoi where Masp=@MaSP_Last;

end


go


--Luc xoa phieu nhap chi tiet thi cong lai ton kho cho san pham
create trigger setlaiSoLuongTonKhoSauKhiXoaSPKhoiPNCT
on CTPHIEUNHAP
for delete
as
begin
	SET NOCOUNT ON 
	declare @MaSP_Last varchar(10);
	declare @SoLuongNhap int;
	set @MaSP_Last=(select top 1 Masp from deleted order by Mactphieunhap desc);
	set @SoLuongNhap=(select top 1 Soluong from deleted order by Mactphieunhap desc);

	declare @SoLuongTonKhoHienTai int;
	set @SoLuongTonKhoHienTai=(select Soluongton from SANPHAM where Masp=@MaSP_Last);
	declare @SoluongTonKhoMoi int;
	set @SoluongTonKhoMoi=@SoLuongTonKhoHienTai-@SoLuongNhap;

	update SANPHAM set Soluongton=@SoluongTonKhoMoi where Masp=@MaSP_Last;

end


go



--Cap nhat lai so luong ton kho khi them sp vao hoa don chi tiet
create trigger setlaiSoLuongTonKhoSauKhiThemSPvaoHDCT
on CHITIETHD
for insert
as
begin
	SET NOCOUNT ON 
	declare @MaSP_Last varchar(10);
	declare @SoLuongBan int;
	set @MaSP_Last=(select top 1 Masp from inserted order by Machitiethoadon desc);
	set @SoLuongBan=(select top 1 Soluong from inserted order by Machitiethoadon desc);

	declare @SoLuongTonKhoHienTai int;
	set @SoLuongTonKhoHienTai=(select Soluongton from SANPHAM where Masp=@MaSP_Last);
	declare @SoluongTonKhoMoi int;
	set @SoluongTonKhoMoi=@SoLuongTonKhoHienTai-@SoLuongBan;

	update SANPHAM set Soluongton=@SoluongTonKhoMoi where Masp=@MaSP_Last;

end

go

--Cap nhat lai so luong ton kho khi xoa sp khoi hoa don chi tiet
create trigger setlaiSoLuongTonKhoSauKhiXoaSPKhoiHDCT
on CHITIETHD
for delete
as
begin
	SET NOCOUNT ON 
	declare @MaSP_Last varchar(10);
	declare @SoLuongBan int;
	set @MaSP_Last=(select top 1 Masp from deleted order by Machitiethoadon desc);
	set @SoLuongBan=(select top 1 Soluong from deleted order by Machitiethoadon desc);

	declare @SoLuongTonKhoHienTai int;
	set @SoLuongTonKhoHienTai=(select Soluongton from SANPHAM where Masp=@MaSP_Last);
	declare @SoluongTonKhoMoi int;
	set @SoluongTonKhoMoi=@SoLuongTonKhoHienTai+@SoLuongBan;

	update SANPHAM set Soluongton=@SoluongTonKhoMoi where Masp=@MaSP_Last;

end


go

--BaoCaoNhapKho xem theo khoảng thời gian từ bắt đầu đến kết thúc
create procedure BaoCaoNhapKho
(
	@batdau date,
	@ketthuc date
)
as
begin
	select CTPHIEUNHAP.Mapn as 'Maphieunhap',SUM(Convert(float,CTPHIEUNHAP.Dongianhap)) as 'Tonggianhap',
	SUM(Convert(float,CTPHIEUNHAP.Soluong)) as 'Tổngnhap',
	SUM(Convert(float,CTPHIEUNHAP.Thanhtien)) as 'Thanhtien'
	from CTPHIEUNHAP JOIN PHIEUNHAP on CTPHIEUNHAP.Mapn=PHIEUNHAP.Mapn
	where PHIEUNHAP.Ngaylap between @batdau and @ketthuc
	group by CTPHIEUNHAP.Mapn
end

go

--Bao cao ban hang theo khoang thoi gian
create procedure BaoCaoCacDonHangDaBan
(
	@batdau date,
	@ketthuc date
)
as
begin
	select hd.Mahd,hd.Makh,hd.Manhanvien,hd.Ngaylaphd,
	cthd.Machitiethoadon,cthd.Mahd,cthd.Masp,cthd.Soluong,cthd.Dongia,cthd.Thanhtien as 'DoanhSo',
	nv.Tendangnhap,kh.Hoten,kh.Diachi,kh.Sdt,
	sp.Tensanpham,
	(select AVG(Convert(float,CTPHIEUNHAP.Dongianhap)) from CTPHIEUNHAP where CTPHIEUNHAP.MaSP=cthd.MaSP)*cthd.Soluong as 'GiaVon',
	cthd.Thanhtien-((select AVG(Convert(float,CTPHIEUNHAP.Dongianhap)) from CTPHIEUNHAP where CTPHIEUNHAP.MaSP=cthd.MaSP)*cthd.Soluong) as 'LaiLo',
	(cthd.Dongia*cthd.Soluong-((select AVG(Convert(float,CTPHIEUNHAP.Dongianhap)) from CTPHIEUNHAP where CTPHIEUNHAP.MaSP=cthd.MaSP)*cthd.Soluong))*100/(cthd.Dongia*cthd.Soluong) as 'TyLeLai'
	from HOADON hd join CHITIETHD cthd
	on hd.Mahd=cthd.Mahd
	join NHANVIEN nv on hd.Manhanvien=nv.Manhanvien
	join KHACHHANG kh on hd.Makh=kh.Makh
	join SANPHAM sp on cthd.Masp=sp.Masp
	where HD.Ngaylaphd between @batdau and @ketthuc
end


go

--select cthd.Masp,sp.Tensanpham,sp.Dongiaban as 'Giá bán',sum(Convert(float,cthd.Soluong)) as 'Tổng số lượng bán',sum(Convert(float,cthd.Thanhtien)) as 'Tổng doanh số',
	--(select sum(Convert(float,ctpn.Soluong)) from CTPHIEUNHAP as ctpn join PHIEUNHAP as pn on ctpn.Mapn=pn.Mapn where (pn.Ngaylap between '2019-01-01' and '2019-01-06') and ctpn.Masp=cthd.Masp group by ctpn.Masp) as 'Tổng số lượng nhập',
	--(select sum(Convert(float,ctpn.Thanhtien)) from CTPHIEUNHAP as ctpn join PHIEUNHAP as pn on ctpn.Mapn=pn.Mapn where (pn.Ngaylap between '2019-01-01' and '2019-01-06') and ctpn.Masp=cthd.Masp group by ctpn.Masp) as 'Tổng tiền vốn nhập',
	--(select sum(Convert(float,cthd.Thanhtien))-sum(Convert(float,ctpn.Thanhtien)) from CTPHIEUNHAP as ctpn join PHIEUNHAP as pn on ctpn.Mapn=pn.Mapn where (pn.Ngaylap between '2019-01-01' and '2019-01-06') and ctpn.Masp=cthd.Masp group by ctpn.Masp) as 'Lời/Lỗ'
	--from CHITIETHD as cthd join HOADON as hd on cthd.Mahd=hd.Mahd
	--join HOADON as hd on 
	--join SANPHAM as sp on cthd.Masp=sp.Masp
	--group by cthd.Masp,sp.Tensanpham,sp.Dongiaban