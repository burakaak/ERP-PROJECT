USE [FabrikaDb]
GO
/****** Object:  Table [dbo].[AdminTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici] [nvarchar](10) NULL,
	[Sifre] [nvarchar](10) NULL,
 CONSTRAINT [PK_AdminTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CagriDetayTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CagriDetayTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cagri] [int] NULL,
	[Aciklama] [nvarchar](250) NULL,
	[Tarih] [date] NULL,
	[Saat] [char](5) NULL,
 CONSTRAINT [PK_CagriDetayTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CagriTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CagriTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Musteri] [int] NULL,
	[Konu] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](max) NULL,
	[Durum] [bit] NULL,
	[Tarih] [date] NULL,
	[CagriPersonel] [int] NULL,
 CONSTRAINT [PK_CagriTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartmanTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmanTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmanId] [int] NULL,
	[DepartmanAdi] [nvarchar](50) NULL,
	[Sorumlu] [nvarchar](50) NULL,
	[PersonelSayisi] [int] NULL,
 CONSTRAINT [PK_DepartmanTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GorevDetayTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GorevDetayTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Gorev] [int] NULL,
	[Aciklama] [nvarchar](500) NULL,
	[Tarih] [date] NULL,
	[Saat] [char](5) NULL,
 CONSTRAINT [PK_GorevDetayTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GorevTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GorevTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GorevVeren] [int] NULL,
	[GorevAlan] [int] NULL,
	[Aciklama] [nvarchar](500) NULL,
	[Durum] [bit] NULL,
	[Tarih] [date] NULL,
 CONSTRAINT [PK_GorevTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MesajlarTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MesajlarTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Gonderen] [int] NULL,
	[Alici] [int] NULL,
	[Konu] [nvarchar](50) NULL,
	[Mesaj] [nvarchar](max) NULL,
	[Tarih] [date] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_MesajlarTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirmaAdi] [nvarchar](50) NULL,
	[Yetkili] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[Sifre] [nvarchar](20) NULL,
	[Sektor] [nvarchar](50) NULL,
	[il] [nvarchar](50) NULL,
	[Gorsel] [nvarchar](200) NULL,
 CONSTRAINT [PK_MusteriTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelBilgileriTb]    Script Date: 9.01.2024 20:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelBilgileriTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[SoyAd] [nvarchar](50) NULL,
	[Tc] [nvarchar](11) NULL,
	[Pozisyon] [nvarchar](50) NULL,
	[Adres] [nvarchar](100) NULL,
	[Departman] [nvarchar](50) NULL,
	[DogumTarihi] [date] NULL,
	[Telefon] [nvarchar](15) NULL,
	[Mail] [nvarchar](50) NULL,
	[Yonetici] [nvarchar](50) NULL,
	[Ucret] [int] NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](10) NULL,
	[Durum] [bit] NULL,
	[Rol] [char](1) NULL,
 CONSTRAINT [PK_PersonelBilgileriTb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminTb] ON 

INSERT [dbo].[AdminTb] ([Id], [Kullanici], [Sifre]) VALUES (1, N'Admin', N'admin')
INSERT [dbo].[AdminTb] ([Id], [Kullanici], [Sifre]) VALUES (2, N'Admin2', N'admin2')
SET IDENTITY_INSERT [dbo].[AdminTb] OFF
GO
SET IDENTITY_INSERT [dbo].[CagriDetayTb] ON 

INSERT [dbo].[CagriDetayTb] ([Id], [Cagri], [Aciklama], [Tarih], [Saat]) VALUES (1, 1, N'Çağrı işleme alındı', CAST(N'2024-01-08' AS Date), N'04:47')
INSERT [dbo].[CagriDetayTb] ([Id], [Cagri], [Aciklama], [Tarih], [Saat]) VALUES (2, 2, N'Çağrı işleme alındı', CAST(N'2024-01-09' AS Date), N'19:01')
INSERT [dbo].[CagriDetayTb] ([Id], [Cagri], [Aciklama], [Tarih], [Saat]) VALUES (3, 3, N'Çağrı işleme alındı', CAST(N'2024-01-09' AS Date), N'19:01')
INSERT [dbo].[CagriDetayTb] ([Id], [Cagri], [Aciklama], [Tarih], [Saat]) VALUES (4, 4, N'Çağrı işleme alındı', CAST(N'2024-01-09' AS Date), N'19:01')
SET IDENTITY_INSERT [dbo].[CagriDetayTb] OFF
GO
SET IDENTITY_INSERT [dbo].[CagriTb] ON 

INSERT [dbo].[CagriTb] ([Id], [Musteri], [Konu], [Aciklama], [Durum], [Tarih], [CagriPersonel]) VALUES (1, 1, N'Kamera Bağlantı', N'Merhaba, kamerada bağlantı problermleri yaşıyoruz.', 0, CAST(N'2024-01-08' AS Date), NULL)
INSERT [dbo].[CagriTb] ([Id], [Musteri], [Konu], [Aciklama], [Durum], [Tarih], [CagriPersonel]) VALUES (2, 1, N'Deneme', N'Test', 1, CAST(N'2024-01-09' AS Date), NULL)
INSERT [dbo].[CagriTb] ([Id], [Musteri], [Konu], [Aciklama], [Durum], [Tarih], [CagriPersonel]) VALUES (3, 1, N'Tel Örgü', N'Merhaba, tel örgülerle alakalı sorun yaşıyoruz', 1, CAST(N'2024-01-09' AS Date), NULL)
INSERT [dbo].[CagriTb] ([Id], [Musteri], [Konu], [Aciklama], [Durum], [Tarih], [CagriPersonel]) VALUES (4, 1, N'Güvenlik Ofis', N'Merhaba, Ofisle alakalı sorunlar yaşamaktayız', 1, CAST(N'2024-01-09' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[CagriTb] OFF
GO
SET IDENTITY_INSERT [dbo].[DepartmanTb] ON 

INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (2, 3, N'Bilgi İşlem', N'Ahmet Bey', 3)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (3, 4, N'Muhasebe', N'Büşra Hanım', 5)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (4, 6, N'Danışma', N'Yusuf Bey', 3)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (5, 7, N'İnsan Kaynakları', N'Elif Hanım', 7)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (6, 9, N'Müdür', N'İsmail Bey', 1)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (7, 8, N'Müdür Yardımcısı', N'Yağız Bey', 1)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (8, 10, N'Temizlik', N'Gamze Hanım', 8)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (9, 11, N'Ulaşım', N'Özkan Bey', 11)
INSERT [dbo].[DepartmanTb] ([Id], [DepartmanId], [DepartmanAdi], [Sorumlu], [PersonelSayisi]) VALUES (10, 1, N'Depo', N'Burak Bey', 12)
SET IDENTITY_INSERT [dbo].[DepartmanTb] OFF
GO
SET IDENTITY_INSERT [dbo].[GorevDetayTb] ON 

INSERT [dbo].[GorevDetayTb] ([Id], [Gorev], [Aciklama], [Tarih], [Saat]) VALUES (1, 1, N'Müşterilerin sorunlarını analiz edip müdahele edin', CAST(N'2024-01-09' AS Date), N'19:02')
INSERT [dbo].[GorevDetayTb] ([Id], [Gorev], [Aciklama], [Tarih], [Saat]) VALUES (2, 2, N'Müşterilerin sorunlarını analiz edip müdahele edin', CAST(N'2024-01-09' AS Date), N'19:02')
INSERT [dbo].[GorevDetayTb] ([Id], [Gorev], [Aciklama], [Tarih], [Saat]) VALUES (3, 3, N'Müşterilerin sorunlarını analiz edip müdahele edin', CAST(N'2024-01-09' AS Date), N'19:02')
INSERT [dbo].[GorevDetayTb] ([Id], [Gorev], [Aciklama], [Tarih], [Saat]) VALUES (4, 4, N'Müşterilerin sorunlarını analiz edip müdahele edin', CAST(N'2024-01-09' AS Date), N'19:02')
SET IDENTITY_INSERT [dbo].[GorevDetayTb] OFF
GO
SET IDENTITY_INSERT [dbo].[GorevTb] ON 

INSERT [dbo].[GorevTb] ([Id], [GorevVeren], [GorevAlan], [Aciklama], [Durum], [Tarih]) VALUES (1, 1, 6, N'Gerekli süreci başlatın', 0, CAST(N'2024-01-09' AS Date))
INSERT [dbo].[GorevTb] ([Id], [GorevVeren], [GorevAlan], [Aciklama], [Durum], [Tarih]) VALUES (2, 1, 6, N'Gerekli süreci başlatın', 1, CAST(N'2024-01-09' AS Date))
INSERT [dbo].[GorevTb] ([Id], [GorevVeren], [GorevAlan], [Aciklama], [Durum], [Tarih]) VALUES (3, 1, 6, N'Gerekli süreci başlatın', 1, CAST(N'2024-01-09' AS Date))
INSERT [dbo].[GorevTb] ([Id], [GorevVeren], [GorevAlan], [Aciklama], [Durum], [Tarih]) VALUES (4, 1, 6, N'Gerekli süreci başlatın', 1, CAST(N'2024-01-09' AS Date))
SET IDENTITY_INSERT [dbo].[GorevTb] OFF
GO
SET IDENTITY_INSERT [dbo].[MusteriTb] ON 

INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (1, N'Yılmaz Güvenlik', N'Mehmet Yılmaz', N'055555555', N'Pendik/Kurtköy', N'firma1@gmail.com', N'11', N'Güvenlik', N'İstanbul', N'https://seeklogo.com/images/O/ozel-guvenlik-logo-5BAD753016-seeklogo.com.png')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (2, N'Ahmet Turizm', N'Ahmet Yalçın', N'055555555', N'Pendik/Kurtköy', N'firma2@gmail.com', N'22', N'Turzim', N'Ankara', N'https://w7.pngwing.com/pngs/877/613/png-transparent-organization-planning-legal-name-advertising-travel-tourism-logo-miscellaneous-service-logo.png')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (3, N'Garanti Bankası', N'Ali Tanrıverdi', N'055555555', N'Pendik/Kurtköy', N'firma3@gmail.com', N'33', N'Bankacılık', N'İzmir', N'https://static.vecteezy.com/system/resources/thumbnails/010/750/691/small/bank-icon-on-white-background-bank-logo-flat-style-vector.jpg')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (4, N'Bodur Koleji', N'Osman Bodur', N'055555555', N'Pendik/Kurtköy', N'firma4@gmail.com', N'44', N'Eğitim', N'Kayseri', N'https://st4.depositphotos.com/14048606/20301/v/450/depositphotos_203010512-stock-illustration-book-learning-vector-icon.jpg')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (5, N'HD İskender', N'Burak Bodur', N'055555555', N'Pendik/Kurtköy', N'firma5@gmail.com', N'55', N'Gıda', N'Kastamonu', N'https://w7.pngwing.com/pngs/426/730/png-transparent-logo-yellow-font-recipe-logo-art-yellow.png')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (6, N'Lunapark', N'Erdem Pak', N'055555555', N'Pendik/Kurtköy', N'firma6@gmail.com', N'66', N'Eğlence', N'Düzce', N'https://seeklogo.com/images/A/Avea_eglence-logo-54EA73445A-seeklogo.com.gif')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (7, N'Bodur Grup', N'Büşra Bodur', N'055555555', N'Pendik/Kurtköy', N'firma7@gmail.com', N'77', N'İnşaat', N'Zonguldak', N'https://as1.ftcdn.net/v2/jpg/00/53/79/56/1000_F_53795695_0kOhb2jCR5N3AHwTubt7savZShs592pz.jpg')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (8, N'BB Organizasyon', N'Veli Bilge', N'055555555', N'Pendik/Kurtköy', N'firma8@gmail.com', N'88', N'Eğlence', N'Balıkesir', N'https://seeklogo.com/images/A/Avea_eglence-logo-54EA73445A-seeklogo.com.gif')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (9, N'Pak Temizlik', N'Erdem Pak', N'055555555', N'Pendik/Kurtköy', N'firma9@gmail.com', N'99', N'Temizlik', N'Çorum', N'https://uploads.turbologo.com/uploads/design/preview_image/732515/preview_image20200905-25622-f5phix.png')
INSERT [dbo].[MusteriTb] ([Id], [FirmaAdi], [Yetkili], [Telefon], [Adres], [Mail], [Sifre], [Sektor], [il], [Gorsel]) VALUES (10, N'Admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'https://img.freepik.com/premium-vector/freelance-sticker-logo-icon-vector-man-with-desktop-blogger-with-laptop-icon-vector-isolated-background-eps-10_399089-1098.jpg')
SET IDENTITY_INSERT [dbo].[MusteriTb] OFF
GO
SET IDENTITY_INSERT [dbo].[PersonelBilgileriTb] ON 

INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (2, N'Burak ', N'Bodur', N'312312313', N'Yönetici', N'Pendik/İstanbul', N'Bilgi İşlem', CAST(N'2002-01-03' AS Date), N'05555555555', NULL, N'Kendisi', 30000, N'burakbodur', N'123123', 0, N'A')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (3, N'Ahmet ', N'Yılmaz ', N'123213323', N'Yönetici', N'Kadıköy/İstanbul', N'Müdür Yardımcısı', CAST(N'2000-11-10' AS Date), N'05333333331', NULL, N'Kendisi', 33000, N'ahmetyılmaz', N'516812', 1, N'A')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (4, N'Büşra', N'Yel', N'312312323', N'Yönetici', N'Kartal/İstanbul', N'Müdür', CAST(N'1999-05-02' AS Date), N'05555444444', NULL, N'Kendisi', 30000, N'büşrayel', N'123231', 1, N'A')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (5, N'Elif', N'Yücel', N'123123123', N'Yönetici', N'Maltepe/İstanbul', N'İnsan Kaynakları', CAST(N'1995-08-07' AS Date), N'05535555555', NULL, N'Kendisi', 31222, N'elifyücel', N'323232', 1, N'A')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (6, N'Ali', N'Çelik', N'312312313', N'Yardımcı', N'Pendik/İstanbul', N'Muhasebe', CAST(N'2002-01-03' AS Date), N'05333333333', NULL, N'Burak Bodur', 15000, N'aliçelik', N'123123', 1, N'B')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (7, N'Barış', N'Yılmaz', N'123123123', N'Yardımcı', N'Kartal/İstanbul', N'Ulaşım', CAST(N'1999-05-02' AS Date), N'05555555555', NULL, N'Ahmet Yılmaz ', 33000, N'barışyılmaz', N'232232', 1, N'B')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (8, N'sdfsdfsdf', N'sdfsdfsdf', N'sdfsdfsdf', N'sdfsdfsdfsd', N'fsdfsdfsdf', N'İnsan Kaynakları', CAST(N'0001-01-01' AS Date), N'sdfsdfsdfsd', NULL, N'sdfsdfsdfsd', 333333, N'sdfsdfsd', N'sdfsdfs', 0, N'B')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'B')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (10, N'Ahmet ', N'Yılmaz ', N'123213323', N'Yönetici', N'Kadıköy/İstanbul', N'Danışma', CAST(N'2000-11-10' AS Date), N'05333333333', NULL, N'Kendisi', 33000, N'ahmetyılmaz', N'516812', 0, N'A')
INSERT [dbo].[PersonelBilgileriTb] ([Id], [Ad], [SoyAd], [Tc], [Pozisyon], [Adres], [Departman], [DogumTarihi], [Telefon], [Mail], [Yonetici], [Ucret], [KullaniciAdi], [Sifre], [Durum], [Rol]) VALUES (11, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PersonelBilgileriTb] OFF
GO
ALTER TABLE [dbo].[CagriDetayTb]  WITH CHECK ADD  CONSTRAINT [FK_CagriDetayTb_CagriTb] FOREIGN KEY([Cagri])
REFERENCES [dbo].[CagriTb] ([Id])
GO
ALTER TABLE [dbo].[CagriDetayTb] CHECK CONSTRAINT [FK_CagriDetayTb_CagriTb]
GO
ALTER TABLE [dbo].[CagriTb]  WITH CHECK ADD  CONSTRAINT [FK_CagriTb_MusteriTb] FOREIGN KEY([Musteri])
REFERENCES [dbo].[MusteriTb] ([Id])
GO
ALTER TABLE [dbo].[CagriTb] CHECK CONSTRAINT [FK_CagriTb_MusteriTb]
GO
ALTER TABLE [dbo].[CagriTb]  WITH CHECK ADD  CONSTRAINT [FK_CagriTb_PersonelBilgileriTb] FOREIGN KEY([CagriPersonel])
REFERENCES [dbo].[PersonelBilgileriTb] ([Id])
GO
ALTER TABLE [dbo].[CagriTb] CHECK CONSTRAINT [FK_CagriTb_PersonelBilgileriTb]
GO
ALTER TABLE [dbo].[GorevDetayTb]  WITH CHECK ADD  CONSTRAINT [FK_GorevDetayTb_GorevTb] FOREIGN KEY([Gorev])
REFERENCES [dbo].[GorevTb] ([Id])
GO
ALTER TABLE [dbo].[GorevDetayTb] CHECK CONSTRAINT [FK_GorevDetayTb_GorevTb]
GO
ALTER TABLE [dbo].[MesajlarTb]  WITH CHECK ADD  CONSTRAINT [FK_MesajlarTb_MusteriTb] FOREIGN KEY([Gonderen])
REFERENCES [dbo].[MusteriTb] ([Id])
GO
ALTER TABLE [dbo].[MesajlarTb] CHECK CONSTRAINT [FK_MesajlarTb_MusteriTb]
GO
ALTER TABLE [dbo].[MesajlarTb]  WITH CHECK ADD  CONSTRAINT [FK_MesajlarTb_MusteriTb1] FOREIGN KEY([Alici])
REFERENCES [dbo].[MusteriTb] ([Id])
GO
ALTER TABLE [dbo].[MesajlarTb] CHECK CONSTRAINT [FK_MesajlarTb_MusteriTb1]
GO
