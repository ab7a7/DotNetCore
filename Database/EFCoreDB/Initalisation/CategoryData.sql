INSERT INTO [dbo].[Category](Name, DateCreated, DateUpdated)
SELECT [c].[Name], [c].[DateCreated], [c].[DateUpdated]
FROM	
(
	SELECT 'Tablets' AS [Name], GETUTCDATE() AS [DateCreated], GETUTCDATE() AS [DateUpdated] UNION ALL
	SELECT 'Laptops' AS [Name], GETUTCDATE() AS [DateCreated], GETUTCDATE() AS [DateUpdated] UNION ALL
	SELECT 'Mobiles' AS [Name], GETUTCDATE() AS [DateCreated], GETUTCDATE() AS [DateUpdated]
)[c]