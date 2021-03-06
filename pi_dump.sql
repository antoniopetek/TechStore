USE [master]
GO
/****** Object:  Database [18038_DB]    Script Date: 4.3.2019. 18:20:24 ******/
CREATE DATABASE [18038_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'18038_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.PISERVER\MSSQL\DATA\18038_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'18038_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.PISERVER\MSSQL\DATA\18038_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [18038_DB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [18038_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [18038_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [18038_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [18038_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [18038_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [18038_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [18038_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [18038_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [18038_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [18038_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [18038_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [18038_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [18038_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [18038_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [18038_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [18038_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [18038_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [18038_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [18038_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [18038_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [18038_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [18038_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [18038_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [18038_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [18038_DB] SET  MULTI_USER 
GO
ALTER DATABASE [18038_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [18038_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [18038_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [18038_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [18038_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [18038_DB] SET QUERY_STORE = OFF
GO
USE [18038_DB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [18038_DB]
GO
/****** Object:  User [18038_User]    Script Date: 4.3.2019. 18:20:24 ******/
CREATE USER [18038_User] FOR LOGIN [18038_User] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [18038_User]
GO
ALTER ROLE [db_datareader] ADD MEMBER [18038_User]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [18038_User]
GO
/****** Object:  Table [dbo].[Artikl]    Script Date: 4.3.2019. 18:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artikl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](100) NOT NULL,
	[Kratki_opis] [varchar](max) NULL,
	[Specifikacija] [varchar](max) NULL,
	[Cijena] [float] NOT NULL,
	[Vrsta_ID] [int] NOT NULL,
 CONSTRAINT [PK_Artikl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dokument]    Script Date: 4.3.2019. 18:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dokument](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Vrijeme_izdavanja] [timestamp] NOT NULL,
	[VrstaDokumenta_ID] [int] NOT NULL,
	[Vrijeme] [datetime] NULL,
 CONSTRAINT [PK_Dokument] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dostupnost]    Script Date: 4.3.2019. 18:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dostupnost](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Artikl_ID] [int] NOT NULL,
	[Poslovnica_ID] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
 CONSTRAINT [PK_Dostupnost] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kompatibilnost]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kompatibilnost](
	[Komponenta1] [int] NOT NULL,
	[Komponenta2] [int] NOT NULL,
	[Kompatibilni] [bit] NOT NULL,
 CONSTRAINT [PK_Kompatibilnost] PRIMARY KEY CLUSTERED 
(
	[Komponenta1] ASC,
	[Komponenta2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poslovnica]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poslovnica](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](70) NOT NULL,
	[Drzava] [varchar](50) NOT NULL,
	[Grad] [varchar](50) NOT NULL,
	[Ulica] [varchar](75) NOT NULL,
	[Broj] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Poslovnica] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StanjeDokumenta]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StanjeDokumenta](
	[Dokument_ID] [int] NOT NULL,
	[VrstaStanja_ID] [int] NOT NULL,
	[Zaposlenik_ID] [int] NOT NULL,
	[Datum_promjene] [timestamp] NOT NULL,
	[Napomena] [text] NULL,
	[Vrijeme] [datetime] NULL,
 CONSTRAINT [PK_StanjeDokumenta] PRIMARY KEY CLUSTERED 
(
	[Dokument_ID] ASC,
	[VrstaStanja_ID] ASC,
	[Zaposlenik_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaDokumenta]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaDokumenta](
	[Artikl_ID] [int] NOT NULL,
	[Dokument_ID] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
 CONSTRAINT [PK_StavkaDokumenta] PRIMARY KEY CLUSTERED 
(
	[Artikl_ID] ASC,
	[Dokument_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipZaposlenika]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipZaposlenika](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipZaposlenika] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VrstaArtikla]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VrstaArtikla](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](75) NOT NULL,
 CONSTRAINT [PK_VrstaArtikla] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VrstaDokumenta]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VrstaDokumenta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_VrstaDokumenta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VrsteStanja]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VrsteStanja](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](75) NOT NULL,
 CONSTRAINT [PK_VrsteStanja] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaposlenik]    Script Date: 4.3.2019. 18:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaposlenik](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Korisnicko_ime] [varchar](25) NOT NULL,
	[Lozinka] [varchar](25) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Kontakt] [varchar](30) NOT NULL,
	[Drzava] [varchar](50) NOT NULL,
	[Grad] [varchar](50) NOT NULL,
	[Ulica] [varchar](75) NOT NULL,
	[Broj] [varchar](5) NOT NULL,
	[Tip_ID] [int] NOT NULL,
	[Poslovnica_ID] [int] NOT NULL,
 CONSTRAINT [PK_Zaposlenik] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Artikl] ON 

INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (1, N'Inkjet printer CANON iX6850', N'Printer za kucnu upotrebu', N'Tintni fotopisac', 1699.22, 1)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (2, N'Miš AQPROX LITE', N'Opticki miš', N'USB prikljucak', 35, 1)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (3, N'Tipkovnica ASUS CERBERUS MKII', N'Gaming tipkovnica', N'USB prikljucak', 415.86, 1)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (4, N'ASROCK 970 PRO3 R2.0', N'Maticna ploca sa AM3 i AM3+ socketima', N'AM3+,DDR3,SATA III,PCI Express 3.0,Visina:13.4,Duljina:25.4,Širina:6,ATX', 501.02, 2)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (5, N'ASROCK Fatal1ty Z270 Gaming K4', N'Gaming maticna ploca koja podržava tri monitora', N'1151,DDR4,PCI Express 3.0,ATX,Visina:30.5,Duljina:24.4,Širina:9.6, SATA III,', 1153.95, 2)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (6, N'NULASUS PRIME H270-PROL', N'Maticna ploca proizvodaca ASUS', N'1151,DDR4,Visina:30.5,Duljina:22.6,Širina:8.3,', 920, 2)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (7, N'ASUS AMD Radeon EX-RX570-O4G', N'Kartica s kapacitetom memorije od 4GB', N'GDDR5,Visina:24,Duljina:13,Širina:4, PCI Express 3.0', 2653.04, 3)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (8, N'ASUS AMD Radeon R5230-SL-2GD3-L', N'Kartica s kapacitetom memorije od 2GB', N'PCI Express 2.1,Visina:2,Duljina:6.9,Širina:16,7', 434.7, 3)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (9, N'ASUS nVidia GeForce CERBERUS-GTX1050Ti-A4G', N'Kartica s kapacitetom memorije od 4GB', N'PCI Express 3.0,Visina:3.8,Duljina:20.3,Širina:11.5', 1549, 3)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (10, N'ASUS nVidia GeForce DUAL-GTX1060-O3G', N'Kartica s kapacitetom memorije od 3GB', N'PCI Express 3.0,Video Memory:GDDR5 3GB,CUDA Core:1152,Memory Clock:8008 MHz,Power Connectors:6-pin,Širina:24.2,Duljina:13,Visina:4.3', 2071.55, 3)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (11, N'ASUS nVidia GeForce GT730-2GD5-BRK', N'Kartica s kapacitetom memorije od 2GB', N'PCI Express 2.0,Video Memory:GDDR5 2GB,Engine Clock:902 MHz,CUDA Core:384,Memory Clock:5010 MHz,Visina:2.6,Duljina:15,Širina:6.9', 699.66, 3)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (12, N'AMD A10 9700', N'Cetverojezgreni procesor s radnom frekvencijom od 3500 MHz', N'AM4,
Base Clock
:3.5GHz
,CPU Cores
:4,
Max Boost Clock:3.8GHz
,', 638, 4)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (14, N'AMD Athlon X4 840', N'Cetverojezgreni procesor s radnom frekvencijom od 3100MHz', N'FM2+,Base Clock:3.1GHz,
Max Boost Clock:3.8GHz, CPU Cores
:4,', 323.33, 4)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (15, N'AMD Athlon X4 950', N'Cetverojezgreni procesor s radnom frekvencijom od 3500MHz', N'AM4,CPU Cores
:4,
Base Clock
:3.5GHz
,
Max Boost Clock:
3.8GHz
,', 427.93, 4)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (17, N'INTEL Core i3 8100', N'Cetverojezgreni procesor s radnom frekvencijom od 3600MHz', N'FCLGA1151,CPU Cores
:4,Base Clock:3.6GHz,', 855, 4)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (18, N'INTEL Celeron G4920', N'Cetverojezgreni proceosr s radnom frekvencijom od 3200MHz', N'1151', 438.62, 4)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (19, N'Memorija A-DATA 2 GB', N'Interna memorija: 2GB', N'DDR2', 206.17, 5)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (21, N'Memorija A-DATA 4 GB', N'Interna memorija: 4GB', N'DDR3', 263.41, 5)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (22, N'Memorija A-DATA 8 GB (2x4 GB)', N'Interna memorija: 8GB', N'DDR3', 720.83, 5)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (26, N'Memorija CORSAIR 4 GB', N'Radna frekvencija: 1066 MHz', N'DDR3', 309.62, 5)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (27, N'Memorija CORSAIR 8 GB', N'Radna frekvencija: 1600 MHz', N'DDR3', 578.03, 5)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (28, N'KINGSTON UV500 120GB', N'SSD disk od 120GB', N'SATA III,M.2', 381.5, 6)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (29, N'INTEL 600p Series 128GB', N'SSD disk od 128GB', N'PCI-Express,M.2', 499.99, 6)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (30, N'SK HYNIX SL308 250GB', N'SSD disk od 250GB', N'SATA III', 649.99, 6)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (31, N'MICRON 1100 256GB', N'SSD disk od 256GB', N'SATA III', 691.88, 6)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (32, N'CRUCIAL MX500 500GB', N'SSD disk od 500GB', N'SATA III', 999.61, 6)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (33, N'HITACHI Travelstar Z5K500', N'Tvrdi disk od 500GB', N'SATA III', 345.02, 7)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (34, N'SEAGATE BarraCuda', N'Tvrdi disk od 1TB', N'SATA III', 399.99, 7)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (35, N'HITACHI Travelstar 7K1000', N'Tvrdi disk od 1TB', N'SATA III', 528.54, 7)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (36, N'SEAGATE IronWolf', N'Tvrdi disk od 1TB', N'SATA III', 553.02, 7)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (37, N'WESTERN DIGITAL Black', N'Tvrdi disk od 512GB', N'SATA III', 442.08, 7)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (38, N'NaviaTec 400W', N'Napajanje s izlaznom snagom od 400W', N'120mm,6 pin, 4 pin,SATA III.', 127.94, 8)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (39, N'Inter-Tech SL500', N'Napajanje s izlaznom snagom od 500W', N'135mm,6 pin, 4 pin,SATA III,Širina:15, Duljina:14,Visina:8.6,500 W,', 169.09, 8)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (41, N' XILENCE Performance C XP400', N'Napajanje s izlaznom snagom od 500W', N'135mm,6 pin, 4 pin,SATA III,Širina:15,Duljina:14,Visina:8.6,400W,', 268.87, 8)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (42, N'CORSAIR VS450', N'Napajanje s izlaznom snagom od 450W', N'140mm,6 pin, 4 pin,SATA III,Širina:15,Duljina:14,Visina:8.6,450W,', 295.31, 8)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (43, N'XILENCE A200', N'Hladnjak za procesor', N'AM4,FM2+,AM3,AM2,AM2+,940+', 64.99, 9)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (44, N'THERMALTAKE Riing 12 LED Blue', N'Hladnjak za procesor', N'AM2,AM2+,AM3,AM4,FM2+,1151', 75.63, 9)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (45, N'THERMALTAKE Gravity i2', N'Hladnjak za procesor', N'AM4,1150,1151', 84.01, 9)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (46, N'ENERMAX T.B. Apollish ', N'Hladnjak za procesor', N'1155,1156,1151', 99, 9)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (48, N'ASUS XONAR DGX', N'Kanalna gaming audio kartica', N'PCI Express 2.0', 265.61, 10)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (50, N'ASUS XONAR AE', N'Kanalna audio kartica', N'PCI Express 3.0', 535.01, 10)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (51, N'ASUS XONAR Essence STX II', N'Kanalna gaming audio kartica', N'PCI Express 3.0', 999.99, 10)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (52, N'ASUS XONAR Essence STX III', N'Kanalna gaming audio kartica', N'PCI Express 3.0', 1199.99, 10)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (53, N'NAVIATEC 603', N'Naviatec NVT-603 kucište bez napajanja', N'2 x USB 2.0', 103.36, 11)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (55, N'MS Industrial PHANTOM', N'MS PHANTOM midi tower kucište', N'2 x USB 2.0,Visina:34.3,Duljina:22.3,Širina:34.2', 136.56, 11)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (56, N'AKYGA AKY313BR', N'AKYGA midi tower kucište', N'2 x USB 2.0,USB 3.0,Visina:33.3,Duljina:32.3,Širina:54.2', 174.32, 11)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (57, N'MS Industrial CYCLOPS III', N'MS Industrial gaming kucište', N'2 x USB 2.0,USB 3.0, Visina:45.2, Širina:19.2, Duljina:42.2', 222.81, 11)
INSERT [dbo].[Artikl] ([ID], [Naziv], [Kratki_opis], [Specifikacija], [Cijena], [Vrsta_ID]) VALUES (72, N'AMD FX8350', N'aaa', N'sssss', 687.32, 1)
SET IDENTITY_INSERT [dbo].[Artikl] OFF
SET IDENTITY_INSERT [dbo].[Dokument] ON 

INSERT [dbo].[Dokument] ([ID], [VrstaDokumenta_ID], [Vrijeme]) VALUES (31, 1, CAST(N'2018-06-23T16:18:39.030' AS DateTime))
INSERT [dbo].[Dokument] ([ID], [VrstaDokumenta_ID], [Vrijeme]) VALUES (32, 1, CAST(N'2018-06-23T23:01:43.680' AS DateTime))
INSERT [dbo].[Dokument] ([ID], [VrstaDokumenta_ID], [Vrijeme]) VALUES (33, 1, CAST(N'2018-06-24T17:36:53.537' AS DateTime))
INSERT [dbo].[Dokument] ([ID], [VrstaDokumenta_ID], [Vrijeme]) VALUES (34, 1, CAST(N'2018-06-24T19:41:52.993' AS DateTime))
INSERT [dbo].[Dokument] ([ID], [VrstaDokumenta_ID], [Vrijeme]) VALUES (35, 1, CAST(N'2018-06-25T12:38:30.470' AS DateTime))
INSERT [dbo].[Dokument] ([ID], [VrstaDokumenta_ID], [Vrijeme]) VALUES (36, 1, CAST(N'2018-06-25T12:38:45.430' AS DateTime))
SET IDENTITY_INSERT [dbo].[Dokument] OFF
SET IDENTITY_INSERT [dbo].[Dostupnost] ON 

INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (1, 1, 1, 29)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (2, 1, 2, 6)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (3, 1, 3, 9)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (4, 2, 1, 23)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (5, 2, 2, 11)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (6, 2, 3, 4)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (7, 3, 1, 10)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (8, 3, 2, 7)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (9, 3, 3, 6)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (10, 1, 4, 3)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (11, 2, 4, 5)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (12, 3, 4, 0)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (13, 4, 1, 20)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (14, 4, 2, 8)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (15, 4, 3, 8)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (16, 4, 4, 3)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (17, 5, 1, 15)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (18, 5, 2, 7)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (19, 5, 3, 9)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (20, 5, 4, 12)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (21, 6, 1, 13)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (22, 6, 2, 17)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (23, 6, 3, 3)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (24, 6, 4, 6)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (25, 7, 1, 12)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (26, 7, 2, 9)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (27, 7, 3, 1)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (28, 7, 4, 11)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (29, 8, 2, 4)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (32, 10, 1, 3)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (33, 29, 1, 5)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (34, 45, 1, 3)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (35, 32, 1, 7)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (36, 34, 1, 3)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (37, 28, 1, 7)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (38, 29, 2, 10)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (39, 8, 1, 5)
INSERT [dbo].[Dostupnost] ([ID], [Artikl_ID], [Poslovnica_ID], [Kolicina]) VALUES (40, 9, 1, 1)
SET IDENTITY_INSERT [dbo].[Dostupnost] OFF
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 2, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 3, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 4, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 5, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 6, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 7, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 8, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 9, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 10, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 11, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 14, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 17, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 18, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (1, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 7, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 8, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 9, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 10, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 11, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 14, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 17, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 18, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 22, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 31, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 36, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (4, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 7, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 8, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 9, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 10, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 11, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 14, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 17, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 18, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 19, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 21, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 22, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 28, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 29, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 33, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 48, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 53, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (5, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 7, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 8, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 9, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 10, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 11, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 14, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 17, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 18, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 19, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 29, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 48, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (6, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 14, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 17, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 18, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 19, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 28, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 29, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 33, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 43, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 48, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 51, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 53, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (7, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 12, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 14, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 17, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 18, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 22, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 27, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 31, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 36, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (8, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 14, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 17, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 18, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 19, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 22, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 48, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (9, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 14, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 17, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 18, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 19, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 22, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 28, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 41, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 43, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 48, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (10, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 14, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 15, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 17, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 26, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 27, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 36, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 45, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (11, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (12, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 22, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 27, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 31, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 36, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 44, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (14, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 19, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 22, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 28, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (15, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 19, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 21, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 28, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 33, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 44, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (17, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 21, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 44, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 53, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (18, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 31, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (19, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 32, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (21, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 28, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 33, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 43, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (22, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 50, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (26, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 28, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (27, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 36, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (28, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 36, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 42, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (29, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (30, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 37, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (31, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 33, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 43, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (32, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (33, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 46, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (34, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 43, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (35, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 38, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 43, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (36, 57, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (37, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (38, 57, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (39, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (41, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 48, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 53, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (42, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 52, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (43, 57, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (44, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (45, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 48, 0)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (46, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (48, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (48, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (48, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (48, 57, 1)
GO
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (50, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (50, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (50, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (50, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (51, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (51, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (51, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (51, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (52, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (52, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (52, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (52, 57, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 1, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 2, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 3, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 4, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 5, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 6, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 7, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 8, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 9, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 10, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 11, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 12, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 14, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 15, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 17, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 18, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 19, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 21, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 22, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 26, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 27, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 28, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 29, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 30, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 31, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 32, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 33, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 34, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 35, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 36, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 37, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 38, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 39, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 41, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 42, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 43, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 44, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 45, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 46, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 48, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 50, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 51, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 52, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 53, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 55, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 56, 1)
INSERT [dbo].[Kompatibilnost] ([Komponenta1], [Komponenta2], [Kompatibilni]) VALUES (72, 57, 1)
SET IDENTITY_INSERT [dbo].[Poslovnica] ON 

INSERT [dbo].[Poslovnica] ([ID], [Naziv], [Drzava], [Grad], [Ulica], [Broj]) VALUES (1, N'Poslovnica 1', N'Hrvatska', N'Varaždin', N'Zagrebacka ulica', N'1')
INSERT [dbo].[Poslovnica] ([ID], [Naziv], [Drzava], [Grad], [Ulica], [Broj]) VALUES (2, N'Poslovnica 2', N'Hrvatska', N'Zagreb', N'Ilica', N'45')
INSERT [dbo].[Poslovnica] ([ID], [Naziv], [Drzava], [Grad], [Ulica], [Broj]) VALUES (3, N'Privremena poslovnica', N'Hrvatska', N'Split', N'Ulica Antuna Branka Šimica', N'11')
INSERT [dbo].[Poslovnica] ([ID], [Naziv], [Drzava], [Grad], [Ulica], [Broj]) VALUES (4, N'Poslovnica', N'Hrvatska', N'Koprivnica', N'Marinka Ilica', N'43b')
INSERT [dbo].[Poslovnica] ([ID], [Naziv], [Drzava], [Grad], [Ulica], [Broj]) VALUES (5, N'Poslovnica 5', N'Hrvatska', N'Križevci', N'Ulica Jorgovana', N'22b')
INSERT [dbo].[Poslovnica] ([ID], [Naziv], [Drzava], [Grad], [Ulica], [Broj]) VALUES (6, N'Glavna poslovnica', N'Hrvatska', N'Osijek', N'Jelkovecka', N'bb')
INSERT [dbo].[Poslovnica] ([ID], [Naziv], [Drzava], [Grad], [Ulica], [Broj]) VALUES (7, N'Poslovnica', N'6', N'Zabok', N'Ulica Vladimira Nazora', N'1')
SET IDENTITY_INSERT [dbo].[Poslovnica] OFF
INSERT [dbo].[StanjeDokumenta] ([Dokument_ID], [VrstaStanja_ID], [Zaposlenik_ID], [Napomena], [Vrijeme]) VALUES (31, 4, 3, N'Narucen je proizvod za poslovnicu Poslovnica 1.', CAST(N'2018-06-23T16:18:39.333' AS DateTime))
INSERT [dbo].[StanjeDokumenta] ([Dokument_ID], [VrstaStanja_ID], [Zaposlenik_ID], [Napomena], [Vrijeme]) VALUES (32, 4, 3, N'Narucen je proizvod za poslovnicu Poslovnica 1.', CAST(N'2018-06-23T23:01:43.917' AS DateTime))
INSERT [dbo].[StanjeDokumenta] ([Dokument_ID], [VrstaStanja_ID], [Zaposlenik_ID], [Napomena], [Vrijeme]) VALUES (33, 4, 3, N'Narucen je proizvod za poslovnicu Poslovnica 1.', CAST(N'2018-06-24T17:36:53.840' AS DateTime))
INSERT [dbo].[StanjeDokumenta] ([Dokument_ID], [VrstaStanja_ID], [Zaposlenik_ID], [Napomena], [Vrijeme]) VALUES (34, 4, 3, N'Narucen je proizvod za poslovnicu Poslovnica 1.', CAST(N'2018-06-24T19:41:53.253' AS DateTime))
INSERT [dbo].[StanjeDokumenta] ([Dokument_ID], [VrstaStanja_ID], [Zaposlenik_ID], [Napomena], [Vrijeme]) VALUES (35, 4, 3, N'Narucen je proizvod za poslovnicu Poslovnica 1.', CAST(N'2018-06-25T12:38:30.900' AS DateTime))
INSERT [dbo].[StanjeDokumenta] ([Dokument_ID], [VrstaStanja_ID], [Zaposlenik_ID], [Napomena], [Vrijeme]) VALUES (36, 4, 3, N'Narucen je proizvod za poslovnicu Poslovnica 1.', CAST(N'2018-06-25T12:38:45.840' AS DateTime))
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (1, 31, 3)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (1, 33, 3)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (2, 33, 3)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (3, 35, 4)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (3, 36, 1)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (4, 31, 4)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (4, 34, 6)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (5, 32, 9)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (6, 33, 8)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (7, 32, 5)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (8, 31, 5)
INSERT [dbo].[StavkaDokumenta] ([Artikl_ID], [Dokument_ID], [Kolicina]) VALUES (9, 34, 1)
SET IDENTITY_INSERT [dbo].[TipZaposlenika] ON 

INSERT [dbo].[TipZaposlenika] ([ID], [Naziv]) VALUES (1, N'Administrator')
INSERT [dbo].[TipZaposlenika] ([ID], [Naziv]) VALUES (2, N'Korisnik')
SET IDENTITY_INSERT [dbo].[TipZaposlenika] OFF
SET IDENTITY_INSERT [dbo].[VrstaArtikla] ON 

INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (1, N'Ostalo')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (2, N'Maticna ploca')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (3, N'Graficka kartica')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (4, N'Procesor')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (5, N'RAM memorija')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (6, N'SSD')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (7, N'HDD')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (8, N'Napajanje')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (9, N'Hladnjak')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (10, N'Zvucna kartica')
INSERT [dbo].[VrstaArtikla] ([ID], [Naziv]) VALUES (11, N'Kucište')
SET IDENTITY_INSERT [dbo].[VrstaArtikla] OFF
SET IDENTITY_INSERT [dbo].[VrstaDokumenta] ON 

INSERT [dbo].[VrstaDokumenta] ([ID], [Naziv]) VALUES (1, N'Narudžba')
INSERT [dbo].[VrstaDokumenta] ([ID], [Naziv]) VALUES (2, N'Racun')
SET IDENTITY_INSERT [dbo].[VrstaDokumenta] OFF
SET IDENTITY_INSERT [dbo].[VrsteStanja] ON 

INSERT [dbo].[VrsteStanja] ([ID], [Naziv]) VALUES (1, N'Placeno')
INSERT [dbo].[VrsteStanja] ([ID], [Naziv]) VALUES (2, N'Izdano')
INSERT [dbo].[VrsteStanja] ([ID], [Naziv]) VALUES (3, N'Draft')
INSERT [dbo].[VrsteStanja] ([ID], [Naziv]) VALUES (4, N'Naruceno')
SET IDENTITY_INSERT [dbo].[VrsteStanja] OFF
SET IDENTITY_INSERT [dbo].[Zaposlenik] ON 

INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (1, N'Martin', N'Posavec', N'mposavec', N'martin123', N'mposavec@foi.hr', N'0912583218', N'Hrvatska', N'Oroslavje', N'Selska', N'7', 2, 1)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (2, N'Josip', N'Marijanovic', N'jmarijano', N'josip321', N'jmarijano@foi.hr', N'0991234567', N'Hrvatska', N'Oroslavje', N'Antuna Mihanovica', N'33', 1, 1)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (3, N'Antonio', N'Petek', N'apetek', N'password', N'apetek@foi.hr', N'0997486067', N'Hrvatska', N'Klanjec', N'Antuna Augustincica', N'5', 1, 1)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (4, N'Hrvoje', N'Šoštaric', N'hsostaric', N'sifra888', N'hsostaric@foi.hr', N'0925884523', N'Hrvatska', N'Bedekovcina', N'Ivana Holjeca', N'22', 1, 2)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (6, N'Antonio', N'Gazdek', N'agazdek', N'gazda010', N'agazdek@foi.hr', N'0925874119', N'Hrvatska', N'Zagreb', N'Trenkova ulica', N'22', 2, 2)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (7, N'Ivan', N'Ivic', N'ivanivic', N'123456', N'iivic@foi.hr', N'0911234567', N'Hrvatska', N'Split', N'Splitska 1', N'2', 2, 3)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (8, N'Petar', N'Petric', N'petarpetric', N'lozinka1234', N'petarpetric@foi.hr', N'556123', N'Hrvatska', N'Koprivnica', N'Ulica Matjaža Keka', N'55', 2, 2)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (9, N'Kristijan', N'Cvitak', N'kcvitak', N'sifra123', N'kcvitak@foi.hr', N'0911315647', N'Hrvatsk', N'Karlovac', N'Novaki', N'2a', 2, 3)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (10, N'Matija', N'Pianec', N'mpianec', N'12345678', N'mpianec@foi.hr', N'091123465', N'Hrvatska', N'Koprivnica', N'Trešnjevacka', N'12a', 2, 1)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (11, N'Jelena', N'Zajec', N'jzajec', N'jelena', N'jzajec@gmail.com', N'556213', N'Hrvatska', N'Klanjec', N'Antuna Augustincica', N'20b', 1, 4)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (12, N'Ivor', N'Gradiski', N'igradiski', N'000000', N'ivorgradiski@hotmail.com', N'091555878', N'Hrvatska', N'Oroslavje', N'Jelkovecka', N'55', 1, 5)
INSERT [dbo].[Zaposlenik] ([ID], [Ime], [Prezime], [Korisnicko_ime], [Lozinka], [Email], [Kontakt], [Drzava], [Grad], [Ulica], [Broj], [Tip_ID], [Poslovnica_ID]) VALUES (13, N'Ivana', N'Lunko', N'lunkoivana', N'543210', N'lunkoivana@foi.hr', N'0955556874', N'Hrvatska', N'Klanjec', N'Rakovec', N'7a', 1, 6)
SET IDENTITY_INSERT [dbo].[Zaposlenik] OFF
ALTER TABLE [dbo].[Dokument] ADD  CONSTRAINT [DefaultTime_Dokument]  DEFAULT (getdate()) FOR [Vrijeme]
GO
ALTER TABLE [dbo].[StanjeDokumenta] ADD  CONSTRAINT [defaultVrijeme_StanjeDokumenta]  DEFAULT (getdate()) FOR [Vrijeme]
GO
ALTER TABLE [dbo].[Artikl]  WITH CHECK ADD  CONSTRAINT [FK_Artikl_VrstaArtikla] FOREIGN KEY([Vrsta_ID])
REFERENCES [dbo].[VrstaArtikla] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Artikl] CHECK CONSTRAINT [FK_Artikl_VrstaArtikla]
GO
ALTER TABLE [dbo].[Dokument]  WITH CHECK ADD  CONSTRAINT [FK_Dokument_VrstaDokumenta] FOREIGN KEY([VrstaDokumenta_ID])
REFERENCES [dbo].[VrstaDokumenta] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dokument] CHECK CONSTRAINT [FK_Dokument_VrstaDokumenta]
GO
ALTER TABLE [dbo].[Dostupnost]  WITH CHECK ADD  CONSTRAINT [FK_Dostupnost_Artikl] FOREIGN KEY([Artikl_ID])
REFERENCES [dbo].[Artikl] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dostupnost] CHECK CONSTRAINT [FK_Dostupnost_Artikl]
GO
ALTER TABLE [dbo].[Dostupnost]  WITH CHECK ADD  CONSTRAINT [FK_Dostupnost_Poslovnica] FOREIGN KEY([Poslovnica_ID])
REFERENCES [dbo].[Poslovnica] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dostupnost] CHECK CONSTRAINT [FK_Dostupnost_Poslovnica]
GO
ALTER TABLE [dbo].[Kompatibilnost]  WITH CHECK ADD  CONSTRAINT [FK_Kompatibilnost_Artikl] FOREIGN KEY([Komponenta1])
REFERENCES [dbo].[Artikl] ([ID])
GO
ALTER TABLE [dbo].[Kompatibilnost] CHECK CONSTRAINT [FK_Kompatibilnost_Artikl]
GO
ALTER TABLE [dbo].[Kompatibilnost]  WITH CHECK ADD  CONSTRAINT [FK_Kompatibilnost_Artikl1] FOREIGN KEY([Komponenta2])
REFERENCES [dbo].[Artikl] ([ID])
GO
ALTER TABLE [dbo].[Kompatibilnost] CHECK CONSTRAINT [FK_Kompatibilnost_Artikl1]
GO
ALTER TABLE [dbo].[StanjeDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StanjeDokumenta_Dokument] FOREIGN KEY([Dokument_ID])
REFERENCES [dbo].[Dokument] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StanjeDokumenta] CHECK CONSTRAINT [FK_StanjeDokumenta_Dokument]
GO
ALTER TABLE [dbo].[StanjeDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StanjeDokumenta_VrsteStanja] FOREIGN KEY([VrstaStanja_ID])
REFERENCES [dbo].[VrsteStanja] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StanjeDokumenta] CHECK CONSTRAINT [FK_StanjeDokumenta_VrsteStanja]
GO
ALTER TABLE [dbo].[StanjeDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StanjeDokumenta_Zaposlenik] FOREIGN KEY([Zaposlenik_ID])
REFERENCES [dbo].[Zaposlenik] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StanjeDokumenta] CHECK CONSTRAINT [FK_StanjeDokumenta_Zaposlenik]
GO
ALTER TABLE [dbo].[StavkaDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StavkaDokumenta_Artikl] FOREIGN KEY([Artikl_ID])
REFERENCES [dbo].[Artikl] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaDokumenta] CHECK CONSTRAINT [FK_StavkaDokumenta_Artikl]
GO
ALTER TABLE [dbo].[StavkaDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StavkaDokumenta_Dokument] FOREIGN KEY([Dokument_ID])
REFERENCES [dbo].[Dokument] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaDokumenta] CHECK CONSTRAINT [FK_StavkaDokumenta_Dokument]
GO
ALTER TABLE [dbo].[Zaposlenik]  WITH CHECK ADD  CONSTRAINT [FK_Zaposlenik_Poslovnica] FOREIGN KEY([Poslovnica_ID])
REFERENCES [dbo].[Poslovnica] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Zaposlenik] CHECK CONSTRAINT [FK_Zaposlenik_Poslovnica]
GO
ALTER TABLE [dbo].[Zaposlenik]  WITH CHECK ADD  CONSTRAINT [FK_Zaposlenik_TipZaposlenika] FOREIGN KEY([Tip_ID])
REFERENCES [dbo].[TipZaposlenika] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Zaposlenik] CHECK CONSTRAINT [FK_Zaposlenik_TipZaposlenika]
GO
USE [master]
GO
ALTER DATABASE [18038_DB] SET  READ_WRITE 
GO
