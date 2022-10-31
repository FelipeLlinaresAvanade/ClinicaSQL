USE [master]
GO
/****** Object:  Database [Clinica]    Script Date: 31/10/2022 12:56:26 ******/
CREATE DATABASE [Clinica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Citas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Citas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Citas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Citas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Clinica] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clinica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clinica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clinica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Clinica] SET  MULTI_USER 
GO
ALTER DATABASE [Clinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clinica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clinica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Clinica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Clinica] SET QUERY_STORE = OFF
GO
USE [Clinica]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 31/10/2022 12:56:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FechaYhora] [datetime] NOT NULL,
	[Paciente] [nvarchar](50) NOT NULL,
	[Medico] [nvarchar](50) NOT NULL,
	[numeroConsulta] [int] NOT NULL,
 CONSTRAINT [PK_Citas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Clinica] SET  READ_WRITE 
GO
