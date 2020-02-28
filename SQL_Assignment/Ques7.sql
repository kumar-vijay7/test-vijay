use EmployeeDB
--------------self join------------------
select * from Student s,Student l
where s.S_Id=l.S_Id

--------------Inner Join-----------------
select * from Student inner join LabDepartment
on student.Lab_Id=Labdepartment.Lab_Id

--------------Left Outer Join -----------
select * from Student left join LabDepartment
on student.Lab_Id=Labdepartment.Lab_Id

--------------Right Outer Join---------------

Select Student_Name,Course,Lab_Name from Student right join LabDepartment
on student.Lab_Id=Labdepartment.Lab_Id
where Lab_Name='Physics'


