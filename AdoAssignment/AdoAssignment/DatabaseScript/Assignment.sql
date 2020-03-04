Create database Assignment
GO
USE [Assignment]
GO
/****** Object:  Table [dbo].[Tbl_Product]    Script Date: 04-03-2020 23:52:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Product](
	[p_id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [varchar](255) NOT NULL,
	[Product_Sold] [int] NULL,
	[Left_Product] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_User]    Script Date: 04-03-2020 23:52:32 ******/
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
SET IDENTITY_INSERT [dbo].[Tbl_Product] ON 
GO
INSERT [dbo].[Tbl_Product] ([p_id], [Product_Name], [Product_Sold], [Left_Product]) VALUES (1, N'Laptop', 7, 0)
GO
INSERT [dbo].[Tbl_Product] ([p_id], [Product_Name], [Product_Sold], [Left_Product]) VALUES (2, N'Mobiile', 11, 7)
GO
INSERT [dbo].[Tbl_Product] ([p_id], [Product_Name], [Product_Sold], [Left_Product]) VALUES (3, N'HeadPhone', 3, 8)
GO
INSERT [dbo].[Tbl_Product] ([p_id], [Product_Name], [Product_Sold], [Left_Product]) VALUES (4, N'Bag', 9, 9)
GO
SET IDENTITY_INSERT [dbo].[Tbl_Product] OFF
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
/****** Object:  StoredProcedure [dbo].[sp_product]    Script Date: 04-03-2020 23:52:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_product]
@p_id int , @product_name varchar(100)
as
begin
select Left_Product from Tbl_Product
where p_id like @p_id and Product_Name like @product_name
end
GO
USE [master]
GO
ALTER DATABASE [Assignment] SET  READ_WRITE 
GO
