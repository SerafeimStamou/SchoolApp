USE [master]
GO
/****** Object:  Database [SchoolAppDB]    Script Date: 11/1/2021 12:33:58 μμ ******/
CREATE DATABASE [SchoolAppDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolAppDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SchoolAppDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolAppDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SchoolAppDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolAppDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolAppDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolAppDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolAppDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolAppDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolAppDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolAppDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolAppDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolAppDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolAppDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolAppDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolAppDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolAppDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolAppDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolAppDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolAppDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolAppDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolAppDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolAppDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolAppDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolAppDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolAppDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolAppDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolAppDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolAppDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SchoolAppDB] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolAppDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolAppDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolAppDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolAppDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolAppDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SchoolAppDB', N'ON'
GO
ALTER DATABASE [SchoolAppDB] SET QUERY_STORE = OFF
GO
USE [SchoolAppDB]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 11/1/2021 12:33:58 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[HoursPerWeek] [smallint] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollments]    Script Date: 11/1/2021 12:33:59 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollments](
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 11/1/2021 12:33:59 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[IsSubscribed] [bit] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 11/1/2021 12:33:59 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[CourseID] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([ID], [Title], [HoursPerWeek]) VALUES (1, N'Math', 4)
INSERT [dbo].[Courses] ([ID], [Title], [HoursPerWeek]) VALUES (2, N'Physics', 4)
INSERT [dbo].[Courses] ([ID], [Title], [HoursPerWeek]) VALUES (3, N'Biology', 2)
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
INSERT [dbo].[Enrollments] ([StudentID], [CourseID]) VALUES (14, 1)
INSERT [dbo].[Enrollments] ([StudentID], [CourseID]) VALUES (21, 1)
INSERT [dbo].[Enrollments] ([StudentID], [CourseID]) VALUES (21, 2)
INSERT [dbo].[Enrollments] ([StudentID], [CourseID]) VALUES (14, 2)
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [FirstName], [LastName], [Email], [Phone], [BirthDate], [IsSubscribed]) VALUES (14, N'Sarah', N'Parker', N'parker@mail.com', N'99', CAST(N'1980-01-30' AS Date), 0)
INSERT [dbo].[Students] ([ID], [FirstName], [LastName], [Email], [Phone], [BirthDate], [IsSubscribed]) VALUES (21, N'John ', N'Smith', N'smith@mail.com', N'99', CAST(N'1981-02-11' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([ID], [FirstName], [LastName], [Email], [Phone], [CourseID]) VALUES (13, N'Mary', N'Watson', N'watson@mail.com', N'9988', 1)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([ID])
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK__Enrollmen__Stude__5535A963] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK__Enrollmen__Stude__5535A963]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([ID])
GO
USE [master]
GO
ALTER DATABASE [SchoolAppDB] SET  READ_WRITE 
GO
