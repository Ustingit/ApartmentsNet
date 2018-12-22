CREATE TABLE [dbo].[Apartments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	[Author] NVARCHAR(50) NOT NULL,
	[Price] NVARCHAR(50) NOT NULL,
	[Phone] INT NULL,
	[Description] NVARCHAR(1500) NULL,
	[PhoneImg] varbinary(max) NULL,
	[MainApPhoto] varbinary(max) NULL,
	[DateCreated] datetime NOT NULL,
	[DateActualTo] datetime NOT NULL,
	[IsActive] BIT NOT NULL,
	[IsDonated] BIT NOT NULL,
	[DonateDueDate] datetime NULL,
	[InternalComment] NVARCHAR(2000) NULL,
	[ClientId] INT NULL,
	CONSTRAINT [ApartmentClients] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([Id]) ON DELETE SET NULL
)