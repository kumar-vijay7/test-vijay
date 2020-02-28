create table Student(
S_Id int identity(1,1) primary key,
Student_Name varchar(100) not null,
Course varchar(100) not null,
Marks bigint not null,
Lab_Id int foreign key references LabDepartment(Lab_Id)
)

-------------------------------------------------

insert into Student
values('Vishesh kapoor','B-Tech',80,3)

insert into Student
values('Sonal Jha','B-Tech',75,3)

insert into Student
values('Latika Malhotra','MCA',60,1)

insert into Student
values('Neha Goel','MCA',99,2)

insert into Student
values('Vijay kumar','MCA',95,2)


-------------------------------------------------

exec sp_rename 'Student.Student_name','S_Name'

---------------------------------------------------
select * from Student

------------------------------------------------
