USE [master]
GO
/****** Object:  Database [LibraryManagement]    Script Date: 5/18/2020 9:45:09 PM ******/
CREATE DATABASE [LibraryManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LibraryManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LibraryManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LibraryManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibraryManagement] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LibraryManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibraryManagement] SET QUERY_STORE = OFF
GO
USE [LibraryManagement]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[SubscriberId] [int] NOT NULL,
	[BillingDate] [datetime] NOT NULL,
	[Price] [money] NOT NULL,
	[RegistrationDate] [datetime] NULL,
	[ExpirationDate] [datetime] NULL,
	[MaterialId] [int] NULL,
	[BillTypeId] [int] NULL,
	[Description] [varchar](50) NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillType]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillType](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrowings]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrowings](
	[BorrowId] [int] IDENTITY(1,1) NOT NULL,
	[SubscriberId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
	[DateOfReceipt] [datetime] NULL,
	[ReturnDate] [datetime] NOT NULL,
	[ShelfId] [int] NULL,
	[Comment] [varchar](50) NULL,
	[TypeId] [int] NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BorrowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreId] [int] IDENTITY(1,1) NOT NULL,
	[Genre] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageId] [int] IDENTITY(1,1) NOT NULL,
	[Language] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[MaterialId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[GenreId] [int] NOT NULL,
	[PublishingHouseId] [int] NULL,
	[PublishYear] [date] NULL,
	[PlaceOfPublication] [varchar](50) NULL,
	[ISBN] [varchar](50) NULL,
	[MaterialTypeId] [int] NOT NULL,
	[AvailableCoppies] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[NumberOfPages] [int] NULL,
	[LanguageId] [int] NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ShelfId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialTypes]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialTypes](
	[MaterialTypeId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialType] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublishHouses]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublishHouses](
	[PublishHouseId] [int] IDENTITY(1,1) NOT NULL,
	[PublishHouse] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PublishHouseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubscriberId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
	[ReservationDate] [datetime] NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[InsBy] [int] NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shelves]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shelves](
	[ShelfId] [int] IDENTITY(1,1) NOT NULL,
	[Location] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Description] [varchar](250) NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ShelfId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscribers]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscribers](
	[SubscriberId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Birthday] [date] NULL,
	[PersonalNumber] [varchar](30) NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[EndDate] [date] NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubscriberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfActions]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfActions](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](220) NULL,
	[Password] [varchar](220) NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[RoleId] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[InsBy] [int] NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'Ismail Kadare', 80, CAST(N'2020-05-03T02:27:31.690' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'endrit tmava', 80, CAST(N'2020-05-06T00:07:46.023' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'asdas', 80, CAST(N'2020-05-06T00:24:45.637' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, N'Beis Presheva', 80, CAST(N'2020-05-06T00:38:44.203' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (10, N'beispresheva', 80, CAST(N'2020-05-06T14:12:50.453' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (11, N'aadsas', 80, CAST(N'2020-05-06T14:29:38.967' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (12, N'aadsasasddaasda', 80, CAST(N'2020-05-06T14:30:34.443' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (13, N'endrit', 80, CAST(N'2020-05-06T14:30:56.697' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (14, N'endrittmavasdf', 80, CAST(N'2020-05-06T14:34:54.280' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, 12, CAST(N'2020-02-02T00:00:00.000' AS DateTime), 213.7000, CAST(N'2020-02-08T00:00:00.000' AS DateTime), CAST(N'2021-02-02T00:00:00.000' AS DateTime), NULL, 1, N'popo', 80, CAST(N'2020-05-09T18:36:53.017' AS DateTime), 80, CAST(N'2020-05-16T01:02:29.790' AS DateTime), 2)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (8, 12, CAST(N'2020-02-02T00:00:00.000' AS DateTime), 29.7000, CAST(N'2020-02-08T00:00:00.000' AS DateTime), CAST(N'2021-02-02T00:00:00.000' AS DateTime), NULL, 1, N'popo', 80, CAST(N'2020-05-09T18:47:16.397' AS DateTime), 80, CAST(N'2020-05-16T01:03:29.070' AS DateTime), 1)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (9, 13, CAST(N'2020-02-02T00:00:00.000' AS DateTime), 29.7000, CAST(N'2020-02-08T00:00:00.000' AS DateTime), CAST(N'2021-02-02T00:00:00.000' AS DateTime), NULL, 1, N'popo', 80, CAST(N'2020-05-15T21:18:57.860' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (10, 39, CAST(N'2020-05-16T06:56:47.623' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, NULL, NULL, 1095, CAST(N'2020-05-16T06:56:47.660' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (11, 40, CAST(N'2020-05-16T06:58:49.940' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T06:58:49.963' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (12, 41, CAST(N'2020-05-16T12:12:24.180' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T12:12:24.200' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (13, 42, CAST(N'2020-05-16T12:20:35.773' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T12:20:35.850' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (14, 43, CAST(N'2020-05-16T12:21:23.510' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T12:21:23.530' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (15, 44, CAST(N'2020-05-16T12:23:48.483' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T12:23:48.500' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (16, 45, CAST(N'2020-05-16T14:44:22.177' AS DateTime), 10.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2020-06-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T14:44:22.200' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (17, 46, CAST(N'2020-05-16T14:45:11.443' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T14:45:11.470' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (18, 47, CAST(N'2020-05-16T14:46:59.720' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T14:46:59.740' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (19, 48, CAST(N'2020-05-16T14:49:56.627' AS DateTime), 10.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2020-06-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T14:49:56.643' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (20, 49, CAST(N'2020-05-16T14:52:36.473' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T14:52:36.493' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (21, 50, CAST(N'2020-05-16T14:55:18.427' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T14:55:18.450' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (22, 51, CAST(N'2020-05-16T15:18:11.153' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T15:18:11.177' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (23, 52, CAST(N'2020-05-16T15:20:32.893' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T15:20:32.917' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (24, 53, CAST(N'2020-05-16T15:22:26.780' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T15:22:26.833' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (25, 54, CAST(N'2020-05-16T15:48:49.963' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T15:48:50.003' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (26, 55, CAST(N'2020-05-16T16:21:14.650' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T16:21:14.687' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (27, 56, CAST(N'2020-05-16T19:09:03.893' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T19:09:03.913' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (28, 57, CAST(N'2020-05-16T19:13:22.583' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T19:13:22.603' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (29, 58, CAST(N'2020-05-16T19:18:20.777' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T19:18:20.793' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (30, 59, CAST(N'2020-05-16T19:26:37.277' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T19:26:37.297' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (31, 60, CAST(N'2020-05-16T19:53:57.520' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T19:53:57.540' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (32, 61, CAST(N'2020-05-16T19:55:43.880' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T19:55:43.900' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (33, 62, CAST(N'2020-05-16T20:11:58.187' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T20:11:58.207' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (34, 63, CAST(N'2020-05-16T20:15:52.067' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, N'Bill Subscription', 1095, CAST(N'2020-05-16T20:15:52.143' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (35, 64, CAST(N'2020-05-16T20:17:53.327' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, N'Bill Subscription', 1095, CAST(N'2020-05-16T20:17:53.343' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (36, 65, CAST(N'2020-05-16T20:22:52.487' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-16T20:22:52.507' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (37, 65, CAST(N'2020-05-17T01:12:50.980' AS DateTime), 100.0000, CAST(N'2020-05-16T14:55:18.423' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T01:12:50.997' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (38, 65, CAST(N'2020-05-17T01:13:14.227' AS DateTime), 100.0000, CAST(N'2020-05-16T14:55:18.423' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T01:13:14.227' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (39, 65, CAST(N'2020-05-17T01:13:41.510' AS DateTime), 100.0000, CAST(N'2020-05-16T14:55:18.423' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T01:13:41.513' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (40, 65, CAST(N'2020-05-17T01:20:04.237' AS DateTime), 100.0000, CAST(N'2020-05-16T04:54:47.127' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T01:20:04.257' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (41, 65, CAST(N'2020-05-17T01:20:30.160' AS DateTime), 100.0000, CAST(N'2020-05-16T04:54:47.127' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T01:20:30.160' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (42, 40, CAST(N'2020-05-17T01:44:56.757' AS DateTime), 100.0000, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2021-05-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T01:44:56.773' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (43, 66, CAST(N'2020-05-17T05:52:00.513' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T05:52:00.583' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (44, 67, CAST(N'2020-05-17T06:19:55.993' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T06:19:56.003' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (45, 68, CAST(N'2020-05-17T06:29:00.710' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T06:29:00.723' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (46, 69, CAST(N'2020-05-17T06:41:21.420' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T06:41:21.477' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (47, 70, CAST(N'2020-05-17T06:41:39.047' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T06:41:39.053' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (48, 70, CAST(N'2020-05-17T06:45:32.537' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T06:45:32.583' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (49, 70, CAST(N'2020-05-17T06:54:25.457' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T06:54:25.483' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (50, 70, CAST(N'2020-05-17T07:03:18.717' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T07:03:18.737' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (51, 70, CAST(N'2020-05-17T07:06:49.963' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T07:06:49.983' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (52, 71, CAST(N'2020-05-17T07:17:12.250' AS DateTime), 10.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-06-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T07:17:12.267' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (53, 72, CAST(N'2020-05-17T07:17:35.360' AS DateTime), 10.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-06-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T07:17:35.357' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (54, 73, CAST(N'2020-05-17T11:23:11.657' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T11:23:11.700' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (55, 74, CAST(N'2020-05-17T11:31:31.897' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T11:31:31.920' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (56, 55, CAST(N'2020-05-17T12:56:25.207' AS DateTime), 100.0000, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2021-05-17T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-17T12:56:25.250' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (57, 75, CAST(N'2020-05-18T03:10:57.830' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T03:10:57.943' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (58, 76, CAST(N'2020-05-18T03:12:52.990' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T03:12:53.020' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (59, 77, CAST(N'2020-05-18T03:30:05.420' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T03:30:05.440' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (60, 78, CAST(N'2020-05-18T03:34:30.713' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T03:34:30.740' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (61, 79, CAST(N'2020-05-18T03:46:59.807' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T03:46:59.827' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (62, 80, CAST(N'2020-05-18T03:53:05.750' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T03:53:05.770' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (63, 81, CAST(N'2020-05-18T03:54:17.647' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T03:54:17.667' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (64, 82, CAST(N'2020-05-18T04:04:57.620' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T04:04:57.650' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (65, 83, CAST(N'2020-05-18T04:14:19.933' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T04:14:19.953' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (66, 84, CAST(N'2020-05-18T04:22:22.947' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T04:22:22.967' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (67, 85, CAST(N'2020-05-18T04:25:38.473' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T04:25:38.497' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (68, 86, CAST(N'2020-05-18T05:17:05.517' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:17:05.533' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (69, 87, CAST(N'2020-05-18T05:19:58.953' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:19:58.973' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (70, 88, CAST(N'2020-05-18T05:23:47.817' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:23:47.833' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (71, 89, CAST(N'2020-05-18T05:30:21.210' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:30:21.230' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (72, 90, CAST(N'2020-05-18T05:46:00.850' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:46:00.870' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (73, 91, CAST(N'2020-05-18T05:50:04.870' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:50:04.887' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (74, 92, CAST(N'2020-05-18T05:53:18.143' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:53:18.180' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (75, 93, CAST(N'2020-05-18T05:56:05.903' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T05:56:05.950' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (76, 94, CAST(N'2020-05-18T06:09:42.150' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:09:42.167' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (77, 95, CAST(N'2020-05-18T06:13:25.000' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:13:25.017' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (78, 96, CAST(N'2020-05-18T06:16:10.447' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:16:10.543' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (79, 97, CAST(N'2020-05-18T06:19:53.897' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:19:53.933' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (80, 98, CAST(N'2020-05-18T06:22:25.520' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:22:25.527' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (81, 99, CAST(N'2020-05-18T06:26:25.273' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:26:25.293' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (82, 100, CAST(N'2020-05-18T06:33:20.353' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:33:20.390' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (83, 101, CAST(N'2020-05-18T06:37:02.720' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:37:02.827' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (84, 102, CAST(N'2020-05-18T06:41:00.310' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:41:00.330' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (85, 103, CAST(N'2020-05-18T06:44:58.243' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:44:58.263' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (86, 104, CAST(N'2020-05-18T06:58:13.493' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:58:13.510' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (87, 105, CAST(N'2020-05-18T06:59:51.690' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T06:59:51.710' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (88, 106, CAST(N'2020-05-18T07:22:22.427' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T07:22:22.443' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (89, 34, CAST(N'2020-05-18T07:37:46.293' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T07:37:46.337' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (90, 23, CAST(N'2020-05-18T07:45:50.863' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T07:45:50.887' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (91, 32, CAST(N'2020-05-18T07:55:16.147' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T07:55:16.163' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (92, 32, CAST(N'2020-05-18T07:56:33.973' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T07:56:33.977' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (93, 32, CAST(N'2020-05-18T08:03:40.303' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T08:05:48.173' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (94, 32, CAST(N'2020-05-18T15:22:37.880' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T15:22:37.907' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (95, 73, CAST(N'2020-05-18T15:28:53.473' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T15:28:53.490' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (96, 107, CAST(N'2020-05-18T15:41:20.433' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T15:41:20.467' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (97, 108, CAST(N'2020-05-18T15:55:34.160' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T15:55:34.180' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (98, 74, CAST(N'2020-05-18T17:17:14.590' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T17:17:14.607' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (99, 60, CAST(N'2020-05-18T17:43:01.127' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T17:43:01.160' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (100, 65, CAST(N'2020-05-18T18:06:20.330' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T18:06:20.410' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (101, 66, CAST(N'2020-05-18T18:21:43.467' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T18:21:43.487' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (102, 67, CAST(N'2020-05-18T19:22:29.487' AS DateTime), 10.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-06-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T19:22:29.513' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (103, 109, CAST(N'2020-05-18T21:36:56.170' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T21:36:56.190' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (104, 109, CAST(N'2020-05-18T21:39:05.087' AS DateTime), 100.0000, CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2021-05-18T00:00:00.000' AS DateTime), NULL, 1, NULL, 1095, CAST(N'2020-05-18T21:39:05.097' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Bills] OFF
GO
SET IDENTITY_INSERT [dbo].[BillType] ON 

INSERT [dbo].[BillType] ([TypeId], [Type], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'Subscriber', 80, CAST(N'2020-05-09T18:35:45.540' AS DateTime), NULL, CAST(N'2020-05-09T18:54:08.083' AS DateTime), 1)
INSERT [dbo].[BillType] ([TypeId], [Type], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'Penal', 80, CAST(N'2020-05-09T18:58:51.520' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[BillType] OFF
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'Fantadczxdsczxsa', 80, CAST(N'2020-05-03T01:30:49.123' AS DateTime), 80, CAST(N'2020-05-05T03:37:45.967' AS DateTime), 2, 0)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (2, N'diti', 80, CAST(N'2020-05-04T04:05:31.023' AS DateTime), 80, CAST(N'2020-05-05T00:02:36.733' AS DateTime), 2, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'edfsdfs&', 80, CAST(N'2020-05-04T04:07:51.580' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (7, N'zhndrias', 80, CAST(N'2020-05-04T21:52:26.353' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (8, N'asdasdsaasd', 80, CAST(N'2020-05-04T23:31:29.403' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (15, N'helloworld', 80, CAST(N'2020-05-05T02:07:16.420' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (17, N'dfgfdg', 80, CAST(N'2020-05-05T14:24:36.827' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (18, N'gfsdfsdf', 80, CAST(N'2020-05-05T23:08:12.413' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Genres] OFF
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'shqipe', 80, CAST(N'2020-05-03T01:30:49.153' AS DateTime), 80, CAST(N'2020-05-05T02:42:38.417' AS DateTime), 8, 0)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'Shqip2', 80, CAST(N'2020-05-03T18:10:15.797' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (4, N'English', 80, CAST(N'2020-05-04T00:22:59.137' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (5, N'English10', 80, CAST(N'2020-05-04T00:25:11.073' AS DateTime), 80, CAST(N'2020-05-04T00:29:50.477' AS DateTime), 1, 0)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (12, N'shqipeeee', 80, CAST(N'2020-05-04T02:12:14.443' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (13, N'gjuhashqipe', 80, CAST(N'2020-05-04T02:13:33.283' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (14, N'Gjuha shqipe', 80, CAST(N'2020-05-04T02:19:00.860' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (15, N'english (uk)', 80, CAST(N'2020-05-04T02:27:39.637' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (17, N'asdasd', 80, CAST(N'2020-05-04T02:33:03.813' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1004, N'shqipees', 80, CAST(N'2020-05-04T21:01:01.617' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1005, N'asdasdsadabeis beis', 80, CAST(N'2020-05-04T21:01:46.560' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1006, N'asdadsdaaa3dd', 80, CAST(N'2020-05-05T01:43:08.020' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1008, N'helloworld', 80, CAST(N'2020-05-05T01:46:32.477' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1009, N'sdfsdfsd', 80, CAST(N'2020-05-05T02:45:23.743' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1011, N'asdasdasd', 80, CAST(N'2020-05-05T14:18:03.360' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1013, N'shqipee', 80, CAST(N'2020-05-05T14:18:18.723' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1017, N'shqipe342', 80, CAST(N'2020-05-05T14:20:13.017' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1019, N'shqipeas', 80, CAST(N'2020-05-05T23:09:09.140' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET IDENTITY_INSERT [dbo].[Materials] ON 

INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [Quantity], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId]) VALUES (1019, N'beis', 7, 15, NULL, N'asdasdasd', N'', 6, 24, 24, 131, 1011, 80, CAST(N'2020-05-06T14:29:38.967' AS DateTime), 80, CAST(N'2020-05-06T14:29:55.297' AS DateTime), 1, 11, 1, 2)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [Quantity], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId]) VALUES (1020, N'beisadsasdsd', 7, 16, NULL, N'asdasdasd', N'', 6, 12, 12, 131, 1011, 80, CAST(N'2020-05-06T14:30:34.443' AS DateTime), NULL, NULL, 0, 12, 1, 2)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [Quantity], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId]) VALUES (1021, N'beis', 7, 16, NULL, N'asdasdasd', N'', 6, 12, 12, 131, 1011, 80, CAST(N'2020-05-06T14:30:56.697' AS DateTime), NULL, NULL, 0, 13, 1, 2)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [Quantity], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId]) VALUES (1022, N'endrittmavaasa', 7, 17, NULL, N'asdasdasd', N'', 3, 13, 13, 151, 4, 80, CAST(N'2020-05-06T14:34:54.280' AS DateTime), NULL, NULL, 0, 14, 1, 3)
SET IDENTITY_INSERT [dbo].[Materials] OFF
SET IDENTITY_INSERT [dbo].[MaterialTypes] ON 

INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'Adsad', 80, CAST(N'2020-05-03T01:31:49.610' AS DateTime), 80, CAST(N'2020-05-05T03:41:57.273' AS DateTime), 3, 0)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (2, N'adasdasda', 80, CAST(N'2020-05-04T04:50:50.767' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'liber', 80, CAST(N'2020-05-04T20:56:10.157' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (5, N'Gjuh shqipeee', 80, CAST(N'2020-05-05T01:17:55.433' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (6, N'Gjuh shqipeeeee', 80, CAST(N'2020-05-05T01:22:12.670' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (7, N'adasda', 80, CAST(N'2020-05-05T01:22:26.647' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (11, N'asdadasdasddddddd', 80, CAST(N'2020-05-05T01:29:02.340' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (12, N'asdadsdaaa3dd', 80, CAST(N'2020-05-05T01:34:10.587' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (14, N'helloo', 80, CAST(N'2020-05-05T14:17:13.397' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (15, N'fadf', 80, CAST(N'2020-05-05T23:09:14.977' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (16, N'shqipe', 80, CAST(N'2020-05-05T23:09:22.890' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[MaterialTypes] OFF
SET IDENTITY_INSERT [dbo].[PublishHouses] ON 

INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'Dukagjini', 80, CAST(N'2020-05-03T02:27:31.690' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'fgsdfsdf', 80, CAST(N'2020-05-06T00:07:46.023' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'asdasd', 80, CAST(N'2020-05-06T00:24:45.637' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, N'ska', 80, CAST(N'2020-05-06T00:38:44.203' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (14, N'asdasda', 80, CAST(N'2020-05-06T14:12:50.453' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (15, N'asddad', 80, CAST(N'2020-05-06T14:29:38.967' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (16, N'asddadasda', 80, CAST(N'2020-05-06T14:30:34.443' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (17, N'asdasdas', 80, CAST(N'2020-05-06T14:34:54.280' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[PublishHouses] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [Role], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'User', 1, CAST(N'2020-05-01T16:01:34.643' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Roles] ([RoleId], [Role], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'admin', 80, CAST(N'2020-05-05T04:26:18.503' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Shelves] ON 

INSERT [dbo].[Shelves] ([ShelfId], [Location], [Quantity], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'veri', 100, N'rafti veri', 80, CAST(N'2020-05-03T17:33:32.143' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Shelves] ([ShelfId], [Location], [Quantity], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'Adsad', 100, N'asdasdasdasdasdasd', 80, CAST(N'2020-05-05T03:49:33.927' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Shelves] ([ShelfId], [Location], [Quantity], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'Adsad', 100, N'asdasdasdasdasdasd', 80, CAST(N'2020-05-05T03:49:39.460' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Shelves] OFF
SET IDENTITY_INSERT [dbo].[Subscribers] ON 

INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (12, N'Granit', N'krasniqi', N'Dri', CAST(N'2020-02-02' AS Date), N'13', N'89', N'g@k', N'M', CAST(N'2020-06-15' AS Date), 80, CAST(N'2020-05-09T18:07:30.113' AS DateTime), 1095, CAST(N'2020-05-16T05:35:22.163' AS DateTime), 8, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (13, N'sranit', N'krasniqi', N'Dri', CAST(N'2020-02-02' AS Date), N'13', N'89', N'g@k', N'M', CAST(N'2021-05-16' AS Date), 80, CAST(N'2020-05-09T18:08:00.017' AS DateTime), 1095, CAST(N'2020-05-16T13:14:30.910' AS DateTime), 5, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (14, N'G1', N'krasniqi', N'Dr', CAST(N'2020-02-02' AS Date), N'dd', N'89', N'g@k', N'M', CAST(N'2021-05-15' AS Date), 80, CAST(N'2020-05-09T18:17:13.140' AS DateTime), 1095, CAST(N'2020-05-16T01:11:54.500' AS DateTime), 6, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (15, N'aa', N'aa', N'aa', CAST(N'2020-02-02' AS Date), N'aa', N'aa', N'aa', N'F', CAST(N'2021-05-16' AS Date), 80, CAST(N'2020-05-15T21:30:43.237' AS DateTime), 1095, CAST(N'2020-05-16T13:21:14.300' AS DateTime), 5, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (17, N'erd', N'fc,r', N'fm,fof', CAST(N'2020-05-16' AS Date), N'dlde', N'odkoe', N'odkeo', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T02:08:51.460' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (18, N'ret', N'd,m', N'dlk', CAST(N'2020-05-16' AS Date), N'mdo', N'mde', N'ddod', N'M', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T02:09:35.683' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (19, N'arnold', N'schwarzeneger', N'am', CAST(N'2020-05-16' AS Date), N'mosx', N'kwodk', N'dk2odk', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T02:13:04.940' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (20, N'erd', N'drf', N'kffk', CAST(N'2020-05-16' AS Date), N'lffl', N'lflfl', N'kfkf', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T03:27:14.153' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (21, N'wddwd', N'dee', N'dee', CAST(N'2020-05-16' AS Date), N'ed', N'ede', N'del', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T03:27:55.780' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (22, N'err', N'pol', N'dmw2d', CAST(N'2020-05-16' AS Date), N'mdk2md', N'dnkd3', N'ikdmki', N'M', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T03:31:15.663' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (23, N'we', N'ele', N'ldld', CAST(N'2020-05-16' AS Date), N'1234321123', N'1234321', N'fnf', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-16T03:34:07.097' AS DateTime), 1095, CAST(N'2020-05-18T07:45:50.857' AS DateTime), 2, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (24, N'ref', N'out', N'tkkt', CAST(N'2020-05-16' AS Date), N'rlrrl', N'lkr', N'rele', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T03:41:55.403' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (25, N'de', N'dlq', N'le,de', CAST(N'2020-05-16' AS Date), N'lele', N'ddlld', N'dlel', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T03:43:05.657' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (26, N'rer', N'rrr', N'ekco', CAST(N'2020-05-16' AS Date), N'lkdd', N'kdk', N'kdkd', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T03:56:05.623' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (27, N'kdk', N'eee', N'eee', CAST(N'2020-05-16' AS Date), N'dee', N'kdkd', N'dd', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T04:02:30.333' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (28, N'kcfckem', N'mfm', N'ef2', CAST(N'2020-05-16' AS Date), N'p3p', N'pr', N'lrl', N'F', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T04:41:05.770' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (29, N'web', N'pol', N'erd', CAST(N'2020-05-16' AS Date), N'der', N'fkf', N'fkkf', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T04:44:33.740' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (30, N'Granit', N'opl', N'jn', CAST(N'2020-05-16' AS Date), N'1231231231', N'123123', N'ujn', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T04:54:47.127' AS DateTime), 1095, CAST(N'2020-05-18T15:22:11.693' AS DateTime), 4, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (31, N'uio', N'poi', N'uu', CAST(N'2020-05-16' AS Date), N'nu', N'b hb', N'buu', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T05:13:36.937' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (32, N'yuu', N'klp', N'mii', CAST(N'2020-05-16' AS Date), N'1233212343', N'123456', N'jmi', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-16T05:45:15.790' AS DateTime), 1095, CAST(N'2020-05-18T15:22:37.870' AS DateTime), 5, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (33, N'heu', N'hdehde', N'dedhe', CAST(N'2020-05-16' AS Date), N'uew', N'e98we8', N'dde8', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T06:27:26.100' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (34, N'ejke', N'eke', N'keke', CAST(N'2020-05-16' AS Date), N'jeje', N'jeje', N'jej', N'M', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T06:30:36.007' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (35, N'granit', N'dkk', N'oe', CAST(N'2020-05-16' AS Date), N'dii', N'meo3', N'dni3', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T06:32:55.513' AS DateTime), 1095, CAST(N'2020-05-17T01:39:14.367' AS DateTime), 2, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (36, N'qa', N'aq', N'qq', CAST(N'2020-05-16' AS Date), N'qq', N'qqq', N'qq', N'M', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T06:35:32.410' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (37, N'op', N'kj', N'jjj', CAST(N'2020-05-16' AS Date), N'jj', N'kk', N'jj', N'M', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T06:50:30.830' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (38, N'o12', N'kek', N'ekke', CAST(N'2020-05-16' AS Date), N'jeje', N'eke', N'ekke', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T06:53:19.397' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (39, N'1223', N'23mk', N'21mie', CAST(N'2020-05-16' AS Date), N'21emo1', N'o12eko12', N'o12kje', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T06:56:45.910' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (40, N'readread', N'okdo', N'emo3', CAST(N'2020-05-16' AS Date), N'm132k', N'pej', N'o23o', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T06:58:48.220' AS DateTime), 1095, CAST(N'2020-05-17T01:44:56.750' AS DateTime), 2, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (41, N'deg', N'pol', N'oow', CAST(N'2020-05-16' AS Date), N'di', N'kdwwk', N'kwqdwk', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T12:12:24.177' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (42, N'erd', N'kio', N'eek', CAST(N'2020-05-16' AS Date), N'kwe', N'kdk', N'kek', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T12:20:35.760' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (43, N'kek', N'djjd', N'kdkd', CAST(N'2020-05-16' AS Date), N'djj', N'kdk', N'kdk', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T12:21:23.510' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (44, N'op', N'kek', N'kke', CAST(N'2020-05-16' AS Date), N'kek', N'kk', N'kk', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T12:23:48.477' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (45, N'mds', N'kk', N'dkekd', CAST(N'2020-05-16' AS Date), N'ekk', N'dkk', N'kek', N'M', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T14:44:22.173' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (46, N'ekke', N'po', N'ek', CAST(N'2020-05-16' AS Date), N'ke', N'kek', N'ekk', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T14:45:11.437' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (47, N'kee', N'eii', N'i3i', CAST(N'2020-05-16' AS Date), N'eii', N'eiei', N'eiie', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T14:46:59.713' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (48, N'ds0iwd0', N'ooo', N'999', CAST(N'2020-05-16' AS Date), N'999', N'iii', N'999', N'M', CAST(N'2020-06-16' AS Date), 1095, CAST(N'2020-05-16T14:49:56.623' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (49, N'du', N'dh2u', N'ueu', CAST(N'2020-05-16' AS Date), N'eueu', N'rer', N'i8e4i', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T14:52:36.470' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (50, N'gran', N'ror', N'roro', CAST(N'2020-05-16' AS Date), N'otot', N'gogo', N'zzz', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T14:55:18.423' AS DateTime), 1095, CAST(N'2020-05-17T01:14:03.693' AS DateTime), 6, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (51, N'iu', N'ii', N'ii', CAST(N'2020-05-16' AS Date), N'jj', N'jj', N'jj', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T15:18:11.153' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (52, N'uii', N'hhh', N'hhhh', CAST(N'2020-05-16' AS Date), N'hh', N'hjh', N'hh', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T15:20:32.890' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (53, N'hhh', N'hh', N'ii', CAST(N'2020-05-16' AS Date), N'ip', N'hi', N'ii', N'F', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T15:22:26.777' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (54, N'jjj', N'hh', N'hh', CAST(N'2020-05-16' AS Date), N'hh', N'iki', N'ii', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T15:48:49.960' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (55, N'oep', N'ror', N'roo', CAST(N'2020-05-16' AS Date), N'roro', N'prf', N'rpr', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T16:21:14.640' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (56, N'fcdew', N'efd32', N'ewee', CAST(N'2020-05-16' AS Date), N'ef', N'ef3w', N'fd3w', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T19:09:03.890' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (57, N'ddk', N'3kk3', N'k3k', CAST(N'2020-05-16' AS Date), N'3k3k', N'3kk3', N'kk', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T19:13:22.580' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (58, N'ej', N'jej', N'kdk', CAST(N'2020-05-16' AS Date), N'o3o', N'kwmk', N'woo', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T19:18:20.773' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (59, N'skks', N'sks', N'skks', CAST(N'2020-05-16' AS Date), N'ksk', N'ksk', N'skks', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T19:26:37.277' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (60, N'Granit', N'Krasniqi', N'Dr', CAST(N'2020-05-16' AS Date), N'1231231234', N'123432', N'123', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-16T19:53:57.517' AS DateTime), 1095, CAST(N'2020-05-18T17:43:01.123' AS DateTime), 2, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (61, N'uj', N'ujr', N'fu', CAST(N'2020-05-16' AS Date), N'1234554321', N'1234556', N'fif', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T19:55:43.877' AS DateTime), 1095, CAST(N'2020-05-18T17:48:20.930' AS DateTime), 1, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (62, N'ede', N'ed', N'de', CAST(N'2020-05-16' AS Date), N'de', N'de', N'de', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T20:11:58.183' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (63, N'ekk', N'ej', N'ei', CAST(N'2020-05-16' AS Date), N'1234566543', N'3456765', N'kjek', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T20:15:52.043' AS DateTime), 1095, CAST(N'2020-05-18T17:54:58.463' AS DateTime), 1, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (64, N'sk', N'msi3', N'm3s', CAST(N'2020-05-16' AS Date), N'ms', N'mo', N'oim', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T20:17:53.320' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (65, N'iu', N'ekjm', N'ikdm', CAST(N'2020-05-16' AS Date), N'mei', N'ejkn', N'imm', N'M', CAST(N'2021-05-16' AS Date), 1095, CAST(N'2020-05-16T20:22:52.483' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (66, N'me', N'jej', N'jje', CAST(N'2020-05-17' AS Date), N'5321233212', N'9876567', N'k3k', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-17T05:52:00.500' AS DateTime), 1095, CAST(N'2020-05-18T18:21:43.463' AS DateTime), 2, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (67, N'fdw3', N'eve', N'fw3', CAST(N'2020-05-17' AS Date), N'1234123432', N'123456', N'3f', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-17T06:19:55.990' AS DateTime), 1095, CAST(N'2020-05-18T19:22:29.483' AS DateTime), 2, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (68, N'mdk', N'mkmd', N'kmdk3', CAST(N'2020-05-17' AS Date), N'9989899898', N'999999', N'kek3', N'M', CAST(N'2021-05-17' AS Date), 1095, CAST(N'2020-05-17T06:29:00.707' AS DateTime), 1095, CAST(N'2020-05-18T19:33:01.867' AS DateTime), 1, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (69, N'tt', N'ji', N'ii', CAST(N'2020-05-17' AS Date), N'1231231231', N'898766', N'ii', N'M', CAST(N'2021-05-17' AS Date), 1095, CAST(N'2020-05-17T06:36:45.710' AS DateTime), 1095, CAST(N'2020-05-18T19:35:03.317' AS DateTime), 1, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (70, N'123', N'pp4', N'iop3', CAST(N'2020-05-17' AS Date), N'1231231231', N'o32o', N'popo', N'M', CAST(N'2021-05-17' AS Date), 1095, CAST(N'2020-05-17T06:41:39.043' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (71, N'ui', N'ii', N'ii', CAST(N'2020-05-17' AS Date), N'9', N'iuu', N'uju', N'M', CAST(N'2020-06-17' AS Date), 1095, CAST(N'2020-05-17T07:17:12.243' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (72, N'ui', N'ii', N'ii', CAST(N'2020-05-17' AS Date), N'9999999999', N'iuu', N'uju', N'M', CAST(N'2020-06-17' AS Date), 1095, CAST(N'2020-05-17T07:17:35.350' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (73, N'n', N'j', N'jk', CAST(N'2020-05-17' AS Date), N'1231231233', N'123123', N'granit.krasniqi2020@outlook.com', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-17T11:23:11.653' AS DateTime), 1095, CAST(N'2020-05-18T15:28:53.467' AS DateTime), 1, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (74, N'j', N'k', N'k', CAST(N'2020-05-17' AS Date), N'5556667988', N'567765', N'o', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-17T11:31:31.897' AS DateTime), 1095, CAST(N'2020-05-18T17:17:14.587' AS DateTime), 1, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (75, N'msks', N'cmc', N'cmwlcm', CAST(N'2020-05-18' AS Date), N'1231231231', N'1231232', N'd', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-18T03:10:57.813' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (76, N'wdm', N'mdkem', N'kdm ke', CAST(N'2020-05-18' AS Date), N'1231231231', N'123123', N'dwd', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T03:12:52.987' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (77, N'dmd', N'jd ncw', N'dnje', CAST(N'2020-05-18' AS Date), N'1232344321', N'234321', N'dk', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T03:30:05.417' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (78, N'ddkd', N'dmjd', N'kmndk', CAST(N'2020-05-18' AS Date), N'3973737373', N'364575', N'eje3ii3', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T03:34:30.710' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (79, N'granit', N'kdk', N'm2d', CAST(N'2020-05-18' AS Date), N'9218933999', N'3939399', N'jie', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T03:46:59.800' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (80, N'Dede', N'kleel', N'kdmwlkd', CAST(N'2020-05-18' AS Date), N'1231231234', N'333333', N'eloelel', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T03:53:05.747' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (81, N'dmwei', N'dmeid', N'mkwedmei', CAST(N'2020-05-18' AS Date), N'9923939933', N'3339999', N'3ii3', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T03:54:17.643' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (82, N'Granit', N'mwkdc', N'kdme', CAST(N'2020-05-18' AS Date), N'1234321229', N'123123', N's,m23ol2', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T04:04:57.620' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (83, N'jje', N'kdkej', N'eeee', CAST(N'2020-05-18' AS Date), N'1234321233', N'333444', N'www', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-18T04:14:19.930' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (84, N'ded', N'ejje', N'jewje', CAST(N'2020-05-18' AS Date), N'1233214321', N'6787654', N'wejj3', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T04:22:22.943' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (85, N'West', N'kfk', N'mdf2kj', CAST(N'2020-05-18' AS Date), N'3455432121', N'234432', N'3je3j', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-18T04:25:38.470' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (86, N'West', N'Lask', N'dk2peo', CAST(N'2020-05-18' AS Date), N'1232433221', N'9876545633', N'idjpo', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-18T05:17:05.513' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (87, N'popopo', N'koko', N'kwkw', CAST(N'2020-05-18' AS Date), N'1929292929', N'2343211222', N'2swdd', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T05:19:58.950' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (88, N'dewkow', N'wasder', N'dkldk', CAST(N'2020-05-18' AS Date), N'1928379812', N'124356', N'mwmdl', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T05:23:47.813' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (89, N'Asd', N'Wes', N'ewcfe', CAST(N'2020-05-18' AS Date), N'6789987654', N'1234554321', N'efvf', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T05:30:21.210' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (90, N'Tu', N'P', N'jjj', CAST(N'2020-05-18' AS Date), N'6787685674', N'1234321123', N'jjj', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-18T05:46:00.850' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (91, N'Poli', N'Gui', N'jjkk', CAST(N'2020-05-18' AS Date), N'0987678909', N'56787654', N'kmiomo', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T05:50:04.867' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (92, N'Poiu', N'Hyuio', N'kjkm', CAST(N'2020-05-18' AS Date), N'0987789098', N'543212', N'kjjmkl', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T05:53:18.140' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (93, N'Poki', N'Muop', N'uhio', CAST(N'2020-05-18' AS Date), N'1112223334', N'1357987', N'jiji', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T05:56:05.900' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (94, N'Qwe', N'Por', N'jkek', CAST(N'2020-05-18' AS Date), N'0990876556', N'1234567', N'huihluu', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:09:42.147' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (95, N'west', N'Brown', N'mop''', CAST(N'2020-05-18' AS Date), N'0909099076', N'7667766', N'kjkjjk', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-18T06:13:24.997' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (96, N'Koi', N'Boi', N'emio2', CAST(N'2020-05-18' AS Date), N'1234543212', N'123432', N'om23or', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:16:10.433' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (97, N'Asdre', N'Mot', N'mdkd', CAST(N'2020-05-18' AS Date), N'3454654543', N'232332', N' dj34', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:19:53.890' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (98, N'Asdre', N'Mot', N'mdkd', CAST(N'2020-05-18' AS Date), N'3454654543', N'232332', N' dj34', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:22:25.513' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (99, N'Des', N'Kop', N'Koo', CAST(N'2020-05-18' AS Date), N'1234567890', N'3211234567', N'eimei', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:26:25.270' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (100, N'Jeton', N'Gashi', N'mxi', CAST(N'2020-05-18' AS Date), N'1929391929', N'18281828', N'wodkmk', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:33:20.350' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (101, N'Jeton', N'Gashi', N'xdjx2i', CAST(N'2020-05-18' AS Date), N'1234567890', N'123456', N'dn2i', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:37:02.697' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (102, N'Jeton', N'Gashi', N'jdiewdji', CAST(N'2020-05-18' AS Date), N'2468013579', N'202002', N'dxewjk', N'M', CAST(N'2020-06-18' AS Date), 1095, CAST(N'2020-05-18T06:41:00.307' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (103, N'Jeton', N'Gashi', N'kks', CAST(N'2020-05-18' AS Date), N'1357908642', N'134321', N'mxiew', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:44:58.240' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (104, N'West', N'Poli', N'df', CAST(N'2020-05-18' AS Date), N'1234567890', N'123123', N'feef', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:58:13.490' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (105, N'frr4', N'rvr', N'efe', CAST(N'2020-05-18' AS Date), N'1234512345', N'123123', N'3df3f34', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T06:59:51.687' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (106, N'pol', N'dk2ed', N'dk2wd', CAST(N'2020-05-18' AS Date), N'1233211231', N'123321', N'kdkd', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T07:22:22.423' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (107, N'endrit', N'tmava', N'wdwd', CAST(N'2020-05-18' AS Date), N'1234567891', N'847463', N'jid', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T15:41:20.427' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (108, N'Beis', N'Presheva', N'Pr', CAST(N'2020-05-18' AS Date), N'7319391929', N'182828', N'jewo9k1e2j', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T15:55:34.157' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (109, N'Sokol', N'Shala', N'mndkj', CAST(N'2020-05-18' AS Date), N'1234567889', N'766677', N'dr.dr@outlook.com', N'M', CAST(N'2021-05-18' AS Date), 1095, CAST(N'2020-05-18T21:36:56.170' AS DateTime), 1095, CAST(N'2020-05-18T21:39:05.087' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[Subscribers] OFF
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (80, N'Endrittmava', N'to8Qg7XjcdlxITInKZ0UK5OJpumhqiSDkzlCmFe+', N'Endritad', N'Tmavaasd', 2, N'Endrit.tmavaa@gmail.com', 1, CAST(N'2020-05-02T04:38:46.460' AS DateTime), 0, CAST(N'2020-05-06T16:08:33.043' AS DateTime), 11, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (81, N'Endrittmav', N'eqiytkORvyMEW96FYBPx/BFXamkRImSn7cHMl//d', N'Endrit', N'Tmava', 1, N'Endrit.tmavaa@gmail.com', 1, CAST(N'2020-05-02T04:39:07.783' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (85, N'Endrittmavgfd', N'FJjz8R/d08AuS0zfkq84pGMluNLVucR1cWt6UWgR', N'Endrit', N'Tmava', 1, N'Endrit.tmavaa@gmail.com', 1, CAST(N'2020-05-02T04:41:09.250' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1084, N'dity', N'asdadsss', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05T04:09:35.557' AS DateTime), 80, CAST(N'2020-05-05T05:06:08.823' AS DateTime), 2, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1085, N'ditdsay', N'asdads', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05T04:11:28.210' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1086, N'ditdsadasdy', N'asdads', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05T04:11:57.593' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1087, N'ditcasdasdadsadasdy', N'asdads', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05T04:12:38.117' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1088, N'helloworld', N'endrittmava', N'Endrit', N'Tmava', 2, N'etttttttt@gmail.com', 80, CAST(N'2020-05-06T02:16:45.680' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1089, N'endritdity', N'hellohello', N'Endrit', N'dity', 2, N'endasd@asda.com', 80, CAST(N'2020-05-06T03:39:36.043' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1090, N'beispresheva', N'123123', N'Beis', N'Presheva', 2, N'beis.presheva@riinvest.net', 80, CAST(N'2020-05-06T03:40:24.697' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1091, N'aasdasd', N'granitbossi', N'Granit', N'Krasniqi', 2, N'gr.@riinvest.net', 80, CAST(N'2020-05-06T05:01:53.660' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1092, N'granitkrasniqi', N'123123', N'Granit', N'Krasniqi', 2, N'gr@riinvest.net', 80, CAST(N'2020-05-06T14:55:56.050' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1093, N'ettm', N'A4EjiMaLwWEZIgqo85wnx7lpgLYPrjFh28d/kw2f', N'Ey', N'tm', 2, N'et@riinvest.net', 80, CAST(N'2020-05-06T15:31:57.083' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1094, N'Granit.k', N'oT85yfpeo52M3rlX41/kb9XmsptxGUqZqxBWRjKL', N'Granit', N'Krasniqi', 1, N'Granit.Krasniqi2020@outlook.com', 80, CAST(N'2020-05-09T06:51:59.173' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1095, N'qwe', N'ndVmtJQfOso7CR5MaiatkbVc5BVCrzHNJ0IhXA5I', N'Granit', N'Krasniqi', 1, N'Granit.Krasniqi2020@outlook.com', 1094, CAST(N'2020-05-15T22:46:58.440' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[USERS] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__BillType__F9B8A48B9113602D]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[BillType] ADD UNIQUE NONCLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Genres__F1410CF3D8C7C21C]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[Genres] ADD UNIQUE NONCLUSTERED 
(
	[Genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Language__C3D592504E1214FF]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[Languages] ADD UNIQUE NONCLUSTERED 
(
	[Language] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Material__28129C09DBF0B0C7]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[MaterialTypes] ADD UNIQUE NONCLUSTERED 
(
	[MaterialType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PublishH__B2F457167C3B7410]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[PublishHouses] ADD UNIQUE NONCLUSTERED 
(
	[PublishHouse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__DA15413E0AD0BA79]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TypeOfAc__F9B8A48B1404ADA9]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[TypeOfActions] ADD UNIQUE NONCLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__USERS__536C85E47C2E57BD]    Script Date: 5/18/2020 9:45:10 PM ******/
ALTER TABLE [dbo].[USERS] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Authors] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Authors] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Bills] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Bills] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[BillType] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[BillType] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Borrowings] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Borrowings] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Genres] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Genres] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Genres] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Languages] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Languages] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Languages] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Materials] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Materials] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Materials] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[MaterialTypes] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[MaterialTypes] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[MaterialTypes] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[PublishHouses] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[PublishHouses] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT (getdate()) FOR [ReservationDate]
GO
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Shelves] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Shelves] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Subscribers] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Subscribers] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[TypeOfActions] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[TypeOfActions] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[USERS] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[USERS] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Authors]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Authors]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([BillTypeId])
REFERENCES [dbo].[BillType] ([TypeId])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Materials] ([MaterialId])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([SubscriberId])
REFERENCES [dbo].[Subscribers] ([SubscriberId])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[BillType]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[BillType]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Materials] ([MaterialId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([ShelfId])
REFERENCES [dbo].[Shelves] ([ShelfId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([SubscriberId])
REFERENCES [dbo].[Subscribers] ([SubscriberId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [dbo].[TypeOfActions] ([TypeId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Genres]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Genres]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Languages]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Languages]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genres] ([GenreId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([MaterialTypeId])
REFERENCES [dbo].[MaterialTypes] ([MaterialTypeId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([PublishingHouseId])
REFERENCES [dbo].[PublishHouses] ([PublishHouseId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([ShelfId])
REFERENCES [dbo].[Shelves] ([ShelfId])
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[MaterialTypes]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[MaterialTypes]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[PublishHouses]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[PublishHouses]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Materials] ([MaterialId])
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD FOREIGN KEY([SubscriberId])
REFERENCES [dbo].[Subscribers] ([SubscriberId])
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Shelves]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Shelves]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Subscribers]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[Subscribers]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[TypeOfActions]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[TypeOfActions]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_Delete]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Bills_Delete]
@billID INT

AS

--select * from dbo.Bills;
--exec usp_Bills_Delete 7

IF(@billId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON', 16, 1)
RETURN -1
END

   DELETE FROM dbo.Bills  

   WHERE  BillID = @billID;
GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_GetAll]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Bills_GetAll]
AS
SELECT * FROM dbo.Bills AS b;

--exec usp_Bills_GetAll
GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_GetByID]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Bills_GetByID]
	@billId INT
AS

--exec usp_Bills_GetByID 6

IF(@billId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON', 16, 1)
RETURN -1
END

	SELECT * 
	FROM  dbo.Bills

	WHERE BillId=@billId;

GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_Insert]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Bills_Insert]
	@subscriberId INT,
	@billingDate DATETIME,
	@price MONEY,
	@registrationDate DATETIME=NULL,
	@expirationDate DATETIME=NULL,
	@materialId INT=NULL,
	@billTypeId INT=NULL,
	@description VARCHAR(50)=NULL,
	@insBy INT,

	@billId INT = NULL

AS

--select * from dbo.Bills;
--exec usp_Bills_Insert 13, '2020-02-02', 29.7, '2020-02-08','2021-02-02',null,1,'popo',80

BEGIN TRY 

IF(@subscriberId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON',16,1)
RETURN -1
END

IF(@price<0)
BEGIN
RAISERROR('NUK GUXON TE KETE SASI NEGATIVE', 16, 1)
RETURN -1
END


IF
(@registrationDate>GETDATE())
BEGIN
	RAISERROR('DATA REGJSTRIMIT TE ABONUESIT NUK GUXON TE JETE ME E MADHE SE DATA AKTUALE', 16, 1);
	RETURN -1;
END

IF
(@expirationDate<GETDATE())
BEGIN
	RAISERROR('NUK GUXON TE JETE DATA ME E VOGEL SE DATA AKTUALE', 16, 1);
	RETURN -1;
END

IF(@insBy IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

INSERT INTO dbo.Bills
(
	SubscriberId,
	BillingDate,
	Price,
	RegistrationDate,
	ExpirationDate,
	MaterialId,
	BillTypeId,
	Description,
	InsBy,
	InsDate
)
VALUES
(	
	@subscriberId, @billingDate, @price, @registrationDate, @expirationDate, @materialId, @billTypeId, @description,
	@insBy, GETDATE()
);
	
	--SCOPE IDENTITY
	SET @billId=SCOPE_IDENTITY();

END TRY

BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_Update]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Bills_Update]
	@billId INT,
	@subscriberId INT,
	@billingDate DATETIME,
	@price MONEY,
	@registrationDate DATETIME=NULL,
	@expirationDate DATETIME=NULL,
	@materialId INT=NULL,
	@billTypeId INT,
	@description VARCHAR(50)=NULL,
	@updBy INT
AS

--select * from dbo.Bills;
--exec usp_Bills_Update 6, 12, '2020-02-02', 213.7, '2020-02-08','2021-02-02',null,1,'popo',80

BEGIN TRY

IF(@billId IS NULL)
BEGIN
RAISERROR('KJO FATURE NUK EKZISTON', 16, 1)
RETURN -1
END

IF(@subscriberId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON', 16, 1)
RETURN -1
END

IF
(@billingDate>GETDATE())
BEGIN
	RAISERROR('DATA E FATURIMIT NUK GUXON TE JETE ME E MADHE SE DATA AKTUALE', 16, 1);
	RETURN -1;
END

IF(@price<0)
BEGIN
RAISERROR('NUK GUXON TE KETE SASI NEGATIVE', 16, 1)
RETURN -1
END


IF
(@registrationDate>GETDATE())
BEGIN
	RAISERROR('DATA REGJSTRIMIT TE ABONUESIT NUK GUXON TE JETE ME E MADHE SE DATA AKTUALE', 16, 1);
	RETURN -1;
END

IF
(@expirationDate<GETDATE())
BEGIN
	RAISERROR('NUK GUXON TE JETE DATA ME E VOGEL SE DATA AKTUALE', 16, 1);
	RETURN -1;
END

IF(@updBy IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL, NE KETE RAST', 16, 1)
RETURN -1
END

UPDATE Bills 
           
SET  
    SubscriberId=@subscriberId,
    BillingDate=@billingDate,
	Price=@price,
	RegistrationDate=@registrationDate,
	ExpirationDate=@expirationDate,
	MaterialId=@materialId,
	BillTypeId=@billTypeId,
	Description=@description,
	UpdBy = @updBy,
	UpdDate = GETDATE(),
    UpdNo = ISNULL(UpdNo,0)+1    
				  
WHERE  
	BillId = @billId;

END TRY

BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[usp_BillType_Delete]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_BillType_Delete]
@billTypeId INT

AS

--select * from dbo.BillType;
--exec usp_BillType_Delete 2

IF(@billTypeId IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

   DELETE FROM dbo.BillType  

   WHERE  TypeId = @billTypeId;
GO
/****** Object:  StoredProcedure [dbo].[usp_BillType_GetAll]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_BillType_GetAll]
AS
SELECT * FROM BillType AS bt;

--exec usp_BillType_GetAll
GO
/****** Object:  StoredProcedure [dbo].[usp_BillType_GetByID]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_BillType_GetByID]
	@billTypeId INT
AS

--exec usp_BillType_GetByID 1

IF(@billTypeId IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

	SELECT * 
	FROM  dbo.BillType

	WHERE TypeId=@billTypeId;

GO
/****** Object:  StoredProcedure [dbo].[usp_BillType_Insert]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_BillType_Insert]
	@_billType VARCHAR(50),
	@insBY INT,

	@billTypeId INT = NULL
AS

--select * from dbo.BillType;
--exec usp_BillType_Insert 'Penal', 80

IF(@_billType IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

IF(@insBy IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

INSERT INTO dbo.BillType
(
	Type,
	InsBy,
	InsDate
)
VALUES
(
	@_billType,
	@insBY, GETDATE()
)

	--SCOPE IDENTITY
	SET @billTypeId=SCOPE_IDENTITY();
GO
/****** Object:  StoredProcedure [dbo].[usp_BillType_Update]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_BillType_Update]
	@billTypeId INT,
	@_billType VARCHAR(50),
	@updBy INT

AS

--select * from dbo.BillType;
--exec usp_BillType_Update 1,'Subscriber', 80

IF(@billTypeId IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

IF(@_billType IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

IF(@updBy IS NULL)
BEGIN
RAISERROR('NUK GUXON TE JETE NULL', 16, 1)
RETURN -1
END

UPDATE dbo.BillType 
           
SET    
	Type=@_billType,
	UpdBy = updBy,
	UpdDate = GETDATE(),
    UpdNo = ISNULL(UpdNo,0)+1     
				        
				  
WHERE  
	TypeId = @billTypeId;
GO
/****** Object:  StoredProcedure [dbo].[usp_ChangeUserPassword]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ChangeUserPassword]
@UserId int,
@Password varchar(200),
@UpdBy int

AS
begin

DECLARE @UpdNo int

   SELECT @UpdNo=UpdNo+1  from Users WHERE @UserId = UserId

update dbo.USERS
SET
    dbo.USERS.Password = @Password, -- varchar
    dbo.USERS.UpdBy = 0, -- int
    dbo.USERS.UpdDate = getdate(), -- datetime
    dbo.USERS.UpdNo = @UpdNo -- int
	where UserId = @UserId
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateGenre]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateGenre]
@Genre varchar(50),
@InsBy int,
@Error int OUTPUT


AS
BEGIN

BEGIN TRY 

DECLARE @exist int 

set @exist = 0

SELECT @exist =1  FROM dbo.Genres a WHERE a.Genre = @Genre


if(@exist = 1)
BEGIN

set @Error = 1
END

ELSE 
BEGIN
SET @Error =0
END




DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

INSERT INTO dbo.Genres
(
    --AuthorId - column value is auto-generated
    Genre,
    InsBy,
    InsDate
)
VALUES
(
@Genre,
@InsBy,
@TodayDate
)
END TRY

BEGIN CATCH

RETURN -2

END CATCH 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateLanguage]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateLanguage]
@Language varchar(50),
@InsBy int,
@Error int OUTPUT


AS
BEGIN

BEGIN TRY 

DECLARE @exist int 

set @exist = 0

SELECT @exist = 1  FROM dbo.Languages a WHERE a.Language = @Language


if(@exist = 1)
BEGIN

set @Error = 1
END

ELSE 
BEGIN
SET @Error =0
END






DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

INSERT INTO dbo.Languages
(
    --AuthorId - column value is auto-generated
    [Language],
    InsBy,
    InsDate
)
VALUES
(
@Language,
@InsBy,
@TodayDate
)
END TRY

BEGIN CATCH

RETURN -1

END CATCH 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterial]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateMaterial]
@Title varchar(50), 
@GenreId int ,
@PublishHouse varchar(50) = null,
@PlaceOfPublication varchar(50) = null,
@PublicationYear datetime = null,
@ISBN varchar(50) = null,
@MaterialTypeId int = null,
--@AvailableCoppies int =null,
@Quantity int,
@NumberOfPages int = null,
@LanguageId int,
@InsBy int  ,
@AuthorName varchar(50),
@IsActive bit =1,
@ShelfId int,
@MaterialId int = null



as
BEGIN

BEGIN TRY

BEGIN TRANSACTION 

set @MaterialId = 0

DECLARE @TodayDate datetime 
set @TodayDate =  GETDATE()





SELECT @Materialid = MaterialId
FROM dbo.Materials 
WHERE @Title = Title AND Materials.AuthorId = (SELECT TOP 1  AuthorId  FROM dbo.Authors WHERE @AuthorName = Authors.AuthorName )  






if(@MaterialId =0 )
BEGIN 

DECLARE @AuthorId int
SELECT @AuthorId = a.AuthorId FROM dbo.Authors a WHERE @AuthorName = a.AuthorName



if(@AuthorId IS NULL)
BEGIN

INSERT INTO dbo.Authors
(
    --AuthorId - column value is auto-generated
    AuthorName,
    InsBy,
    InsDate
)
VALUES
(
@AuthorName,
@InsBy,
@TodayDate
)

set @AuthorId = Scope_Identity()
END


DECLARE @PublishHouseId int
SELECT @PublishHouseId = a.PublishHouseId FROM dbo.PublishHouses a WHERE a.PublishHouse = @PublishHouse

if(@PublishHouseId IS NULL)
BEGIN

INSERT INTO dbo.PublishHouses
(
    --AuthorId - column value is auto-generated
    PublishHouse,
    InsBy,
    InsDate
)
VALUES
(
@PublishHouse,
@InsBy,
@TodayDate
)

set @PublishHouseId = Scope_Identity()
END



INSERT INTO dbo.Materials
(
    --MaterialId - column value is auto-generated
    Title,
    GenreId,
    PublishingHouseId,
    PublishYear,
    PlaceOfPublication,
    ISBN,
    MaterialTypeId,
    AvailableCoppies,
    Quantity,
    NumberOfPages,
    LanguageId,
    InsBy,
    InsDate,
    AuthorId,
    IsActive,
	ShelfId
)
VALUES
(
@Title, 
@GenreId ,
@PublishHouseId,
@PublicationYear,
@PlaceOfPublication,
@ISBN,
@MaterialTypeId,
@Quantity,
@Quantity,
@NumberOfPages,
@LanguageId,
@InsBy ,
@TodayDate,
@AuthorId,
@IsActive,
@ShelfId

)

set @MaterialId = scope_identity()



END


else
BEGIN



DECLARE @TempActiveMaterial bit 

SELECT @TempActiveMaterial= m.IsActive FROM dbo.Materials m WHERE @MaterialId= m.MaterialId

if(@TempActiveMaterial = 1)
begin
DECLARE @AvailableCoppies int

SELECT @AvailableCoppies = m.AvailableCoppies + @Quantity FROM dbo.Materials m WHERE MaterialId = @MaterialId

SELECT @Quantity = m.Quantity + @Quantity FROM dbo.Materials m WHERE MaterialId = @MaterialId


	END

	DECLARE @UpdateNo int
	SELECT @UpdateNo = m.UpdNo + 1 FROM dbo.Materials m WHERE MaterialId = @MaterialId

UPDATE dbo.Materials
SET

    dbo.Materials.AvailableCoppies = @AvailableCoppies, -- int
    dbo.Materials.Quantity = @Quantity, -- int
    dbo.Materials.UpdBy = @InsBy, -- int
    dbo.Materials.UpdDate = @TodayDate, -- datetime
    dbo.Materials.UpdNo = @UpdateNo, -- int
    dbo.Materials.IsActive = @IsActive -- bit
	WHERE MaterialId = @MaterialId


END






COMMIT TRANSACTION


END TRY


BEGIN CATCH

ROLLBACK

END CATCH



END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterialType]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateMaterialType]
@MaterialType varchar(50),
@InsBy int,
@Error int OUTPUT


AS
BEGIN

BEGIN TRY 

DECLARE @exist int 

set @exist = 0

SELECT @exist= 1 
FROM MaterialTypes 
WHERE dbo.MaterialTypes.MaterialType = @MaterialType


if(@exist = 1)
BEGIN

set @Error = 1
END

ELSE 
BEGIN
SET @Error =0
END


DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

INSERT INTO dbo.MaterialTypes
(
    --AuthorId - column value is auto-generated
    MaterialType,
    InsBy,
    InsDate
)
VALUES
(
@MaterialType,
@InsBy,
@TodayDate
)



END TRY



BEGIN CATCH


END CATCH



END



GO
/****** Object:  StoredProcedure [dbo].[usp_CreateShelf]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateShelf]
@Location varchar(50),
@Quantity int,
@Description varchar(50) =NULL,
@InsBy int,
@Error int OUTPUT


AS
BEGIN


DECLARE @exist int 

set @exist = 0

SELECT @exist = 1  FROM dbo.Shelves mt WHERE @Location = mt.Location


if(@exist = 1)
BEGIN

set @Error = 1

END

ELSE 

BEGIN

SET @Error =0

END



DECLARE @TodayDate datetime 
set @TodayDate =  GETDATE()

INSERT INTO dbo.Shelves
(
    --ShelfId - column value is auto-generated
    Location,
    Quantity,
    Description,
    InsBy,
    InsDate,
	UpdNo
)
VALUES
(
@Location,
@Quantity,
@Description,
@InsBy,
@TodayDate,
0

)

END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateUsers]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_CreateUsers]
@UserName varchar(50),
@Password VARCHAR(220),
@Name varchar(50),
@LastName varchar(50),
@RoleId varchar(50),
@Email varchar(50) ,
@InsertBy int,
@IsActive bit = 1,
@Error int OUTPUT


AS

BEGIN

BEGIN TRY

declare @InsertDate datetime

SET @InsertDate = GETDATE()



DECLARE @exist int 

set @exist = 0

SELECT @exist = 1  FROM dbo.USERS mt WHERE @Username = mt.Username



if(@exist = 1)
BEGIN

set @Error = 1

Raiserror('User already exists',16,1)

END


ELSE
BEGIN

set @Error = 0

END










INSERT INTO dbo.USERS
(
    --UserId - column value is auto-generated
    Username,
    [Password],
    Name,
    LastName,
    RoleId,
    Email,
    InsBy,
    InsDate,
	dbo.USERS.IsActive

)
VALUES
(
@UserName,
@Password,
@Name,
@LastName,
@RoleId,
@Email,
@InsertBy,
@InsertDate,
@IsActive

)
END TRY

BEGIN CATCH 
return -1
END CATCH 


END 
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteGenre]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteGenre]
@GenreId int

AS 
begin

update dbo.Genres
SET
    --MaterialTypeId - column value is auto-generated
    dbo.Genres.IsActive =0
	WHERE dbo.Genres.GenreId = @GenreId
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteLanguage]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteLanguage]

@LanguageId int

AS 
begin

update dbo.Languages
SET
    --MaterialTypeId - column value is auto-generated
    dbo.Languages.IsActive =0
	WHERE @LanguageId = dbo.Languages.LanguageId
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterial]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteMaterial]
@MaterialiId int

AS BEGIN

UPDATE dbo.Materials
SET
    dbo.Materials.IsActive = 0 
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterialType]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteMaterialType]
@MaterialTypeId int

AS 
begin

update dbo.MaterialTypes
SET
    --MaterialTypeId - column value is auto-generated
    dbo.MaterialTypes.IsActive =0
	WHERE MaterialTypes.MaterialTypeId = @MaterialTypeId
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteUser]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteUser]
@UserId int


AS
BEGIN

  UPDATE dbo.USERS

 SET 
 dbo.USERS.IsActive = 0
where Users.UserId = @UserId

end
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllGenres]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllGenres]


AS

SELECT * FROM genres 
WHERE dbo.genres.IsActive = 1;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllLanguages]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[usp_GetAllLanguages]



AS BEGIN


SELECT * FROM languages

end
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllMaterialTypes]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllMaterialTypes]

AS

SELECT * FROM dbo.MaterialTypes mt WHERE mt.IsActive =1;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllRoles]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllRoles]
AS
BEGIN

SELECT * FROM dbo.Roles s
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllShelves]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllShelves]
AS
BEGIN

SELECT * FROM dbo.Shelves s
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllUsers]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllUsers]

AS

SELECT u.UserId AS UserId,u.Username AS Username, u.Name AS Name, u.LastName AS LastName, u.RoleId AS RoleId,r.Role AS Role, u.Email AS Email,u.InsBy AS InsBy,u.InsDate AS InsDate,u.UpdBy AS UpdBy,u.UpdDate,u.UpdNo AS UpdNo,u.IsActive AS IsActive , u.Password
FROM dbo.USERS u 
JOIN dbo.Roles r 
ON u.RoleId = r.RoleId;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUser]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetUser]
@UserId int

AS
BEGIN




SELECT u.UserId AS UserId,u.Username AS Username, u.Name AS Name, u.LastName AS LastName, u.RoleId AS RoleId,r.Role AS Role, u.Email AS Email,u.InsBy AS InsBy,u.InsDate AS InsDate,u.UpdBy AS UpdBy,u.UpdDate,u.UpdNo AS UpdNo,u.IsActive AS IsActive 
FROM dbo.USERS u 
JOIN dbo.Roles r 
ON u.RoleId = r.RoleId
WHERE @UserId = u.UserId

END
GO
/****** Object:  StoredProcedure [dbo].[usp_LogIn]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LogIn]
@UserName varchar(50),
@Password varchar(50)


AS
BEGIN




SELECT u.UserId,u.Username, u.Name, u.LastName, u.RoleId,r.Role, u.Email,u.InsBy,u.InsDate,u.UpdBy,u.UpdDate,u.UpdNo,u.IsActive,u.Password
FROM dbo.USERS u 
JOIN dbo.Roles r 
ON u.RoleId = r.RoleId
WHERE u.Username = @UserName AND u.Password = @Password

END
GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Delete]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_Delete]
	@subscriberId INT

AS

IF(@subscriberId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON', 16, 1)
RETURN -1
END

UPDATE dbo.Subscribers
SET
   dbo.Subscribers.IsActive = 0 

   WHERE  @subscriberId = dbo.Subscribers.SubscriberId;
GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_GetAll]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_GetAll]
AS
SELECT *   FROM   dbo.Subscribers AS s;

--exec usp_Subscribers_GetAll
GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_GetByID]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_GetByID]
	@subscriberId INT
AS

--exec usp_Subscribers_GetByID 20

IF(@subscriberId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON', 16, 1)
RETURN -1
END

BEGIN
	SELECT *
	FROM  dbo.Subscribers

	WHERE SubscriberId=@subscriberId;

END
GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Insert]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_Insert]
	@name VARCHAR(50),
	@lastName VARCHAR(50),
	@address VARCHAR(100),
	@birthday DATETIME=NULL,
	@personalNumber VARCHAR(30)=NULL,
	@phoneNumber VARCHAR(50),
	@email VARCHAR(50),
	@gender VARCHAR(1),
	@expirationDate DATETIME,
	@isActive BIT,
	@insBy INT,

	@subscriberId INT = NULL
	
AS
--delete from dbo.Subscribers where SubscriberId=15;
--select * from dbo.Subscribers;
--exec usp_Subscribers_Insert 'G1','krasniqi','Dr','2020-02-02','','89','g@k','M', '2029-02-02', 1, 80
BEGIN TRY
IF(TRIM(@name)= '')
BEGIN
	RAISERROR('EMRI NUK GUXON TE JETE I ZBRAZET',16,1);
	RETURN -1;
END

IF(TRIM(@lastName) = '')
BEGIN
	RAISERROR('MBIEMRI NUK GUXON TE JETE I ZBRAZET',16,1);
	RETURN -1;
END

IF(TRIM(@address) = '')
BEGIN
	RAISERROR('ADRESA NUK GUXON TE JETE I ZBRAZET',16,1);
	RETURN -1;
END

IF(@birthday>GETDATE())
BEGIN
	RAISERROR('DATELINDJA NUK GUXON TE JETE ME E MADHE SE DATA AKTUALE',16,1);
	RETURN -1;
END

IF
(@expirationDate<GETDATE())
BEGIN
	RAISERROR('NUK GUXON TE JETE DATA ME E VOGEL SE DATA AKTUALE',16,1);
	RETURN -1;
END

INSERT INTO dbo.Subscribers
(
	Name,
	LastName,
	Address,
	Birthday,
	PersonalNumber,
	PhoneNumber,
	Email,
	Gender,
	EndDate,
	IsActive,
	InsBy,
	InsDate
)
VALUES
(	
	@name, @lastName, @address, @birthday, @personalNumber, @phoneNumber, @email, @gender, @expirationDate, 1,
	@insBy, GETDATE()
);
	

	--SCOPE IDENTITY
	SET @subscriberId=SCOPE_IDENTITY();

END TRY

BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Update]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_Update]
	@subscriberId INT,
	@name VARCHAR(50),
	@lastName VARCHAR(50),
	@address VARCHAR(100),
	@birthday DATE=NULL,
	@personalNumber VARCHAR(30)=NULL,
	@phoneNumber VARCHAR(50),
	@email VARCHAR(50),
	@gender VARCHAR(1),
	@expirationDate DATETIME,
	@isActive BIT,
	@updBy INT=NULL--,
	--@insDate INT
AS


--select * from dbo.Subscribers;
--exec usp_Subscribers_Update 15,'aa','aa','aa','2020-02-02','aa','aa','aa','F', '2029-02-02', 1, 80
BEGIN TRY

IF(@subscriberId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON',16,1)
RETURN -1
END

IF(TRIM(@name) = '')
BEGIN
	RAISERROR('EMRI NUK GUXON TE JETE I ZBRAZET',16,1);
	RETURN -1;
END

IF(TRIM(@lastName) = '')
BEGIN
	RAISERROR('MBIEMRI NUK GUXON TE JETE I ZBRAZET',16,1);
	RETURN -1;
END

IF(TRIM(@address) = '')
BEGIN
	RAISERROR('ADRESA NUK GUXON TE JETE I ZBRAZET',16,1);
	RETURN -1;
END

IF(@birthday>GETDATE())
BEGIN
	RAISERROR('DATELINDJA NUK GUXON TE JETE ME E MADHE SE DATA AKTUALE',16,1);
	RETURN -1;
END

IF
(@expirationDate <GETDATE())
BEGIN
	RAISERROR('NUK GUXON TE JETE DATA ME E VOGEL SE DATA AKTUALE',16,1);
	RETURN -1;
END


UPDATE Subscribers 
           
SET    
	Name = @name,  
    LastName = @lastName,  
    Address = @address, 
    Birthday = @birthday,
	PersonalNumber = @personalNumber,
	PhoneNumber = @phoneNumber,
	Email = @email,
	Gender = @gender,
	EndDate = @expirationDate,
	IsActive = 1,
	--InsDate=@insDate,
	UpdBy = @updBy,
	UpdDate = GETDATE(),
    UpdNo = ISNULL(UpdNo,0)+1    
				        
				  
WHERE  
	SubscriberId = @subscriberId;

END TRY

BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateGenre]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateGenre]
@GenreId int,
@Genre varchar(50),
@UpdBy int,
@Error int OUTPUT


AS
BEGIN

BEGIN TRY 

DECLARE @exist int 

set @exist = 0

SELECT @exist = 1  FROM dbo.Genres mt WHERE @Genre = mt.Genre


if(@exist = 1)
BEGIN

set @Error = 1

END

ELSE 
BEGIN

SET @Error =0

END


DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()


DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo+ 1  FROM dbo.Genres mt WHERE @GenreId = mt.GenreId


UPDATE dbo.Genres
SET

    dbo.Genres.Genre = @Genre, -- varchar
    dbo.Genres.UpdBy = @UpdBy, -- int
    dbo.Genres.UpdDate = @TodayDate, -- datetime
    dbo.Genres.UpdNo = @UpdNo -- intalTypes

WHERE @GenreId = Genres.GenreId

END TRY

BEGIN CATCH 
RETURN -1
END CATCH 

END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateLanguage]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateLanguage]
@LanguageId int,
@Language varchar(50),
@UpdBy int,
@Error int OUTPUT


AS
BEGIN

BEGIN TRY 

DECLARE @exist int 

set @exist = 0

SELECT @exist =1  FROM dbo.Languages mt WHERE @Language = mt.Language


if(@exist = 1)
BEGIN

set @Error = 1

END

ELSE 
BEGIN
SET @Error =0
END

DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo +1 FROM dbo.Languages mt WHERE @LanguageId = mt.LanguageId

UPDATE dbo.Languages
SET

    dbo.Languages.[Language] = @Language, -- varchar
    dbo.Languages.UpdBy = @UpdBy, -- int
    dbo.Languages.UpdDate = @TodayDate, -- datetime
    dbo.Languages.UpdNo = @UpdNo -- intalTypes
WHERE @LanguageId = Languages.LanguageId
END TRY

BEGIN CATCH 
RETURN -1
END CATCH 
END


GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateMaterial]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_UpdateMaterial]
@MaterialId int out,
@Title varchar(50), 
@GenreId int ,
@PublishHouse varchar(50) = null,
@PublishHouseId int = null,
@PlaceOfPublication varchar(50) = null,
@PublicationYear datetime = null,
@ISBN varchar(50) = null,
@MaterialTypeId int,
@AvailableCoppies int,
@Quantity int,
@NumberOfPages int = null,
@LanguageId int,
@UpdId int,
@Author VARCHAR(50) ,
@AuthorId int,
@IsActive bit =1

AS
BEGIN

BEGIN TRANSACTION 

BEGIN TRY



DECLARE @exists bit

SELECT @exists = 1 FROM Materials WHERE @MaterialId = dbo.Materials.MaterialId

if(@exists = 0)
BEGIN
raiserror('This material does not exist',16,1)
END

DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo +1 FROM dbo.MaterialTypes mt WHERE @MaterialTypeId = mt.MaterialTypeId





UPDATE dbo.Authors
SET
    dbo.Authors.AuthorName = @Author, 
    dbo.Authors.UpdBy = @UpdId,
    dbo.Authors.UpdDate = @TodayDate,
    dbo.Authors.UpdNo = @UpdNo 
	WHERE Authors.AuthorId = @AuthorId

	UPDATE dbo.PublishHouses
	SET
	    --PublishHouseId - column value is auto-generated
	    dbo.PublishHouses.PublishHouse = @PublishHouse, -- varchar
	    dbo.PublishHouses.UpdBy = @UpdId, -- int
	    dbo.PublishHouses.UpdDate = @TodayDate, -- datetime
	    dbo.PublishHouses.UpdNo = @UpdNo -- int
		WHERE PublishHouses.PublishHouseId = @PublishHouseId

UPDATE dbo.Materials
SET
    --MaterialId - column value is auto-generated
    dbo.Materials.Title = @Title, -- varchar
    dbo.Materials.GenreId = @GenreId, -- int
    dbo.Materials.PublishingHouseId = @PublishHouse, -- int
    dbo.Materials.PublishYear = @PlaceOfPublication, -- date
    dbo.Materials.PlaceOfPublication = @PublicationYear, -- varchar
    dbo.Materials.ISBN = @ISBN, -- varchar
    dbo.Materials.MaterialTypeId = @MaterialTypeId, -- int
    dbo.Materials.AvailableCoppies = @AvailableCoppies, -- int
    dbo.Materials.Quantity = @Quantity, -- int
    dbo.Materials.NumberOfPages = @NumberOfPages, -- int
    dbo.Materials.LanguageId = @LanguageId, -- int
    dbo.Materials.UpdBy = @UpdId, -- int
    dbo.Materials.UpdDate = @TodayDate, -- datetime
    dbo.Materials.UpdNo = @UpdNo, -- int
    dbo.Materials.AuthorId = @AuthorId, -- int
    dbo.Materials.IsActive = @IsActive -- bit
	WHERE Materials.MaterialId = @MaterialId

	COMMIT TRANSACTION 
END TRY


 
BEGIN CATCH 


ROLLBACK TRANSACTION



END CATCH
END 

GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateMaterialType]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateMaterialType]
@MaterialTypeId int,
@MaterialType varchar(50),
@UpdBy int,
@Error int OUTPUT


AS
BEGIN

BEGIN TRY 

DECLARE @exist int 

set @exist = 0

SELECT @exist = 1  FROM dbo.MaterialTypes mt WHERE @MaterialType = mt.MaterialType


if(@exist = 1)
BEGIN

set @Error = 1

END

ELSE 
BEGIN

SET @Error =0

END

DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo +1 FROM dbo.MaterialTypes mt WHERE @MaterialTypeId = mt.MaterialTypeId

UPDATE dbo.MaterialTypes
SET

    dbo.MaterialTypes.MaterialType = @MaterialType, -- varchar
    dbo.MaterialTypes.UpdBy = @UpdBy, -- int
    dbo.MaterialTypes.UpdDate = @TodayDate, -- datetime
    dbo.MaterialTypes.UpdNo = @UpdNo -- intalTypes
	WHERE @MaterialTypeId = MaterialTypeId
	END TRY
BEGIN CATCH 
RETURN -1
END CATCH 
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateShelf]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_UpdateShelf]
@ShelfId int,
@Location varchar(50),
@Quantity int,
@Description varchar(50) = null,
@UpdBy int,
@Error int OUTPUT


AS
BEGIN

BEGIN TRY 

DECLARE @exist int 

set @exist = 0

SELECT @exist = 1  FROM dbo.Shelves mt WHERE @Location = mt.Location


if(@exist = 1)
BEGIN

set @Error = 1

END

ELSE 

BEGIN

SET @Error =0

END


	DECLARE @UpdateNo int
	SELECT @UpdateNo = s.UpdNo + 1 
	FROM dbo.Shelves s  
	WHERE @ShelfId =ShelfId

	DECLARE @TodayDate datetime 
set @TodayDate =  GETDATE()

UPDATE dbo.Shelves
SET
    --ShelfId - column value is auto-generated
    dbo.Shelves.Location = @Location, -- varchar
    dbo.Shelves.Quantity = @Quantity, -- int
    dbo.Shelves.Description = @Description, -- varchar
    dbo.Shelves.UpdBy = @UpdBy, -- int
    dbo.Shelves.UpdDate = @TodayDate, -- datetime
    dbo.Shelves.UpdNo = @UpdateNo -- int
	END TRY
	BEGIN CATCH
	RETURN -1
	END CATCH 
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateUser]    Script Date: 5/18/2020 9:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateUser]
@UserId int = null,
@Username varchar(50),--me validu username ne c#(nuk duhet me kan null)
@Name varchar(50) ,
@LastName varchar(50) ,
@RoleId int,
@Email varchar(50),
@UpdBy int,--me validu LastUpdateBy ne c#(nuk duhet me kan null)
@UbdDate datetime = null,
@UpdNo int= null,
@IsActive bit,
@Error int OUTPUT


AS

BEGIN

BEGIN TRY

declare @InsertDate datetime

SET @InsertDate = GETDATE()



DECLARE @exist int 

set @exist = 0


SELECT @UserId = u.UserId  from Users AS u WHERE @Username = u.Username

  if(@UserId IS NULL)
  BEGIN
  set @Error = 2
raiserror('This User does not exist',16,1)
END

ELSE

BEGIN

set @error = 0
END


   SELECT @UpdNo=UpdNo+1  from Users WHERE @UserId = UserId


  UPDATE dbo.USERS

 SET 
 Name = @Name,
 LastName= @LastName,
 RoleId = @RoleId,
 Email = @Email,
  dbo.USERS.UpdBy = @UpdBy,
 USERS.UpdDate  = GETDATE(),
 UpdNo = @UpdNo,
 IsActive = @IsActive
where Users.UserId = @UserId





END TRY

BEGIN CATCH 
RETURN -1;
END CATCH 




END
GO
USE [master]
GO
ALTER DATABASE [LibraryManagement] SET  READ_WRITE 
GO
