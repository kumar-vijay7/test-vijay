<Query Kind="Expression">
  <Connection>
    <ID>566a0f03-5424-40e1-9dbe-12a12d14d9fd</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-222DMDH\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA5fZVMszwM0K26CZLIf+bIAAAAAACAAAAAAAQZgAAAAEAACAAAACLIfuvPqA/UYinwFy5UVgM8qw8XLgrebU0Lx6LTgeQ8wAAAAAOgAAAAAIAACAAAAD7aW5swupcIGrIvPZCHJ0FHZpX0hmXkYS8Xfmr4emtiBAAAAB5FdRhBQe683e6/BXxPsBBQAAAAPw7waaIuytqwazlGDOHJ1DKvsPPUcGlu+vuXMm1GivXRCnRhU8cRDURgd3yLOAxGNgrCZGlZWwgjOLzweo+Ubw=</Password>
    <Database>EmployeeDB</Database>
  </Connection>
</Query>

from student in Students
join labdepartment in LabDepartments
on student.S_Id equals labdepartment.Lab_Id into LeftJoinTable 
from labdepartment in LeftJoinTable.DefaultIfEmpty()
select new {
student,
labdepartment
}