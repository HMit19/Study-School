use BT1CSDL
go

create function abc (@n int)
returns table
as 
return (
		select top 1 with ties NV.MaNV , NV.TenNV ,sum(SLBan* DonGiaBan) as 'Doanh so' 
		from tNhanVien as NV join tHoaDonBan as HD on NV.MaNV = HD.MaNV 
		join tChiTietHDB as CTHD on CTHD.SoHDB = HD.SoHDB 
		join tSach as S on CTHD.MaSach = S.MaSach
		where year(NgayBan) = @n
		group by NV.MaNV, NV.TenNV
		order by sum(SLBan * DonGiaBan) DESC
		)
select * from abc(2014)

alter function birth(@date datetime)
returns table
as 
return (
	select * from tNhanVien 
	where NgaySinh = @date
	)
select * from birth('1994-05-05')

alter function ton()
returns table
as return (






	select S.MaSach , S.TenSach
	from tHoaDonNhap as HD join tChiTietHDN as CTHD on CTHD.SoHDN = HD.SoHDN 
	join tSach as S on CTHD.MaSach = S.MaSach 
	where (year(getdate()) - year(NgayNhap) between 2 and 1000) and S.MaSach in (
				select S.MaSach 
				from tChiTietHDN as CTHDN join tSach as S on CTHDN.MaSach = S.MaSach 
				join tChiTietHDB as CTHDB on CTHDB.MaSach = S.MaSach
				where (SLNhap - SLBan > 0))



	)

select * from ton()

