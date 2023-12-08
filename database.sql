USE [master]
GO

CREATE DATABASE [vinoteket-test]
GO

CREATE LOGIN [testUser] WITH PASSWORD=N'testPassword', DEFAULT_DATABASE=[vinoteket-test], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

USE [vinoteket-test]
GO

CREATE USER [testUser] FOR LOGIN [testUser] WITH DEFAULT_SCHEMA=[dbo]
GO

USE [vinoteket-test]
GO

CREATE TABLE Article (
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sku] [varchar](10) NOT NULL,
	[url] [varchar](100) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](500) NULL,
	[image_url] [varchar](200) NULL,
	[price] [int] NOT NULL
)
GO

INSERT INTO Article (sku, name, image_url, price, [description], url)
VALUES
('SKU1','Le Filere Barbaresco 2019', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w31848-le-filere-barbaresco-2019-20231122120335_lg.webp', 199, 'Fylligt vin', 'sku1'),					
('SKU2','Le Filere Barbera d''Asti 2021', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w31264-le-filere-barbera-dasti-2021-20231122115909_lg.webp', 99, 'Tunnt vin', 'sku2'), 
('SKU3','Le Filere Piemonte DOC Rosso 2020', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w31537-le-filere-piemonte-doc-rosso-2020-20231122115827_lg.webp', 129, 'Gott vin', 'sku3'),
('SKU4','Le Filere Langhe Nebbiolo 2022', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w32863-le-filere-langhe-nebbiolo-2022-20231122115458_lg.webp', 159, 'Bästa vinet!', 'sku4'),
('SKU5','Poggio al Sale Vino Nobile di Montepulciano 2019', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w33486-poggio-al-sale-vino-nobile-di-montepulciano-2019-20231122115333_lg.webp', 149, 'Ekologiskt', 'sku5'),
('SKU6','Markus Molitor Rosenberg Kabinett Fruchtsüss 2020', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w33470-markus-molitor-rosenberg-kabinett-fruchtsuss-2020-20231122115304_lg.webp', 99, 'Wow!', 'sku6'),
('SKU7','Le Filere Langhe Chardonnay 2022', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w33422-le-filere-langhe-chardonnay-2022-20231122115238_lg.webp', 299, 'Mums till räkor', 'sku7'),
('SKU8','Geografico La Pevera Toscana 2019', 'https://d3p3oepuk3k14u.cloudfront.net/img/article/w33365-geografico-la-pevera-toscana-2019-20231122115046_lg.webp', 499, NULL, 'sku8')
GO






