--user defined scalar function creation

create function getName(@id int)
returns varchar(100)
as
begin
return (select Student_Name  from Student where S_Id=@id)
end
--function creation ends
--function invoke here
print dbo.getName(2)

--user defined table function creation

create function getStudent(@Lab_Id int)
returns table
as
return (select *  from Student where Lab_Id=@Lab_Id)
--user defined table function ends

--user defined table function invoke

select * from getStudent(3)
