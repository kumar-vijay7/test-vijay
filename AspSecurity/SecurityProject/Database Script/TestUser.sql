create database TestUser
USE [TestUser]
GO
/****** Object:  Table [dbo].[UserRegistration]    Script Date: 17-03-2020 22:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRegistration](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[Mobile] [varchar](10) NULL,
	[Role] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserRegistration] ON 
GO
INSERT [dbo].[UserRegistration] ([UserID], [UserName], [Password], [Mobile], [Role]) VALUES (1, N'vijay kumar', N'123', N'9990377362', N'admin')
GO
INSERT [dbo].[UserRegistration] ([UserID], [UserName], [Password], [Mobile], [Role]) VALUES (2, N'Hena', N'hena123', N'9384756102', N'user')
GO
SET IDENTITY_INSERT [dbo].[UserRegistration] OFF
GO
