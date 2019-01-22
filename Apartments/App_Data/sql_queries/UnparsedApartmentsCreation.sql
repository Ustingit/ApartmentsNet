CREATE TABLE [dbo].[UnparsedApartments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[URL] NVARCHAR(250) NOT NULL,
	[HTML] NVARCHAR(2500) NOT NULL,
	[ErrorDate] NVARCHAR(250) NULL,
	[Exception] NVARCHAR(1250) NULL
)