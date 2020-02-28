use EmployeeDB
create table Student_Detail(
SD_Id int identity(1,1) primary key,
S_Name varchar(100) not null,
Course varchar(100) not null,
Marks bigint not null,
Mobile varchar(10)
)

---------------------------------------

insert into Student_Detail 
(S_Name,Course,Marks) 
select S_Name,Course,Marks from Student

---------------------------------------
select * from Student_Detail