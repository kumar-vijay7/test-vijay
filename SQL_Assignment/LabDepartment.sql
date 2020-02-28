create table LabDepartment
(
Lab_Id int identity(1,1) primary key,
Lab_Name varchar(150) not null
)

insert into LabDepartment
values('Computer')
insert into LabDepartment
values('Robotics')
insert into LabDepartment
values('Physics')
insert into LabDepartment
values('Checmistry')

select * from LabDepartment