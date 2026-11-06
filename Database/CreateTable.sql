USE [BitXifyMockDB];
GO

CREATE TABLE [dbo].[tblProduct]
(
    [Id] INT NOT NULL,
    [Name] NVARCHAR(64) NOT NULL,
    [Price] FLOAT NOT NULL,
    [CreatedDate] DATETIME NOT NULL,
    CONSTRAINT [PK_tblProduct] PRIMARY KEY ([Id])
);
GO
