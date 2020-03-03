Create Database Assignment
go
USE [Assignment]
GO
/****** Object:  Table [dbo].[Tbl_User]    Script Date: 03-03-2020 15:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Age] [int] NOT NULL,
	[Password] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_User] ON 
GO
INSERT [dbo].[Tbl_User] ([user_id], [UserName], [Email], [Age], [Password]) VALUES (1, N'Vijaykr7', N'vijay_kumar7@gmail.com', 24, N'123456')
GO
INSERT [dbo].[Tbl_User] ([user_id], [UserName], [Email], [Age], [Password]) VALUES (2, N'Abhishek', N'abhishek@ymail.com', 25, N'123')
GO
INSERT [dbo].[Tbl_User] ([user_id], [UserName], [Email], [Age], [Password]) VALUES (3, N'4234234', N'4324@gmail.com', 19, N'123')
GO
SET IDENTITY_INSERT [dbo].[Tbl_User] OFF
GO
