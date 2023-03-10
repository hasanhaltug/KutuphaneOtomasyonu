USE [master]
GO
/****** Object:  Database [Kutuphane]    Script Date: 4.12.2022 22:20:35 ******/
CREATE DATABASE [Kutuphane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kutuphane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Kutuphane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kutuphane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Kutuphane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Kutuphane] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kutuphane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kutuphane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kutuphane] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kutuphane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kutuphane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kutuphane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kutuphane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kutuphane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kutuphane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kutuphane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kutuphane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kutuphane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kutuphane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kutuphane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kutuphane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kutuphane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kutuphane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kutuphane] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kutuphane] SET  MULTI_USER 
GO
ALTER DATABASE [Kutuphane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kutuphane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kutuphane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kutuphane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kutuphane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kutuphane] SET QUERY_STORE = OFF
GO
USE [Kutuphane]
GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 4.12.2022 22:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KitapAdi] [nvarchar](50) NOT NULL,
	[Yazar] [nvarchar](50) NOT NULL,
	[Tur] [nvarchar](50) NULL,
	[Sayfa] [int] NULL,
	[Uygunluk] [bit] NOT NULL,
 CONSTRAINT [PK_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 4.12.2022 22:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Meslek] [nvarchar](50) NULL,
	[CezaPuanı] [int] NULL,
 CONSTRAINT [PK_Uyeler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Takip]    Script Date: 4.12.2022 22:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Takip](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UyeID] [int] NOT NULL,
	[KitapID] [int] NOT NULL,
	[AlımTarihi] [datetime2](7) NOT NULL,
	[TeslimTarihi] [datetime] NULL,
	[GeldigiTarih] [datetime] NULL,
 CONSTRAINT [PK_Takip] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewKutuphane]    Script Date: 4.12.2022 22:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewKutuphane]
AS
SELECT        dbo.Kitaplar.ID, dbo.Uyeler.ID AS Expr1, dbo.Takip.UyeID, dbo.Takip.KitapID, dbo.Takip.AlımTarihi
FROM            dbo.Kitaplar INNER JOIN
                         dbo.Takip ON dbo.Kitaplar.ID = dbo.Takip.KitapID INNER JOIN
                         dbo.Uyeler ON dbo.Takip.UyeID = dbo.Uyeler.ID
GO
SET IDENTITY_INSERT [dbo].[Kitaplar] ON 

INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (1, N'Altın Işık', N'Ziya Gökalp', N'100 Temel Eser', 63, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (2, N'Define Adası', N'Robert L. Stevenson', N'100 Temel Eser', 120, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (3, N'İnsan Ne İle Yaşar', N'Tolstoy', N'100 Temel Eser', 80, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (4, N'Kaplanın Sırtında - İstibdat ve Hürriyet', N'Zülfü Livaneli', N'Roman', 324, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (5, N'Hayvan Çiftliği', N'George Orwell', N'Roman', 152, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (6, N'Şeker Portakalı', N'Jose Mauro De Vasconcelos', N'Roman', 200, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (7, N'Henüz Vakit Varken Gülüm', N'Nazım Hikmet', N'Şiir', 112, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (8, N'Gılgamış Destanı', N'Sait Maden', N'Destan', 176, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (9, N'Küçük Yuvarlak Taşlar', N'Melisa Kesmez', N'Deneme/Yazın', 84, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (10, N'Sırça Köşk', N'Sabahattin Ali', N'Türk Öykü', 74, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (11, N'Kozmos', N'Carl Sagan', N'Astronomi', 263, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (12, N'Sokrates''in Savunması', N'Platon', N'Felsefe Bilimi', 98, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (13, N'TYT Paragraf Soru Bankası', N'Kolektif', N'Sınav Kitapları', 362, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (14, N'Satranç', N'Stefan Zweig', N'Roman', 72, 1)
INSERT [dbo].[Kitaplar] ([ID], [KitapAdi], [Yazar], [Tur], [Sayfa], [Uygunluk]) VALUES (15, N'Yaban', N'Yakup Kadri Karaosmanoğlu', N'Türk Klasik', 214, 1)
SET IDENTITY_INSERT [dbo].[Kitaplar] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Kitaplar"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 173
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Takip"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 172
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Uyeler"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 158
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewKutuphane'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewKutuphane'
GO
USE [master]
GO
ALTER DATABASE [Kutuphane] SET  READ_WRITE 
GO
