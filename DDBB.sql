USE [master]
GO

/****** Object:  Database [Gestion_Interna]    Script Date: 18-09-2020 11:55:16 ******/
CREATE DATABASE [Gestion_Interna]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestion_Interna', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestion_Interna.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gestion_Interna_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestion_Interna_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestion_Interna].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Gestion_Interna] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Gestion_Interna] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Gestion_Interna] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Gestion_Interna] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Gestion_Interna] SET ARITHABORT OFF 
GO

ALTER DATABASE [Gestion_Interna] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Gestion_Interna] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Gestion_Interna] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Gestion_Interna] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Gestion_Interna] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Gestion_Interna] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Gestion_Interna] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Gestion_Interna] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Gestion_Interna] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Gestion_Interna] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Gestion_Interna] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Gestion_Interna] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Gestion_Interna] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Gestion_Interna] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Gestion_Interna] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Gestion_Interna] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Gestion_Interna] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Gestion_Interna] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Gestion_Interna] SET  MULTI_USER 
GO

ALTER DATABASE [Gestion_Interna] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Gestion_Interna] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Gestion_Interna] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Gestion_Interna] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Gestion_Interna] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Gestion_Interna] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Gestion_Interna] SET  READ_WRITE 
GO
