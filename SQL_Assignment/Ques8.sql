-----------------procedure 1---------------

create procedure sp_procedure1
as
select * from ViewJoinStudentLabData
go
-----------------procedure 1 ends----------

-----------------procedure2 starts---------
create procedure sp_procedure2
as
exec sp_procedure1
go
-----------------procedure2 ends---------
exec sp_procedure2



