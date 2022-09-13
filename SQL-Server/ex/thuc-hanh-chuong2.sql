create database test

use test;

CREATE TABLE Persons
(
PersonID int,
LastName varchar(255),
FirstName varchar(255),
Address varchar(255),
City varchar(255)
);


exec sp_addlogin hieu, 1905;

use test;

exec sp_adduser hieu, nameuser;

exec sp_addrole namerole;

exec sp_addrolemember namerole, nameuser

grant select, update on Persons to nameuser

grant ALL on Persons to nameuser;

revoke insert on persons from nameuser;

drop login root;