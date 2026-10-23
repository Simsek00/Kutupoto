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
        [adi] [nvarchar](20) NULL,          
        [soyadi] [nvarchar](20) NULL,        
        [KullaniciAdi] [nvarchar](20) NULL,  
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
        [kitapAdi] [nvarchar](50) NULL,      
        [yazarAdi] [nvarchar](50) NULL,      
        [sayfaSayisi] [nvarchar](20) NULL,   
        [tur] [nvarchar](20) NULL,           
        [yayinevi] [nvarchar](50) NULL,     
        [basimYili] [nvarchar](20) NULL,     
        [dolapNo] [nvarchar](20) NULL,       
        [rafNo] [nvarchar](20) NULL,         
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
        [adi] [nvarchar](30) NULL,           
        [soyadi] [nvarchar](30) NULL,        
        [cinsiyeti] [nvarchar](10) NULL,     
        [sinifi] [nvarchar](10) NULL,       
        [okulNo] [nvarchar](30) NULL,        
        [cepTel] [nvarchar](30) NULL,        
        [adres] [nvarchar](250) NULL,        
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

-- Eski kurulumlar için: varchar metin sütunlarını nvarchar'a çevirir (Türkçe karakterler her collation'da korunur).
-- Yeni kurulumda hiçbir şey yapmaz; script tekrar çalıştırılabilir.
DECLARE @sql nvarchar(max) = N'';

SELECT @sql += N'ALTER TABLE [dbo].' + QUOTENAME(t.name) + N' ALTER COLUMN ' + QUOTENAME(c.name)
             + N' nvarchar(' + CAST(c.max_length AS nvarchar(10)) + N') NULL; '
FROM sys.columns c
JOIN sys.tables t ON c.object_id = t.object_id
JOIN sys.types ty ON c.user_type_id = ty.user_type_id
WHERE ty.name = N'varchar' AND t.name IN (N'kullanicilar', N'kitaplar', N'okuyucular');

IF @sql <> N''
BEGIN
    -- Sütun tipi değişirken üzerindeki UNIQUE kısıtı geçici olarak kaldırılır, aşağıda tekrar eklenir.
    IF EXISTS (SELECT * FROM sys.indexes WHERE name = N'UQ_kullanicilar_KullaniciAdi')
        ALTER TABLE [dbo].[kullanicilar] DROP CONSTRAINT [UQ_kullanicilar_KullaniciAdi];

    EXEC sp_executesql @sql;
END
GO

-- Kullanıcı adları tekil olmalı. Var olan veritabanlarında da çalışır; tekrar eden kullanıcı adı varsa kısıt eklenmez.
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = N'UQ_kullanicilar_KullaniciAdi')
   AND NOT EXISTS (SELECT KullaniciAdi FROM [dbo].[kullanicilar] GROUP BY KullaniciAdi HAVING COUNT(*) > 1)
BEGIN
    ALTER TABLE [dbo].[kullanicilar] ADD CONSTRAINT [UQ_kullanicilar_KullaniciAdi] UNIQUE ([KullaniciAdi])
END
GO
