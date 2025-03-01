USE [master]
GO
/****** Object:  Database [LibraryManagement]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[udf_GetTable]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create FUNCTION [dbo].[udf_GetTable](@value int)
RETURNS @Table TABLE (Id int)

AS
BEGIN
INSERT INTO @Table
SELECT m.MaterialId
FROM dbo.Materials m 
WHERE @value = m.MaterialId
return
end


GO
/****** Object:  Table [dbo].[Authors]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  Table [dbo].[Bills]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  Table [dbo].[BillType]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  Table [dbo].[Borrowings]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrowings](
	[BorrowId] [int] IDENTITY(1,1) NOT NULL,
	[SubscriberId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[ShelfId] [int] NULL,
	[Comment] [varchar](50) NULL,
	[InsBy] [int] NOT NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdBy] [int] NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[ReservationId] [int] NULL,
	[BorrowDate] [datetime] NULL,
	[IsNotified] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BorrowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BorrowReturns]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorrowReturns](
	[BorrowReturnId] [int] IDENTITY(1,1) NOT NULL,
	[BorrowId] [int] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[BillId] [int] NULL,
	[InsDate] [datetime] NOT NULL,
	[UpdDate] [datetime] NULL,
	[UpdNo] [int] NOT NULL,
	[Comment] [varchar](50) NULL,
	[InsBy] [int] NOT NULL,
	[UpdBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BorrowReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  Table [dbo].[Languages]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  Table [dbo].[Materials]    Script Date: 6/9/2020 1:35:25 PM ******/
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
	[ISBN] [varchar](50) NULL,
	[MaterialTypeId] [int] NOT NULL,
	[AvailableCoppies] [int] NOT NULL,
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
	[MaterialQuantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialTypes]    Script Date: 6/9/2020 1:35:25 PM ******/
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
	[MaterialTypeDelayFee] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notifications]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notifications](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NotificationMessage] [varchar](max) NOT NULL,
	[NotificationDate] [datetime] NOT NULL,
	[NotificationCategory] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublishHouses]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  Table [dbo].[Reservations]    Script Date: 6/9/2020 1:35:25 PM ******/
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
	[IsNotified] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  Table [dbo].[Shelves]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shelves](
	[ShelfId] [int] IDENTITY(1,1) NOT NULL,
	[Location] [varchar](50) NOT NULL,
	[QuantityOfShelf] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Subscribers]    Script Date: 6/9/2020 1:35:25 PM ******/
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
	[IsNotified] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubscriberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 6/9/2020 1:35:25 PM ******/
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

INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'Alan Moore', 1, CAST(N'2020-06-09T07:37:52.097' AS DateTime), 1, CAST(N'2020-06-09T08:43:04.183' AS DateTime), 2)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (5, N'Ismail kadare', 3, CAST(N'2020-06-09T12:04:22.673' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, N'Raul Palacio', 3, CAST(N'2020-06-09T12:07:23.590' AS DateTime), 3, CAST(N'2020-06-09T12:52:06.460' AS DateTime), 9)
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (8, N'Raul Palacio', 3, CAST(N'2020-06-09T13:31:05.100' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, 1, CAST(N'2020-06-09T07:45:38.613' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 1, CAST(N'2020-06-09T07:45:38.630' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, 1, CAST(N'2020-06-09T07:45:38.613' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 1, CAST(N'2020-06-09T07:45:38.630' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, 2, CAST(N'2020-06-09T10:17:24.527' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:17:24.587' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (4, 2, CAST(N'2020-06-09T10:17:24.527' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:17:24.593' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (5, 3, CAST(N'2020-06-09T10:23:32.977' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:23:32.977' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, 3, CAST(N'2020-06-09T10:23:32.977' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:23:32.983' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (7, 4, CAST(N'2020-06-09T10:24:59.323' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:24:59.330' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (8, 4, CAST(N'2020-06-09T10:24:59.323' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:24:59.337' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (9, 5, CAST(N'2020-06-09T10:26:47.943' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:26:47.943' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (10, 5, CAST(N'2020-06-09T10:26:47.943' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:26:47.947' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (11, 6, CAST(N'2020-06-09T10:27:50.857' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:27:50.857' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (12, 6, CAST(N'2020-06-09T10:27:50.857' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:27:50.867' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (13, 7, CAST(N'2020-06-09T10:28:53.297' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:28:53.297' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (14, 7, CAST(N'2020-06-09T10:28:53.297' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:28:53.300' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (15, 8, CAST(N'2020-06-09T10:30:57.630' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:30:57.643' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (16, 8, CAST(N'2020-06-09T10:30:57.630' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:30:57.657' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (17, 9, CAST(N'2020-06-09T10:31:55.143' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:31:55.143' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (18, 9, CAST(N'2020-06-09T10:31:55.143' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:31:55.157' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (19, 10, CAST(N'2020-06-09T10:32:52.677' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:32:52.677' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (20, 10, CAST(N'2020-06-09T10:32:52.677' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:32:52.680' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (21, 11, CAST(N'2020-06-09T10:41:01.697' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:41:01.707' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (22, 11, CAST(N'2020-06-09T10:41:01.697' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:41:01.710' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (23, 12, CAST(N'2020-06-09T10:42:25.550' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:42:25.560' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (24, 12, CAST(N'2020-06-09T10:42:25.550' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:42:25.563' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (25, 13, CAST(N'2020-06-09T10:43:41.790' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:43:41.810' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (26, 13, CAST(N'2020-06-09T10:43:41.790' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:43:41.813' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (27, 14, CAST(N'2020-06-09T10:44:31.720' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:44:31.733' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (28, 14, CAST(N'2020-06-09T10:44:31.720' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:44:31.740' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (29, 15, CAST(N'2020-06-09T10:46:19.470' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:46:19.480' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (30, 15, CAST(N'2020-06-09T10:46:19.470' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:46:19.483' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (31, 16, CAST(N'2020-06-09T10:48:30.257' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:48:30.267' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (32, 16, CAST(N'2020-06-09T10:48:30.257' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:48:30.270' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (33, 17, CAST(N'2020-06-09T10:49:55.820' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:49:55.830' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (34, 17, CAST(N'2020-06-09T10:49:55.820' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:49:55.833' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (35, 18, CAST(N'2020-06-09T10:51:21.103' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:51:21.113' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (36, 18, CAST(N'2020-06-09T10:51:21.103' AS DateTime), 100.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2021-06-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:51:21.117' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (37, 19, CAST(N'2020-06-09T10:52:55.887' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:52:55.900' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (38, 19, CAST(N'2020-06-09T10:52:55.887' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:52:55.907' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (39, 20, CAST(N'2020-06-09T10:54:48.197' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:54:48.210' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Bills] ([BillId], [SubscriberId], [BillingDate], [Price], [RegistrationDate], [ExpirationDate], [MaterialId], [BillTypeId], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (40, 20, CAST(N'2020-06-09T10:54:48.197' AS DateTime), 10.0000, CAST(N'2020-06-09T00:00:00.000' AS DateTime), CAST(N'2020-07-09T00:00:00.000' AS DateTime), NULL, NULL, NULL, 3, CAST(N'2020-06-09T10:54:48.217' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Bills] OFF
SET IDENTITY_INSERT [dbo].[Borrowings] ON 

INSERT [dbo].[Borrowings] ([BorrowId], [SubscriberId], [MaterialId], [ReturnDate], [ShelfId], [Comment], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [ReservationId], [BorrowDate], [IsNotified]) VALUES (1, 1, 3, CAST(N'2020-06-14T00:00:00.000' AS DateTime), 1, NULL, 1, CAST(N'2020-06-09T07:47:58.730' AS DateTime), NULL, NULL, 0, NULL, CAST(N'2020-06-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Borrowings] ([BorrowId], [SubscriberId], [MaterialId], [ReturnDate], [ShelfId], [Comment], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [ReservationId], [BorrowDate], [IsNotified]) VALUES (2, 1, 3, CAST(N'2020-06-14T00:00:00.000' AS DateTime), 1, NULL, 1, CAST(N'2020-06-09T07:59:45.640' AS DateTime), NULL, NULL, 0, NULL, CAST(N'2020-06-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Borrowings] ([BorrowId], [SubscriberId], [MaterialId], [ReturnDate], [ShelfId], [Comment], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [ReservationId], [BorrowDate], [IsNotified]) VALUES (3, 1, 3, CAST(N'2020-06-09T00:00:00.000' AS DateTime), 1, NULL, 1, CAST(N'2020-06-09T09:21:10.453' AS DateTime), NULL, NULL, 0, NULL, CAST(N'2020-06-09T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Borrowings] ([BorrowId], [SubscriberId], [MaterialId], [ReturnDate], [ShelfId], [Comment], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [ReservationId], [BorrowDate], [IsNotified]) VALUES (4, 1, 3, CAST(N'2020-06-17T00:00:00.000' AS DateTime), 1, NULL, 1, CAST(N'2020-06-09T09:25:07.987' AS DateTime), NULL, NULL, 0, 1, CAST(N'2020-06-09T00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Borrowings] OFF
SET IDENTITY_INSERT [dbo].[BorrowReturns] ON 

INSERT [dbo].[BorrowReturns] ([BorrowReturnId], [BorrowId], [ReturnDate], [BillId], [InsDate], [UpdDate], [UpdNo], [Comment], [InsBy], [UpdBy]) VALUES (1, 2, CAST(N'2020-06-09T08:00:44.657' AS DateTime), NULL, CAST(N'2020-06-09T08:00:44.660' AS DateTime), NULL, 0, N'ska tash', 1, NULL)
INSERT [dbo].[BorrowReturns] ([BorrowReturnId], [BorrowId], [ReturnDate], [BillId], [InsDate], [UpdDate], [UpdNo], [Comment], [InsBy], [UpdBy]) VALUES (9, 1, CAST(N'2020-06-09T08:06:09.563' AS DateTime), NULL, CAST(N'2020-06-09T08:06:09.560' AS DateTime), NULL, 0, N'ska tash', 1, NULL)
SET IDENTITY_INSERT [dbo].[BorrowReturns] OFF
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'Graphic Novel', 1, CAST(N'2020-06-09T07:30:32.697' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (2, N'Fantasy', 1, CAST(N'2020-06-09T07:42:40.563' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'Thriller', 3, CAST(N'2020-06-09T11:36:02.413' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (4, N'Mystery', 3, CAST(N'2020-06-09T11:36:30.923' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (5, N'Fiction', 3, CAST(N'2020-06-09T11:36:41.763' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (6, N'Review', 3, CAST(N'2020-06-09T11:37:36.877' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (7, N'Article', 3, CAST(N'2020-06-09T11:37:52.303' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (8, N'Mathematics', 3, CAST(N'2020-06-09T11:42:29.487' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (9, N'Biology', 3, CAST(N'2020-06-09T11:42:47.773' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Genres] ([GenreId], [Genre], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (10, N'Physics', 3, CAST(N'2020-06-09T11:43:11.243' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Genres] OFF
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'English', 1, CAST(N'2020-06-09T07:30:41.530' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (2, N'French', 1, CAST(N'2020-06-09T07:43:06.520' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[Languages] ([LanguageId], [Language], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'Albanian', 3, CAST(N'2020-06-09T11:47:18.073' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET IDENTITY_INSERT [dbo].[Materials] ON 

INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (3, N'Mrekullia', 2, 6, CAST(N'2012-01-01' AS Date), N'1345234532235', 1, 20, 15, 3, 1, CAST(N'2020-06-09T07:37:52.097' AS DateTime), 3, CAST(N'2020-06-09T12:37:30.947' AS DateTime), 2, 6, 1, 1, 20)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (5, N'Kukulla', 5, 8, CAST(N'2013-01-01' AS Date), N'1345234532235', 3, 25, 150, 2, 3, CAST(N'2020-06-09T12:04:22.673' AS DateTime), 3, CAST(N'2020-06-09T13:31:05.103' AS DateTime), 10, 6, 1, 1, 25)
INSERT [dbo].[Materials] ([MaterialId], [Title], [GenreId], [PublishingHouseId], [PublishYear], [ISBN], [MaterialTypeId], [AvailableCoppies], [NumberOfPages], [LanguageId], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [AuthorId], [IsActive], [ShelfId], [MaterialQuantity]) VALUES (6, N'Mrekullia', 2, 6, CAST(N'2012-01-01' AS Date), N'1345234532235', 1, 20, 90, 3, 3, CAST(N'2020-06-09T12:07:23.590' AS DateTime), 3, CAST(N'2020-06-09T12:31:48.173' AS DateTime), 2, 6, 1, 1, 20)
SET IDENTITY_INSERT [dbo].[Materials] OFF
SET IDENTITY_INSERT [dbo].[MaterialTypes] ON 

INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [MaterialTypeDelayFee]) VALUES (1, N'Book', 1, CAST(N'2020-06-09T07:29:21.610' AS DateTime), NULL, NULL, 0, 1, 2.0000)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [MaterialTypeDelayFee]) VALUES (3, N'Journal', 3, CAST(N'2020-06-09T11:46:04.100' AS DateTime), NULL, NULL, 0, 1, 2.0000)
INSERT [dbo].[MaterialTypes] ([MaterialTypeId], [MaterialType], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [MaterialTypeDelayFee]) VALUES (4, N'Scientific Paper', 3, CAST(N'2020-06-09T11:46:23.637' AS DateTime), NULL, NULL, 0, 1, 2.0000)
SET IDENTITY_INSERT [dbo].[MaterialTypes] OFF
SET IDENTITY_INSERT [dbo].[PublishHouses] ON 

INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (3, N'DC Comicss', 1, CAST(N'2020-06-09T07:37:52.097' AS DateTime), 1, CAST(N'2020-06-09T08:43:04.183' AS DateTime), 2)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (5, N'Onufri', 3, CAST(N'2020-06-09T12:04:22.673' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (6, N'endrit', 3, CAST(N'2020-06-09T12:07:23.590' AS DateTime), 3, CAST(N'2020-06-09T12:52:06.460' AS DateTime), 9)
INSERT [dbo].[PublishHouses] ([PublishHouseId], [PublishHouse], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (8, N'endrit22', 3, CAST(N'2020-06-09T13:31:05.100' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[PublishHouses] OFF
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([Id], [SubscriberId], [MaterialId], [ReservationDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsNotified]) VALUES (1, 1, 3, CAST(N'2020-06-14T00:00:00.000' AS DateTime), 1, CAST(N'2020-06-09T07:49:10.090' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[Reservations] ([Id], [SubscriberId], [MaterialId], [ReservationDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsNotified]) VALUES (2, 1, 3, CAST(N'2020-06-11T00:00:00.000' AS DateTime), 1, CAST(N'2020-06-09T09:20:50.363' AS DateTime), NULL, NULL, 0, 0)
INSERT [dbo].[Reservations] ([Id], [SubscriberId], [MaterialId], [ReservationDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsNotified]) VALUES (3, 1, 3, CAST(N'2020-06-10T00:00:00.000' AS DateTime), 1, CAST(N'2020-06-09T09:24:55.560' AS DateTime), NULL, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[Reservations] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [Role], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'Admin', 0, CAST(N'2020-09-06T00:00:00.000' AS DateTime), 0, NULL, 0)
INSERT [dbo].[Roles] ([RoleId], [Role], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'User', 0, CAST(N'2020-06-09T06:53:36.257' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Shelves] ON 

INSERT [dbo].[Shelves] ([ShelfId], [Location], [QuantityOfShelf], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (1, N'North', 100, N'', 1, CAST(N'2020-06-09T07:29:40.783' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Shelves] ([ShelfId], [Location], [QuantityOfShelf], [Description], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo]) VALUES (2, N'South', 100, N'', 1, CAST(N'2020-06-09T07:42:52.907' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Shelves] OFF
SET IDENTITY_INSERT [dbo].[Subscribers] ON 

INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (1, N'Endrit', N'Tmava', N'Fushe Kosove', CAST(N'1997-06-09T07:44:12.000' AS DateTime), N'1234512345', N'11223344', N'endrit.tmava@riinvest.net', N'M', CAST(N'2021-06-09' AS Date), 1, CAST(N'2020-06-09T07:45:36.587' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (2, N'Granit', N'Krasniqi', N'Drenas', CAST(N'2020-06-09T10:14:32.770' AS DateTime), N'1235333470', N'049428454', N'Granit.Kransiqi2020@outlook.com', N'M', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:17:22.590' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (3, N'Beis', N'Presheva', N'Prishtine', CAST(N'2020-06-09T10:22:28.620' AS DateTime), N'1928374763', N'18182334', N'beis.presheva@riinvest.net', N'M', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:23:31.640' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (4, N'Alma', N'Deda', N'Peje', CAST(N'2011-01-20T00:00:00.000' AS DateTime), N'2923456783', N'12876523', N'ag@de.com', N'F', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:24:57.600' AS DateTime), 3, CAST(N'2020-06-09T11:04:28.140' AS DateTime), 2, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (5, N'Leotrim', N'Shala', N'Prizren', CAST(N'2010-10-01T10:25:11.000' AS DateTime), N'9865325421', N'1298435676', N'leo@sha.com', N'M', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:26:46.707' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (6, N'Egzona', N'Berisha', N'Gjakove', CAST(N'1995-09-01T00:00:00.000' AS DateTime), N'1243567889', N'34567565', N'eg@be.com', N'F', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:27:49.480' AS DateTime), 3, CAST(N'2020-06-09T11:04:57.433' AS DateTime), 3, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (7, N'Samir', N'Rexhepi', N'Kline', CAST(N'1997-08-21T00:00:00.000' AS DateTime), N'4323675645', N'98764523', N'sa@re.com', N'M', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:28:51.990' AS DateTime), 3, CAST(N'2020-06-09T11:05:29.993' AS DateTime), 1, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (8, N'Ermira', N'Kryeziu', N'Ferizaj', CAST(N'2003-10-23T00:00:00.000' AS DateTime), N'9876542312', N'1736452', N'er@kr.com', N'F', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:30:56.437' AS DateTime), 3, CAST(N'2020-06-09T11:05:49.473' AS DateTime), 3, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (9, N'Dardan', N'Gashi', N'Istog', CAST(N'2008-01-14T00:00:00.000' AS DateTime), N'9865732312', N'21237856', N'da@ga.com', N'M', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:31:53.900' AS DateTime), 3, CAST(N'2020-06-09T11:06:20.637' AS DateTime), 1, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (10, N'Teuta', N'Berisha', N'Gjilan', CAST(N'1989-04-18T00:00:00.000' AS DateTime), N'5674356223', N'8473626', N'te@be.com', N'F', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:32:51.367' AS DateTime), 3, CAST(N'2020-06-09T11:06:39.543' AS DateTime), 2, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (11, N'Labinot', N'Osmani', N'Lipjan', CAST(N'2005-03-11T00:00:00.000' AS DateTime), N'8765674523', N'98675423', N'la@os.com', N'M', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:41:00.487' AS DateTime), 3, CAST(N'2020-06-09T11:07:14.663' AS DateTime), 1, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (12, N'Shkumbim', N'Aliu', N'Mitrovice', CAST(N'1998-02-13T00:00:00.000' AS DateTime), N'1167453444', N'56775432', N'Sh@al.com', N'M', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:42:24.227' AS DateTime), 3, CAST(N'2020-06-09T11:08:20.160' AS DateTime), 1, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (13, N'Mirlinda', N'Brestovci', N'Kastriot', CAST(N'2020-06-09T10:42:33.120' AS DateTime), N'7465743231', N'896785', N'mi@br.com', N'F', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:43:40.533' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (14, N'Rinora', N'Pajaziti', N'Shtime', CAST(N'2020-06-09T00:00:00.000' AS DateTime), N'2354546729', N'987654', N'ri@pa.com', N'F', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:44:30.450' AS DateTime), 3, CAST(N'2020-06-09T10:44:45.150' AS DateTime), 1, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (15, N'Albin', N'Hoti', N'Therande', CAST(N'2020-06-09T10:45:10.803' AS DateTime), N'8834456211', N'12785678', N'al@ho.com', N'M', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:46:18.200' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (16, N'Berat', N'Leka', N'Gjakove', CAST(N'1999-06-09T10:46:33.000' AS DateTime), N'2154765443', N'987654', N'be@le.com', N'M', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:48:28.923' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (17, N'Albert', N'Hoxha', N'Skenderaj', CAST(N'2009-06-09T10:48:56.000' AS DateTime), N'9845678543', N'325467', N'al@ho.com', N'M', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:49:53.720' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (18, N'Donika', N'Sallova', N'Vushtrri', CAST(N'1985-06-09T00:00:00.000' AS DateTime), N'4356789854', N'12343234', N'do@sa.com', N'F', CAST(N'2021-06-09' AS Date), 3, CAST(N'2020-06-09T10:51:19.800' AS DateTime), 3, CAST(N'2020-06-09T10:51:37.030' AS DateTime), 1, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (19, N'Abedin', N'Avdiu', N'Malisheve', CAST(N'1992-02-09T10:51:45.000' AS DateTime), N'6756453423', N'1123345', N'ab@av.com', N'M', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:52:54.603' AS DateTime), NULL, NULL, 0, 1, 0)
INSERT [dbo].[Subscribers] ([SubscriberId], [Name], [LastName], [Address], [Birthday], [PersonalNumber], [PhoneNumber], [Email], [Gender], [EndDate], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive], [IsNotified]) VALUES (20, N'Diana', N'Koliqi', N'Prishtine', CAST(N'2002-12-09T10:53:09.000' AS DateTime), N'1254678791', N'896754', N'di@ko.com', N'F', CAST(N'2020-07-09' AS Date), 3, CAST(N'2020-06-09T10:54:46.910' AS DateTime), NULL, NULL, 0, 1, 0)
SET IDENTITY_INSERT [dbo].[Subscribers] OFF
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (1, N'Endrittmava', N'to8Qg7XjcdlxITInKZ0UK5OJpumhqiSDkzlCmFe+', N'Endrit', N'Tmava', 1, N'endrit.tmava@riinvest.net', 0, CAST(N'2020-06-09T06:59:30.103' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (2, N'beispresheva', N'3ylBzA2QMF7MhodQ8FKDsVdGqD8Bv4QQbBkO3ugP', N'Beis', N'Presheva', 1, N'beis.presheva@riinvest.net', 1, CAST(N'2020-06-09T07:02:52.153' AS DateTime), NULL, NULL, 0, 1)
INSERT [dbo].[USERS] ([UserId], [Username], [Password], [Name], [LastName], [RoleId], [Email], [InsBy], [InsDate], [UpdBy], [UpdDate], [UpdNo], [IsActive]) VALUES (3, N'Granit.k', N'oT85yfpeo52M3rlX41/kb9XmsptxGUqZqxBWRjKL', N'Granit', N'Krasniqi', 2, N'Granit.Krasniqi2020@outlook.com', 1, CAST(N'2020-06-09T10:13:33.237' AS DateTime), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[USERS] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__BillType__F9B8A48B89FF4806]    Script Date: 6/9/2020 1:35:25 PM ******/
ALTER TABLE [dbo].[BillType] ADD UNIQUE NONCLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_BorrowId]    Script Date: 6/9/2020 1:35:25 PM ******/
ALTER TABLE [dbo].[BorrowReturns] ADD  CONSTRAINT [UC_BorrowId] UNIQUE NONCLUSTERED 
(
	[BorrowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Genres__F1410CF3C3F83C98]    Script Date: 6/9/2020 1:35:25 PM ******/
ALTER TABLE [dbo].[Genres] ADD UNIQUE NONCLUSTERED 
(
	[Genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Language__C3D5925062740ABE]    Script Date: 6/9/2020 1:35:25 PM ******/
ALTER TABLE [dbo].[Languages] ADD UNIQUE NONCLUSTERED 
(
	[Language] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Material__28129C091B7F2EE7]    Script Date: 6/9/2020 1:35:25 PM ******/
ALTER TABLE [dbo].[MaterialTypes] ADD UNIQUE NONCLUSTERED 
(
	[MaterialType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PublishH__B2F45716519C7565]    Script Date: 6/9/2020 1:35:25 PM ******/
ALTER TABLE [dbo].[PublishHouses] ADD UNIQUE NONCLUSTERED 
(
	[PublishHouse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__DA15413E83EBE154]    Script Date: 6/9/2020 1:35:25 PM ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__USERS__536C85E4F574A4F4]    Script Date: 6/9/2020 1:35:25 PM ******/
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
ALTER TABLE [dbo].[Borrowings] ADD  DEFAULT ((0)) FOR [IsNotified]
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
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT ((0)) FOR [IsNotified]
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
ALTER TABLE [dbo].[Subscribers] ADD  DEFAULT ((0)) FOR [IsNotified]
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
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([ReservationId])
REFERENCES [dbo].[Reservations] ([Id])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([ShelfId])
REFERENCES [dbo].[Shelves] ([ShelfId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([SubscriberId])
REFERENCES [dbo].[Subscribers] ([SubscriberId])
GO
ALTER TABLE [dbo].[Borrowings]  WITH CHECK ADD FOREIGN KEY([UpdBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[BorrowReturns]  WITH CHECK ADD FOREIGN KEY([BillId])
REFERENCES [dbo].[Bills] ([BillId])
GO
ALTER TABLE [dbo].[BorrowReturns]  WITH CHECK ADD FOREIGN KEY([BorrowId])
REFERENCES [dbo].[Borrowings] ([BorrowId])
GO
ALTER TABLE [dbo].[BorrowReturns]  WITH CHECK ADD FOREIGN KEY([InsBy])
REFERENCES [dbo].[USERS] ([UserId])
GO
ALTER TABLE [dbo].[BorrowReturns]  WITH CHECK ADD FOREIGN KEY([UpdBy])
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
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
/****** Object:  StoredProcedure [dbo].[CreateNotification]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CreateNotification]

@Message varchar(MAX),

@Date datetime,

@Category varchar(50)

AS

BEGIN

        Insert into Notifications (NotificationMessage, NotificationDate, NotificationCategory)

        values (@Message, @Date, @Category);

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllNotifications]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllNotifications]

as

        select * from Notifications

        order by NotificationDate desc;

GO
/****** Object:  StoredProcedure [dbo].[usp_BestSubscribers]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_BestSubscribers]

as

select s.SubscriberId, s.Name, s.LastName, Borrowings
from (select TOP(10)  Count( b.SubscriberId) as Borrowings,b.SubscriberId
from Borrowings b
join (SELECT m.MaterialId, m.Title,
	  mt.MaterialTypeId,mt.MaterialType, a.AuthorId, a.AuthorName, mt.MaterialTypeDelayFee
	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId) m1 ON b.MaterialId = m1.MaterialId
	JOIN dbo.Subscribers s  ON s.SubscriberId = b.SubscriberId
	GROUP BY b.SubscriberId
	ORDER BY Borrowings DESC) b
	JOIN dbo.Subscribers s  ON s.SubscriberId = b.SubscriberId;

GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_Delete]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[usp_Bills_Delete]
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
/****** Object:  StoredProcedure [dbo].[usp_Bills_GetAll]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[usp_Bills_GetAll]
AS
SELECT * FROM dbo.Bills AS b;


GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_GetByID]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Bills_Insert]    Script Date: 6/9/2020 1:35:25 PM ******/
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
	@BillId INT OUT 

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
	Description,
	InsBy,
	InsDate
)
VALUES
(	
	@subscriberId, @billingDate, @price, @registrationDate, @expirationDate, @materialId, @description,
	@insBy, GETDATE()
);
	
	--SCOPE IDENTITY
	SET @BillId=SCOPE_IDENTITY();

END TRY

BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH

GO
/****** Object:  StoredProcedure [dbo].[usp_Bills_MaxId]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Bills_MaxId]

AS

SELECT MAX(BillId) as Id
FROM Bills;


GO
/****** Object:  StoredProcedure [dbo].[usp_ChangeUserPassword]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateBorrow]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateBorrow]
@SubscriberId int,
@MaterialId int,
@ReturnDate datetime,
@ShelfId int= null,
@BorrowDate datetime = null,
@ReservationId int = null,
@Comment varchar(50) = null,
@InsBy int,
@Error int out



AS
begin transaction 
begin try


DECLARE @BAvailableCoppies int
Declare @Reservations int
set @Reservations =0
SELECT @BAvailableCoppies=  m.AvailableCoppies FROM dbo.Materials m WHERE M.MaterialId = @MaterialId


select  @Reservations = count(@MaterialId) from Reservations r where r.SubscriberId = @SubscriberId and r.MaterialId = @MaterialId and r.ReservationDate > Getdate()

if(@Reservations > 0)
begin

set @BAvailableCoppies = @BAvailableCoppies - @Reservations

end
else 
begin

set @BAvailableCoppies = @BAvailableCoppies - 1
EXEC usp_UpdateAvaliableCoppies  @MaterialId, @BAvailableCoppies

end



if(@BAvailableCoppies >0)
begin

set @Error = 0

INSERT INTO dbo.Borrowings
(
    --BorrowId - column value is auto-generated
    SubscriberId,
    MaterialId,
    BorrowDate,
    ReturnDate,
	ReservationId,
    ShelfId,
    Comment,
    InsBy,
    InsDate
)
VALUES
(
    -- BorrowId - int
   @SubscriberId, -- SubscriberId - int
    @MaterialId, -- MaterialId - int
    @BorrowDate, -- DateOfReceipt - datetime
    @ReturnDate, -- ReturnDate - datetime
	@ReservationId,
    @ShelfId, -- ShelfId - int
    @Comment, -- Comment - varchar
    @InsBy, -- InsBy - int
    getdate() -- InsDate - datetime
)
end

else
begin

set @Error = 1
end


commit transaction

end try

begin catch

ROLLBACK


end catch

;

GO
/****** Object:  StoredProcedure [dbo].[usp_CreateBorrowReturns]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateBorrowReturns]
@BorrowId int,
@ReturnDate datetime,
@BillId int = null,
@Comment varchar(8000) = NULL,
@InsBy int
AS

BEGIN TRANSACTION
BEGIN TRY


	   DECLARE @BMaterialId int
DECLARE @BAvailableCoppies int

SELECT @BMaterialId = b.MaterialId FROM dbo.Borrowings b WHERE b.BorrowId = @BorrowId




INSERT INTO dbo.BorrowReturns
(
   BorrowId,
   ReturnDate,
   BillId,
   Comment,
   InsBy,
   InsDate,
   UpdNo
)
VALUES
(
    -- BorrowId - int
    @BorrowId, 
    @ReturnDate, -- MaterialId - int
    @BillId, 
    @Comment, -- Comment - varchar
    @InsBy, -- InsBy - int
    GetDate(),
	0
)

  SELECT @BAvailableCoppies=  m.AvailableCoppies FROM dbo.Materials m WHERE M.MaterialId = @BMaterialId
set @BAvailableCoppies = @BAvailableCoppies + 1

EXEC usp_UpdateAvaliableCoppies  @BMaterialId, @BAvailableCoppies

	   Commit transaction

END try



BEGIN CATCH 

ROLLBACK 

end CATCH 

;

GO
/****** Object:  StoredProcedure [dbo].[usp_CreateGenre]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateLanguage]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterial]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_CreateMaterialType]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CreateMaterialType]
@MaterialType varchar(50),
@InsBy int,
@MaterialTypeDelayFee MONEY,
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
	MaterialTypeDelayFee,
    InsBy,
    InsDate
)
VALUES
(
@MaterialType,
@MaterialTypeDelayFee,
@InsBy,
@TodayDate
)

END





END

GO
/****** Object:  StoredProcedure [dbo].[usp_CreateShelf]    Script Date: 6/9/2020 1:35:25 PM ******/
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
    QuantityOfShelf,
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
/****** Object:  StoredProcedure [dbo].[usp_CreateUsers]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteGenre]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteLanguage]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterial]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteMaterialType]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteShelf]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_DeleteUser]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_EditMaterial]    Script Date: 6/9/2020 1:35:25 PM ******/
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
@IsActive bit,
@ShelfId int
 

AS
BEGIN

BEGIN TRANSACTION 

BEGIN TRY








DECLARE @TodayDate datetime

SET @TodayDate = GETDATE()

DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo +1 FROM dbo.Materials mt WHERE @MaterialId = mt.MaterialId

SELECT @AuthorId = AuthorId FROM materials WHERE materialId = @MaterialId

DECLARE @an bit
SET @an = 0
     SELECT   @an = 1 FROM dbo.Materials m WHERE (SELECT  COUNT(AuthorId)
FROM Materials
GROUP BY dbo.Materials.AuthorId
HAVING COUNT(*) > 1 ) > 1

if(@an =0)
begin
UPDATE dbo.Authors
SET
    dbo.Authors.AuthorName = @Author, 
    dbo.Authors.UpdBy = @UpdId,
    dbo.Authors.UpdDate = @TodayDate,
    dbo.Authors.UpdNo = @UpdNo 
WHERE @AuthorId = AuthorId

 END
ELSE
begin
INSERT INTO dbo.Authors
(
    --AuthorId - column value is auto-generated
AuthorName,
InsBy,
InsDate
)
VALUES
(
@Author,
@UpdId,
@TodayDate
)
end
DECLARE @ph bit
SET @ph = 0
 SELECT  @ph =1 FROM dbo.Materials m  WHERE (SELECT  COUNT(PublishingHouseId)
FROM Materials
GROUP BY dbo.Materials.PublishingHouseId
HAVING COUNT(*) > 1  ) > 1

if(@ph = 0)
BEGIN
UPDATE dbo.PublishHouses
    SET
   --PublishHouseId - column value is auto-generated
   dbo.PublishHouses.PublishHouse = @PublishHouse, -- varchar
   dbo.PublishHouses.UpdBy = @UpdId, -- int
   dbo.PublishHouses.UpdDate = @TodayDate, -- datetime
   dbo.PublishHouses.UpdNo = @UpdNo -- int
WHERE PublishHouseId = @PublishHouseId

END
ELSE 
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
@UpdId,
@TodayDate
)
set @PublishHouseId = Scope_Identity()
END
UPDATE dbo.Materials
SET
    --MaterialId - column value is auto-generated
    dbo.Materials.Title = @Title, -- varchar
    dbo.Materials.GenreId = @GenreId, -- int
    dbo.Materials.PublishingHouseId = @PublishHouseId, -- int
    dbo.Materials.PublishYear = @PublicationYear, -- date
    dbo.Materials.ISBN = @ISBN, -- varchar
    dbo.Materials.MaterialTypeId = @MaterialTypeId, -- int
    dbo.Materials.AvailableCoppies = @AvailableCoppies, -- int
    dbo.Materials.NumberOfPages = @NumberOfPages, -- int
    dbo.Materials.LanguageId = @LanguageId, -- int
    dbo.Materials.UpdBy = @UpdId, -- int
    dbo.Materials.UpdDate = Getdate(), -- datetime
    dbo.Materials.UpdNo = @UpdNo, -- int
    dbo.Materials.AuthorId = @AuthorId, -- int
    dbo.Materials.IsActive = @IsActive, -- bit
    dbo.Materials.ShelfId = @ShelfId, -- int
    dbo.Materials.MaterialQuantity = @Quantity -- int
WHERE @MaterialId = Materials.MaterialId  
COMMIT TRANSACTION 
END TRY
BEGIN CATCH 
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ExpiredSubscriber]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ExpiredSubscriber]
AS

SELECT s.Email FROM dbo.Subscribers s WHERE GETDATE() > s.EndDate

UPDATE dbo.Subscribers 
SET dbo.Subscribers.IsActive = 0  
WHERE GETDATE() > Subscribers.EndDate;

GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllBorrowings]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllBorrowings]
AS

SELECT b.BorrowId, s.SubscriberId,s.Name,s.LastName,m1.MaterialId,m1.Title,m1.MaterialTypeId,m1.MaterialTypeDelayFee,m1.MaterialType,m1.AuthorId,m1.AuthorName,m1.MaterialTypeDelayFee
,b.ReturnDate AS Deadline,s2.ShelfId,s2.Location,b.Comment,b.BorrowDate,r.Id,r.ReservationDate,r.Id AS reservationId,b.InsBy,b.InsDate,b.UpdBy,b.UpdDate,b.UpdDate,b.UpdNo
, br.BorrowReturnId, br.ReturnDate, br.BillId, br.Comment AS [ReturnComment]
FROM dbo.Borrowings b
INNER JOIN 
	(SELECT m.MaterialId, m.Title,
	  mt.MaterialTypeId,mt.MaterialType, a.AuthorId, a.AuthorName, mt.MaterialTypeDelayFee
	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId) m1 ON b.MaterialId = m1.MaterialId
INNER JOIN dbo.Subscribers s ON b.SubscriberId = s.SubscriberId
LEFT JOIN dbo.Shelves s2 ON b.ShelfId = s2.ShelfId
LEFT JOIN BorrowReturns br ON b.BorrowId = br.BorrowId
LEFT JOIN dbo.Reservations r ON b.ReservationId = r.Id
;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllBorrowReturn]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllBorrowReturn]
@BorrowId int

AS

SELECT *
FROM BorrowReturns br
;

GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllGenres]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllGenres]


AS

SELECT * FROM genres WHERE Genres.IsActive = 1;

GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllLanguages]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[usp_GetAllLanguages]



AS BEGIN


SELECT * FROM languages WHERE IsActive = 1

end


GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllMaterials]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[usp_GetAllMaterials]

	AS
		SELECT m.MaterialId, m.Title, g.GenreId, g.Genre, ph.PublishHouseId,ph.PublishHouse,
	m.PublishYear, m.ISBN, mt.MaterialTypeId,
	mt.MaterialType, m.AvailableCoppies, m.MaterialQuantity ,m.NumberOfPages,
	l.LanguageId, l.Language, a.AuthorId, a.AuthorName, m.IsActive, 
	s.ShelfId, s.Location, s.QuantityOfShelf AS ShelfQuantity, s.Description, m.InsBy, m.InsDate, m.UpdNo, m.UpdBy, m.UpdDate

	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.Genres g ON m.GenreId = g.GenreId
	JOIN dbo.Languages l ON m.LanguageId = l.LanguageId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId
	JOIN dbo.Shelves s ON m.ShelfId = s.ShelfId
		JOIN dbo.PublishHouses ph ON m.PublishingHouseId = ph.PublishHouseId
		WHERE m.IsActive = 1;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllMaterialTypes]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllMaterialTypes]

AS

SELECT * FROM dbo.MaterialTypes mt WHERE mt.IsActive = 1;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllRoles]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetAllShelves]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetAllUsers]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetAllUsers]

AS

SELECT u.UserId AS UserId,u.Username AS Username, u.Name AS Name, u.LastName AS LastName, u.RoleId AS RoleId,r.Role AS Role, u.Email AS Email,u.InsBy AS InsBy,u.InsDate AS InsDate,u.UpdBy AS UpdBy,u.UpdDate,u.UpdNo AS UpdNo,u.IsActive AS IsActive , u.Password
FROM dbo.USERS u 
JOIN dbo.Roles r 
ON u.RoleId = r.RoleId
WHERE IsActive = 1;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetBorrowById]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetBorrowById]
@BorrowId int
AS

SELECT b.BorrowId, s.SubscriberId,s.Name,s.LastName,m1.MaterialId,m1.MaterialTypeDelayFee,m1.Title,m1.MaterialTypeId,m1.MaterialType,m1.AuthorId,m1.AuthorName,m1.MaterialTypeDelayFee
,b.ReturnDate AS Deadline,s2.ShelfId,s2.Location,b.Comment,b.BorrowDate,r.Id,r.ReservationDate,b.InsBy,b.InsDate,b.UpdBy,b.UpdDate,b.UpdDate,b.UpdNo
, br.BorrowReturnId, br.ReturnDate, br.BillId, br.Comment AS [ReturnComment]
FROM dbo.Borrowings b
INNER JOIN 
	(SELECT m.MaterialId, m.Title,
	  mt.MaterialTypeId,mt.MaterialType, a.AuthorId, a.AuthorName,mt.MaterialTypeDelayFee
	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId) m1 ON b.MaterialId = m1.MaterialId
INNER JOIN dbo.Subscribers s ON b.SubscriberId = s.SubscriberId
LEFT JOIN dbo.Shelves s2 ON b.ShelfId = s2.ShelfId
LEFT JOIN BorrowReturns br ON b.BorrowId = br.BorrowId
LEFT JOIN dbo.Reservations r ON b.ReservationId = r.Id
WHERE @BorrowId = b.BorrowId
;

GO
/****** Object:  StoredProcedure [dbo].[usp_GetBorrowCountLast12Months]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_GetBorrowCountLast12Months]

as

select Count(BorrowId) as borrowings,Month(b.BorrowDate) as [month]
from (select *
from borrowings 
where DATEADD(Month, -12, GETDATE()) < BorrowDate and BorrowDate < GETDATE()) as b
GROUP BY Month(b.BorrowDate)

;

GO
/****** Object:  StoredProcedure [dbo].[usp_GetBorrowReturnByBorrowId]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetBorrowReturnByBorrowId]
@BorrowId int

AS

SELECT *
FROM BorrowReturns br
WHERE @BorrowId = br.BorrowId
;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetExpiredSubscribers]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetExpiredSubscribers]

AS


SELECT s.Email, s.SubscriberId
FROM dbo.Subscribers s
WHERE getdate() > s.EndDate;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetMaterialById]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetMaterialById]
@MaterialId int

AS

	SELECT m.MaterialId, m.Title, g.GenreId, g.Genre, ph.PublishHouseId,ph.PublishHouse,
	m.PublishYear, m.ISBN, mt.MaterialTypeId,
	mt.MaterialType, m.AvailableCoppies, m.MaterialQuantity ,m.NumberOfPages,
	l.LanguageId, l.Language, a.AuthorId, a.AuthorName, m.IsActive, 
	s.ShelfId, s.Location, s.QuantityOfShelf AS ShelfQuantity, s.Description, m.InsBy, m.InsDate, m.UpdNo, m.UpdBy, m.UpdDate

	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.Genres g ON m.GenreId = g.GenreId
	JOIN dbo.Languages l ON m.LanguageId = l.LanguageId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId
	JOIN dbo.Shelves s ON m.ShelfId = s.ShelfId
	LEFT JOIN dbo.PublishHouses ph ON m.PublishingHouseId = ph.PublishHouseId
	WHERE m.MaterialId = @MaterialId;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetReservationById]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetReservationById]
@ReservationId int
AS

SELECT r.Id, r.SubscriberId, r.MaterialId, r.ReservationDate,s.Name, s.LastName,m.Title,m.AuthorName,m.MaterialType, m.MaterialTypeDelayFee,m.ShelfId, m.Location,r.InsDate
from dbo.Reservations r
JOIN dbo.Subscribers s ON r.SubscriberId = s.SubscriberId
JOIN (
SELECT m.Title,m.MaterialId,a.AuthorId, a.AuthorName,mt.MaterialType, mt.MaterialTypeId, mt.MaterialTypeDelayFee, mt.IsActive, s2.ShelfId, s2.Location
from Materials m 
JOIN dbo.Authors a ON m.AuthorId = a.AuthorId 
JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId
JOIN dbo.Shelves s2 ON m.ShelfId = s2.ShelfId
) m ON r.MaterialId = m.MaterialId
WHERE r.Id = @ReservationId;

GO
/****** Object:  StoredProcedure [dbo].[usp_GetReservationBySubscriberIdAndMaterialId]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_GetReservationBySubscriberIdAndMaterialId]
@SubscriberId int,
@MaterialId int

as
SELECT r.Id, r.SubscriberId, r.MaterialId, r.ReservationDate, r.InsBy, r.InsDate, r.UpdBy, r.UpdDate, r.UpdNo ,
m1.MaterialId, m1.Title, m1.MaterialType, m1.AuthorId, m1.AuthorName,m1.Location, s.SubscriberId, s.Name, s.LastName, s.PhoneNumber, s.Email
 FROM dbo.Reservations AS r 
INNER JOIN 
	(SELECT m.MaterialId, m.Title,
	  mt.MaterialTypeId,mt.MaterialType, a.AuthorId, a.AuthorName, s2.Location
	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.Shelves s2 ON m.ShelfId = s2.ShelfId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId) m1 ON r.MaterialId = m1.MaterialId
JOIN dbo.Subscribers s ON r.SubscriberId = s.SubscriberId
 where r.SubscriberId = @SubscriberId and r.MaterialId = @MaterialId and r.ReservationDate > Getdate()
;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetShelfById]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetShelfById]
@ShelfId int

AS
SELECT * FROM dbo.Shelves s WHERE s.ShelfId = @ShelfId;


GO
/****** Object:  StoredProcedure [dbo].[usp_GetSubsBorrowReturn]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetSubsBorrowReturn]

AS
SELECT s.Email , s.Name,s.LastName,m.Title,m.AuthorName,m.MaterialType
FROM Borrowings b
JOIN dbo.Subscribers s ON b.SubscriberId = s.SubscriberId
JOIN (
SELECT a.AuthorName,Title,mt.MaterialType,MaterialId
FROM dbo.Materials m2 
JOIN dbo.Authors a ON m2.AuthorId = a.AuthorId
JOIN dbo.MaterialTypes mt ON m2.MaterialTypeId = mt.MaterialTypeId
) m ON b.MaterialId = m.MaterialId
 WHERE month(b.ReturnDate) = MONTH(DATEADD(DAY, 5, GETDATE())) AND YEAR(b.ReturnDate) = YEAR(DATEADD(DAY, 5, GETDATE())) AND day(DATEADD(DAY, 5, GETDATE())) = DAY(b.ReturnDate) AND b.IsNotified = 0

UPDATE dbo.Borrowings
SET
dbo.Borrowings.IsNotified = 1
WHERE month(dbo.Borrowings.ReturnDate) = MONTH(DATEADD(DAY, 5, GETDATE())) AND YEAR(dbo.Borrowings.ReturnDate) = YEAR(DATEADD(DAY, 5, GETDATE())) AND day(DATEADD(DAY, 5, GETDATE())) = DAY(dbo.Borrowings.ReturnDate) AND dbo.Borrowings.IsNotified = 0
;

GO
/****** Object:  StoredProcedure [dbo].[usp_GetTop10Subscribers]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_GetTop10Subscribers]
as
SELECT TOP 10 * FROM Subscribers
ORDER BY SubscriberId DESC
GO
/****** Object:  StoredProcedure [dbo].[usp_GetTop5Subscribers]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_GetTop5Subscribers]
as
SELECT TOP 5 * FROM Subscribers
ORDER BY SubscriberId DESC
GO
/****** Object:  StoredProcedure [dbo].[usp_GetTotalCountBorrowings]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_GetTotalCountBorrowings]
as
SELECT COUNT(BorrowId) as Id
FROM Borrowings		;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetTotalCountMaterials]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_GetTotalCountMaterials]
as
SELECT COUNT(MaterialId) as Id
FROM Materials	  ;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetTotalCountSubscribers]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_GetTotalCountSubscribers]
as
SELECT COUNT(SubscriberId) as Id
FROM Subscribers  ;
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUser]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetUserByUsername]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_LogIn]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_MostBorrowedBooks]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[usp_MostBorrowedBooks]
	as
	select s.Borrowings, m.MaterialId, m.Title, a.AuthorName
	from (select TOP(10) Count(MaterialId) AS Borrowings, MaterialId from Borrowings GROUP BY Borrowings.MaterialId ORDER BY Borrowings DESC) s
	JOIN Materials m ON s.MaterialId =  m.MaterialId
	JOIN Authors a ON a.AuthorId = m.AuthorId
	;

GO
/****** Object:  StoredProcedure [dbo].[usp_MostBorrowedMaterialTypes]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_MostBorrowedMaterialTypes]

as


select TOP(5)  Count( m1.MaterialTypeId) as Borrowings, m1.MaterialType
from Borrowings b
join (SELECT m.MaterialId, m.Title,
	  mt.MaterialTypeId,mt.MaterialType, a.AuthorId, a.AuthorName, mt.MaterialTypeDelayFee
	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId) m1 ON b.MaterialId = m1.MaterialId
Group By  m1.MaterialType
Order by Borrowings desc

;

GO
/****** Object:  StoredProcedure [dbo].[usp_Reservations_Delete]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[usp_Reservations_Delete]
@ReservationID INT

AS

IF(@reservationId IS NULL)
BEGIN
RAISERROR('KY REZERVIM NUK EKZISTON', 16, 1)
RETURN -1
END

   DELETE FROM dbo.Reservations  

   WHERE  Id = @reservationID;

GO
/****** Object:  StoredProcedure [dbo].[usp_Reservations_GetAll]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Reservations_GetAll]
AS
SELECT r.Id, r.SubscriberId, r.MaterialId, r.ReservationDate, r.InsBy, r.InsDate, r.UpdBy, r.UpdDate, r.UpdNo ,
m1.MaterialId, m1.Title, m1.MaterialType, m1.AuthorId, m1.AuthorName,m1.Location, s.SubscriberId, s.Name, s.LastName, s.PhoneNumber, s.Email
 FROM dbo.Reservations AS r 
INNER JOIN 
	(SELECT m.MaterialId, m.Title,
	  mt.MaterialTypeId,mt.MaterialType, a.AuthorId, a.AuthorName, s2.Location
	FROM dbo.Materials m
	JOIN dbo.Authors a ON m.AuthorId = a.AuthorId
	JOIN dbo.Shelves s2 ON m.ShelfId = s2.ShelfId
	JOIN dbo.MaterialTypes mt ON m.MaterialTypeId = mt.MaterialTypeId) m1 ON r.MaterialId = m1.MaterialId
JOIN dbo.Subscribers s ON r.SubscriberId = s.SubscriberId

;

GO
/****** Object:  StoredProcedure [dbo].[usp_Reservations_GetByID]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[usp_Reservations_GetByID]
	@reservationId INT
AS

IF(@reservationId IS NULL)
BEGIN
RAISERROR('KY REZERVIM NUK EKZISTON', 16, 1)
RETURN -1
END

	SELECT * 
	FROM  dbo.Reservations

	WHERE Id=@reservationId;

GO
/****** Object:  StoredProcedure [dbo].[usp_Reservations_Insert]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Reservations_Insert]
	@subscriberId INT,
	@materialId INT,
	@reservationDate DATE,
	@insBy INT

AS

BEGIN TRY


declare	@reservationId INT
INSERT INTO dbo.Reservations
(
	SubscriberId,
	MaterialId,
	ReservationDate,
	InsBy,
	InsDate
)
VALUES
(	
	@subscriberId,@materialId,@reservationDate,
	@insBy, GETDATE()
);

	--SCOPE IDENTITY
	SET @reservationId=SCOPE_IDENTITY();

END TRY


BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH

GO
/****** Object:  StoredProcedure [dbo].[usp_Reservations_Update]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[usp_Reservations_Update]
	@reservationId INT,
	@subscriberId INT,
	@materialId INT,
	@reservationDate DATE,
	@updBy INT

AS

BEGIN TRY

UPDATE Reservations 
           
SET  
    SubscriberId=@subscriberId,
	MaterialId=@materialId,
	ReservationDate=@reservationDate,
	UpdBy = @updBy,
	UpdDate = GETDATE(),
    UpdNo = ISNULL(UpdNo,0)+1    
				  
WHERE  
	Reservations.Id = @reservationId

END TRY

BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH

GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Delete]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Subscribers_Delete]
	@subscriberId INT

AS

--select * from dbo.Subscribers;
--exec usp_Subscribers_Delete 20

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
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_GetAll]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_GetAll]
AS
SELECT *   FROM   dbo.Subscribers AS s;


GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_GetByID]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Insert]    Script Date: 6/9/2020 1:35:25 PM ******/
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
	@insBy INT
	
AS
--delete from dbo.Subscribers where SubscriberId=15;
--select * from dbo.Subscribers;
--exec usp_Subscribers_Insert 'aa','aa','aa','2020-02-02','aa','aa','aa','M', '2029-02-02', 1, 80
BEGIN TRY


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
	



END TRY

BEGIN CATCH

DECLARE @ErrorMsg NVARCHAR(MAX)
SET @ErrorMsg=ERROR_MESSAGE();

RAISERROR (@ErrorMsg,16,1)
RETURN -1;

END CATCH


GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_MaxId]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subscribers_MaxId]

 

AS

 

SELECT MAX(SubscriberId) as Id

FROM Subscribers;

GO
/****** Object:  StoredProcedure [dbo].[usp_Subscribers_Update]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateAvaliableCoppies]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateAvaliableCoppies]
@MaterialId int,
@AvailableCoppies int
AS

update dbo.Materials
SET
    --MaterialId - column value is auto-generated
   
    dbo.Materials.AvailableCoppies = @AvailableCoppies  -- int
	WHERE dbo.Materials.MaterialId = @MaterialId;

GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateBorrow]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_UpdateBorrow]
@BorrowId int,
@SubscriberId int,
@MaterialId int,
@ReturnDate datetime,
@ShelfId int= null,
@Comment varchar(50) = null,
@BorrowDate datetime = null,
@ReturnedBorrowId int = null,
@UpdBy int,
@ReservationId int = null

AS

DECLARE @BMaterialId int

SELECT @BMaterialId = b.MaterialId FROM dbo.Borrowings b WHERE b.BorrowId = @BorrowId

DECLARE @IsReturned bit
SET @IsReturned = 0

SELECT @IsReturned = 1 FROM dbo.BorrowReturns  br WHERE @BorrowId = br.BorrowId

if(@BMaterialId <> @MaterialId AND @IsReturned = 0)
BEGIN

	DECLARE @BAvailableCoppies int

	SELECT @BAvailableCoppies=  m.AvailableCoppies FROM dbo.Materials m WHERE M.MaterialId = @BMaterialId
set @BAvailableCoppies = @BAvailableCoppies + 1

EXEC usp_UpdateAvaliableCoppies  @BMaterialId, @BAvailableCoppies



	SELECT @BAvailableCoppies =  m.AvailableCoppies FROM dbo.Materials m WHERE M.MaterialId = @MaterialId
set @BAvailableCoppies = @BAvailableCoppies - 1

EXEC usp_UpdateAvaliableCoppies  @MaterialId, @BAvailableCoppies




	END


	DECLARE @UpdNo int
SELECT @UpdNo = b.UpdNo+ 1  FROM dbo.Borrowings b WHERE @BorrowId = b.BorrowId


	UPDATE dbo.Borrowings
SET
    --BorrowId - column value is auto-generated
    dbo.Borrowings.SubscriberId = @SubscriberId, -- int
    dbo.Borrowings.MaterialId = @MaterialId, -- int
    dbo.Borrowings.ReturnDate = @ReturnDate, -- datetime
    dbo.Borrowings.ShelfId = @ShelfId, -- int
    dbo.Borrowings.Comment = @Comment, -- varchar
    dbo.Borrowings.UpdBy = @UpdBy, -- int
    dbo.Borrowings.UpdDate = GETDATE(), -- datetime
    dbo.Borrowings.UpdNo = @UpdNo, -- int
    dbo.Borrowings.ReservationId = @ReservationId, -- int
    dbo.Borrowings.BorrowDate = @BorrowDate -- datetime
	WHERE @BorrowId = Borrowings.BorrowId
;


GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateBorrowReturn]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[usp_UpdateBorrowReturn]
		@BorrowReturnId int,
	@BorrowId int,
@ReturnDate datetime,
@BillId int = null,
@Comment varchar(8000) = NULL,
@UpdBy int
AS




DECLARE @UpdNo int
SELECT @UpdNo = mt.UpdNo +1 FROM dbo.BorrowReturns mt WHERE @BorrowReturnId = mt.BorrowReturnId






UPDATE dbo.BorrowReturns
SET
    --BorrowReturnId - column value is auto-generated
    dbo.BorrowReturns.BorrowId = @BorrowId, -- int
    dbo.BorrowReturns.ReturnDate = @ReturnDate, -- datetime
    dbo.BorrowReturns.BillId = @BillId, -- int
    dbo.BorrowReturns.UpdDate = getdate(), -- datetime
    dbo.BorrowReturns.UpdNo = @UpdNo, -- int
    dbo.BorrowReturns.Comment = @Comment, -- varchar
    dbo.BorrowReturns.UpdBy = @UpdBy -- int
	WHERE @BorrowReturnId = BorrowReturnId


	;

GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateGenre]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateLanguage]    Script Date: 6/9/2020 1:35:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdateMaterialType]    Script Date: 6/9/2020 1:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateMaterialType]
@MaterialTypeId int,
@MaterialType varchar(50),
@MaterialTypeDelayFee MONEY,
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
	dbo.MaterialTypes.MaterialTypeDelayFee = @MaterialTypeDelayFee,
    dbo.MaterialTypes.UpdBy = @UpdBy, -- int
    dbo.MaterialTypes.UpdDate = @TodayDate, -- datetime
    dbo.MaterialTypes.UpdNo = @UpdNo, -- intalTypes
	 dbo.MaterialTypes.IsActive=@IsActive
	WHERE @MaterialTypeId = MaterialTypeId
	END


GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateShelf]    Script Date: 6/9/2020 1:35:25 PM ******/
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
    dbo.Shelves.QuantityOfShelf = @Quantity, -- int
    dbo.Shelves.Description = @Description, -- varchar
    dbo.Shelves.UpdBy = @UpdBy, -- int
    dbo.Shelves.UpdDate = @TodayDate, -- datetime
    dbo.Shelves.UpdNo = @UpdateNo -- int
	WHERE dbo.Shelves.ShelfId = @ShelfId
	END


GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateUser]    Script Date: 6/9/2020 1:35:25 PM ******/
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
