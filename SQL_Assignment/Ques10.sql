--in stored procedure we maintain the exeception handling we can use try-catch
--procedure cannot be call from the user defined functions
--stored procedure have input and output parameters

create procedure sp_select_all
as
select * from student
select * from LabDepartment
go

exec sp_select_all

--we cannot maintain the exception handling in functions
--functions can be called from the procedure
--functions only have the input parameters
create function findStudent(@S_Id int)
returns varchar(100)
as
begin
return(select Student_Name from student where S_Id=@S_Id)
end

	print dbo.findStudent(3)