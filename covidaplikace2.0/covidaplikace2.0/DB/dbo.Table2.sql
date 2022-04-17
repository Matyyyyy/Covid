CREATE TABLE [dbo].[TableReport]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Jméno] VARCHAR(50) NULL, 
    [Příjmení] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Telefonní kontakt] VARCHAR(50) NULL, 
    [Datum narození] VARCHAR(50) NULL, 
    [Délka kotaktu] VARCHAR(50) NULL, 
    [Příznaky] VARCHAR(50) NULL, 
    [Vztah k osobě] VARCHAR(50) NULL
)
