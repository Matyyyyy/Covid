CREATE TABLE [dbo].[TableReport] (
    [Id]                INT          IDENTITY (1, 1) NOT NULL,
    [Jméno]             VARCHAR (50) NULL,
    [Příjmení]          VARCHAR (50) NULL,
    [Email]             VARCHAR (50) NULL,
    [Telefonní kontakt] VARCHAR (50) NULL,
    [Datum narození]    VARCHAR (50) NULL,
    [Délka kotaktu]     VARCHAR (50) NULL,
    [Příznaky]          VARCHAR (50) NULL,
    [Očkování]          VARCHAR (50) NULL,
    [Chráněný kontakt]  VARCHAR (50) NULL,
    [ReportujiciO] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

