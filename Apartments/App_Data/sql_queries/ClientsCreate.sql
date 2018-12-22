CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	[Surname] NVARCHAR(50) NULL,
	[Fathername] NVARCHAR(50) NULL,
	[Address] NVARCHAR(50) NULL,
	[Agency] NVARCHAR(50) NULL,
	[Internalcomment] NVARCHAR(50) NULL,
	[Phone] INT NULL,
	[BirthDate] datetime NOT NULL,
	[RegistrationDate] datetime NOT NULL,
	[Isagent] BIT NOT NULL,
	[Isdonated] BIT NOT NULL,
	[AvatarId] INT NULL
)