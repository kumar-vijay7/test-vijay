create table TBL_EMPLOYEE(
ID int identity(1,1) Primary key,
EmpName varchar(50),
Mobile_Number nvarchar(10) constraint check_mobile check(Mobile_Number like '[6-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
DateOfBirth datetime,
Address varchar(max),
Salary money,
Zip_Code varchar(6) constraint check_zip check(Zip_Code like '[1-9][0-9][0-9][0-9][0-9][0-9]'),
IsActive bit,
CreatedDate DATETIME DEFAULT GetDate(),
ModifiedDate DATETIME DEFAULT GetDate()
)

------------------------Tbl_EmployeeSalary creation-------------------------------------------
create table Tbl_EmployeeSalary(
ID int foreign key references TBL_EMPLOYEE(id),
Salary money
)


----------------------------------------------------------------------------------------------------------------------

select * from Tbl_EmployeeSalary
select * from TBL_EMPLOYEE
--------------------------------------------insert query-------------------------------------------------
insert into TBL_EMPLOYEE
values('Abhishek Srivastav','6325458962',1998-05-18,'Allahabad',null,'202121',1,GETDATE(),GETDATE())
insert into TBL_EMPLOYEE
values('Sonal jha','7894561230',1998-08-28,'Varanasi',null,'123568',1,GETDATE(),GETDATE())

insert into TBL_EMPLOYEE
values('Vishesh Kapoor','8799654236',1997-10-12,'Ghaziabad',null,'101010',1,GETDATE(),GETDATE())

insert into TBL_EMPLOYEE
values('Neha Goel','8779246430',1995-08-08,'Delhi',null,'110002',1,GETDATE(),GETDATE())

insert into TBL_EMPLOYEE
values('Mohd. Azeem','9810234569',1996-09-15,'Delhi',null,'110005',1,GETDATE(),GETDATE())

insert into TBL_EMPLOYEE
values('Aprit','6398756424',1997-12-25,'Noida',null,'202225',1,GETDATE(),GETDATE())

insert into TBL_EMPLOYEE
values('Latika malhotra','9988776644',1995-02-29,'Delhi',null,'110025',1,GETDATE(),GETDATE())

insert into TBL_EMPLOYEE
values('Shagun Gupta','6666777895',1996-03-23,'Faridabad',null,'110036',1,GETDATE(),GETDATE())

insert into TBL_EMPLOYEE
values('Punita Yadav','7825458962',1998-05-27,'Ghaziabad',null,'101010',1,GETDATE(),GETDATE())

------------------------------------------------------------------------------------------------------
------------------insert into tbl_employeeSalary--------------------

insert into Tbl_EmployeeSalary values(2,18000)

insert into Tbl_EmployeeSalary values(2,20000)

insert into Tbl_EmployeeSalary values(2,22000)

insert into Tbl_EmployeeSalary values(3,30000)

insert into Tbl_EmployeeSalary values(3,15000)

insert into Tbl_EmployeeSalary values(4,12000)

insert into Tbl_EmployeeSalary values(4,35000)

insert into Tbl_EmployeeSalary values(5,17000)

insert into Tbl_EmployeeSalary values(5,11000)

insert into Tbl_EmployeeSalary values(6,10000)

insert into Tbl_EmployeeSalary values(6,23000)

insert into Tbl_EmployeeSalary values(7,33000)

insert into Tbl_EmployeeSalary values(7,8000)

insert into Tbl_EmployeeSalary values(9,21000)

insert into Tbl_EmployeeSalary values(9,30000)

insert into Tbl_EmployeeSalary values(10,40000)

insert into Tbl_EmployeeSalary values(10,14000)

insert into Tbl_EmployeeSalary values(11,13000)

insert into Tbl_EmployeeSalary values(11,39000)


---------------------------------------------------------------------------------------------


select TBL_EMPLOYEE.id,Tbl_EmployeeSalary.salary
from TBL_EMPLOYEE 
full outer join Tbl_EmployeeSalary on
TBL_EMPLOYEE.id=Tbl_EmployeeSalary.Id
order by TBL_EMPLOYEE.id

select id,sum(SALARY) as TotalSalary,
count(id)
from Tbl_EmployeeSalary
group by id

update TBL_EMPLOYEE
set 
TBL_EMPLOYEE.Salary= SAL
from TBL_EMPLOYEE join 
(select id,sum(SALARY) as SAL 
from Tbl_EmployeeSalary 
group by id) 
as Tbl_EmployeeSalary on TBL_EMPLOYEE.ID=Tbl_EmployeeSalary.ID

select * from TBL_EMPLOYEE