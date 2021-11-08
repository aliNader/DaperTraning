CREATE TABLE [dbo].[Student] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (32) NOT NULL,
    [LastName]   NVARCHAR (32) NOT NULL,
    [FatherName] NVARCHAR (32) NOT NULL,
    [MotherName] NVARCHAR (32) NOT NULL,
    [Mark]       DECIMAL(5,2)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

