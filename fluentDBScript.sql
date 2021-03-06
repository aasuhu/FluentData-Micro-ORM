USE [FluentDataDB]
GO
/****** Object:  Table [dbo].[Catagory]    Script Date: 4/12/2019 10:59:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catagory](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Catagory_1] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/12/2019 10:59:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Catagory] ON 

INSERT [dbo].[Catagory] ([CategoryId], [Name]) VALUES (1, N'Mobile')
SET IDENTITY_INSERT [dbo].[Catagory] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [Name], [CategoryId]) VALUES (1, N'LG', 1)
INSERT [dbo].[Product] ([ProductId], [Name], [CategoryId]) VALUES (2, N'Sumsung', 1)
INSERT [dbo].[Product] ([ProductId], [Name], [CategoryId]) VALUES (3, N'Nokia', 1)
INSERT [dbo].[Product] ([ProductId], [Name], [CategoryId]) VALUES (4, N'OPPO', 1)
INSERT [dbo].[Product] ([ProductId], [Name], [CategoryId]) VALUES (6, N'Hawei', 1)
INSERT [dbo].[Product] ([ProductId], [Name], [CategoryId]) VALUES (7, N'A1', 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
