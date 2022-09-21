 use BT1CSDL;

/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */

/* cau 1 */
select [MaSach], [TenSach] from tSach;


/* cau 2 */
select * from tSach where TenSach like 'Ngày%';


/* cau 3 */
select [MaSach], [TenSach] from tSach 
where (MaNXB = (select MaNXB from tNhaXuatBan where TenNXB like N'%Giáo Dục')) 
and (DonGiaBan between 100000 and 150000);


/* cau 4 */
select [MaSach], [TenSach] 
from tSach join tNhaXuatBan on tSach.MaNXB = tNhaXuatBan.MaNXB
where (TenNXB like N'%Giáo Dục' or TenNXB like N'%Trẻ')
and (DonGiaBan between 90000 and 140000);


/* cau 5 */
select HD.SoHDB, Sum(SLBan * DonGiaBan) as N'Trị giá hóa đơn'
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
join tSach as S on CTHD.MaSach = S.MaSach
where NgayBan = '2014-1-1' or NgayBan = '2014-12-31'
group by HD.SoHDB;


/* cau 6 */
select HD.SoHDB, HD.NgayBan, sum(SLBan * DonGiaBan) as N'Trị giá hóa đơn'
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
join tSach as S on CTHD.MaSach = S.MaSach
and NgayBan between '2014-03-30' and '2014-05-01'
group by HD.SoHDB, NgayBan
order by NgayBan ASC, sum(SLBan * DonGiaBan) DESC;


/* cau 7 */
select KH.MaKH, KH.TenKH
from tKhachHang as KH join tHoaDonBan as HD on KH.MaKH = HD.MaKH
where NgayBan = '2014-04-10';


/* cau 8 */
select HD.SoHDB, sum(SLBan * DonGiaBan) as N'Trị giá hóa đơn'
from tHoaDonBan as HD join tNhanVien as NV on HD.MaNV = NV.MaNV 
join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB 
join tSach as S on CTHD.MaSach = S.MaSach
where TenNV = N'Trần Huy' and NgayBan = '2014-08-11'
group by HD.SoHDB;

/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */

/* Câu 9: In ra danh sách(MaSach, TenSach) được khách hàng có tên là "Nguyễn Đình Sơn" mua trong tháng 8/2014 */
select S.MaSach, S.TenSach
from tSach as S join tChiTietHDB as CTHD on CTHD.MaSach = S.MaSach
join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB 
join tKhachHang as KH on HD.MaKH = KH.MaKH
where TenKH = N'Nguyễn Đình Sơn' and NgayBan between '2014-08-01' and '2014-08-31'

/* Câu 10: Tìm các só hóa đơn đã mua sách "Cấu trúc dữ liệu và giải thuật" */
select HD.SoHDB as N'Số hóa đơn'
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
join tSach as S on CTHD.MaSach = S.MaSach
where TenSach = N'Cấu trúc dữ liệu và giải thuật';


/* Câu 11: Tìm số các hóa đơn đã mua sản phẩm có mã số "S01" hoặc "S02", mỗi sản phẩm mua với số lượng từ 10 đến 20 */
select SoHDB as N'Số hóa đơn'
from tChiTietHDB
where MaSach = 'S01' or MaSach = 'S02' 
and SLBan between 10 and 20;

/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */

/* Câu 12: Tìm các số hóa đơn mua cùng lúc 2 sản phẩm có mã số là "S10" và "S11",
mỗi sản phẩm mua với số lượng từ 5 đến 10 */
select CTHD.SoHDB as N'Số hóa đơn'
from tChiTietHDB as CTHD
join(select SoHDB from tChiTietHDB where MaSach = 'S10' and SLBan between 5 and 10) as SPS10 
on CTHD.SoHDB = SPS10.SoHDB
where MaSach = 'S11';

/* Câu 13: In danh sách các sách không bán được */
select * 
from tSach 
where MaSach != all (select MaSach from tChiTietHDB);


/* Câu 14: In danh sách các sách không được bán trong năm 2014 */
select * 
from tSach
where MaSach != all (select S.MaSach
	from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
	join tSach as S on CTHD.MaSach = S.MaSach 
	where YEAR(NgayBan) = 2014);


/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */
/* Câu 15: In ra danh sách các sách của NXB Giáo dục không bán được trong năm 2014 */
select * 
from tSach as S join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
where MaSach != all (select S.MaSach
	from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
	join tSach as S on CTHD.MaSach = S.MaSach 
	where YEAR(NgayBan) = 2014) and NXB.TenNXB like N'%Giáo dục';
	

/* Câu 16: Tìm số hóa đơn đã mua tất cả các sách của NXB giáo dục */
select HD.SoHDB
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
join tSach as S on CTHD.MaSach = S.MaSach
join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
where TenNXB like N'NXB Giáo dục'
group by HD.SoHDB
having count(S.MaSach) = (select count(S.MaSach)
from tSach as S join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
where NXB.TenNXB like N'NXB Giáo dục')


/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */
/* Câu 17: Có báo nhiêu đầu sách khác nhau được bán ra trong năm 2014 */
select count(A.MaSach) as N'Số đầu sách'
from (select distinct MaSach
	from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
	where year(NgayBan) = 2014) as A


/* 18: Cho biết trị giá hóa đơn cao nhất, thấp nhất là bao nhiêu? */
select max(giaHD) as N'Giá hóa đơn cao nhất', min(giaHD) as N'Giá hóa đơn thấp nhất'
from(
	select CTHD.SoHDB, (SLBan * DonGiaBan) as giaHD
	from tChiTietHDB as CTHD join tSach as S on CTHD.MaSach = S.MaSach
) as A;


/* 19: Trị giá trung bình của tất cả các hóa đơn được bán ra trong năm 2014 là bao nhiêu? */
select avg(giaHD) as N'Giá trị trung bình'
from (
	select CTHD.SoHDB, sum(SLBan * DonGiaBan) as giaHD
	from tChiTietHDB as CTHD join tSach as S on CTHD.MaSach = S.MaSach
	join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB
	where year(ngayban) = 2014
	group by CTHD.SoHDB
) as A;


/* 20: Tính doanh thu bán hàng trong năm 2014 */
select sum(giaHD) as 'Doanh thu 2014'
from ( select CTHD.SoHDB, sum(SLBan * DonGiaBan) as giaHD
	from tChiTietHDB as CTHD join tSach as S on CTHD.MaSach = S.MaSach
	join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB
	where year(ngayban) = 2014
	group by CTHD.SoHDB
) as A;


/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */
/* 21: Tìm số hóa đơn có trị giá cao nhất trong năm 2014 */
select CTHD.SoHDB
from tChiTietHDB as CTHD join tSach as S on CTHD.MaSach = S.MaSach
group by CTHD.SoHDB
having sum(CTHD.SLBan * DonGiaBan) = (select top 1 with ties sum(SLBan * DonGiaBan) as giaHD
	from tChiTietHDB as CTHD join tSach as S on CTHD.MaSach = S.MaSach
	join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB
	where year(ngayban) = 2014
	group by CTHD.SoHDB
	order by giaHD DESC
) 


/* 22: Tìm họ tên khách hàng đã mua hóa đơn có trị giá cao nhất trong năm 2014 */
select TenKH 
from tKhachHang as KH 
join (select CTHD.SoHDB, HD.MaKH
	from tChiTietHDB as CTHD join tSach as S on CTHD.MaSach = S.MaSach
	join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB
	group by CTHD.SoHDB, HD.MaKH
	having sum(CTHD.SLBan * DonGiaBan) = (select top 1 with ties sum(SLBan * DonGiaBan) as giaHD
		from tChiTietHDB as CTHD join tSach as S on CTHD.MaSach = S.MaSach
		join tHoaDonBan as HD on HD.SoHDB = CTHD.SoHDB
		where year(ngayban) = 2014
		group by CTHD.SoHDB
		order by giaHD DESC
	)
) as hdmax on KH.MaKH = hdmax.MaKH


/* 23: In ra danh sách 3 khách hàng (MaKH, TenKH) có doanh số cao nhất */
select top 3 KH.MaKH, KH.TenKH
from tKhachHang as KH join (
	select MaKH, sum(SLBan * DonGiaBan) as GiaTri from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
	join tSach as S on CTHD.MaSach = S.MaSach
	group by MaKH
) as A on KH.MaKH = A.MaKH
order by GiaTri DESC



/* 24: In ra danh sách các sách có giá bán bằng 1 trong 3 mức giá cao nhất */
select MaSach, TenSach
from tSach
where DonGiaBan = any (select distinct top 3 DonGiaBan from tSach order by DonGiaBan DESC)


/* Cau 25: In ra danh sách các sách do NXB Giáo Dục sản xuất có giá bằng 1 trong 3 mức giá cao nhất 
(của tất cả các sản phẩm)*/
select MaSach, TenSach
from tSach
where DonGiaBan = any (select distinct top 3 DonGiaBan from tSach as S 
						join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
						where NXB.TenNXB like N'NXB Giáo Dục'
						order by DonGiaBan DESC)
order by DonGiaBan DESC


/* Cau 26: Tính tổng số đầu sách do NXB Giáo Dục xuất bản */
select count(S.MaSach) as N'Số sách'
from tSach as S join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
where NXB.TenNXB like N'NXB Giáo Dục'


/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */
/* Cau 27: Tính tổng số sách của từng NXB */
select NXB.TenNXB, count(S.MaSach) as N'Số sách'
from tSach as S join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
group by NXB.TenNXB


/* Cau 28: Với từng NXB, tìm giá bán cao nhất, thấp nhất, trung bình của các sản phẩm */
select NXB.TenNXB, max(S.DonGiaBan) as MAX, min(S.DonGiaBan) as MIN, avg(DonGiaBan) as AVG
from tSach as S join tNhaXuatBan as NXB on S.MaNXB = NXB.MaNXB
group by NXB.TenNXB


/* Cau 29: Tính doanh thu bán hàng mỗi ngày */
select HD.NgayBan, sum(SLBan * DonGiaBan)
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
join tSach as S on S.MaSach = CTHD.MaSach
group by HD.NgayBan


/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */
/* Cau 30: Tính tổng số lượng của từng sách bán ra trong tháng 8/2014 */
select CTHD.MaSach, sum(SLBan) as N'Số lượng bán ra'
from tChiTietHDB as CTHD join tHoaDonBan as HD on CTHD.SoHDB = HD.SoHDB
where year(HD.NgayBan) = 2014 and MONTH(HD.NgayBan) = 8
group by CTHD.MaSach


/* Cau 31: Tính doanh thu bán hàng của từng tháng trong năm 2014 
(kể cả những tháng không có doanh thu, VD: Tháng 1: 0; Tháng 2: 12000000; Tháng 3: 0; Tháng ....)*/
select
ISNULL(sum(case Month(NgayBan) when 1 then (SLBan * DonGiaBan) end), 0) as Thang1,
ISNULL(sum(case Month(NgayBan) when 2 then (SLBan * DonGiaBan) end), 0) as Thang2,
ISNULL(sum(case Month(NgayBan) when 3 then (SLBan * DonGiaBan) end), 0) as Thang3,
ISNULL(sum(case Month(NgayBan) when 4 then (SLBan * DonGiaBan) end), 0) as Thang4,
ISNULL(sum(case Month(NgayBan) when 5 then (SLBan * DonGiaBan) end), 0) as Thang5,
ISNULL(sum(case Month(NgayBan) when 6 then (SLBan * DonGiaBan) end), 0) as Thang6,
ISNULL(sum(case Month(NgayBan) when 7 then (SLBan * DonGiaBan) end), 0) as Thang7,
ISNULL(sum(case Month(NgayBan) when 8 then (SLBan * DonGiaBan) end), 0) as Thang8,
ISNULL(sum(case Month(NgayBan) when 9 then (SLBan * DonGiaBan) end), 0) as Thang9,
ISNULL(sum(case Month(NgayBan) when 10 then (SLBan * DonGiaBan) end), 0) as Thang10,
ISNULL(sum(case Month(NgayBan) when 11 then (SLBan * DonGiaBan) end), 0) as Thang11,
ISNULL(sum(case Month(NgayBan) when 12 then (SLBan * DonGiaBan) end), 0) as Thang12
from tSach join tChiTietHDB on tSach.MaSach = tChiTietHDB.MaSach
join tHoaDonBan on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
where YEAR(NgayBan) = 2014 


/* Mai Văn Hiếu - 201200123 - CNTT4 - K61 */
/* Cau 32: Tìm hóa đơn có mua ít nhất 4 sản phẩm khác nhau */
select HD.SoHDB
from tHoaDonBan as HD join tChiTietHDB as CTHD on HD.SoHDB = CTHD.SoHDB
group by HD.SoHDB
having count(MaSach) >= 4



































Select B.MaNXB, TenSach, MaSach,DonGiaBan
from tSach  inner join (select tSach.MaNXB, Max(DonGiaBan) as DonGia		
	from tSach) B on tSach.MaNXB = B.MaNXB 
where DonGiaBan = DonGia




















































































