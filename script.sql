USE [master]
GO
/****** Object:  Database [HomeLess]    Script Date: 12/5/2018 1:44:02 AM ******/
CREATE DATABASE [HomeLess]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HomeLess', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HomeLess.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HomeLess_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HomeLess_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HomeLess] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeLess].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeLess] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeLess] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeLess] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeLess] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeLess] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeLess] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeLess] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeLess] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeLess] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeLess] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeLess] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeLess] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeLess] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeLess] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeLess] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeLess] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeLess] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeLess] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeLess] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeLess] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeLess] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeLess] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeLess] SET RECOVERY FULL 
GO
ALTER DATABASE [HomeLess] SET  MULTI_USER 
GO
ALTER DATABASE [HomeLess] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeLess] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HomeLess] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HomeLess] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HomeLess] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HomeLess]
GO
/****** Object:  Table [dbo].[AbotutUs]    Script Date: 12/5/2018 1:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AbotutUs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Fb] [nvarchar](50) NULL,
	[Twitter] [nvarchar](50) NULL,
	[Instgram] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Photo] [nvarchar](max) NULL,
 CONSTRAINT [PK_AbotutUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AytamPlaces]    Script Date: 12/5/2018 1:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AytamPlaces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mobile] [nvarchar](50) NULL,
	[Website] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CityId] [int] NULL,
	[Mail] [nvarchar](50) NULL,
	[Photos] [nvarchar](max) NULL,
 CONSTRAINT [PK_AytamPlaces] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/5/2018 1:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[City]    Script Date: 12/5/2018 1:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CountryId] [int] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contactus]    Script Date: 12/5/2018 1:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MessageContent] [nvarchar](max) NULL,
	[Mail] [nvarchar](50) NULL,
 CONSTRAINT [PK_Contactus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 12/5/2018 1:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Photo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Topics]    Script Date: 12/5/2018 1:44:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TopicAddress] [nvarchar](50) NULL,
	[TopicContent] [nvarchar](max) NULL,
	[IsClosed] [bit] NULL,
	[Notes] [nvarchar](max) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[HouseAddress] [nvarchar](max) NULL,
	[MobileUserName] [nvarchar](50) NULL,
	[AnotherMobilePhone] [nvarchar](50) NULL,
	[ResonOfAbsense] [nvarchar](max) NULL,
	[Photos] [nvarchar](max) NULL,
	[MainPhoto] [nvarchar](max) NULL,
	[AbsenceDate] [date] NULL,
	[CategoryId] [int] NULL,
	[CityId] [int] NULL,
	[LostName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[AbotutUs] ON 

INSERT [dbo].[AbotutUs] ([Id], [Name], [Fb], [Twitter], [Instgram], [Mobile], [Description], [Photo]) VALUES (1, N'Mohamed', N'sdfsd', N'fs', N'dsfs', N'(100) 002-3924', N'fsfsd', N'AbotutUs/00000/00000001_hy2nr4j7e6m5g.jpg')
INSERT [dbo].[AbotutUs] ([Id], [Name], [Fb], [Twitter], [Instgram], [Mobile], [Description], [Photo]) VALUES (2, N'Mohamed', N'fb.com', N'twitter.com', N'instgram.com', N'(100) 392-4342', N'asdsa', N'AbotutUs/00000/00000002_xcfvcew4wbfqu.jpg')
INSERT [dbo].[AbotutUs] ([Id], [Name], [Fb], [Twitter], [Instgram], [Mobile], [Description], [Photo]) VALUES (3, N'asdasdasdas', N'dsfsdf .sdfs', N'dsfsd.sd fsd', N'sdafa;asfasfa.s', N'(103) 925-4234', N'sdafsdfsdxczvz zxczx cdsf sdfsdgsdgsdg s dg sdgfsdf', N'AbotutUs/00000/00000003_wkvuv4ibvroc6.jpg')
SET IDENTITY_INSERT [dbo].[AbotutUs] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Description], [Photo]) VALUES (3, N'المفقودين', NULL, N'Category/00000/00000003_zjzt2gibhbzbk.jpg')
INSERT [dbo].[Category] ([Id], [Name], [Description], [Photo]) VALUES (4, N'المعثور عليهم', NULL, N'Category/00000/00000004_2mnwbdj2jlwjs.jpg')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([Id], [Name], [CountryId]) VALUES (1, N'كفرالشيخ', 1)
INSERT [dbo].[City] ([Id], [Name], [CountryId]) VALUES (2, N'المنصورة', 1)
INSERT [dbo].[City] ([Id], [Name], [CountryId]) VALUES (3, N'المحلة', 1)
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Contactus] ON 

INSERT [dbo].[Contactus] ([Id], [MessageContent], [Mail]) VALUES (2, N'sadas', N'qasdas@asfa.ca')
SET IDENTITY_INSERT [dbo].[Contactus] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name], [Photo]) VALUES (1, N'مصر', N'Country/00000/00000001_mtpl7c7v5i4gc.jpg')
INSERT [dbo].[Country] ([Id], [Name], [Photo]) VALUES (2, N'الجزائر', N'Country/00000/00000002_pvcooyxb6f2cc.jpg')
INSERT [dbo].[Country] ([Id], [Name], [Photo]) VALUES (3, N'ليبيا', N'Country/00000/00000003_xlgfmqk4evcsq.jpg')
INSERT [dbo].[Country] ([Id], [Name], [Photo]) VALUES (4, N'الصومال', N'Country/00000/00000004_dnrhn2rziylew.jpg')
INSERT [dbo].[Country] ([Id], [Name], [Photo]) VALUES (5, N'المغرب', N'Country/00000/00000005_owchrnokxjcd6.jpg')
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Topics] ON 

INSERT [dbo].[Topics] ([Id], [TopicAddress], [TopicContent], [IsClosed], [Notes], [Mobile], [Mail], [HouseAddress], [MobileUserName], [AnotherMobilePhone], [ResonOfAbsense], [Photos], [MainPhoto], [AbsenceDate], [CategoryId], [CityId], [LostName]) VALUES (1, N'sdfs', N'sdfsdf', 1, N'dssfsdfds', N'(103) 202-4922', N'saasd@af.cs', N'dsfds', N'sadsadsa', NULL, NULL, N'[{"Filename":"Topics/00000/00000001_cnqi4mmcxs3vk.jpg","OriginalName":"dangerfield11.jpg"},{"Filename":"Topics/00000/00000001_uiz2hawysuimy.jpg","OriginalName":"dangerfield11.jpg"}]', N'Topics/00000/00000001_x23qga7cdk4fk.jpg', CAST(N'2018-11-15' AS Date), 3, 2, N'lamia')
INSERT [dbo].[Topics] ([Id], [TopicAddress], [TopicContent], [IsClosed], [Notes], [Mobile], [Mail], [HouseAddress], [MobileUserName], [AnotherMobilePhone], [ResonOfAbsense], [Photos], [MainPhoto], [AbsenceDate], [CategoryId], [CityId], [LostName]) VALUES (2, N'sdfs', N'sdfsdf', 1, N'dssfsdfds', N'(103) 202-4922', N'saasd@af.cs', N'dsfds', N'sadsadsa', NULL, NULL, N'[{"Filename":"Topics/00000/00000001_cnqi4mmcxs3vk.jpg","OriginalName":"dangerfield11.jpg"},{"Filename":"Topics/00000/00000001_uiz2hawysuimy.jpg","OriginalName":"dangerfield11.jpg"}]', N'Topics/00000/00000002_j7cdzfocr5wkw.jpg', CAST(N'2018-11-15' AS Date), 3, 2, N'ahmed')
INSERT [dbo].[Topics] ([Id], [TopicAddress], [TopicContent], [IsClosed], [Notes], [Mobile], [Mail], [HouseAddress], [MobileUserName], [AnotherMobilePhone], [ResonOfAbsense], [Photos], [MainPhoto], [AbsenceDate], [CategoryId], [CityId], [LostName]) VALUES (3, N'sdfs', N'sdfsdf', 1, N'dssfsdfds', N'(103) 202-4922', N'saasd@af.cs', N'dsfds', N'sadsadsa', NULL, NULL, N'[{"Filename":"Topics/00000/00000001_uiz2hawysuimy.jpg","OriginalName":"dangerfield11.jpg"},{"Filename":"Topics/00000/00000003_otuo64ntzswaq.jpg","OriginalName":"1.jpg"}]', N'Topics/00000/00000003_265d5zf6axaey.jpg', CAST(N'2018-11-15' AS Date), 3, 2, N'mohamed')
INSERT [dbo].[Topics] ([Id], [TopicAddress], [TopicContent], [IsClosed], [Notes], [Mobile], [Mail], [HouseAddress], [MobileUserName], [AnotherMobilePhone], [ResonOfAbsense], [Photos], [MainPhoto], [AbsenceDate], [CategoryId], [CityId], [LostName]) VALUES (4, N'sdfs', N'sdfsdf', 1, N'dssfsdfds', N'(103) 202-4922', N'saasd@af.cs', N'dsfds', N'sadsadsa', NULL, NULL, N'[{"Filename":"Topics/00000/00000001_cnqi4mmcxs3vk.jpg","OriginalName":"dangerfield11.jpg"},{"Filename":"Topics/00000/00000001_uiz2hawysuimy.jpg","OriginalName":"dangerfield11.jpg"}]', N'Topics/00000/00000004_qdsggy7aaexh4.jpg', CAST(N'2018-11-15' AS Date), 3, 2, N'saad')
INSERT [dbo].[Topics] ([Id], [TopicAddress], [TopicContent], [IsClosed], [Notes], [Mobile], [Mail], [HouseAddress], [MobileUserName], [AnotherMobilePhone], [ResonOfAbsense], [Photos], [MainPhoto], [AbsenceDate], [CategoryId], [CityId], [LostName]) VALUES (5, N'sdfs', N'sdfsdf', 1, N'dssfsdfds', N'(103) 202-4922', N'saasd@af.cs', N'dsfds', N'sadsadsa', NULL, NULL, N'[{"Filename":"Topics/00000/00000001_cnqi4mmcxs3vk.jpg","OriginalName":"dangerfield11.jpg"},{"Filename":"Topics/00000/00000001_uiz2hawysuimy.jpg","OriginalName":"dangerfield11.jpg"}]', N'Topics/00000/00000005_26sgucsk6dwju.jpg', CAST(N'2018-11-15' AS Date), 3, 2, N'kamel')
INSERT [dbo].[Topics] ([Id], [TopicAddress], [TopicContent], [IsClosed], [Notes], [Mobile], [Mail], [HouseAddress], [MobileUserName], [AnotherMobilePhone], [ResonOfAbsense], [Photos], [MainPhoto], [AbsenceDate], [CategoryId], [CityId], [LostName]) VALUES (6, N'sdfs', N'sdfsdf', 1, N'dssfsdfds', N'(103) 202-4922', N'saasd@af.cs', N'dsfds', N'sadsadsa', NULL, NULL, N'[{"Filename":"Topics/00000/00000001_cnqi4mmcxs3vk.jpg","OriginalName":"dangerfield11.jpg"},{"Filename":"Topics/00000/00000001_uiz2hawysuimy.jpg","OriginalName":"dangerfield11.jpg"}]', N'Topics/00000/00000006_w4nrtkm563lvi.jpg', CAST(N'2018-11-15' AS Date), 3, 2, N'hamed')
INSERT [dbo].[Topics] ([Id], [TopicAddress], [TopicContent], [IsClosed], [Notes], [Mobile], [Mail], [HouseAddress], [MobileUserName], [AnotherMobilePhone], [ResonOfAbsense], [Photos], [MainPhoto], [AbsenceDate], [CategoryId], [CityId], [LostName]) VALUES (7, N'sdfs', N'sdfsdf', 1, N'dssfsdfds', N'(103) 202-4922', N'saasd@af.cs', N'dsfds', N'sadsadsa', NULL, NULL, N'[{"Filename":"Topics/00000/00000001_cnqi4mmcxs3vk.jpg","OriginalName":"dangerfield11.jpg"},{"Filename":"Topics/00000/00000001_uiz2hawysuimy.jpg","OriginalName":"dangerfield11.jpg"}]', N'Topics/00000/00000007_rllvnmc65rih2.jpg', CAST(N'2018-11-15' AS Date), 3, 2, N'hamdy')
SET IDENTITY_INSERT [dbo].[Topics] OFF
ALTER TABLE [dbo].[AytamPlaces]  WITH CHECK ADD  CONSTRAINT [FK_AytamPlaces_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[AytamPlaces] CHECK CONSTRAINT [FK_AytamPlaces_City]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Country]
GO
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Category]
GO
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_City]
GO
USE [master]
GO
ALTER DATABASE [HomeLess] SET  READ_WRITE 
GO
