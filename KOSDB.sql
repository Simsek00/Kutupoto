USE [master]
GO

IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'KOSDb')
BEGIN
    CREATE DATABASE [KOSDb]
END
GO

USE [KOSDb]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kullanicilar]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[kullanicilar](
        [id] [int] IDENTITY(1,1) NOT NULL,
        [adi] [varchar](20) NULL,          
        [soyadi] [varchar](20) NULL,        
        [KullaniciAdi] [varchar](20) NULL,  
        [Sifre] [nvarchar](100) NULL,      
        PRIMARY KEY CLUSTERED ([id] ASC)
    )

END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kitaplar]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[kitaplar](
        [id] [int] IDENTITY(1,1) NOT NULL,  
        [kayitNo] [int] NULL,               
        [kitapAdi] [varchar](50) NULL,      
        [yazarAdi] [varchar](50) NULL,      
        [sayfaSayisi] [varchar](20) NULL,   
        [tur] [varchar](20) NULL,           
        [yayinevi] [varchar](50) NULL,     
        [basimYili] [varchar](20) NULL,     
        [dolapNo] [varchar](20) NULL,       
        [rafNo] [varchar](20) NULL,         
        [aktif] [int] DEFAULT 1,            
        [durum] [int] DEFAULT 1,            
        PRIMARY KEY CLUSTERED ([id] ASC)
    )
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[okuyucular]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[okuyucular](
        [id] [int] IDENTITY(1,1) NOT NULL,
        [adi] [varchar](30) NULL,           
        [soyadi] [varchar](30) NULL,        
        [cinsiyeti] [varchar](10) NULL,     
        [sinifi] [varchar](10) NULL,       
        [okulNo] [varchar](30) NULL,        
        [cepTel] [varchar](30) NULL,        
        [adres] [varchar](250) NULL,        
        [aktif] [int] DEFAULT 1,           
        PRIMARY KEY CLUSTERED ([id] ASC)
    )
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[emanetler]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[emanetler](
        [id] [int] IDENTITY(1,1) NOT NULL,
        [kitapId] [int] NULL,              
        [okuyucuId] [int] NULL,            
        [emanetVerilisTarihi] [date] NULL, 
        [emanetGeriAlmaTarihi] [date] NULL,
        [emanetIslemTarihi] [date] NULL,    
        [durum] [int] DEFAULT 0,            
        [aktif] [int] DEFAULT 1,            
        PRIMARY KEY CLUSTERED ([id] ASC)
    )
END
GO