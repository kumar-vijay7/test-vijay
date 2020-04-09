create database BootCamp2020
USE [BootCamp2020]
GO
/****** Object:  Table [dbo].[TBL_EMPLOYEES]    Script Date: 10-04-2020 02:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_EMPLOYEES](
	[EMP_ID] [int] IDENTITY(100,1) NOT NULL,
	[EMP_Name] [varchar](50) NULL,
	[EMP_DOB] [datetime2](3) NULL,
	[EMP_SALARY] [money] NULL,
	[Manager_Id] [int] NULL,
	[IsTrainer] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[EMP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_EMPLOYEES] ON 
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (100, N'Sachin', CAST(N'1985-01-01T00:00:00.0000000' AS DateTime2), 20000.0000, NULL, 1)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (101, N'Ashish', CAST(N'1987-05-21T00:00:00.0000000' AS DateTime2), 18000.0000, 100, 1)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (102, N'Sakshi', CAST(N'1989-06-22T00:00:00.0000000' AS DateTime2), 16000.0000, 100, 1)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (103, N'Ritesh', CAST(N'1990-01-22T00:00:00.0000000' AS DateTime2), 12000.0000, 100, 1)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (105, N'Vijay', CAST(N'1993-11-22T00:00:00.0000000' AS DateTime2), 15000.0000, 103, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (106, N'Latika', CAST(N'1996-07-20T00:00:00.0000000' AS DateTime2), 11000.0000, 101, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (107, N'Abhishek', CAST(N'1998-08-18T00:00:00.0000000' AS DateTime2), 13000.0000, 103, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (108, N'Vishesh', CAST(N'1998-05-11T00:00:00.0000000' AS DateTime2), 8000.0000, 101, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (109, N'Shagun', CAST(N'1998-02-15T00:00:00.0000000' AS DateTime2), 10000.0000, 100, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (110, N'Azeem ', CAST(N'1996-02-02T00:00:00.0000000' AS DateTime2), 9000.0000, 101, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (111, N'Sonal', CAST(N'1998-12-18T00:00:00.0000000' AS DateTime2), 7000.0000, 103, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (112, N'Arpit', CAST(N'1996-08-22T00:00:00.0000000' AS DateTime2), 11000.0000, 102, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (113, N'Neha ', CAST(N'1995-08-07T00:00:00.0000000' AS DateTime2), 14000.0000, 102, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (114, N'Punita', CAST(N'1998-06-22T00:00:00.0000000' AS DateTime2), 7000.0000, 102, 0)
GO
INSERT [dbo].[TBL_EMPLOYEES] ([EMP_ID], [EMP_Name], [EMP_DOB], [EMP_SALARY], [Manager_Id], [IsTrainer]) VALUES (128, N'Tushar', CAST(N'1985-01-22T00:00:00.0000000' AS DateTime2), 0.0000, 0, 1)
GO
SET IDENTITY_INSERT [dbo].[TBL_EMPLOYEES] OFF
GO
/****** Object:  StoredProcedure [dbo].[SELF_JOIN]    Script Date: 10-04-2020 02:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELF_JOIN]
AS
BEGIN
SELECT E.EMP_Name,E2.EMP_Name
from TBL_EMPLOYEES E,TBL_EMPLOYEES E2
where E.Manager_Id=E2.EMP_Id
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteEmp]    Script Date: 10-04-2020 02:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_DeleteEmp]
@Emp_name varchar(255)
as
begin
delete from TBL_EMPLOYEES where EMP_Name=@Emp_name;
end
GO
/****** Object:  StoredProcedure [dbo].[usp_FindeMentor]    Script Date: 10-04-2020 02:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_FindeMentor](@mentor int)
as
begin 
select E2.EMP_Name AS MENTOR, E.EMP_Name AS EMPLOYEE from TBL_EMPLOYEES E2,TBL_EMPLOYEES E
where E2.Manager_Id=@mentor
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertEmployee]    Script Date: 10-04-2020 02:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_InsertEmployee]
@Emp_name varchar(255),
@Emp_dob datetime,
@Emp_salary money,
@Manager_Id int,
@IsTrainer bit
as
begin
insert into TBL_EMPLOYEES values(@Emp_name,@Emp_dob,@Emp_salary,@Manager_Id,@IsTrainer)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateEmp]    Script Date: 10-04-2020 02:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_UpdateEmp]
@Emp_name varchar(255),@Salary money
as
begin
update TBL_EMPLOYEES set EMP_SALARY=@Salary where EMP_Name=@Emp_name
end
GO
