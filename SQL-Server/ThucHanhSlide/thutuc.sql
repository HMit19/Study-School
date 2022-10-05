-- thuc hanh tren lop bai 1

use BT1CSDL
go
alter procedure cau1 @mas nvarchar(10), @soluong int output
as
begin
set @soluong=0;
select @soluong = Sum(isnull(CTHD.SLBan,0)) from tChiTietHDB as CTHD
join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB
where CTHD.MaSach = @mas and year(NgayBan) = 2014
end
go

declare @number int
exec cau1 'S04', @number output
print @number

go
alter procedure cau2 @day datetime, 
@sl int output,
@tien money output
as
begin
set @sl=0
set @tien = 0
select @sl = count(distinct CTHD.SoHDB), @tien =  sum(CTHD.SLBan*S.Soluong)
from tChiTietHDB as CTHD join tSach as s on CTHD.MaSach = S.MaSach
join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB
where HD.NgayBan = @day
end
go

declare @soHD int, @soTien money
exec cau2 '2014-06-30', @soHD output, @soTien output
print 'so luong hoa don: ' + cast(@soHD as char(10))
print 'tong tien la: ' + cast(@soTien as char(8))



-- thuc hanh tren lop bai 2


-- thuc hanh tren lop bai 3
--Tạo thủ tục có đầu vào là mã nhà cung cấp, đầu ra là số đầu sách và số tiền cửa hàng đã nhập của nhà cung cấp đó
go
create procedure cau3 @maNCC varchar(5), @soS int output, @Stien money output
as 

begin
	select @soS = count(CTHD.MaSach), @Stien = sum(SLNhap * DonGiaNhap)	
	from tSach as S join tChiTietHDN as CTHD on S.MaSach = CTHD.MaSach
	join tHoaDonNhap as HDN on HDN.SoHDN = CTHD.SoHDN
	where HDN.MaNCC = 'NCC01'
end
go

declare @s int, @t money
exec cau3 'NCC01', @s output, @t output
print @s
print t