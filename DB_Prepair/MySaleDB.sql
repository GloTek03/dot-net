USE [master]
GO

CREATE DATABASE [MySaleDB]
GO
USE [MySaleDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Birthdate] [smalldatetime] NOT NULL,
	[Gender] bit NOT NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[UnitPrice] [money] NULL,
	[UnitsInStock] [int] NULL,
	[Image] [nvarchar](max),
	[CategoryID] [int] NULL
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Users](
	[Account] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Gender] bit NOT NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Laptop')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'PC')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Mobile')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Tablet')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock],[Image], [CategoryID]) VALUES (1, N'Laptop Acer', 10.0000, 100,'Acer.jpg', 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock],[Image], [CategoryID]) VALUES (2, N'Printer Sony', 15.5000, 50,'Sony.jpg', 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock],[Image], [CategoryID]) VALUES (3, N'Projector HP', 16.5000, 250,'HP.jpg', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock],[Image], [CategoryID]) VALUES (7, N'Camery Sony', 15.5000, 100,'Sony2.jps', 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock],[Image], [CategoryID]) VALUES (8, N'PC Compact', 20.5000, 100,'Compact.jps', 3)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO

SET IDENTITY_INSERT [dbo].[Customers] ON 
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Birthdate], [Gender], [Address]) VALUES (1, N'Nguyen Van A', '1986-01-01', 1, N'Gia Lâm, Hà Nội')
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Birthdate], [Gender], [Address]) VALUES (2, N'Nguyen Van B', '1990-06-03', 1, N'Lương Sơn, Hòa Bình')
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Birthdate], [Gender], [Address]) VALUES (3, N'Nguyen Thi C', '1985-11-10', 0, N'Sapa, Lào Cai')
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Birthdate], [Gender], [Address]) VALUES (4, N'Nguyen Van D', '2000-01-09', 1, N'Thạch Thất, Hà Nội')
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Birthdate], [Gender], [Address]) VALUES (5, N'Nguyen Thi E', '1996-11-01', 0, N'Lý Nhân, Hà Nam')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO

INSERT [dbo].[Users] ([Account], [Password], [Name], [Gender], [Address]) VALUES ('admin', '123',N'Nguyen Van A', 1, N'Gia Lâm, Hà Nội')
GO

