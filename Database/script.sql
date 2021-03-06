
IF EXISTS (SELECT * 
	         FROM   master..sysdatabases 
	        WHERE  name = 'JointStockCompany')
BEGIN
 ALTER DATABASE JointStockCompany
 SET SINGLE_USER with ROLLBACK IMMEDIATE
 USE [master]
 DROP DATABASE JointStockCompany
END
GO

CREATE DATABASE JointStockCompany
GO

USE [JointStockCompany]
GO
/****** Object:  Table [dbo].[Bid]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bid](
	[IdBid] [int] IDENTITY(1,1) NOT NULL,
	[IdHolder] [int] NOT NULL,
	[TradeType] [nchar](4) NOT NULL,
	[Date] [date] NOT NULL,
	[ShareBidQty] [int] NOT NULL,
	[ShareType] [nchar](6) NOT NULL,
	[Price] [money] NOT NULL,
	[ExecutedShareBidQty] [int] NOT NULL,
	[Complete] [int] NOT NULL,
	[GuidUser] [uniqueidentifier] NULL,
	[Closed] [int] NULL,
 CONSTRAINT [PK_Bid] PRIMARY KEY CLUSTERED 
(
	[IdBid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DivHolder]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DivHolder](
	[IdDiv] [int] NOT NULL,
	[IdHolder] [int] NOT NULL,
	[CommonShareQty] [int] NOT NULL,
	[PreferShareQty] [int] NOT NULL,
 CONSTRAINT [PK_DivHolder] PRIMARY KEY CLUSTERED 
(
	[IdDiv] ASC,
	[IdHolder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DividendCalculation]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DividendCalculation](
	[IdDiv] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[AmountRevenue] [money] NOT NULL,
	[AllCommonShareQty] [int] NOT NULL,
	[AllPreferShareQty] [int] NOT NULL,
	[AmountOnePrefer] [money] NOT NULL,
	[AmountOneCommon] [money] NOT NULL,
	[Complete] [int] NULL,
 CONSTRAINT [PK_Dividend] PRIMARY KEY CLUSTERED 
(
	[IdDiv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holder]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holder](
	[IdHolder] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[SecondName] [nvarchar](20) NOT NULL,
	[CommonShareQty] [int] NOT NULL,
	[PreferShareQty] [int] NOT NULL,
	[Balance] [money] NOT NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](255) NULL,
 CONSTRAINT [PK_Holders] PRIMARY KEY CLUSTERED 
(
	[IdHolder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderBalance]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderBalance](
	[idOrder] [int] IDENTITY(1,1) NOT NULL,
	[idHolder] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Amount] [money] NOT NULL,
 CONSTRAINT [PK_OrderBalance] PRIMARY KEY CLUSTERED 
(
	[idOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceQuote]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceQuote](
	[Date] [date] NOT NULL,
	[CommonPrice] [money] NOT NULL,
	[PreferPrice] [money] NOT NULL,
 CONSTRAINT [PK_PriceQuote] PRIMARY KEY CLUSTERED 
(
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[PropertyName] [nvarchar](50) NOT NULL,
	[PropertyValue] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[PropertyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trade]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trade](
	[IdTrade] [int] IDENTITY(1,1) NOT NULL,
	[DateTrade] [date] NOT NULL,
	[IdSeller] [int] NOT NULL,
	[IdPurchaser] [int] NOT NULL,
	[ShareQty] [int] NOT NULL,
	[ShareType] [nchar](6) NOT NULL,
	[Price] [money] NOT NULL,
	[NameUser] [nvarchar](30) NULL,
	[Comission] [money] NOT NULL,
 CONSTRAINT [PK_Trade] PRIMARY KEY CLUSTERED 
(
	[IdTrade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_quote]    Script Date: 6/24/2018 9:45:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[view_quote] (datetrade, priceCommon, pricePrefer)
as
with v1 (datetrade, CountCommon, CountPrefer, Price)
-- first set of data
as
(
select (datetrade),
       (iif(ShareType='Common',ShareQty,0)) as  CountCommon,
       (iif(ShareType='Prefer',ShareQty,0)) as  CountPrefer,
	   (Price)
   FROM Trade 
  WHERE datetrade NOT IN (SELECT date
						    FROM PriceQuote)
   ), 
-- second set of data based on first one
v2 (datetrade, amountCommon, countCommon, amountPrefer, CountPrefer)
as
(

SELECT datetrade,
	   sum(v1.CountCommon * v1.Price) as amountCommon,
       sum(v1.CountCommon) as countCommon,
       sum(v1.CountPrefer * v1.Price) as amountPrefer,
	   sum(v1.CountPrefer) as CountPrefer
  FROM v1 
 GROUP BY datetrade
HAVING NOT(DATEDIFF(day, datetrade, GETDATE()) = 0)
)
-- final set of data
 select datetrade,
        case countCommon 
          when 0 then 0
          else amountCommon / countCommon
	    end as PriceCommon,
		case CountPrefer 
          when 0 then 0
          else amountPrefer / CountPrefer
	    end as PricePrefer
 from v2
GO
SET IDENTITY_INSERT [dbo].[Bid] ON 

INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (1, 1, N'buy ', CAST(N'2017-06-12' AS Date), 10, N'common', 98.0000, 10, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (2, 1, N'sale', CAST(N'2017-12-25' AS Date), 10, N'prefer', 100.0000, 10, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (3, 2, N'buy ', CAST(N'2018-02-07' AS Date), 15, N'common', 99.0000, 15, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (4, 3, N'sale', CAST(N'2018-02-10' AS Date), 10, N'common', 99.0000, 5, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (5, 3, N'buy ', CAST(N'2018-02-10' AS Date), 50, N'common', 98.0000, 26, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (6, 3, N'buy ', CAST(N'2018-02-11' AS Date), 50, N'common', 98.0000, 6, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (7, 8, N'sale', CAST(N'2018-02-20' AS Date), 5, N'common', 100.0000, 5, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (8, 8, N'buy ', CAST(N'2018-03-04' AS Date), 9, N'common', 97.5000, 2, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (9, 7, N'sale', CAST(N'2018-03-14' AS Date), 115, N'prefer', 100.0000, 32, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (10, 8, N'sale', CAST(N'2018-04-03' AS Date), 11, N'common', 101.0000, 11, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (11, 10, N'buy ', CAST(N'2018-04-03' AS Date), 10, N'prefer', 101.0000, 10, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (12, 12, N'buy ', CAST(N'2018-04-03' AS Date), 30, N'prefer', 101.0000, 30, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (13, 3, N'sale', CAST(N'2018-04-08' AS Date), 50, N'common', 100.5500, 50, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (16, 6, N'sale', CAST(N'2018-04-08' AS Date), 15, N'common', 101.0000, 15, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (17, 15, N'sale', CAST(N'2018-04-08' AS Date), 10, N'common', 105.0000, 10, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (18, 6, N'buy ', CAST(N'2018-04-08' AS Date), 20, N'common', 104.0000, 20, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (19, 18, N'sale', CAST(N'2018-04-08' AS Date), 40, N'prefer', 103.0000, 40, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (20, 10, N'sale', CAST(N'2018-04-08' AS Date), 30, N'common', 104.0000, 30, 1, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (21, 16, N'buy ', CAST(N'2018-04-18' AS Date), 0, N'common', 104.0000, 0, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (22, 18, N'buy ', CAST(N'2018-04-19' AS Date), 10, N'common', 101.0000, 0, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (23, 18, N'sale', CAST(N'2018-04-19' AS Date), 0, N'common', 98.0000, 0, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (24, 18, N'sale', CAST(N'2018-04-19' AS Date), 0, N'common', 98.0000, 0, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (25, 3, N'sale', CAST(N'2018-04-20' AS Date), 50, N'common', 103.5000, 20, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (26, 7, N'buy ', CAST(N'2018-04-20' AS Date), 10, N'common', 102.0000, 0, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (27, 16, N'sale', CAST(N'2018-04-21' AS Date), 40, N'prefer', 104.0000, 15, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (28, 1, N'sale', CAST(N'2018-04-28' AS Date), 63, N'common', 0.0000, 0, 0, NULL, 1)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (29, 10, N'sale', CAST(N'2018-06-24' AS Date), 33, N'common', 100.5500, 0, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (30, 7, N'buy ', CAST(N'2018-06-24' AS Date), 15, N'common', 102.0000, 0, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (31, 14, N'sale', CAST(N'2018-06-24' AS Date), 45, N'common', 108.0000, 10, 0, NULL, 0)
INSERT [dbo].[Bid] ([IdBid], [IdHolder], [TradeType], [Date], [ShareBidQty], [ShareType], [Price], [ExecutedShareBidQty], [Complete], [GuidUser], [Closed]) VALUES (32, 12, N'buy ', CAST(N'2018-06-24' AS Date), 40, N'prefer', 102.0000, 0, 0, NULL, 0)
SET IDENTITY_INSERT [dbo].[Bid] OFF
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 1, 57, 60)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 2, 28, 13)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 3, 995, 710)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 4, 39, 100)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 6, 29, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 7, 3, 108)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 8, 11, 4)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 10, 58, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 11, 0, 204)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 12, 105, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 14, 45, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 15, 77, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 16, 0, 300)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 17, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 18, 0, 40)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 19, 0, 45)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 20, 36, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 21, 0, 128)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 22, 15, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (13, 23, 16, 17)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 1, 57, 60)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 2, 28, 13)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 3, 995, 710)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 4, 39, 100)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 6, 29, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 7, 3, 107)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 8, 11, 5)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 10, 58, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 11, 0, 204)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 12, 105, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 14, 45, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 15, 77, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 16, 0, 300)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 17, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 18, 0, 40)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 19, 0, 45)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 20, 36, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 21, 0, 128)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 22, 15, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (14, 23, 16, 17)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 1, 63, 60)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 2, 38, 8)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 3, 984, 710)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 4, 54, 90)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 6, 27, 9)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 7, 0, 73)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 8, 0, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 10, 63, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 11, 7, 204)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 12, 95, 40)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 14, 45, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 15, 67, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 16, 0, 300)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 17, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 18, 0, 35)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 19, 0, 45)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 20, 36, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 21, 0, 128)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 22, 15, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 23, 16, 17)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 24, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (15, 26, 19, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 1, 63, 70)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 2, 38, 8)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 3, 951, 710)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 4, 54, 90)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 6, 34, 9)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 7, 0, 73)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 8, 10, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 10, 33, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 11, 30, 204)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 12, 95, 40)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 14, 45, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 15, 67, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 16, 0, 305)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 17, 23, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 19, 15, 55)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 20, 36, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 21, 0, 128)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 22, 5, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 23, 21, 17)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 24, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 26, 19, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (19, 27, 0, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 1, 63, 70)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 2, 38, 8)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 3, 956, 710)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 4, 59, 95)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 6, 44, 9)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 7, 0, 68)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 8, 0, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 10, 33, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 11, 20, 204)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 12, 95, 40)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 14, 45, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 15, 67, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 16, 0, 290)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 17, 23, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 19, 15, 55)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 20, 36, 0)
GO
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 21, 0, 128)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 22, 5, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 23, 21, 17)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 24, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 25, 0, 15)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 26, 19, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (20, 27, 0, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 1, 63, 70)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 2, 38, 8)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 3, 956, 710)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 4, 59, 95)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 6, 44, 9)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 7, 0, 68)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 8, 0, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 10, 43, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 11, 20, 204)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 12, 95, 40)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 14, 35, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 15, 67, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 16, 0, 290)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 17, 23, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 19, 15, 55)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 20, 36, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 21, 0, 128)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 22, 5, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 23, 21, 17)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 24, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 25, 0, 15)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 26, 19, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (21, 27, 0, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 1, 63, 70)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 2, 38, 8)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 3, 956, 710)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 4, 59, 95)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 6, 44, 9)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 7, 0, 68)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 8, 0, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 10, 43, 10)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 11, 20, 204)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 12, 95, 40)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 14, 35, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 15, 67, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 16, 0, 290)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 17, 23, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 19, 15, 55)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 20, 36, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 21, 0, 128)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 22, 5, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 23, 21, 17)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 24, 10, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 25, 0, 15)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 26, 19, 0)
INSERT [dbo].[DivHolder] ([IdDiv], [IdHolder], [CommonShareQty], [PreferShareQty]) VALUES (22, 27, 0, 10)
SET IDENTITY_INSERT [dbo].[DividendCalculation] ON 

INSERT [dbo].[DividendCalculation] ([IdDiv], [Date], [AmountRevenue], [AllCommonShareQty], [AllPreferShareQty], [AmountOnePrefer], [AmountOneCommon], [Complete]) VALUES (13, CAST(N'2018-03-19' AS Date), 39992.5600, 1549, 1739, 11.0000, 13.6900, 1)
INSERT [dbo].[DividendCalculation] ([IdDiv], [Date], [AmountRevenue], [AllCommonShareQty], [AllPreferShareQty], [AmountOnePrefer], [AmountOneCommon], [Complete]) VALUES (14, CAST(N'2018-03-21' AS Date), 10002.3600, 1549, 1739, 3.0000, 3.1400, 1)
INSERT [dbo].[DividendCalculation] ([IdDiv], [Date], [AmountRevenue], [AllCommonShareQty], [AllPreferShareQty], [AmountOnePrefer], [AmountOneCommon], [Complete]) VALUES (15, CAST(N'2018-04-11' AS Date), 4993.9600, 1549, 1739, 1.5000, 1.5400, 1)
INSERT [dbo].[DividendCalculation] ([IdDiv], [Date], [AmountRevenue], [AllCommonShareQty], [AllPreferShareQty], [AmountOnePrefer], [AmountOneCommon], [Complete]) VALUES (19, CAST(N'2018-04-20' AS Date), 9989.9800, 1549, 1739, 3.5000, 2.5200, 1)
INSERT [dbo].[DividendCalculation] ([IdDiv], [Date], [AmountRevenue], [AllCommonShareQty], [AllPreferShareQty], [AmountOnePrefer], [AmountOneCommon], [Complete]) VALUES (20, CAST(N'2018-06-24' AS Date), 10003.4100, 1549, 1739, 3.0000, 3.0900, 1)
INSERT [dbo].[DividendCalculation] ([IdDiv], [Date], [AmountRevenue], [AllCommonShareQty], [AllPreferShareQty], [AmountOnePrefer], [AmountOneCommon], [Complete]) VALUES (21, CAST(N'2018-06-24' AS Date), 10003.4100, 1549, 1739, 3.0000, 3.0900, 1)
INSERT [dbo].[DividendCalculation] ([IdDiv], [Date], [AmountRevenue], [AllCommonShareQty], [AllPreferShareQty], [AmountOnePrefer], [AmountOneCommon], [Complete]) VALUES (22, CAST(N'2018-06-24' AS Date), 0.0000, 1549, 1739, 0.0000, 0.0000, 0)
SET IDENTITY_INSERT [dbo].[DividendCalculation] OFF
SET IDENTITY_INSERT [dbo].[Holder] ON 

INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (1, N'Andrey', N'Pirson', 63, 70, 3719.8300, N'380506333333', N'pirson@gmail.com')
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (2, N'Adam                ', N'Smith               ', 38, 8, 1333.4400, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (3, N'Bill', N'Geits', 956, 710, 97628.0900, N'4906056714', NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (4, N'Tom', N'Sojer', 59, 95, 5345.6900, N'380104565212', N'me@gmail.com')
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (6, N'Konrad', N'Brosman', 44, 9, 4476.0900, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (7, N'Ann', N'Balloc', 0, 68, 5320.9800, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (8, N'Willy               ', N'Price               ', 0, 10, 3431.4700, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (10, N'Andrey              ', N'Simpson             ', 43, 10, 3301.4100, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (11, N'Andrey              ', N'Hopkins             ', 20, 204, 9699.1900, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (12, N'Andrey              ', N'Walker              ', 95, 40, 5368.3600, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (14, N'Fill                ', N'Walker              ', 35, 0, 3679.3500, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (15, N'Jane                ', N'Pirson              ', 67, 0, 4435.6500, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (16, N'Mary                ', N'Popins              ', 0, 290, 17503.7800, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (17, N'Tim                 ', N'Kardigan            ', 23, 0, 1412.3200, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (18, N'Garry', N'Trumen', 0, 0, 11583.0600, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (19, N'Bill                ', N'Clinton             ', 15, 55, 910.5000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (20, N'Garry               ', N'Leman               ', 36, 0, 3758.2000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (21, N'Sam                 ', N'Torbins             ', 0, 128, 15804.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (22, N'Philip              ', N'Baggins             ', 5, 0, 2606.2600, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (23, N'Lane                ', N'Parkinson           ', 21, 17, 1849.7000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (24, N'Nick                ', N'Garrison            ', 10, 0, 9052.4000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (25, N'Lane                ', N'Brosman             ', 0, 15, 3530.0000, NULL, N'i@gmail.com')
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (26, N'Garry               ', N'Marple              ', 19, 0, 291.3800, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (27, N'Tim', N'Nikman', 0, 10, 3095.0000, N'380500004545', NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (28, N'David', N'Ligman', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (29, N'dddd', N'ffffffff', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (30, N'dad', N'dfg', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (32, N'fffffff', N'ggg', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (33, N'nnn', N'hghg', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (34, N'aaaaaaa', N'hhhh', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (35, N'bbbb', N'cccc', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (36, N'zgfszhjzgjmgmxfmxfhm', N'dbgdzbzx', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (37, N'hjhj', N'dsdgfsg', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (38, N'Garry', N'Hopkins', 0, 0, 0.0000, NULL, NULL)
INSERT [dbo].[Holder] ([IdHolder], [FirstName], [SecondName], [CommonShareQty], [PreferShareQty], [Balance], [Phone], [Email]) VALUES (39, N'aaaa', N'dddd', 0, 0, 0.0000, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Holder] OFF
SET IDENTITY_INSERT [dbo].[OrderBalance] ON 

INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (1, 3, CAST(N'2017-10-12' AS Date), 525.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (2, 6, CAST(N'2017-11-12' AS Date), 300.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (3, 3, CAST(N'2017-11-12' AS Date), -500.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (4, 3, CAST(N'2017-12-12' AS Date), 600.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (5, 4, CAST(N'2018-03-22' AS Date), -1200.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (6, 7, CAST(N'2018-03-22' AS Date), -2500.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (7, 7, CAST(N'2018-03-22' AS Date), -1000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (8, 3, CAST(N'2018-03-23' AS Date), 300.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (9, 18, CAST(N'2018-04-10' AS Date), 5000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (10, 4, CAST(N'2018-03-22' AS Date), -1300.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (11, 10, CAST(N'2018-03-22' AS Date), -200.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (12, 1, CAST(N'2018-03-24' AS Date), -2000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (13, 17, CAST(N'2018-04-10' AS Date), 2000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (14, 15, CAST(N'2018-04-10' AS Date), -2000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (15, 7, CAST(N'2018-04-20' AS Date), -2000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (16, 6, CAST(N'2018-04-20' AS Date), 5000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (17, 8, CAST(N'2018-04-21' AS Date), 3000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (18, 3, CAST(N'2018-06-21' AS Date), -1000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (19, 1, CAST(N'2018-06-21' AS Date), -1000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (20, 8, CAST(N'2018-06-22' AS Date), -1000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (21, 10, CAST(N'2018-06-22' AS Date), -500.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (22, 7, CAST(N'2018-06-22' AS Date), -2000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (23, 3, CAST(N'2018-06-22' AS Date), -10000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (24, 3, CAST(N'2018-06-22' AS Date), -1000.0000)
INSERT [dbo].[OrderBalance] ([idOrder], [idHolder], [Date], [Amount]) VALUES (25, 3, CAST(N'2018-06-22' AS Date), -2000.0000)
SET IDENTITY_INSERT [dbo].[OrderBalance] OFF
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-01-01' AS Date), 95.0000, 95.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-01' AS Date), 98.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-02' AS Date), 99.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-03' AS Date), 99.5000, 101.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-04' AS Date), 100.0000, 101.6000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-05' AS Date), 99.8000, 102.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-06' AS Date), 96.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-10' AS Date), 0.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-11' AS Date), 99.0000, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-26' AS Date), 99.0000, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-02-28' AS Date), 0.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-03-03' AS Date), 98.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-03-04' AS Date), 98.5700, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-03-08' AS Date), 98.0000, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-03-14' AS Date), 0.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-03-20' AS Date), 0.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-03-28' AS Date), 98.0000, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-03-31' AS Date), 0.0000, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-03' AS Date), 101.0000, 101.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-08' AS Date), 99.8300, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-09' AS Date), 101.5900, 101.2500)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-10' AS Date), 105.0000, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-12' AS Date), 0.0000, 103.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-13' AS Date), 102.0000, 103.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-15' AS Date), 104.0000, 103.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-18' AS Date), 100.5500, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-20' AS Date), 102.2500, 100.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-21' AS Date), 0.0000, 104.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-04-29' AS Date), 98.0000, 0.0000)
INSERT [dbo].[PriceQuote] ([Date], [CommonPrice], [PreferPrice]) VALUES (CAST(N'2018-06-02' AS Date), 103.5000, 100.0000)
INSERT [dbo].[Settings] ([PropertyName], [PropertyValue]) VALUES (N'EmissionDate', N'2018-01-01')
INSERT [dbo].[Settings] ([PropertyName], [PropertyValue]) VALUES (N'NameCompany', N'Mounting Company')
INSERT [dbo].[Settings] ([PropertyName], [PropertyValue]) VALUES (N'TradeComission', N'0.015')
SET IDENTITY_INSERT [dbo].[Trade] ON 

INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (1, CAST(N'2018-02-03' AS Date), 1, 2, 10, N'common', 98.0000, N'User1', 5.0000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (2, CAST(N'2018-02-03' AS Date), 2, 3, 15, N'prefer', 99.5000, N'User2', 10.0000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (4, CAST(N'2018-02-03' AS Date), 3, 1, 20, N'common', 98.7000, N'User1', 12.0000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (5, CAST(N'2018-02-04' AS Date), 4, 6, 10, N'common', 97.0000, N'User2', 8.5000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (6, CAST(N'2018-02-04' AS Date), 7, 3, 15, N'prefer', 97.8000, N'User1', 11.0000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (7, CAST(N'2018-02-05' AS Date), 2, 4, 20, N'common', 99.0000, N'User1', 12.3000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (8, CAST(N'2018-02-10' AS Date), 1, 3, 3, N'prefer', 100.0000, N'User2', 2.1000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (9, CAST(N'2018-02-11' AS Date), 3, 7, 2, N'common', 99.0000, N'User1', 1.5000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (10, CAST(N'2018-02-26' AS Date), 3, 2, 3, N'common', 99.0000, N'User1', 1.2000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (11, CAST(N'2018-02-28' AS Date), 1, 3, 5, N'prefer', 100.0000, N'User2', 1.5000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (12, CAST(N'2018-03-03' AS Date), 1, 3, 2, N'prefer', 100.0000, N'User2', 1.2000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (13, CAST(N'2018-03-03' AS Date), 6, 1, 1, N'common', 98.0000, N'User1', 1.3000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (14, CAST(N'2018-03-03' AS Date), 4, 1, 1, N'common', 98.0000, N'User3', 1.4000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (15, CAST(N'2018-03-03' AS Date), 7, 1, 1, N'common', 98.0000, N'User3', 1.2500)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (16, CAST(N'2018-03-03' AS Date), 1, 3, 2, N'common', 98.0000, N'User4', 1.3300)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (17, CAST(N'2018-03-03' AS Date), 7, 3, 4, N'common', 98.0000, N'User4', 4.7000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (18, CAST(N'2018-03-04' AS Date), 3, 2, 5, N'common', 99.0000, N'User3', 5.9400)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (19, CAST(N'2018-03-04' AS Date), 10, 8, 2, N'common', 97.5000, N'User3', 2.3400)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (20, CAST(N'2018-03-08' AS Date), 3, 1, 2, N'common', 98.0000, N'User2', 2.3500)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (21, CAST(N'2018-03-08' AS Date), 3, 1, 3, N'common', 98.0000, N'User3', 3.5200)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (22, CAST(N'2018-03-08' AS Date), 3, 1, 1, N'common', 98.0000, N'User1', 1.1700)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (23, CAST(N'2018-03-14' AS Date), 7, 8, 4, N'prefer', 100.0000, N'User2', 4.8000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (24, CAST(N'2018-03-14' AS Date), 7, 2, 3, N'prefer', 100.0000, N'User3', 3.6000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (25, CAST(N'2018-03-20' AS Date), 7, 8, 1, N'prefer', 100.0000, N'User2', 1.2000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (26, CAST(N'2018-03-28' AS Date), 26, 3, 1, N'common', 98.0000, N'User3', 1.1800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (27, CAST(N'2018-03-31' AS Date), 7, 6, 2, N'prefer', 100.0000, N'User3', 2.4000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (28, CAST(N'2018-04-03' AS Date), 4, 10, 10, N'prefer', 101.0000, N'User3', 12.1200)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (29, CAST(N'2018-04-03' AS Date), 7, 12, 25, N'prefer', 101.0000, N'User3', 30.3000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (30, CAST(N'2018-04-03' AS Date), 8, 4, 11, N'common', 101.0000, N'User2', 13.3300)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (31, CAST(N'2018-04-03' AS Date), 2, 12, 5, N'prefer', 101.0000, N'User2', 6.0600)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (32, CAST(N'2018-04-08' AS Date), 8, 1, 5, N'common', 100.0000, N'User1', 6.0000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (33, CAST(N'2018-04-08' AS Date), 4, 1, 1, N'common', 98.0000, N'User1', 1.1800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (34, CAST(N'2018-04-08' AS Date), 12, 2, 10, N'common', 99.0000, N'User1', 11.8800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (35, CAST(N'2018-04-08' AS Date), 3, 4, 5, N'common', 100.5500, N'User1', 6.0300)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (36, CAST(N'2018-04-08' AS Date), 6, 10, 5, N'common', 101.0000, N'User1', 6.0600)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (37, CAST(N'2018-04-09' AS Date), 18, 8, 5, N'prefer', 103.0000, N'User2', 6.1800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (38, CAST(N'2018-04-09' AS Date), 7, 6, 7, N'prefer', 100.0000, N'User2', 8.4000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (39, CAST(N'2018-04-09' AS Date), 3, 11, 7, N'common', 100.5500, N'User2', 8.4500)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (40, CAST(N'2018-04-09' AS Date), 7, 6, 3, N'common', 104.0000, N'User2', 3.7400)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (41, CAST(N'2018-04-10' AS Date), 15, 24, 10, N'common', 105.0000, N'User1', 12.6000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (42, CAST(N'2018-04-12' AS Date), 18, 16, 5, N'prefer', 103.0000, N'User1', 6.1800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (43, CAST(N'2018-04-13' AS Date), 18, 1, 10, N'prefer', 103.0000, N'User1', 12.3600)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (44, CAST(N'2018-04-13' AS Date), 18, 19, 10, N'prefer', 103.0000, N'User1', 12.3600)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (45, CAST(N'2018-04-13' AS Date), 10, 19, 10, N'common', 104.0000, N'User1', 12.4800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (46, CAST(N'2018-04-13' AS Date), 17, 3, 5, N'common', 98.0000, N'User3', 5.8800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (47, CAST(N'2018-04-13' AS Date), 6, 17, 10, N'common', 101.0000, N'User1', 12.1200)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (48, CAST(N'2018-04-13' AS Date), 10, 23, 5, N'common', 104.0000, N'User1', 6.2400)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (49, CAST(N'2018-04-15' AS Date), 18, 7, 10, N'prefer', 103.0000, N'User1', 12.3600)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (50, CAST(N'2018-04-15' AS Date), 10, 8, 10, N'common', 104.0000, N'User1', 12.4800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (51, CAST(N'2018-04-18' AS Date), 3, 17, 8, N'common', 100.5500, N'User1', 9.6500)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (52, CAST(N'2018-04-20' AS Date), 7, 27, 10, N'prefer', 100.0000, N'User1', 12.0000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (53, CAST(N'2018-04-20' AS Date), 3, 11, 30, N'common', 100.5500, N'User1', 36.2000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (54, CAST(N'2018-04-20' AS Date), 10, 19, 5, N'common', 104.0000, N'User1', 6.2400)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (55, CAST(N'2018-04-20' AS Date), 22, 6, 10, N'common', 104.0000, N'User1', 12.4800)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (56, CAST(N'2018-04-20' AS Date), 11, 6, 7, N'common', 104.0000, N'User1', 8.7400)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (57, CAST(N'2018-04-20' AS Date), 3, 6, 10, N'common', 103.5000, N'User1', 12.4200)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (58, CAST(N'2018-04-21' AS Date), 16, 25, 15, N'prefer', 104.0000, N'User1', 18.7200)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (59, CAST(N'2018-04-29' AS Date), 8, 3, 10, N'common', 98.0000, N'User1', 14.7000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (60, CAST(N'2018-06-02' AS Date), 7, 4, 5, N'prefer', 100.0000, N'User1', 7.5000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (61, CAST(N'2018-06-02' AS Date), 3, 4, 5, N'common', 103.5000, N'User1', 7.7600)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (62, CAST(N'2018-06-24' AS Date), 11, 3, 10, N'common', 98.0000, N'User1', 14.7000)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (63, CAST(N'2018-06-24' AS Date), 3, 3, 5, N'common', 103.5000, N'User1', 7.7600)
INSERT [dbo].[Trade] ([IdTrade], [DateTrade], [IdSeller], [IdPurchaser], [ShareQty], [ShareType], [Price], [NameUser], [Comission]) VALUES (64, CAST(N'2018-06-24' AS Date), 14, 10, 10, N'common', 108.0000, N'User1', 16.2000)
SET IDENTITY_INSERT [dbo].[Trade] OFF
/****** Object:  Index [IX_Common]    Script Date: 6/24/2018 9:45:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Common] ON [dbo].[Holder]
(
	[CommonShareQty] ASC,
	[IdHolder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FirstName]    Script Date: 6/24/2018 9:45:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_FirstName] ON [dbo].[Holder]
(
	[FirstName] ASC,
	[IdHolder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Prefer]    Script Date: 6/24/2018 9:45:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Prefer] ON [dbo].[Holder]
(
	[PreferShareQty] ASC,
	[IdHolder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SecondName]    Script Date: 6/24/2018 9:45:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_SecondName] ON [dbo].[Holder]
(
	[SecondName] ASC,
	[IdHolder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DateTrade]    Script Date: 6/24/2018 9:45:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_DateTrade] ON [dbo].[Trade]
(
	[DateTrade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Purchaser]    Script Date: 6/24/2018 9:45:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Purchaser] ON [dbo].[Trade]
(
	[IdPurchaser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Seller]    Script Date: 6/24/2018 9:45:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Seller] ON [dbo].[Trade]
(
	[IdSeller] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bid]  WITH CHECK ADD  CONSTRAINT [FK_Bid_Holders] FOREIGN KEY([IdHolder])
REFERENCES [dbo].[Holder] ([IdHolder])
GO
ALTER TABLE [dbo].[Bid] CHECK CONSTRAINT [FK_Bid_Holders]
GO
ALTER TABLE [dbo].[DivHolder]  WITH CHECK ADD  CONSTRAINT [FK_DivHolder_DividendCalculation] FOREIGN KEY([IdDiv])
REFERENCES [dbo].[DividendCalculation] ([IdDiv])
GO
ALTER TABLE [dbo].[DivHolder] CHECK CONSTRAINT [FK_DivHolder_DividendCalculation]
GO
ALTER TABLE [dbo].[DivHolder]  WITH CHECK ADD  CONSTRAINT [FK_DivHolder_Holder] FOREIGN KEY([IdHolder])
REFERENCES [dbo].[Holder] ([IdHolder])
GO
ALTER TABLE [dbo].[DivHolder] CHECK CONSTRAINT [FK_DivHolder_Holder]
GO
ALTER TABLE [dbo].[OrderBalance]  WITH CHECK ADD  CONSTRAINT [FK_OrderBalance_Holder1] FOREIGN KEY([idHolder])
REFERENCES [dbo].[Holder] ([IdHolder])
GO
ALTER TABLE [dbo].[OrderBalance] CHECK CONSTRAINT [FK_OrderBalance_Holder1]
GO
ALTER TABLE [dbo].[Trade]  WITH CHECK ADD  CONSTRAINT [FK_TradePurchaser_Holder] FOREIGN KEY([IdPurchaser])
REFERENCES [dbo].[Holder] ([IdHolder])
GO
ALTER TABLE [dbo].[Trade] CHECK CONSTRAINT [FK_TradePurchaser_Holder]
GO
ALTER TABLE [dbo].[Trade]  WITH CHECK ADD  CONSTRAINT [FK_TradeSeller_Holder] FOREIGN KEY([IdSeller])
REFERENCES [dbo].[Holder] ([IdHolder])
GO
ALTER TABLE [dbo].[Trade] CHECK CONSTRAINT [FK_TradeSeller_Holder]
GO
/****** Object:  Trigger [dbo].[Update_Bid]    Script Date: 6/24/2018 9:45:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[Update_Bid]
   ON  [dbo].[Bid] 
      AFTER UPDATE
AS 
BEGIN
IF UPDATE (GuidUser)
BEGIN
   DECLARE @GuidUserNew uniqueidentifier
   DECLARE @GuidUserOld uniqueidentifier
   SET @GuidUserOld = (SELECT GuidUSER FROM deleted)
   SET @GuidUserNew = (SELECT GuidUSER FROM inserted)
   IF NOT(@GuidUserOld IS NULL OR @GuidUserNew IS NULL OR @GuidUserOld = @GuidUserNew) 
      BEGIN
	     RAISERROR ('The Bid is processed by another user.', -- Message text.  
               16, -- Severity.  
               1 -- State.  
               ) 
      END
END
	SET NOCOUNT ON;

    -- Insert statements for trigger here

END
GO
ALTER TABLE [dbo].[Bid] ENABLE TRIGGER [Update_Bid]
GO
/****** Object:  Trigger [dbo].[Update_Holders_Account]    Script Date: 6/24/2018 9:45:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[Update_Holders_Account] 
   ON  [dbo].[Holder] 
   AFTER UPDATE
AS 
BEGIN
IF ((SELECT COUNT(*) FROM inserted WHERE Balance < 0 ) > 0)
  BEGIN
	    RAISERROR ('Not enough currency on holder account', -- Message text.  
               16, -- Severity.  
               1 -- State.  
               ) 

   END
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

END
GO
ALTER TABLE [dbo].[Holder] ENABLE TRIGGER [Update_Holders_Account]
GO
/****** Object:  Trigger [dbo].[Update_Holders_Shares]    Script Date: 6/24/2018 9:45:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[Update_Holders_Shares] 
   ON  [dbo].[Holder] 
   AFTER UPDATE
AS 
BEGIN
IF ((SELECT COUNT(*) FROM inserted WHERE CommonShareQty < 0 OR  PreferShareQty < 0) > 0) 
   BEGIN
	    RAISERROR ('Share quantity for trade is too large. Refresh data.', -- Message text.  
               16, -- Severity.  
               1 -- State.  
               ) 

   END
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

END
GO
ALTER TABLE [dbo].[Holder] ENABLE TRIGGER [Update_Holders_Shares]
GO
