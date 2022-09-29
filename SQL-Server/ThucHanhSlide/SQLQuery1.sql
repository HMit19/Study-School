Declare @n int, @gt int, @i int
Set @n = 10 ; Set @gt = 1; Set @i = 1;
While (@i <= @n)
	begin
		set @gt = @gt * @i;
		set @i = @i + 1;
	end
Print @gt


use BT1_TKCSDL
go
alter table dshs add dtbc float; 
-- tính điểm trung bình trung
-- khai bao con tro 
go


declare hs cursor for select mahs from DSHS
-- su dung con tro
open hs
--khai bao bien 
declare @mahs nvarchar(5), @dtb float
--di chuyen cursor
fetch next from hs into @mahs
while(@@FETCH_STATUS = 0)
	begin
		select @dtb = round((toan*2 + van*2 + hoa + ly)/6, 2)
		from DIEM where MAHS = @mahs
		update DSHS set dtbc = @dtb 
		where MAHS = @mahs
		fetch next from hs into @mahs 
	end
-- xoa con tro
close hs;
-- 
Deallocate hs


CREATE PROCEDURE DiemTrungBinh @mahs nvarchar(5), @dtb float
output
AS
begin
select @dtb=round((toan*2+van*2+ly+hoa)/6, 2) from diem where
MAHS=@mahs
End

--Gọi thủ tục:
declare @tb float
exec DiemTrungBinh '00019', @tb output
print @tb

