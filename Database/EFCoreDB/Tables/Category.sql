CREATE TABLE [dbo].[Category]
(
	[Id] INT IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
	[DateCreated] DATETIME NULL,
	[DateUpdated] DATETIME NULL
	CONSTRAINT [Pk_Category] PRIMARY KEY ([Id]) 
)
