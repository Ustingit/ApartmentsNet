CREATE TABLE [dbo].[Apartments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(MAX) NOT NULL,
	[Author] NVARCHAR(MAX) NOT NULL,
	[Price] NVARCHAR(MAX) NOT NULL,
	[Phone] INT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[DateCreated] NVARCHAR(50) NULL,
	[DateActualTo] NVARCHAR(50) NULL,
	[IsActive] BIT NOT NULL,
	[IsDonated] BIT NOT NULL,
	[DonateDueDate] NVARCHAR(50) NULL,
	[InternalComment] NVARCHAR(MAX) NULL,
	[ClientId] INT NULL,
	CONSTRAINT [ApartmentClients] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([Id]) ON DELETE SET NULL,
	[ParsingSource] INT NULL,
	CONSTRAINT [ApartmentSource] FOREIGN KEY ([ParsingSource]) REFERENCES [ParsingSources]([Id]) ON DELETE SET NULL,
	[ShortId] NVARCHAR(MAX)  NULL,
	[SourceURL] NVARCHAR(MAX)  NULL,
	[mainPhotoUrl] NVARCHAR(MAX) NULL,
	[photosListUrls] NVARCHAR(MAX) NULL,
	[phoneImgURL] NVARCHAR(MAX) NULL
)
