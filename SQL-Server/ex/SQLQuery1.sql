exec sp_addlogin users, 1905;

use demo;

create user users for login test1User

exec sp_adduser users, testUser;

exec sp_dropuser testUser;

drop user testUser;

exec sp_addrole quyen;

exec sp_addrolemember quyen, testUser;

grant select, update on table_1 to testUser