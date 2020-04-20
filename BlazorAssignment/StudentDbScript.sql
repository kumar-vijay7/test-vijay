create database StudentDB
GO
USE [StudentDB]
GO
/****** Object:  Table [dbo].[TblLogin]    Script Date: 21-04-2020 01:52:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLogin](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblNavData]    Script Date: 21-04-2020 01:52:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblNavData](
	[NavID] [int] IDENTITY(1,1) NOT NULL,
	[NavMenuName] [varchar](255) NULL,
	[NavLink] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[NavID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStudent]    Script Date: 21-04-2020 01:52:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStudent](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](255) NULL,
	[StudentGender] [varchar](7) NULL,
	[StudentCourse] [varchar](255) NULL,
	[StudentEmail] [varchar](255) NULL,
	[StudentPhone] [varchar](13) NULL,
	[StudentAddress] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblLogin] ON 
GO
INSERT [dbo].[TblLogin] ([LoginID], [UserName], [Password]) VALUES (1, N'Vijaykr7', N'vijay@123')
GO
SET IDENTITY_INSERT [dbo].[TblLogin] OFF
GO
SET IDENTITY_INSERT [dbo].[TblNavData] ON 
GO
INSERT [dbo].[TblNavData] ([NavID], [NavMenuName], [NavLink]) VALUES (1, N'Question1', N'question1')
GO
INSERT [dbo].[TblNavData] ([NavID], [NavMenuName], [NavLink]) VALUES (2, N'Question2', N'question2')
GO
INSERT [dbo].[TblNavData] ([NavID], [NavMenuName], [NavLink]) VALUES (3, N'Question3', N'question3')
GO
INSERT [dbo].[TblNavData] ([NavID], [NavMenuName], [NavLink]) VALUES (4, N'Question4', N'question4')
GO
INSERT [dbo].[TblNavData] ([NavID], [NavMenuName], [NavLink]) VALUES (5, N'Question5', N'question5')
GO
SET IDENTITY_INSERT [dbo].[TblNavData] OFF
GO
SET IDENTITY_INSERT [dbo].[TblStudent] ON 
GO
INSERT [dbo].[TblStudent] ([StudentID], [StudentName], [StudentGender], [StudentCourse], [StudentEmail], [StudentPhone], [StudentAddress]) VALUES (9, N'Jagpreet ', N'Female', N'MCA', N'jag@gmail.com', N'9876543219', N'Delhi')
GO
INSERT [dbo].[TblStudent] ([StudentID], [StudentName], [StudentGender], [StudentCourse], [StudentEmail], [StudentPhone], [StudentAddress]) VALUES (10, N'Vijay Kumar', N'Male', N'MCA', N'vijay@gmail.com', N'9990377362', N'Delhi')
GO
INSERT [dbo].[TblStudent] ([StudentID], [StudentName], [StudentGender], [StudentCourse], [StudentEmail], [StudentPhone], [StudentAddress]) VALUES (11, N'Abhishek', N'Male', N'Btech', N'Abhi@gmail.com', N'1234567890', N'Allahabad')
GO
INSERT [dbo].[TblStudent] ([StudentID], [StudentName], [StudentGender], [StudentCourse], [StudentEmail], [StudentPhone], [StudentAddress]) VALUES (12, N'Sonal Jha', N'Female', N'Btech', N'sonal@yahoo.com', N'9897968546', N'Banaras')
GO
INSERT [dbo].[TblStudent] ([StudentID], [StudentName], [StudentGender], [StudentCourse], [StudentEmail], [StudentPhone], [StudentAddress]) VALUES (13, N'neha goel', N'Female', N'MCA', N'Neha@gmail.com', N'9632587456', N'Delhi')
GO
SET IDENTITY_INSERT [dbo].[TblStudent] OFF
GO
/****** Object:  StoredProcedure [dbo].[_Usp_StudentAdd]    Script Date: 21-04-2020 01:52:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[_Usp_StudentAdd]
	@SName varchar(255),
	@SGender varchar(7),
	@SCourse varchar(255),
	@SEmail varchar(255),
	@SPhone varchar(13),
	@SAddress varchar(max)
	as
	begin 
		insert into TblStudent
	values(@SName,
	@SGender ,
	@SCourse,
	@SEmail ,
	@SPhone ,
	@SAddress )
	End
GO
/****** Object:  StoredProcedure [dbo].[_Usp_StudentUpdate]    Script Date: 21-04-2020 01:52:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[_Usp_StudentUpdate]
	@SId int,
	@SName varchar(255),
	@SGender varchar(7),
	@SCourse varchar(255),
	@SEmail varchar(255),
	@SPhone varchar(13),
	@SAddress varchar(max)
	as
	begin 
		update TblStudent 
		set
	
	StudentName=@SName,
	StudentGender=@SGender ,
	StudentCourse=@SCourse,
	StudentEmail=@SEmail ,
	StudentPhone=@SPhone ,
	StudentAddress=@SAddress 

	where StudentID=@SId
	End

