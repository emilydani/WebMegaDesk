CREATE TABLE [dbo].[Quote] (
    [ID]         INT             IDENTITY (1, 1) NOT NULL,
    [name]       NVARCHAR (MAX)  NULL,
    [width]      FLOAT (53)      NULL,
    [depth]      FLOAT (53)      NULL,
    [numOfDrawers] INT             NULL,
    [price]      DECIMAL (18, 2) NULL,
    [Material] NVARCHAR (MAX)  NULL,
    [rushOrder]    NVARCHAR (MAX)  NULL,
    [DateAdded]  DATETIME2 (7)   NOT NULL,
    CONSTRAINT [PK_name] PRIMARY KEY CLUSTERED ([ID] ASC)
);

