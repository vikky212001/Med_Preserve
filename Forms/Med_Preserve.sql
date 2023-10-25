USE [master]
GO
/****** Object:  Database [Med_Preserve]    Script Date: 10/26/2023 2:40:45 AM ******/
CREATE DATABASE [Med_Preserve]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Med_Preserve', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Med_Preserve.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Med_Preserve_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Med_Preserve_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Med_Preserve] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Med_Preserve].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Med_Preserve] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Med_Preserve] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Med_Preserve] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Med_Preserve] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Med_Preserve] SET ARITHABORT OFF 
GO
ALTER DATABASE [Med_Preserve] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Med_Preserve] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Med_Preserve] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Med_Preserve] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Med_Preserve] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Med_Preserve] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Med_Preserve] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Med_Preserve] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Med_Preserve] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Med_Preserve] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Med_Preserve] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Med_Preserve] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Med_Preserve] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Med_Preserve] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Med_Preserve] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Med_Preserve] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Med_Preserve] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Med_Preserve] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Med_Preserve] SET  MULTI_USER 
GO
ALTER DATABASE [Med_Preserve] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Med_Preserve] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Med_Preserve] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Med_Preserve] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Med_Preserve] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Med_Preserve] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Med_Preserve] SET QUERY_STORE = ON
GO
ALTER DATABASE [Med_Preserve] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Med_Preserve]
GO
/****** Object:  Table [dbo].[CompanyMaster]    Script Date: 10/26/2023 2:40:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyMaster](
	[SrNo] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[ContactNo] [varchar](15) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Logo] [varbinary](max) NULL,
	[CreatedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SrNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoggerConfig]    Script Date: 10/26/2023 2:40:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoggerConfig](
	[SrNo] [int] NOT NULL,
	[LoggerID] [int] NOT NULL,
	[S1_T_Low] [numeric](5, 2) NULL,
	[S1_T_High] [numeric](5, 2) NULL,
	[S1_H_Low] [numeric](5, 2) NULL,
	[S1_H_High] [numeric](5, 2) NULL,
	[S2_T_Low] [numeric](5, 2) NULL,
	[S2_T_High] [numeric](5, 2) NULL,
	[S2_H_Low] [numeric](5, 2) NULL,
	[S2_H_High] [numeric](5, 2) NULL,
	[S3_T_Low] [numeric](5, 2) NULL,
	[S3_T_High] [numeric](5, 2) NULL,
	[S3_H_Low] [numeric](5, 2) NULL,
	[S3_H_High] [numeric](5, 2) NULL,
	[S4_T_Low] [numeric](5, 2) NULL,
	[S4_T_High] [numeric](5, 2) NULL,
	[S4_H_Low] [numeric](5, 2) NULL,
	[S4_H_High] [numeric](5, 2) NULL,
	[S1_T_Calibrate] [numeric](5, 2) NULL,
	[S2_T_Calibrate] [numeric](5, 2) NULL,
	[S3_T_Calibrate] [numeric](5, 2) NULL,
	[S4_T_Calibrate] [numeric](5, 2) NULL,
	[S1_H_Calibrate] [numeric](5, 2) NULL,
	[S2_H_Calibrate] [numeric](5, 2) NULL,
	[S3_H_Calibrate] [numeric](5, 2) NULL,
	[S4_H_Calibrate] [numeric](5, 2) NULL,
	[S1_Temp] [numeric](5, 2) NULL,
	[S2_Temp] [numeric](5, 2) NULL,
	[S3_Temp] [numeric](5, 2) NULL,
	[S4_Temp] [numeric](5, 2) NULL,
	[S1_Humi] [numeric](5, 2) NULL,
	[S2_Humi] [numeric](5, 2) NULL,
	[S3_Humi] [numeric](5, 2) NULL,
	[S4_Humi] [numeric](5, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoggerMaster]    Script Date: 10/26/2023 2:40:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoggerMaster](
	[LoggerID] [int] IDENTITY(1,1) NOT NULL,
	[LoggerName] [varchar](50) NOT NULL,
	[LoggerType] [varchar](25) NOT NULL,
	[NoOfSensors] [int] NOT NULL,
	[AssignTo] [varchar](50) NOT NULL,
	[Interval] [int] NULL,
	[S1Name] [varchar](25) NULL,
	[S2Name] [varchar](25) NULL,
	[S3Name] [varchar](25) NULL,
	[S4Name] [varchar](25) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LoggerMaster1] PRIMARY KEY CLUSTERED 
(
	[LoggerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/26/2023 2:40:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] NOT NULL,
	[RoleType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SensorData]    Script Date: 10/26/2023 2:40:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SensorData](
	[SrNO] [int] NOT NULL,
	[LoggerID] [int] NOT NULL,
	[S1_T] [int] NULL,
	[S1_H] [int] NULL,
	[S2_T] [int] NULL,
	[S2_H] [int] NULL,
	[S3_T] [int] NULL,
	[S3_H] [int] NULL,
	[S4_T] [int] NULL,
	[S4_H] [int] NULL,
	[TimeStamp] [datetime] NULL,
 CONSTRAINT [PK_SensorData] PRIMARY KEY CLUSTERED 
(
	[SrNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserData]    Script Date: 10/26/2023 2:40:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserData](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Mobile] [varchar](15) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Reason] [varchar](255) NULL,
	[RoleID] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_UserData] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserData]  WITH CHECK ADD  CONSTRAINT [FK_UserData_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[UserData] CHECK CONSTRAINT [FK_UserData_Role]
GO
USE [master]
GO
ALTER DATABASE [Med_Preserve] SET  READ_WRITE 
GO
