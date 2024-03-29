USE [master]
GO
/****** Object:  Database [Managerment_SellProduct]    Script Date: 12/7/2019 12:38:17 PM ******/
CREATE DATABASE [Managerment_SellProduct]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Managerment_SellProduct', FILENAME = N'E:\MySQLServer\MSSQL14.MSSQLSERVER\MSSQL\DATA\Managerment_SellProduct.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Managerment_SellProduct_log', FILENAME = N'E:\MySQLServer\MSSQL14.MSSQLSERVER\MSSQL\DATA\Managerment_SellProduct_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Managerment_SellProduct] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Managerment_SellProduct].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Managerment_SellProduct] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET ARITHABORT OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Managerment_SellProduct] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Managerment_SellProduct] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Managerment_SellProduct] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Managerment_SellProduct] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Managerment_SellProduct] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Managerment_SellProduct] SET  MULTI_USER 
GO
ALTER DATABASE [Managerment_SellProduct] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Managerment_SellProduct] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Managerment_SellProduct] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Managerment_SellProduct] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Managerment_SellProduct] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Managerment_SellProduct] SET QUERY_STORE = OFF
GO
USE [Managerment_SellProduct]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Phone] [varchar](15) NULL,
	[Email] [nvarchar](35) NULL,
	[Address] [nvarchar](20) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderCustomerId] [int] NULL,
	[OrderDate] [datetime2](7) NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[DetailProductId] [int] NULL,
	[DetailOrderId] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Order_detail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[PermissionId] [int] IDENTITY(1,1) NOT NULL,
	[PermissionTitle] [nvarchar](20) NULL,
	[PermissionDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductTypeName] [nvarchar](50) NULL,
	[ProductPrice] [int] NULL,
	[ProductQuantity] [int] NULL,
	[ProductImage] [nvarchar](50) NULL,
	[ProductDescription] [nvarchar](50) NULL,
	[ProductProviderId] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderId] [int] IDENTITY(1,1) NOT NULL,
	[ProviderBrand] [nvarchar](20) NULL,
	[ProviderAddress] [nvarchar](20) NULL,
	[ProviderDescription] [nvarchar](20) NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/7/2019 12:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserPermissionId] [int] NULL,
	[UserName] [varchar](20) NULL,
	[UserPassword] [varchar](20) NULL,
	[UserCustomerId] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([OrderCustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_Order_detail_Order] FOREIGN KEY([DetailOrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_Order_detail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_Order_detail_Product] FOREIGN KEY([DetailProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_Order_detail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider] FOREIGN KEY([ProductProviderId])
REFERENCES [dbo].[Provider] ([ProviderId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Provider]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Customers] FOREIGN KEY([UserCustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Customers]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Permission1] FOREIGN KEY([UserPermissionId])
REFERENCES [dbo].[Permission] ([PermissionId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Permission1]
GO
USE [master]
GO
ALTER DATABASE [Managerment_SellProduct] SET  READ_WRITE 
GO
