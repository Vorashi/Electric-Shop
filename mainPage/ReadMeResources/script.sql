CREATE DATABASE SystemShop
GO
USE [SystemShop]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 09.06.2025 17:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[order_detail_id] [int] NOT NULL,
	[id_order] [int] NOT NULL,
	[id_product] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[order_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 09.06.2025 17:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id_order] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[brand] [varchar](50) NULL,
	[price] [int] NOT NULL,
	[category] [varchar](50) NULL,
	[login] [varchar](50) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 09.06.2025 17:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id_product] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[brand] [varchar](50) NULL,
	[price] [int] NOT NULL,
	[category] [varchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09.06.2025 17:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (1, N'Компьютер', N'MSI', 23000, N'Компьютерное оборудование', N'admin')
INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (2, N'Смартфон HUAWEI nova 11', N'Huawei', 2350, N'Мобильные устройства', N'admin')
INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (3, N'Смартфон HUAWEI nova 11', N'Huawei', 23500, N'Мобильные устройства', N'admin')
INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (4, N'Смарт-часы HUAWEI WATCH GT4 ARA-B19 ', N'Huawei', 10990, N'Смарт-часы', N'admin')
INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (5, N'Компьютер', N'Syt', 23000, N'Компьютерное оборудование', N'admin')
INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (6, N'Компьютер', N'Syt', 23000, N'Компьютерное оборудование', N'admin')
INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (7, N'Компьютер', N'MSI', 23000, N'Компьютерное оборудование', N'admin')
INSERT [dbo].[Orders] ([id_order], [name], [brand], [price], [category], [login]) VALUES (8, N'Компьютер', N'MSI', 23000, N'Компьютерное оборудование', N'admin')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([id_product], [name], [brand], [price], [category]) VALUES (1, N'Смартфон HUAWEI nova 11', N'Huawei', 235000, N'Мобильные устройства')
INSERT [dbo].[Products] ([id_product], [name], [brand], [price], [category]) VALUES (2, N'Компьютер', N'MSI', 23000, N'Компьютерное оборудование')
INSERT [dbo].[Products] ([id_product], [name], [brand], [price], [category]) VALUES (5, N'Realme C51', N'RealMe', 17670, N'Мобильные устройства')
INSERT [dbo].[Products] ([id_product], [name], [brand], [price], [category]) VALUES (6, N'Ноутбук', N'ASUS', 32500, N'Компьютерная техника')
INSERT [dbo].[Products] ([id_product], [name], [brand], [price], [category]) VALUES (7, N'Смарт-часы HUAWEI WATCH GT4 ARA-B19 ', N'Huawei', 10990, N'Смарт-часы')
INSERT [dbo].[Products] ([id_product], [name], [brand], [price], [category]) VALUES (8, N'adsadas', N'adad', 234234, N'dsadsdasd')
INSERT [dbo].[Products] ([id_product], [name], [brand], [price], [category]) VALUES (9, N'Компьютер', N'IBM', 120550, N'Компьютерное оборудование')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id_user], [login], [password], [role]) VALUES (1, N'admin', N'admin', N'Администратор')
INSERT [dbo].[Users] ([id_user], [login], [password], [role]) VALUES (2, N'Demir', N'Demi1902', N'Пользователь')
INSERT [dbo].[Users] ([id_user], [login], [password], [role]) VALUES (3, N'Shar19', N'Shar2019', N'Пользователь')
INSERT [dbo].[Users] ([id_user], [login], [password], [role]) VALUES (4, N'Eder12', N'Fered21', N'Пользователь')
INSERT [dbo].[Users] ([id_user], [login], [password], [role]) VALUES (5, N'Sharov19', N'19SDER', N'Пользователь')
INSERT [dbo].[Users] ([id_user], [login], [password], [role]) VALUES (6, N'vnvnvnv', N'vnvbnvn', N'Пользователь')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([id_order])
REFERENCES [dbo].[Orders] ([id_order])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([id_product])
REFERENCES [dbo].[Products] ([id_product])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
