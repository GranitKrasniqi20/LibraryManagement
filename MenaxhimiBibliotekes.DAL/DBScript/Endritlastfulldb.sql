USE [master]
GO
/****** Object:  Database [LibraryManagement]    Script Date: 5/20/2020 11:25:08 AM ******/
CREATE DATABASE [LibraryManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.ET\MSSQL\DATA\LibraryManagement.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LibraryManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.ET\MSSQL\DATA\LibraryManagement_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
USE [LibraryManagement]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BillType]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Borrowings]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreId] [int] IDENTITY(1,1) NOT NULL,
	[Genre] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageId] [int] IDENTITY(1,1) NOT NULL,
	[Language] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
	[NumberOfPages] [int] NULL,
	[LanguageId] [int] NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
	[AuthorId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
	[ShelfId] [int] NOT NULL,
	[MaterialQuantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaterialTypes]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaterialTypes](
	[MaterialTypeId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialType] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PublishHouses]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PublishHouses](
	[PublishHouseId] [int] IDENTITY(1,1) NOT NULL,
	[PublishHouse] [varchar](50) NOT NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[PublishHouseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 5/20/2020 11:25:08 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[InsBy] [int] NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shelves]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shelves](
	[ShelfId] [int] IDENTITY(1,1) NOT NULL,
	[Location] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Description] [varchar](250) NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ShelfId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subscribers]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TypeOfActions]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
	[InsDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL DEFAULT ((0)),
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'endrit tmava', 80, CAST(N'2020-05-03 02:27:31.690' AS DateTime), 80, CAST(N'2020-05-20 11:02:55.380' AS DateTime), 3)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'sdasdasd', 80, CAST(N'2020-05-06 00:07:46.023' AS DateTime), 80, CAST(N'2020-05-15 21:11:07.807' AS DateTime), 1)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'asdas', 80, CAST(N'2020-05-06 00:24:45.637' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, N'Beis Presheva', 80, CAST(N'2020-05-06 00:38:44.203' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (10, N'beispresheva', 80, CAST(N'2020-05-06 14:12:50.453' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (11, N'Endrittmava', 80, CAST(N'2020-05-06 14:29:38.967' AS DateTime), 80, CAST(N'2020-05-07 04:27:36.257' AS DateTime), 2)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (12, N'aadsasasddaasda', 80, CAST(N'2020-05-06 14:30:34.443' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (13, N'ditaa', 80, CAST(N'2020-05-06 14:30:56.697' AS DateTime), 80, CAST(N'2020-05-15 21:44:44.163' AS DateTime), 1)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (14, N'endrittmavasdf', 80, CAST(N'2020-05-06 14:34:54.280' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (15, N'kushasdf', 80, CAST(N'2020-05-19 04:15:41.857' AS DateTime), 80, CAST(N'2020-05-19 04:31:53.857' AS DateTime), 1)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (16, N'prishtyna', 80, CAST(N'2020-05-19 22:44:29.717' AS DateTime), 80, CAST(N'2020-05-19 23:07:16.427' AS DateTime), 1)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (17, N'endrit', 80, CAST(N'2020-05-20 05:02:16.640' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (18, N'adasdasd', 80, CAST(N'2020-05-20 05:07:16.020' AS DateTime), 80, CAST(N'2020-05-20 05:07:41.340' AS DateTime), 1)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (19, N'asdasdasdas', 80, CAST(N'2020-05-20 11:03:46.070' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'Fantadczxdsczxsa', 80, CAST(N'2020-05-03 01:30:49.123' AS DateTime), 80, CAST(N'2020-05-05 03:37:45.967' AS DateTime), 2, 0)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (2, N'diti', 80, CAST(N'2020-05-04 04:05:31.023' AS DateTime), 80, CAST(N'2020-05-05 00:02:36.733' AS DateTime), 2, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'edfsdfs&', 80, CAST(N'2020-05-04 04:07:51.580' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (7, N'zhndrias', 80, CAST(N'2020-05-04 21:52:26.353' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (8, N'asdasdsaasd', 80, CAST(N'2020-05-04 23:31:29.403' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (15, N'helloworld', 80, CAST(N'2020-05-05 02:07:16.420' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (17, N'dfgfdg', 80, CAST(N'2020-05-05 14:24:36.827' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (18, N'gfsdfsdf', 80, CAST(N'2020-05-05 23:08:12.413' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (20, N'zhand', 80, CAST(N'2020-05-19 18:16:20.297' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (21, N'adsadaaaay', 80, CAST(N'2020-05-20 10:43:33.473' AS DateTime), 80, CAST(N'2020-05-20 10:56:11.910' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Genres] OFF
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'shqipe', 80, CAST(N'2020-05-03 01:30:49.153' AS DateTime), 80, CAST(N'2020-05-05 02:42:38.417' AS DateTime), 8, 0)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'Shqip2', 80, CAST(N'2020-05-03 18:10:15.797' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (4, N'English', 80, CAST(N'2020-05-04 00:22:59.137' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (5, N'English10', 80, CAST(N'2020-05-04 00:25:11.073' AS DateTime), 80, CAST(N'2020-05-04 00:29:50.477' AS DateTime), 1, 0)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (12, N'shqipeeee', 80, CAST(N'2020-05-04 02:12:14.443' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (13, N'gjuhashqipe', 80, CAST(N'2020-05-04 02:13:33.283' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (14, N'Gjuha shqipe', 80, CAST(N'2020-05-04 02:19:00.860' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (15, N'english (uk)', 80, CAST(N'2020-05-04 02:27:39.637' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (17, N'asdasd', 80, CAST(N'2020-05-04 02:33:03.813' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1004, N'shqipees', 80, CAST(N'2020-05-04 21:01:01.617' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1005, N'asdasdsadabeis beis', 80, CAST(N'2020-05-04 21:01:46.560' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1006, N'asdadsdaaa3dd', 80, CAST(N'2020-05-05 01:43:08.020' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1008, N'helloworld', 80, CAST(N'2020-05-05 01:46:32.477' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1009, N'sdfsdfsd', 80, CAST(N'2020-05-05 02:45:23.743' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1011, N'asdasdasd', 80, CAST(N'2020-05-05 14:18:03.360' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1013, N'shqipee', 80, CAST(N'2020-05-05 14:18:18.723' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1017, N'shqipe342', 80, CAST(N'2020-05-05 14:20:13.017' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1019, N'shqipeas', 80, CAST(N'2020-05-05 23:09:09.140' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1020, N'asdasddsaadsyyy', 80, CAST(N'2020-05-20 10:59:31.890' AS DateTime), 80, CAST(N'2020-05-20 11:00:29.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET IDENTITY_INSERT [dbo].[Materials] ON 

INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1019, N'kosova', 7, 1, CAST(N'2020-05-15' AS Date), N'prishtine', N'', 6, 0, 41, 1013, 80, CAST(N'2020-05-06 14:29:38.967' AS DateTime), 80, CAST(N'2020-05-15 21:03:35.823' AS DateTime), 4, 1, 1, 2, 12)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1020, N'tryagain', 1, 1, CAST(N'2020-05-07' AS Date), N'FFK', NULL, 1, 4, NULL, 1, 80, CAST(N'2020-05-06 14:30:34.443' AS DateTime), 80, CAST(N'2020-05-07 04:23:54.533' AS DateTime), 2, 1, 1, 2, 2)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1021, N'beis', 7, 16, NULL, N'asdasdasd', N'', 6, 12, 131, 1011, 80, CAST(N'2020-05-06 14:30:56.697' AS DateTime), NULL, NULL, 0, 13, 1, 2, 2)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1022, N'endrittmavaasa', 7, 17, NULL, N'asdasdasd', N'', 3, 13, 151, 4, 80, CAST(N'2020-05-06 14:34:54.280' AS DateTime), NULL, NULL, 0, 14, 1, 3, 2)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1023, N'testtest', 7, 1, NULL, N'prishtine', N'1234567890123', 6, 41, 511, 1013, 80, CAST(N'2020-05-07 05:06:25.280' AS DateTime), NULL, NULL, 0, 11, 1, 2, 2)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1024, N'asdasd', 7, 1, CAST(N'2020-05-15' AS Date), N'fkhjghjg', N'', 3, 0, 411, 5, 80, CAST(N'2020-05-15 21:09:12.147' AS DateTime), 80, CAST(N'2020-05-15 21:11:07.807' AS DateTime), 1, 1, 1, 2, 50)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1025, N'ksss', 2, 1, CAST(N'2020-05-15' AS Date), N'prishtinas', N'', 3, 0, 611, 1019, 80, CAST(N'2020-05-15 21:37:46.797' AS DateTime), 80, CAST(N'2020-05-15 21:44:44.163' AS DateTime), 1, 1, 0, 2, 51)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1026, N'endrittos', 15, 1, CAST(N'2020-05-19' AS Date), N'prishtinefsddf', N'', 6, 31, 513, 1011, 80, CAST(N'2020-05-19 04:15:41.857' AS DateTime), 80, CAST(N'2020-05-19 04:31:53.857' AS DateTime), 1, 1, 1, 3, 311)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1027, N'asdasd', 8, 21, NULL, N'prishtine', N'', 3, 31, 111, 1013, 80, CAST(N'2020-05-19 22:44:29.717' AS DateTime), NULL, NULL, 0, 16, 1, 2, 31)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1028, N'materialsss', 15, 1, CAST(N'2020-05-19' AS Date), N'prishtine', N'1234567890234', 7, 31, 111, 1013, 80, CAST(N'2020-05-19 22:45:32.510' AS DateTime), 80, CAST(N'2020-05-19 23:08:57.360' AS DateTime), 2, 1, 0, 2, 31)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1029, N'provimfinal', 7, 23, NULL, N'prish', N'1233211233210', 5, 314, 41, 3, 80, CAST(N'2020-05-20 05:02:16.640' AS DateTime), NULL, NULL, 0, 17, 1, 4, 314)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1030, N'endrittyyyy', 8, 1, CAST(N'2020-05-20' AS Date), N'adasdasd', N'1233211233211', 5, 14, 51, 1009, 80, CAST(N'2020-05-20 05:07:16.020' AS DateTime), 80, CAST(N'2020-05-20 11:02:55.380' AS DateTime), 3, 1, 1, 2, 14)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [PlaceOfPublication], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (1031, N'adasdas', 2, 25, CAST(N'2019-01-01' AS Date), N'pryshtyna', N'1233212224321', 3, 45, 151, 1013, 80, CAST(N'2020-05-20 11:03:46.070' AS DateTime), NULL, NULL, 0, 19, 0, 4, 45)
SET IDENTITY_INSERT [dbo].[Materials] OFF
SET IDENTITY_INSERT [dbo].[MaterialTypes] ON 

INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'Adsad', 80, CAST(N'2020-05-03 01:31:49.610' AS DateTime), 80, CAST(N'2020-05-05 03:41:57.273' AS DateTime), 3, 0)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (2, N'adasdasda', 80, CAST(N'2020-05-04 04:50:50.767' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'liber', 80, CAST(N'2020-05-04 20:56:10.157' AS DateTime), 80, CAST(N'2020-05-20 00:13:58.040' AS DateTime), 3, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (5, N'Gjuh shqipeee', 80, CAST(N'2020-05-05 01:17:55.433' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (6, N'Gjuh shqipeeeee', 80, CAST(N'2020-05-05 01:22:12.670' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (7, N'adasda', 80, CAST(N'2020-05-05 01:22:26.647' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (11, N'asdadasdasddddddd', 80, CAST(N'2020-05-05 01:29:02.340' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (12, N'asdadsdaaa3dd', 80, CAST(N'2020-05-05 01:34:10.587' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (14, N'helloo', 80, CAST(N'2020-05-05 14:17:13.397' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (15, N'fadf', 80, CAST(N'2020-05-05 23:09:14.977' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (16, N'shqipe', 80, CAST(N'2020-05-05 23:09:22.890' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (18, N'Genres', 80, CAST(N'2020-05-19 18:09:18.093' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (19, N'asdtype', 80, CAST(N'2020-05-19 23:49:26.467' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (20, N'testtestttttt', 80, CAST(N'2020-05-20 10:36:59.550' AS DateTime), 80, CAST(N'2020-05-20 10:37:57.790' AS DateTime), 2, 1)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (21, N'asdasdasdssss', 80, CAST(N'2020-05-20 11:22:33.603' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[MaterialTypes] OFF
SET IDENTITY_INSERT [dbo].[PublishHouses] ON 

INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'Dukagjini', 80, CAST(N'2020-05-03 02:27:31.690' AS DateTime), 80, CAST(N'2020-05-20 11:02:55.380' AS DateTime), 3)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'fgsdfsdf', 80, CAST(N'2020-05-06 00:07:46.023' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'asdasd', 80, CAST(N'2020-05-06 00:24:45.637' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, N'ska', 80, CAST(N'2020-05-06 00:38:44.203' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (14, N'asdasda', 80, CAST(N'2020-05-06 14:12:50.453' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (15, N'asddad', 80, CAST(N'2020-05-06 14:29:38.967' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (16, N'asddadasda', 80, CAST(N'2020-05-06 14:30:34.443' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (17, N'asdasdas', 80, CAST(N'2020-05-06 14:34:54.280' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (18, N'fush', 80, CAST(N'2020-05-15 21:09:12.147' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (19, N'shpi', 80, CAST(N'2020-05-15 21:37:46.797' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (20, N'fushasdsdd', 80, CAST(N'2020-05-19 04:15:41.857' AS DateTime), 80, CAST(N'2020-05-19 04:31:53.857' AS DateTime), 1)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (21, N'kosovv', 80, CAST(N'2020-05-19 22:44:29.717' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (22, N'kosovvdsa', 80, CAST(N'2020-05-19 22:45:32.510' AS DateTime), 80, CAST(N'2020-05-19 23:07:16.427' AS DateTime), 1)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (23, N'prishtine', 80, CAST(N'2020-05-20 05:02:16.640' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (24, N'asddasd', 80, CAST(N'2020-05-20 05:07:16.020' AS DateTime), 80, CAST(N'2020-05-20 05:07:41.340' AS DateTime), 1)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (25, N'dasdasdasda', 80, CAST(N'2020-05-20 11:03:46.070' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[PublishHouses] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [Role], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'User', 1, CAST(N'2020-05-01 16:01:34.643' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Roles] ([RoleId], [Role], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'Admin', 80, CAST(N'2020-05-05 04:26:18.503' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Shelves] ON 

INSERT [dbo].[Shelves] ([ShelfId], [Location], [Quantity], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'asd', 31, N'df', 80, CAST(N'2020-05-03 17:33:32.143' AS DateTime), 1098, CAST(N'2020-05-20 00:18:50.570' AS DateTime), 1)
INSERT [dbo].[Shelves] ([ShelfId], [Location], [Quantity], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'asd', 31, N'df', 80, CAST(N'2020-05-05 03:49:33.927' AS DateTime), 1098, CAST(N'2020-05-20 00:18:50.570' AS DateTime), 1)
INSERT [dbo].[Shelves] ([ShelfId], [Location], [Quantity], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'asd', 31, N'df', 80, CAST(N'2020-05-05 03:49:39.460' AS DateTime), 1098, CAST(N'2020-05-20 00:18:50.570' AS DateTime), 1)
INSERT [dbo].[Shelves] ([ShelfId], [Location], [Quantity], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (4, N'asdffffffff', 31, N'df', 1098, CAST(N'2020-05-20 00:17:16.857' AS DateTime), 80, CAST(N'2020-05-20 10:35:16.107' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[Shelves] OFF
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (80, N'Endrittmava', N'to8Qg7XjcdlxITInKZ0UK5OJpumhqiSDkzlCmFe+', N'Endrit', N'Tmava', 2, N'Endrit.tmavaa@gmail.com', 1, CAST(N'2020-05-02 04:38:46.460' AS DateTime), 0, CAST(N'2020-05-20 11:16:46.710' AS DateTime), 18, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (81, N'Endrittmav', N'eqiytkORvyMEW96FYBPx/BFXamkRImSn7cHMl//d', N'Endrit', N'Tmava', 1, N'Endrit.tmavaa@gmail.com', 1, CAST(N'2020-05-02 04:39:07.783' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (85, N'Endrittmavgfd', N'FJjz8R/d08AuS0zfkq84pGMluNLVucR1cWt6UWgR', N'Endrit', N'Tmava', 1, N'Endrit.tmavaa@gmail.com', 1, CAST(N'2020-05-02 04:41:09.250' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1084, N'dity', N'asdadsss', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05 04:09:35.557' AS DateTime), 80, CAST(N'2020-05-05 05:06:08.823' AS DateTime), 2, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1085, N'ditdsay', N'asdads', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05 04:11:28.210' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1086, N'ditdsadasdy', N'asdads', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05 04:11:57.593' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1087, N'ditcasdasdadsadasdy', N'asdads', N'eas', N'asdasd', 1, N'asdas@sadas.com', 80, CAST(N'2020-05-05 04:12:38.117' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1088, N'helloworld', N'endrittmava', N'Endrit', N'Tmava', 2, N'etttttttt@gmail.com', 80, CAST(N'2020-05-06 02:16:45.680' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1089, N'endritdity', N'hellohello', N'Endrit', N'dity', 2, N'endasd@asda.com', 80, CAST(N'2020-05-06 03:39:36.043' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1090, N'beispresheva', N'123123', N'Beis', N'Presheva', 2, N'beis.presheva@riinvest.net', 80, CAST(N'2020-05-06 03:40:24.697' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1091, N'aasdasd', N'granitbossi', N'Granit', N'Krasniqi', 2, N'gr.@riinvest.net', 80, CAST(N'2020-05-06 05:01:53.660' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1092, N'granitkrasniqi', N'123123', N'Granit', N'Krasniqi', 2, N'gr@riinvest.net', 80, CAST(N'2020-05-06 14:55:56.050' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1093, N'ettm', N'A4EjiMaLwWEZIgqo85wnx7lpgLYPrjFh28d/kw2f', N'Ey', N'tm', 2, N'et@riinvest.net', 80, CAST(N'2020-05-06 15:31:57.083' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1094, N'beispreshevaaa', N'wfDKdcs0SK1zwRL2LqXbfcSeatDpEHNRWlOLVMo8', N'beis', N'presheva', 2, N'beis@asda.com', 80, CAST(N'2020-05-06 17:09:50.580' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1095, N'endrittmavaas', N'23zrvLGQ5Z5g/hk1Hdb527raDMQDHNU/Pf2wehSs', N'endrit', N'tmava', 2, N'endritt.mava@gmail.com', 80, CAST(N'2020-05-10 02:45:21.180' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1096, N'etmv', N'a9P9IAzkA6qCxOCqsSRDjDcxes1esMrl5zggcJW9', N'Etmvvvfgg', N'Tmava', 2, N'ends@gmail.com', 80, CAST(N'2020-05-19 03:34:21.363' AS DateTime), 0, CAST(N'2020-05-19 03:35:49.237' AS DateTime), 2, 0)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1097, N'endrityy', N'j4DG56n7z8DHm5/2O+XVQL8Bjk/TGytggbU2t9iR', N'end', N'rit', 2, N'end@rit.com', 80, CAST(N'2020-05-19 22:43:50.563' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1098, N'dasdas', N'RWeyZIh4XZLx3mwRAF/PHKD62VLhsCHR22UAudD9', N'dasda', N'adsda', 1, N'ads@ads.com', 80, CAST(N'2020-05-19 23:38:34.573' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1099, N'qweqwe', N'fQpRujxrnxDEf3nXH92ZdEuvP16MoyxOoMTYRvY6', N'asdasd', N'adasda', 1, N'dasda@adasd.cooc', 80, CAST(N'2020-05-20 05:08:41.860' AS DateTime), 0, CAST(N'2020-05-20 05:13:39.030' AS DateTime), 2, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1100, N'asddsa', N'7SaXbaka/tcm6jRz/ZENsIfxre0/zKrAm6a9jwQo', N'gagafsf', N'lala', 2, N'sadas@asdas.com', 80, CAST(N'2020-05-20 11:05:03.650' AS DateTime), 0, CAST(N'2020-05-20 11:10:19.540' AS DateTime), 5, 0)
SET IDENTITY_INSERT [dbo].[USERS] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__BillType__F9B8A48BD635FAA3]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[BillType] ADD UNIQUE NONCLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Genres__F1410CF3106E7001]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[Genres] ADD UNIQUE NONCLUSTERED 
(
	[Genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Language__C3D59250B6D0EA67]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[Languages] ADD UNIQUE NONCLUSTERED 
(
	[Language] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Material__28129C09C4963367]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[MaterialTypes] ADD UNIQUE NONCLUSTERED 
(
	[MaterialType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__PublishH__B2F45716BAEF45AB]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[PublishHouses] ADD UNIQUE NONCLUSTERED 
(
	[PublishHouse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Roles__DA15413E5A45A35C]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TypeOfAc__F9B8A48B2421EA0D]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[TypeOfActions] ADD UNIQUE NONCLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__USERS__536C85E4EB386A1A]    Script Date: 5/20/2020 11:25:08 AM ******/
ALTER TABLE [dbo].[USERS] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT (getdate()) FOR [ReservationDate]
GO
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[Subscribers] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[Subscribers] ADD  DEFAULT ((0)) FOR [UpdNo]
GO
ALTER TABLE [dbo].[TypeOfActions] ADD  DEFAULT (getdate()) FOR [InsDate]
GO
ALTER TABLE [dbo].[TypeOfActions] ADD  DEFAULT ((0)) FOR [UpdNo]
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
/****** Object:  StoredProcedure [dbo].[usp_ChangeUserPassword]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateGenre]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateGenre]
@Genre varchar(50),
@InsBy int,
@IsActive int =1,
@Error int OUTPUT


AS
BEGIN


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





DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

INSERT INTO dbo.Genres
(
    --AuthorId - column value is auto-generated
    Genre,
    InsBy,
    InsDate,
	IsActive
)
VALUES
(
@Genre,
@InsBy,
@TodayDate,
@IsActive
)

END



END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateLanguage]    Script Date: 5/20/2020 11:25:08 AM ******/
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

END


END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterial]    Script Date: 5/20/2020 11:25:08 AM ******/
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
    MaterialQuantity,
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

SELECT @Quantity = m.MaterialQuantity + @Quantity FROM dbo.Materials m WHERE MaterialId = @MaterialId


	END

	DECLARE @UpdateNo int
	SELECT @UpdateNo = m.UpdNo + 1 FROM dbo.Materials m WHERE MaterialId = @MaterialId

UPDATE dbo.Materials
SET

    dbo.Materials.AvailableCoppies = @AvailableCoppies, -- int
    dbo.Materials.MaterialQuantity = @Quantity, -- int
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
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterialType]    Script Date: 5/20/2020 11:25:08 AM ******/
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

END





END



GO
/****** Object:  StoredProcedure [dbo].[usp_CreateShelf]    Script Date: 5/20/2020 11:25:08 AM ******/
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
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateUsers]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteGenre]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteLanguage]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterial]    Script Date: 5/20/2020 11:25:08 AM ******/
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
	WHERE dbo.Materials.MaterialId = @MaterialiId
	END


GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterialType]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteShelf]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteShelf]
@ShelfId int,
@Error int out



AS



DECLARE @exist int 

set @exist = 0

SELECT @exist = 1  FROM dbo.Materials mt WHERE mt.ShelfId = @ShelfId


if(@exist = 1)
BEGIN

set @Error = 1

END

ELSE 

BEGIN

SET @Error =0

DELETE 
FROM dbo.Shelves
WHERE @ShelfId = dbo.Shelves.ShelfId

END
;
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteUser]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_EditMaterial]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_EditMaterial]
@MaterialId int,
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
@Author VARCHAR(50),
@AuthorId int,
@IsActive bit =1

AS
BEGIN

BEGIN TRANSACTION 

BEGIN TRY


DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo +1 FROM dbo.Materials mt WHERE @MaterialId = mt.MaterialId




SELECT @AuthorId = AuthorId FROM materials WHERE materialId = @MaterialId




UPDATE dbo.Authors
SET
    dbo.Authors.AuthorName = @Author, 
    dbo.Authors.UpdBy = @UpdId,
    dbo.Authors.UpdDate = @TodayDate,
    dbo.Authors.UpdNo = @UpdNo 
	WHERE @AuthorId = AuthorId





	UPDATE dbo.PublishHouses
	SET
	    --PublishHouseId - column value is auto-generated
	    dbo.PublishHouses.PublishHouse = @PublishHouse, -- varchar
	    dbo.PublishHouses.UpdBy = @UpdId, -- int
	    dbo.PublishHouses.UpdDate = @TodayDate, -- datetime
	    dbo.PublishHouses.UpdNo = @UpdNo -- int
		WHERE PublishHouseId = @PublishHouseId










UPDATE dbo.Materials
SET
    --MaterialId - column value is auto-generated
    dbo.Materials.Title = @Title, -- varchar
    dbo.Materials.GenreId = @GenreId, -- int
    dbo.Materials.PublishingHouseId = 1, -- int
    dbo.Materials.PublishYear = getdate(), -- date
    dbo.Materials.PlaceOfPublication = @PlaceOfPublication, -- varchar
    dbo.Materials.ISBN = @ISBN, -- varchar
    dbo.Materials.MaterialTypeId = @MaterialTypeId, -- int
    dbo.Materials.AvailableCoppies = @AvailableCoppies, -- int
    dbo.Materials.MaterialQuantity = @Quantity, -- int
    dbo.Materials.NumberOfPages = @NumberOfPages, -- int
    dbo.Materials.LanguageId = @LanguageId, -- int
    dbo.Materials.UpdBy = @UpdId, -- int
    dbo.Materials.UpdDate = @TodayDate, -- datetime
    dbo.Materials.UpdNo = @UpdNo, -- int
    dbo.Materials.AuthorId = 1, -- int
    dbo.Materials.IsActive = @IsActive -- bit
	WHERE Materials.MaterialId = @MaterialId

	COMMIT TRANSACTION 
END TRY


 
BEGIN CATCH 

ROLLBACK TRANSACTION



END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllGenres]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllGenres]


AS

SELECT * FROM genres ;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllLanguages]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[usp_GetAllLanguages]



AS BEGIN


SELECT * FROM languages

end
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllMaterials]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[usp_GetAllMaterials]

	AS
		SELECT m.MaterialId, m.Title, g.GenreId, g.Genre, ph.PublishHouseId,ph.PublishHouse,
	m.PublishYear, m.PlaceOfPublication, m.ISBN, mt.MaterialTypeId,
	mt.MaterialType, m.AvailableCoppies, m.MaterialQuantity ,m.NumberOfPages,
	l.LanguageId, l.Language, a.AuthorId, a.AuthorName, m.IsActive, 
	s.ShelfId, s.Location, s.Quantity AS ShelfQuantity, s.Description, m.InsBy, m.InsDate, m.UpdNo, m.UpdBy, m.UpdDate

	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.Genres g ON m.GenreId = g.GenreId
	JOIN dbo.Languages l ON m.LanguageId = l.LanguageId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId
	JOIN dbo.Shelves s ON m.ShelfId = s.ShelfId
		JOIN dbo.PublishHouses ph ON m.PublishingHouseId = ph.PublishHouseId;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllMaterialTypes]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllMaterialTypes]

AS

SELECT * FROM dbo.MaterialTypes mt;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllRoles]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetAllShelves]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetAllUsers]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetMaterialById]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetMaterialById]
@MaterialId int

AS

	SELECT m.MaterialId, m.Title, g.GenreId, g.Genre, ph.PublishHouseId,ph.PublishHouse,
	m.PublishYear, m.PlaceOfPublication, m.ISBN, mt.MaterialTypeId,
	mt.MaterialType, m.AvailableCoppies, m.MaterialQuantity ,m.NumberOfPages,
	l.LanguageId, l.Language, a.AuthorId, a.AuthorName, m.IsActive, 
	s.ShelfId, s.Location, s.Quantity AS ShelfQuantity, s.Description, m.InsBy, m.InsDate, m.UpdNo, m.UpdBy, m.UpdDate

	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.Genres g ON m.GenreId = g.GenreId
	JOIN dbo.Languages l ON m.LanguageId = l.LanguageId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId
	JOIN dbo.Shelves s ON m.ShelfId = s.ShelfId
		JOIN dbo.PublishHouses ph ON m.PublishingHouseId = ph.PublishHouseId
	WHERE m.MaterialId = @MaterialId;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetShelfById]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetShelfById]
@ShelfId int

AS
SELECT * FROM dbo.Shelves s WHERE s.ShelfId = @ShelfId;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUser]    Script Date: 5/20/2020 11:25:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetUserByUsername]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetUserByUsername]

@Username varchar(50)

as

SELECT u.UserId,u.Username, u.Name, u.LastName, u.RoleId,r.Role, u.Email,u.InsBy,u.InsDate,u.UpdBy,u.UpdDate,u.UpdNo,u.IsActive,u.Password
FROM dbo.USERS u 
JOIN dbo.Roles r 
ON u.RoleId = r.RoleId
WHERE u.Username = @Username


;
GO
/****** Object:  StoredProcedure [dbo].[usp_LogIn]    Script Date: 5/20/2020 11:25:08 AM ******/
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
WHERE u.Username = @UserName AND u.Password = @Password AND u.IsActive = 1

END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateGenre]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateGenre]
@GenreId int,
@Genre varchar(50),
@UpdBy int,
@IsActive bit

AS
BEGIN




DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()


DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo+ 1  FROM dbo.Genres mt WHERE @GenreId = mt.GenreId


UPDATE dbo.Genres
SET

    dbo.Genres.Genre = @Genre, -- varchar
    dbo.Genres.UpdBy = @UpdBy, -- int
    dbo.Genres.UpdDate = @TodayDate, -- datetime
    dbo.Genres.UpdNo = @UpdNo, -- intalTypes
	dbo.Genres.IsActive = @IsActive
WHERE @GenreId = Genres.GenreId



END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateLanguage]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateLanguage]
@LanguageId int,
@Language varchar(50),
@UpdBy int


AS
BEGIN


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


END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateMaterialType]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateMaterialType]
@MaterialTypeId int,
@MaterialType varchar(50),
@UpdBy int,
@IsActive bit


AS
BEGIN





DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo +1 FROM dbo.MaterialTypes mt WHERE @MaterialTypeId = mt.MaterialTypeId

UPDATE dbo.MaterialTypes
SET

    dbo.MaterialTypes.MaterialType = @MaterialType, -- varchar
    dbo.MaterialTypes.UpdBy = @UpdBy, -- int
    dbo.MaterialTypes.UpdDate = @TodayDate, -- datetime
    dbo.MaterialTypes.UpdNo = @UpdNo, -- intalTypes
	 dbo.MaterialTypes.IsActive=@IsActive
	WHERE @MaterialTypeId = MaterialTypeId
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateShelf]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_UpdateShelf]
@ShelfId int,
@Location varchar(50),
@Quantity int,
@Description varchar(50) = null,
@UpdBy int


AS
BEGIN




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
	WHERE dbo.Shelves.ShelfId = @ShelfId
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateUser]    Script Date: 5/20/2020 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateUser]
@Username varchar(50),--me validu username ne c#(nuk duhet me kan null)
@Name varchar(50) ,
@LastName varchar(50) ,
@RoleId int,
@Email varchar(50),
@UpdBy int,--me validu LastUpdateBy ne c#(nuk duhet me kan null)
@UbdDate datetime = null,
@UpdNo int= null,
@IsActive bit


AS

BEGIN

   SELECT @UpdNo=UpdNo+1  from Users WHERE @Username = Username

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
where Users.Username = @Username


END
GO
USE [master]
GO
ALTER DATABASE [LibraryManagement] SET  READ_WRITE 
GO
