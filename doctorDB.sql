create table dbo.Department(
DepartmentId int identity(1,1),
DepartmentName varchar(500)
)
select * from dbo.Department

insert into dbo.Department Values('Support')

create table dbo.Employee(
EmployeeId int identity(1,1),
EmployeeName varchar(500),
Department varchar(500),
DateOfJoining date,
PhotoFileName varchar(500)
)

select * from dbo.Employee
insert into dbo.Employee values('Elmedin','IT','2022-05-21','img.jpg')

create table dbo.Nurse(
NurseId int identity(1,1),
NurseName varchar(500),
Department varchar(500),
DateOfJoining date,
PhotoFileName varchar(500),
NrDhomes int
)

select * from dbo.Nurse

insert into dbo.Nurse values('Elmedin','IT','2022-05-13','image.png',3)

create table dbo.Admin(
AdminId int identity(1,1),
AdminName varchar(500),
Birthday date,
Vendbanimi varchar(500),
PhotoFileName varchar(500),
Email varchar(500),
AdminPassword varchar(500),
AdminRole varchar(500)
)

select * from dbo.Admin

insert into dbo.Admin values('Elmedin','2002-10-14','Shtime','image.png','elmedin@gmail.com','12345678','Admin')


create table dbo.Dhoma(
DhomaId int identity(1,1),
DhomaName varchar(500),
Department varchar(500),
EmployeeName varchar(500),
NurseName varchar(500),
Slots varchar(500)
)

select * from dbo.Dhoma
insert into dbo.Dhoma values('Elmedin','IT','doctor','nurse name','3/20')