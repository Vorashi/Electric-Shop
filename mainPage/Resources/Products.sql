USE [SystemShop]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06.04.2024 9:12:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06.04.2024 9:12:53 ******/
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