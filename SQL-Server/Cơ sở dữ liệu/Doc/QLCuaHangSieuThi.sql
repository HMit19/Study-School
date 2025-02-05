CREATE DATABASE QLCuaHangSieuThi
GO
DROP DATABASE QLCuaHangSieuThi
GO
USE QLCuaHangSieuThi
GO

CREATE TABLE HANGHOA(
	MaHangHoa VARCHAR(20) PRIMARY KEY NOT NULL,
	TenHang NVARCHAR(100) NOT NULL,
	DonVi NVARCHAR(100) NOT NULL,
	LoaiHang NVARCHAR(100) NOT NULL,
	SLTon INT ,
	GiaNiemYet FLOAT NOT NULL
)
GO

CREATE TABLE NHACUNGCAP(
	MaNCC VARCHAR(20) PRIMARY KEY NOT NULL,
	TenNCC NVARCHAR(100) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	SDT INT ,
	Email NVARCHAR(100),
)
GO

CREATE TABLE PHIEUNHAPHANG(
	MaPhieu VARCHAR(20) PRIMARY KEY NOT NULL,
	MaHangHoa VARCHAR(20) FOREIGN KEY (MaHangHoa) REFERENCES HANGHOA(MaHangHoa),
	MaNCC VARCHAR(20) FOREIGN KEY (MaNCC) REFERENCES NHACUNGCAP(MaNCC),
	NgayNhap DATE NOT NULL,
	HanSuDung DATE NOT NULL,
	DonVi NVARCHAR(100) NOT NULL,
	SoLuong INT NOT NULL,
	Gia FLOAT NOT NULL,
	ThanhTien FLOAT NULL,
)
GO

CREATE TABLE CHUCVU(
	MaCV VARCHAR(20) PRIMARY KEY NOT NULL,
	TenCV NVARCHAR(100) NOT NULL,
	Luong FLOAT NOT NULL,
)
GO

CREATE TABLE NHANVIEN(
	MaNhanVien VARCHAR(20) PRIMARY KEY NOT NULL,
	MaCV VARCHAR(20) FOREIGN KEY (MaCV) REFERENCES CHUCVU(MaCV),
	Ten NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	SDT INT ,
)
GO

CREATE TABLE LOAIKHACHHANG(
	MaLoaiKH VARCHAR(20) PRIMARY KEY NOT NULL,
	TenLoai NVARCHAR(100) NOT NULL,
	DieuKien NVARCHAR(100) NOT NULL,
)
GO

CREATE TABLE KHACHHANG(
	MaKH VARCHAR(20) PRIMARY KEY NOT NULL,
	MaLoaiKH VARCHAR(20) FOREIGN KEY (MaLoaiKH) REFERENCES LOAIKHACHHANG(MaLoaiKH),
	HoTen NVARCHAR(100) NOT NULL,
	SDT INT ,
	DiaChi NVARCHAR(100) NOT NULL,
	DiemTichLuy INT NULL,
	TongTienDaTieu FLOAT NULL
)
GO

CREATE TABLE HOADON(
	MaHoaDon VARCHAR(20) PRIMARY KEY NOT NULL,
	MaNhanVien VARCHAR(20) FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien),
	MaKH VARCHAR(20) FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	TongTien FLOAT NULL,
)
GO

CREATE TABLE KHUYENMAI(
	MaKM VARCHAR(20) PRIMARY KEY NOT NULL,
	MaHangHoa VARCHAR(20) FOREIGN KEY (MaHangHoa) REFERENCES HANGHOA(MaHangHoa),
	NgayBatDau DATE NOT NULL,
	NgayKetThuc DATE NOT NULL,
	ChietKhau INT NOT NULL
)
GO

CREATE TABLE CHITIETHOADON(
	MaCTHD VARCHAR(20) PRIMARY KEY NOT NULL,
	MaHoaDon VARCHAR(20) FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon),
	MaHangHoa VARCHAR(20) FOREIGN KEY (MaHangHoa) REFERENCES HANGHOA(MaHangHoa),
	SoLuong INT NOT NULL,
	ThanhTien FLOAT NULL
)	
GO

CREATE TABLE LICHLAMVIEC(
	MaLich VARCHAR(20) PRIMARY KEY NOT NULL,
	MaNhanVienLam VARCHAR(20) FOREIGN KEY (MaNhanVienLam) REFERENCES NHANVIEN(MaNhanVien),
	MaNhanVienThay VARCHAR(20) FOREIGN KEY (MaNhanVienThay) REFERENCES NHANVIEN(MaNhanVien),
	TimeBatDau TIME NOT NULL,
	TimeKetThuc TIME NOT NULL,
	DiemDanh INT   -- 1: C�  /  0 : KH�NG
)	
GO

