


SET IDENTITY_INSERT dbo.Provider ON
insert into dbo.Provider(ProviderId, ProviderBrand, ProviderAddress, ProviderDescription)
values ('1', 'Phong Vũ' , '123, Lý Tự Trọng', 'Nhà cung cấp 1')

insert into dbo.Provider(ProviderId, ProviderBrand, ProviderAddress, ProviderDescription)
values ('2', 'Mai Hoàng' , '237, An Dương Vương', 'Nhà cung cấp 2')

insert into dbo.Provider(ProviderId, ProviderBrand, ProviderAddress, ProviderDescription)
values ('3', 'Laptopcentre' , '173, Lê Quang Định', 'Nhà cung cấp 3')
SET IDENTITY_INSERT dbo.Provider OFF

SET IDENTITY_INSERT dbo.Product ON
insert into dbo.Product (ProductId,
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('1' ,
		'CPU AMD Ryzen 3 2200G' ,
		'CPU',
		'2390000' , 
		'50' ,
		'2' ,
		'CPU AMD Ryzen 3 2200G(3.5 GHz - 3.7 GHz, 4MB)-AM4' ,
		'CPUAMDRyzen32200G-AM4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('2' , 
		'CPU AMD Ryzen 5 2400G(3.6GHz-3.9GHz,4MB)-AM4' ,
		'CPU',
		'4390000' , 
		'50' ,
		'2' ,
		'CPU AMD Ryzen 5 2400G(3.6GHz-3.9GHz,4MB)-AM4' ,
		'CPUAMDRyzen52400G-AM4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('3' ,
		'CPU AMD Ryzen 5 2600(3.4GHz-3.9GHz,16MB)-AM4' ,
		'CPU',
		'3990000' , 
		'50' ,
		'3',
		'CPU AMD Ryzen 5 2600(3.4GHz-3.9GHz,16MB)-AM4' ,
		'CPUAMDRyzen52600-AM4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('4' ,
		'CPU AMD Ryzen 5 2600X(3.6 GHz-4.2GHz,16MB)-AM4' ,
		'CPU',
		'5500000' , 
		'50' ,
		'1',
		'CPU AMD Ryzen 5 2600X(3.6GHz-4.2GHz,16MB)-AM4' ,
		'CPUAMDRyzen52600X-AM4.jpg')

insert into dbo.Product (ProductId, 
						ProductName,
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('5' ,
		'CPU AMD Ryzen 7(8C16T,3.2GHz-4.1GHz,16MB)-AM4' ,
		'CPU',
		'8500000' , 
		'50' ,
		'3',
		'CPU AMD Ryzen 7(8C16T,3.2GHz-4.1GHz,16MB)-AM4' ,
		'CPUAMDRyzen7-AM4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('6' ,
		'CPU AMD Ryzen Athlon 200GE(3.2GHz,4MB)-AM4' ,
		'CPU',
		'14100000' , 
		'50' ,
		'2',
		'CPU AMD Ryzen Athlon 200GE(3.2GHz,4MB)-AM4' ,
		'CPUAMDRyzenAthlon200GE-AM4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('7' ,
		'CPU Intel Celeron G4900(3.1GHz,2MB)-LGA1151-v2' ,
		'CPU',
		'13900000' , 
		'50' ,
		'3',
		'CPU Intel Celeron G4900(3.1GHz,2MB)-LGA1151-v2' ,
		'CPUIntelCeleron.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('8' ,
		'CPU Intel Core I3-7100 (3.9GHz)' ,
		'CPU',
		'3350000' , 
		'50' ,
		'2',
		'CPU Intel Core I3-7100 (3.9GHz)' ,
		'CPUIntelCoreI3-7100.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('9' ,
		'CPU Intel Core I3-8100 (3.6GHz)' ,
		'CPU',
		'3290000' , 
		'50' ,
		'1',
		'CPU Intel Core I3-8100 (3.6GHz)' ,
		'CPUIntelCoreI3-8100.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('10' ,
		'CPU INTEL Core i3-9100(3.60GHz-4.20GHz,6MB)-1151' ,
		'CPU',
		'3390000' , 
		'50' ,
		'1',
		'CPU INTEL Core i3-9100(3.60GHz-4.20GHz,6MB)-1151' ,
		'CPUINTELCorei3-9100.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('11' ,
		'CPU Intel Core I5-7500 (3.4GHz - 3.8GHz)' ,
		'CPU',
		'5000000' , 
		'50' ,
		'1',
		'CPU INTEL Core i3-9100(3.60GHz-4.20GHz,6MB)-1151' ,
		'CPUINTELCorei3-9100.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('12' ,
		'CPU Intel Core I5-7500 (3.4GHz - 3.8GHz)' ,
		'CPU',
		'4000000' , 
		'50' ,
		'1',
		'CPU Intel Core I5-7500 (3.4GHz - 3.8GHz)' ,
		'CPUIntelCoreI5-7500.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('13' ,
		'CPU Intel Core I5-8600K (3.6GHz)' ,
		'CPU',
		'4000000' , 
		'50' ,
		'1',
		'CPU Intel Core I5-8600K (3.6GHz)' ,
		'CPUIntelCoreI5-8600K.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('14' ,
		'CPU Intel Core i5-9400F(2.9-4.1GHz,9MB)-LGA1151-v2' ,
		'CPU',
		'3500000' , 
		'50' ,
		'1',
		'CPU Intel Core i5-9400F(2.9-4.1GHz,9MB)-LGA1151-v2' ,
		'CPUIntelCorei5-9400F.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('15' ,
		'CPUIntelCore i5-9600K(6C6T,3.7GHz-4.6GHz,9MB)-LGA' ,
		'CPU',
		'3500000' , 
		'50' ,
		'1',
		'CPUIntelCore i5-9600K(6C6T,3.7GHz-4.6GHz,9MB)-LGA' ,
		'CPUIntelCorei5-9600K.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('16' ,
		'CPU Intel Core I7-7700 (3.6GHz)' ,
		'CPU',
		'9100000' , 
		'50' ,
		'1',
		'CPU Intel Core I7-7700 (3.6GHz)' ,
		'CPUIntelCoreI7-7700.jpg')


insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('17' ,
		'CPU INTEL Corei7-9700(3.00GHz-4.7GHz,12MB)1151-v2' ,
		'CPU',
		'9100000' , 
		'50' ,
		'3',
		'CPU INTEL Core i7-9700 1151-v2' ,
		'CPUINTELCorei7-9700.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('18' ,
		'CPU Intel Core i7-97(3.6 GHz-4.9GHz,12MB)-LGA' ,
		'CPU',
		'13000000' , 
		'50' ,
		'3',
		'CPU Intel Core i7-97(3.6 GHz-4.9GHz,12MB)-LGA' ,
		'CPUIntelCorei7-97.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('19' ,
		'CPU Intel Core i9-99(3.6GHz-5GHz,16MB) -LGA1151-v2' ,
		'CPU',
		'12000000' , 
		'50' ,
		'2',
		'CPU Intel Core i9-99(3.6GHz-5GHz,16MB) -LGA1151-v2' ,
		'CPUIntelCorei9-99.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('20' ,
		'CPU Intel Pentium G5400(3.7GHz,4MB)-LG1151-v2' ,
		'CPU',
		'5000000' , 
		'50' ,
		'2',
		'CPU Intel Pentium G5400(3.7GHz,4MB)-LG1151-v2' ,
		'CPUIntelPentiumG5400.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('21' ,
		'HDD Western Digital Elements Portable USB 3' ,
		'Ổ cứng di động',
		'5000000' , 
		'50' ,
		'2',
		'HDD Western Digital Elements Portable USB 3' ,
		'WDBU6Y0020BBK.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('22' ,
		'HDD Western Digital My Passport Ultra 1TB 2.5 USBC' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'2',
		'HDD Western Digital My Passport Ultra 1TB 2.5 USBC' ,
		'WDBC3C0010BSL.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('23' ,
		'HDD Seagate Barracuda 1TB 3.5 SATA 3' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'2',
		'HDD Seagate Barracuda 1TB 3.5 SATA 3' ,
		'ST1000DM010.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('24' ,
		'HDD Western Digital Blue 1TB 3.5 SATA 3' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'3',
		'HDD Western Digital Blue 1TB 3.5 SATA 3' ,
		'WD10EZEX.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('25' ,
		'SSD ADATA SX6000 LITE 128GB M.2 2280 NVMe' ,
		'Ổ cứng di động',
		'4000000' , 
		'50' ,
		'3',
		'SSD ADATA SX6000 LITE 128GB M.2 2280 NVMe' ,
		'ASX6000LNP.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('26' ,
		'SSD Intel Optane 16GB M.2 2280 NVMe' ,
		'Ổ cứng di động',
		'3000000' , 
		'50' ,
		'3',
		'SSD Intel Optane 16GB M.2 2280 NVMe' ,
		'MEMPEK1W016GAXT.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('27' ,
		'SSD Intel Optane 32GB M.2 NVMe' ,
		'Ổ cứng di động',
		'3000000' , 
		'50' ,
		'1',
		'SSD Intel Optane 32GB M.2 NVMe' ,
		'MEMPEK1W032GAXT.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('28' ,
		'SSD Kingston A400 120GB 2.5 SATA 3' ,
		'Ổ cứng di động',
		'3000000' , 
		'50' ,
		'1',
		'SSD Kingston A400 120GB 2.5 SATA 3' ,
		'SSDKingstonA400120GB.jpg')


insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('29' ,
		'SSD Kingston A400 240GB 2.5 SATA 3' ,
		'Ổ cứng di động',
		'3000000' , 
		'50' ,
		'2',
		'SSD Kingston A400 240GB 2.5 SATA 3' ,
		'SSDKingstonA400240GB.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('30' ,
		'SSD Kingston SUV500 120GB 2.5 SATA 3' ,
		'Ổ cứng di động',
		'8500000' , 
		'50' ,
		'2',
		'SSD Kingston SUV500 120GB 2.5 SATA 3' ,
		'SSDKingstonSUV500120GB.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('31' ,
		'Ổ cứng SSD Samsung 860 Evo 250GB 2.5 SATA 3' ,
		'Ổ cứng di động',
		'8500000' , 
		'50' ,
		'2',
		'Ổ cứng SSD Samsung 860 Evo 250GB 2.5 SATA 3' ,
		'MZ76E250BW.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('32' ,
		'SSD Samsung 860 Evo 250GB M.2 2280 SATA 3' ,
		'Ổ cứng di động',
		'5000000' , 
		'50' ,
		'2',
		'SSD Samsung 860 Evo 250GB M.2 2280 SATA 3' ,
		'MZ-N6E250BW.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('33' ,
		'SSD Transcend 230S 128GB 2.5 SATA' ,
		'Ổ cứng di động',
		'5000000' , 
		'50' ,
		'2',
		'SSD Transcend 230S 128GB 2.5 SATA' ,
		'SSDTranscend230S128GB.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('34' ,
		'SSD Transcend 820s 120GB M.2 2280 SATA 3' ,
		'Ổ cứng di động',
		'5000000' , 
		'50' ,
		'1',
		'SSD Transcend 820s 120GB M.2 2280 SATA 3' ,
		'SSDTranscend820s120GB.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('35' ,
		'SSD Western Digital Blue 250GB 2.5 SATA 3' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'1',
		'SSD Western Digital Blue 250GB 2.5 SATA 3' ,
		'WDS250G2B0A.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('36' ,
		'SSD Western Digital Blue 500GB 2.5 SATA 3' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'1',
		'SSD Western Digital Blue 250GB 2.5 SATA 3' ,
		'WDS500G2B0A.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('37' ,
		'SSD Western Digital Green 240GB 2.5 SATA 3' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'1',
		'SSD Western Digital Green 240GB 2.5 SATA 3' ,
		'WDS240G2G0A.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('38' ,
		'SSD Western Digital WD Blue 250GB M.2 2280 SATA 3' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'1',
		'SSD Western Digital WD Blue 250GB M.2 2280 SATA 3' ,
		'WDS250G2B0B.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('39' ,
		'SSD Western Digital WD Green 240GB M.2 2280 SATA 3' ,
		'Ổ cứng di động',
		'2000000' , 
		'50' ,
		'1',
		'SSD Western Digital WD Green 240GB M.2 2280 SATA 3' ,
		'WDS240G2G0B.jpg')


insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('40' ,
		'RAM desktop ADATA AD4U240038G17-R(1x8GB)DR42400MHz' ,
		'RAM',
		'1400000' , 
		'50' ,
		'2',
		'RAM desktop ADATA AD4U240038G17-R(1x8GB)DR42400MHz' ,
		'RAMdesktopADATAAD4U240038G17-R.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('41' ,
		'ADATA XPG Gammix D10 AX4 (1x8GB)DDR426MHz' ,
		'RAM',
		'1200000' , 
		'50' ,
		'2',
		'ADATA XPG Gammix D10 AX4 (1x8GB)DDR42666MHz' ,
		'ADATAXPGGammixD10.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('42' ,
		'ADATA XPG GAMMIX D10 AX4U2(1x8GB) DDR4 2666MHz' ,
		'RAM',
		'1200000' , 
		'50' ,
		'2',
		'ADATA XPG GAMMIX D10 AX4U2(1x8GB) DDR4 2666MHz' ,
		'ADATAXPGGAMMIXD10AX4U2.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('43' ,
		'CORSAIR Vengeance LPX (1x8GB) DDR4 2666MHz' ,
		'RAM',
		'1200000' , 
		'50' ,
		'2',
		'CORSAIR Vengeance LPX (1x8GB) DDR4 2666MHz' ,
		'CORSAIR Vengeance LPX .jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('44' ,
		'Crucial Ballistix Sport LT(1x4GB) DDR4 2666MHz' ,
		'RAM',
		'1200000' , 
		'50' ,
		'2',
		'Crucial Ballistix Sport LT(1x4GB) DDR4 2666MHz' ,
		'Crucial Ballistix Sport LT.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('45' ,
		'RAM desktop Crucial CT4(1x4GB) DDR4 2400MHz' ,
		'RAM',
		'1200000' , 
		'50' ,
		'3',
		'RAM desktop Crucial CT4(1x4GB) DDR4 2400MHz' ,
		'Crucial CT4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('46' ,
		'RAM desktop Crucial CT8(1x8GB) DDR4 2666MHz' ,
		'RAM',
		'1300000' , 
		'50' ,
		'3',
		'RAM desktop Crucial CT8(1x8GB) DDR4 2666MHz' ,
		'Crucial CT8.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('47' ,
		'RAM desktop G.SKILL Aegis(1x4GB) DDR3 1600MHz' ,
		'RAM',
		'1300000' , 
		'50' ,
		'3',
		'RAM desktop G.SKILL Aegis(1x4GB) DDR3 1600MHz' ,
		'RAM desktop Aegis.jpg')


insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('48' ,
		'RAM desktop G.SKILL Aegis F4(1x4GB) DDR4 2400MHz' ,
		'RAM',
		'1300000' , 
		'50' ,
		'3',
		'RAM desktop G.SKILL Aegis F4(1x4GB) DDR4 2400MHz' ,
		'SKILL Aegis F4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('49' ,
		'RAM desktop Aegis F4(1x8GB) DDR4 2666MHz' ,
		'RAM',
		'1600000' , 
		'50' ,
		'3',
		'RAM desktop Aegis F4(1x8GB) DDR4 2666MHz' ,
		'S Aegis F4.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('50' ,
		'RAM desktop G.SKILL F4-4GNT (1x4GB) DDR4 2400MHz' ,
		'RAM',
		'1600000' , 
		'50' ,
		'3',
		'RAM desktop G.SKILL F4-4GNT (1x4GB) DDR4 2400MHz' ,
		'F4-4GNT.jpg')

insert into dbo.Product (ProductId, 
						ProductName, 
						ProductTypeName,
						ProductPrice, 
						ProductQuantity,
						ProductProviderId,
						ProductDescription, 
						ProductImage)
values ('51' ,
		'RAM desktop G.SKILL F4-8GNT (1x8GB) DDR4 2666MH' ,
		'RAM',
		'1600000' , 
		'50' ,
		'3',
		'RAM desktop G.SKILL F4-8GNT (1x8GB) DDR4 2666MH' ,
		'F4-8GNT.jpg')
SET IDENTITY_INSERT dbo.Product OFF

SET IDENTITY_INSERT dbo.Customer ON
insert into dbo.Customer(CustomerId, Name, Phone, Email, Address)
values ('165','Nguyễn Thiên Hữu', '0123456789', 'huu@gmail.com', '23 Trần Bình Trọng')
insert into dbo.Customer(CustomerId, Name, Phone, Email, Address)
values ('123','Nguyễn Thị Trang', '01234236779', 'trang@gmail.com', '11 Ngô Đức Thắng')
insert into dbo.Customer(CustomerId, Name, Phone, Email, Address)
values ('211','Dương Đức Trọng', '0999999999', 'trong@gmail.com', '93 Huỳnh Đình Hai')
insert into dbo.Customer(CustomerId, Name, Phone, Email, Address)
values ('333','Nguyễn Khải Triều', '0132433677', 'trieu@gmail.com', '22 Lý Chính Thắng')
insert into dbo.Customer(CustomerId, Name, Phone, Email, Address)
values ('134','Ngô Ngọc Bảo Châu', '0142422657', 'chau@gmail.com', '23 Lý Chính Thắng')
SET IDENTITY_INSERT dbo.Customer OFF

SET IDENTITY_INSERT dbo.Order ON
insert into dbo.Order(OrderId, OrderCustomerId, OrderDate)
values ('1', '134', '12/7/2019')
insert into dbo.Order(OrderId, OrderCustomerId, OrderDate)
values ('2', '211', '10/7/2019')
insert into dbo.Order(OrderId, OrderCustomerId, OrderDate)
values ('3', '123', '9/7/2019')
insert into dbo.Order(OrderId, OrderCustomerId, OrderDate)
values ('4', '333', '12/7/2019')
insert into dbo.Order(OrderId, OrderCustomerId, OrderDate)
values ('5', '165', '12/7/2019')
SET IDENTITY_INSERT dbo.Odrder OFF

SET IDENTITY_INSERT dbo.Permission ON
insert into dbo.Permission (PermissionId, PermissionTitle, PermissionDescription)
values ('1', 'Admin', 'Quyền truy cập của admin')
insert into dbo.Permission (PermissionId, PermissionTitle, PermissionDescription)
values ('2', 'Customer', 'Quyền truy cập của khách hàng')
SET IDENTITY_INSERT dbo.Permission OFF

