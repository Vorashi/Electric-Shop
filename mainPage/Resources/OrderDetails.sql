USE [SystemShop]
GO

ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Products]
GO

ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Orders]
GO

/****** Object:  Table [dbo].[OrderDetails]    Script Date: 06.04.2024 9:11:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderDetails]') AND type in (N'U'))
DROP TABLE [dbo].[OrderDetails]
GO

/****** Object:  Table [dbo].[OrderDetails]    Script Date: 06.04.2024 9:11:55 ******/
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
