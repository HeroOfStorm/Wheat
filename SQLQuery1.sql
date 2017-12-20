﻿USE master;
IF DB_ID('ShopAdo') IS NOT NULL
      DROP DATABASE ShopAdo;
CREATE DATABASE ShopAdo collate Ukrainian_CI_AS;

GO
USE ShopAdo ;
IF OBJECT_ID('Manufacturer', 'U') IS NOT NULL
   DROP TABLE Manufacturer;
CREATE TABLE dbo.Manufacturer
(
   ManufacturerId int not null IDENTITY(1,1) primary key,
   ManufacturerName NVARCHAR(20) NOT NULL
);
GO

SET IDENTITY_INSERT dbo.Manufacturer ON;

INSERT INTO dbo.Manufacturer (ManufacturerId, ManufacturerName) 

VALUES 
     (1, 'Lays'),
	 (2, 'Kakao'),
	 (3, 'Flint'),
	 (4, 'Huawei'),
	 (5, 'Sony'),
	 (6, 'LG'),
	 (7, 'Acer'),
	 (8, 'HP'),
	 (9, 'Canon'),
	 (10, 'Asus');
SET IDENTITY_INSERT dbo.Manufacturer OFF;

IF OBJECT_ID('Category', 'U') IS NOT NULL
   DROP TABLE Category;
CREATE TABLE dbo.Category
(
   CategoryId int not null IDENTITY(1,1) primary key,
   CategoryName NVARCHAR(20) NOT NULL
);
GO

SET IDENTITY_INSERT dbo.Category ON;

INSERT INTO dbo.Category (CategoryId, CategoryName) 
VALUES 
     (1, 'Smartphone'),
	 (2, 'Notebook'),
	 (3, 'Printer'),(4, 'Telephon');
SET IDENTITY_INSERT dbo.Category OFF;


IF OBJECT_ID('Good', 'U') IS NOT NULL
   DROP TABLE Good;
CREATE TABLE dbo.Good
(
   GoodId int not null IDENTITY(1,1) primary key,
   GoodName VARCHAR(100) NOT NULL,
   ManufacturerId int foreign key REFERENCES dbo.Manufacturer(ManufacturerId), 
   CategoryId int foreign key REFERENCES dbo.Category(CategoryId), 
   Price money not null default 0,
   GoodCount numeric(18,3) not null default 0
);
GO
SET IDENTITY_INSERT dbo.Good ON;

INSERT INTO dbo.Good (GoodId, GoodName, ManufacturerId, CategoryId, Price, GoodCount) 
VALUES 
		(1, 'HP LaserJet P2035 (CE461A)', 8,3, 5445, 12),
		(2, 'Canon i-SENSYS MF212W with Wi-F' ,9,3,3999, 7),
		(3, 'Samsung SCX-4650N ', 1,3,3999, 15),
		(4, 'HP DJ1510 (B2L56C) ', 8,3,1199, 2),
		(5, 'Asus Transformer Book T100TAF 32GB',10,2, 4999, 11),
		(6, 'Lenovo Flex 10 (59427902)', 2, 2, 5555, 11),
		(7, 'Acer Aspire ES1-411-C1XZ', 7,2,6399, 7),
		(8, 'HP 255 G4 (N0Y69ES)', null, 2, 6199, 5),
		(9, 'HP ProBook 430 (N0Y70ES)', 8,2,12400, 3),
		(10, 'Ultrabook Samsung 535U3', 1, null, 8000,10),
		(11, 'Samsung Galaxy S3 Neo Duos I9300i Black', 1,1,3999, 7),
		(12, 'Lenovo A5000 Black', 2,1,3299, 5),
		(13, 'Microsoft Lumia 640 XL (Nokia)', 3,1, 4888, 5),
		(14, 'LG G3s Dual D724 Titan', 6, 1,3999, 0);
SET IDENTITY_INSERT dbo.Good OFF;

CREATE TABLE Sale
(
   SaleId int not null identity(1,1) primary key,
   NumberSale int not null,
   UserPhone char(10) NOT NULL DEFAULT '0',
   UserEmail nvarchar(80) NOT NULL,
   DateSale Date not null,
   Summa money not null default 0
)
CREATE TABLE SalePos
(
   SalePosId int not null identity(1,1) primary key,
   SaleId int not null Foreign Key REFERENCES dbo.Sale(SaleId),
   GoodId int not null Foreign Key REFERENCES dbo.Good(GoodId),
   CountGood int not null,
   Summa money not null default 0
)

ALTER TABLE dbo.Good ADD CONSTRAINT Check_COUNT CHECK (GoodCount>=0)

GO
CREATE TABLE [dbo].[Photo](
	[PhotoId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[GoodId] [int] NULL,
	[PhotoPath] [nvarchar](200) NOT NULL
) 
GO
INSERT INTO dbo.Photo( GoodId, PhotoPath) 
VALUES 
		(1,'http://product-images.www8-hp.com/digmedialib/prodimg/lowres/c02943910.png'),
		(2,'http://www.canon.ua/Images/MF212w%20Default_tcm212-1173941.jpg'),
		(3,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		(4,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		(5,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		( 6,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		( 7,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		( 8,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		( 9,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		(10,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		( 11,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		( 12,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		(13,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg'),
		(14,'https://akphoto3.ask.fm/642/294/778/1650003019-1rnrfi0-6phim2o499cihj5/original/tmp_14043211721634646481.jpg');    