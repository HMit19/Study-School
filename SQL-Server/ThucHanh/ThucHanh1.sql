use BT1CSDL

/* Cau 1 */

create view demo as (select S.MaSach, S.TenSach
from tHoaDonNhap as HDN join tChiTietHDN as CTHDN on HDN.SoHDN = CTHDN.SoHDN
join tSach as S on CTHDN.MaSach = S.MaSach 
join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
where YEAR(HDN.NgayNhap) = 2014 and TenNXB like N'%Giáo dục');

select * from demo;

/* Cau 2 */
create view SachBan2014
as 
select distinct CTHD.MaSach 
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
where YEAR(NgayBan) = 2014;

select * 
from tSach
where MaSach != all(Select MaSach from SachBan2014);

/* Cau 3: Tạo view thống kê các sách không bán được trong nắm 2021*/
select top 10 with ties kH.MaKH, sum(SLBan * DonGiaBan) as 'tong'
from tKhachHang as KH join tHoaDonBan as HDB on KH.MaKH = HDB.MaKH
join tChiTietHDB as CTHD on HDB.SoHDB = CTHD.SoHDB
join tSach as S on CTHD.MaSach = S.MaSach
where YEAR(NgayBan) = 2014
group by KH.MaKH
order by tong DESC


/* Cau 4: tạo view thống kê số lượng bán trong năm 2021 và số lượng tồn với mỗi đầu sách*/
select sum(SLBan) as N'Số lượng bán'
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
where year(NgayBan) = 2014;

select S.MaSach, S.TenSach, Sum(S.SoLuong - CTHD.SLBan) as N'Số lượng tồn'
from tSach as S join tChiTietHDB as CTHD on S.MaSach = CTHD.MaSach
join tHoaDonBan as HDB on CTHD.SoHDB = HDB.SoHDB
where year(NgayBan) < 2015
group by S.MaSach, S.TenSach
order by Sum(S.SoLuong - CTHD.SLBan) DESC


select S.MaSach, SLB as N'Số lượng bán', (S.SoLuong - SLB) as N'Số lượng tồn'
from tSach as S join(
	select CTHD.MaSach as 'MS', sum(SLBan) as 'SLB'
	from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
	where year(NgayBan) = 2014
	group by CTHD.MaSach
) as Child on S.MaSach = Child.MS