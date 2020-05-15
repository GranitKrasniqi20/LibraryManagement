USE [master]
GO
/****** Object:  Database [LibraryManagement]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Authors]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Bills]    Script Date: 5/9/2020 11:50:24 PM ******/
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
	[BillTypeId] [int] NOT NULL,
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
/****** Object:  Table [dbo].[BillType]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Borrowings]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Genres]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Languages]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Materials]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[MaterialTypes]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[PublishHouses]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Reservations]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Roles]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Shelves]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[Subscribers]    Script Date: 5/9/2020 11:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscribers](
	[SubscriberId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Birthday] [datetime] NULL,
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
/****** Object:  Table [dbo].[TypeOfActions]    Script Date: 5/9/2020 11:50:24 PM ******/
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
/****** Object:  Table [dbo].[USERS]    Script Date: 5/9/2020 11:50:24 PM ******/
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

INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, 12, CAST(N'2020-02-02T00:00:00.000' AS DateTime), 213.7000, CAST(N'2020-02-08T00:00:00.000' AS DateTime), CAST(N'2021-02-02T00:00:00.000' AS DateTime), NULL, 1, N'popo', 80, CAST(N'2020-05-09T18:36:53.017' AS DateTime), NULL, CAST(N'2020-05-09T18:41:39.417' AS DateTime), 1)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (8, 13, CAST(N'2020-02-02T00:00:00.000' AS DateTime), 29.7000, CAST(N'2020-02-08T00:00:00.000' AS DateTime), CAST(N'2021-02-02T00:00:00.000' AS DateTime), NULL, 1, N'popo', 80, CAST(N'2020-05-09T18:47:16.397' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Bills] OFF
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

INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (12, N'Granit', N'krasniqi', N'Dri', CAST(N'2020-02-02T00:00:00.000' AS DateTime), N'13', N'89', N'g@k', N'M', CAST(N'2021-02-02' AS Date), 80, CAST(N'2020-05-09T18:07:30.113' AS DateTime), NULL, CAST(N'2020-05-09T18:22:54.440' AS DateTime), 3, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (13, N'Granit', N'krasniqi', N'Dri', CAST(N'2020-02-02T00:00:00.000' AS DateTime), N'13', N'89', N'g@k', N'M', CAST(N'2021-02-02' AS Date), 80, CAST(N'2020-05-09T18:08:00.017' AS DateTime), NULL, CAST(N'2020-05-09T19:03:24.220' AS DateTime), 1, 1)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (14, N'G1', N'krasniqi', N'Dr', CAST(N'2020-02-02T00:00:00.000' AS DateTime), N'', N'89', N'g@k', N'M', CAST(N'2029-02-02' AS Date), 80, CAST(N'2020-05-09T18:17:13.140' AS DateTime), NULL, NULL, 0, 1)
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
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1094, N'Granit.k', N'oT85yfpeo52M3rlX41/kb9XmsptxGUqZqxBWRjKL', N'Granit', N'Krasniqi', 1, N'Granit.Krasniqi2020@outlook.com', 80, CAST(N'2020-05-09T06:51:59.173' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[USERS] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__BillType__F9B8A48B41D0F259]    Script Date: 5/9/2020 11:50:25 PM ******/
ALTER TABLE [dbo].[BillType] ADD UNIQUE NONCLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Genres__F1410CF3B0D2EBF6]    Script Date: 5/9/2020 11:50:25 PM ******/
ALTER TABLE [dbo].[Genres] ADD UNIQUE NONCLUSTERED 
(
	[Genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Language__C3D5925022A28CE2]    Script Date: 5/9/2020 11:50:25 PM ******/
ALTER TABLE [dbo].[Languages] ADD UNIQUE NONCLUSTERED 
(
	[Language] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Material__28129C09EAF9EACE]    Script Date: 5/9/2020 11:50:25 PM ******/
ALTER TABLE [dbo].[MaterialTypes] ADD UNIQUE NONCLUSTERED 
(
	[MaterialType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PublishH__B2F45716A990AA16]    Script Date: 5/9/2020 11:50:25 PM ******/
ALTER TABLE [dbo].[PublishHouses] ADD UNIQUE NONCLUSTERED 
(
	[PublishHouse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__DA15413E1079E7F7]    Script Date: 5/9/2020 11:50:25 PM ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TypeOfAc__F9B8A48B63B8608E]    Script Date: 5/9/2020 11:50:25 PM ******/
ALTER TABLE [dbo].[TypeOfActions] ADD UNIQUE NONCLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__USERS__536C85E4C95273F2]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Bills_Delete]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Bills_GetAll]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Bills_GetAll]
AS
SELECT * FROM dbo.Bills AS b;

--exec usp_Bills_GetAll
GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_GetByID]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Bills_Insert]    Script Date: 5/9/2020 11:50:25 PM ******/
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
	@billTypeId INT,
	@description VARCHAR(50)=NULL,
	@insBY INT,

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
	@insBY, GETDATE()
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
/****** Object:  StoredProcedure [dbo].[usp_Bills_Update]    Script Date: 5/9/2020 11:50:25 PM ******/
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
	@updBY INT
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
	UpdBy = updBy,
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
/****** Object:  StoredProcedure [dbo].[usp_BillType_Delete]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_BillType_GetAll]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_BillType_GetAll]
AS
SELECT * FROM BillType AS bt;

--exec usp_BillType_GetAll
GO
/****** Object:  StoredProcedure [dbo].[usp_BillType_GetByID]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_BillType_Insert]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_BillType_Update]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_ChangeUserPassword]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateGenre]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateLanguage]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterial]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterialType]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateShelf]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateUsers]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteGenre]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteLanguage]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterial]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterialType]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteUser]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetAllGenres]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllGenres]


AS

SELECT * FROM genres 
WHERE dbo.genres.IsActive = 1;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllLanguages]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[usp_GetAllLanguages]



AS BEGIN


SELECT * FROM languages

end
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllMaterialTypes]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllMaterialTypes]

AS

SELECT * FROM dbo.MaterialTypes mt WHERE mt.IsActive =1;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllRoles]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetAllShelves]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetAllUsers]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetUser]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_LogIn]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Delete]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_GetAll]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_GetAll]
AS
SELECT *   FROM   dbo.Subscribers AS s;

--exec usp_Subscribers_GetAll
GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_GetByID]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_GetByID]
	@subscriberID INT
AS

--exec usp_Subscribers_GetByID 12

IF(@subscriberId IS NULL)
BEGIN
RAISERROR('KY ABONUES NUK EKZISTON', 16, 1)
RETURN -1
END

BEGIN
	SELECT * 
	FROM  dbo.Subscribers

	WHERE SubscriberID=@subscriberID;

END
GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Insert]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Update]    Script Date: 5/9/2020 11:50:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[usp_Subscribers_Update]
	@subscriberId INT,
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
	@updBy INT=NULL
AS


--select * from dbo.Subscribers;
--exec usp_Subscribers_Update 13,'Granit','krasniqi','Dri','2020-02-02','13','89','g@k','M','2021-02-02', 1

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
	UpdBy = updBy,
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateGenre]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateLanguage]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateMaterial]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateMaterialType]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateShelf]    Script Date: 5/9/2020 11:50:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateUser]    Script Date: 5/9/2020 11:50:25 PM ******/
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
