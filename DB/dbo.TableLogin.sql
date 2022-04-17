CREATE TABLE [dbo].[TableLogin] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [email] VARCHAR (50) NULL,
    [heslo] VARCHAR (50) NULL,
    [jmeno] VARCHAR(50) NULL, 
    [prijmeni] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

