--View help us to handle the complex queries. 
--it means that when we have a complex join queries so we put into in the view. when we required we simple call the view
--View provides the virtual table



create view ViewJoinStudentLabData
as
select Student_Name,Course,Marks,Lab_Name
from Student join LabDepartment
on student.Lab_Id=Labdepartment.Lab_Id


select * from ViewJoinStudentLabData
