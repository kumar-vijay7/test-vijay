create database EcommerceDB
USE [EcommerceDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF;
GO
USE [EcommerceDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 19-03-2020 18:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](255) NULL,
	[CustomerPhone] [varchar](10) NULL,
	[CustomerEmail] [varchar](200) NULL,
	[CustomerAddresss] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 19-03-2020 18:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[CustomerID] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 19-03-2020 18:15:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhone], [CustomerEmail], [CustomerAddresss]) VALUES (1, N'Vijay Kumar', N'9990377362', N'vijay.kumar1@tothenew.com', N'Delhi')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhone], [CustomerEmail], [CustomerAddresss]) VALUES (2, N'Vishesh Kapoor', N'7289041074', N'vishesh.kapoor@tothenew.com', N'Delhi')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhone], [CustomerEmail], [CustomerAddresss]) VALUES (3, N'Abhishek Srivastava', N'7081580054', N'abhishek.srivastava@tothenew.com', N'Allahabad')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhone], [CustomerEmail], [CustomerAddresss]) VALUES (4, N'Mohd. Azeem', N'8178209298', N'azeem@tothenew.com', N'Delhi')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhone], [CustomerEmail], [CustomerAddresss]) VALUES (5, N'Arpit', N'9634249940', N'arpit@tothenew.com', N'Noida')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhone], [CustomerEmail], [CustomerAddresss]) VALUES (18, N'vivek Kumar', N'9555559789', N'vivekk812@gmail.com', N'Delhi')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (1, 1, 1, 2)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (2, 2, 1, 2)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (3, 4, 2, 5)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (4, 2, 3, 2)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (5, 5, 4, 8)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (6, 3, 4, 1)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (7, 1, 5, 1)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (8, 2, 5, 1)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (9, 1, NULL, 2)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (17, 1, NULL, 2)
GO
INSERT [dbo].[Orders] ([OrderID], [ProductID], [CustomerID], [Quantity]) VALUES (20, 1, 18, 2)
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (1, N'Laptop')
GO
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (2, N'Mobile')
GO
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (3, N'Bag')
GO
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (4, N'Data Cable')
GO
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (5, N'Power Bank')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO

