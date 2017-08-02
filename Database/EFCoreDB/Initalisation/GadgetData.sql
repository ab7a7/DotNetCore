INSERT INTO [dbo].[Gadget]([Name], [Description], [Price], [CategoryId])
SELECT [g].[Name], [g].[Description], [g].[Price], [g].[CategoryId]
FROM 
(
	SELECT 'ProntoTec 7' AS [Name], 'Android 4.4 KitKat Tablet PC, Cortex A8 1.2 GHz Dual Core Processor,512MB / 4GB,Dual Camera,G-Sensor (Black)' AS [Description], 1 AS [CategoryId], 46.99 AS [Price] UNION ALL
	SELECT 'Samsung Galaxy' AS [Name], 'Android 4.4 Kit Kat OS, 1.2 GHz quad-core processor' AS [Description], 1 AS [CategoryId], 120.95 AS [Price] UNION ALL
	SELECT 'NeuTab® N7 Pro 7' AS [Name], 'NeuTab N7 Pro tablet features the amazing powerful, Quad Core processor performs approximately Double multitasking running speed, and is more reliable than ever' AS [Description], 1 AS [CategoryId], 56.99 AS [Price] UNION ALL
	SELECT 'ASUS 15.6-Inch' AS [Name], 'Latest Generation Intel Dual Core Celeron 2.16 GHz Processor (turbo to 2.41 GHz)' AS [Description], 2 AS [CategoryId], 249.5 AS [Price] UNION ALL
	SELECT 'HP Pavilion 15-r030wm' AS [Name], 'This Certified Refurbished product is manufacturer refurbished, shows limited or no wear, and includes all original accessories plus a 90-day warranty' AS [Description], 2 AS [CategoryId], 299.95 AS [Price] UNION ALL
	SELECT 'Dell Inspiron 15.6-Inch' AS [Name], 'Intel Celeron N2830 Processor, 15.6-Inch Screen, Intel HD Graphics' AS [Description], 2 AS [CategoryId], 308.00 AS [Price] UNION ALL
	SELECT 'HTC Desire 816' AS [Name], '13 MP Rear Facing BSI Camera / 5 MP Front Facing' AS [Description], 3 AS [CategoryId], 177.99 AS [Price] UNION ALL
	SELECT 'Sanyo Innuendo' AS [Name], 'Uniquely designed 3G-enabled messaging phone with side-flipping QWERTY keyboard and external glow-thru OLED dial pad that ''disappears'' when not in use' AS [Description], 3 AS [CategoryId], 54.99 AS [Price] UNION ALL
	SELECT 'Ulefone N9000' AS [Name], 'Unlocked world GSM phone. 3G-850/2100, 2G -850/900/1800/1900' AS [Description], 3 AS [CategoryId], 133.99 AS [Price] 

) [g]