CREATE TABLE [dbo].[Users] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [Email]     NVARCHAR (MAX) NULL,
    [FullName] NVARCHAR (MAX) NOT NULL,
    [Password]  NVARCHAR (MAX) NOT NULL,
    [Username]  NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([ID] ASC)
);

