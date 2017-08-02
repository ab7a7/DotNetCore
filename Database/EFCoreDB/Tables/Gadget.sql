CREATE TABLE [dbo].[Gadget]
(
	[Id] INT IDENTITY (1,1),
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX),
	[Price] DECIMAL(8,2) NOT NULL,
	[CategoryId] int NOT NULL,
	CONSTRAINT [Pk_Gadget_Id] PRIMARY KEY ([Id]),
	CONSTRAINT [Fk_Gadget_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id])
)
