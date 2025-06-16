USE [SystemShop]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 06.04.2024 9:12:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Orders]') AND type in (N'U'))
DROP TABLE [dbo].[Orders]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 06.04.2024 9:12:33 ******/
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