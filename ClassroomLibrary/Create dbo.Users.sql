USE [ClassroomLibrary]
GO

/****** Object: Table [dbo].[Users] Script Date: 5/21/2017 12:14:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Email]    NVARCHAR (MAX) NULL,
    [FullName] NVARCHAR (MAX) NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    [Username] NVARCHAR (MAX) NOT NULL,
	
	CONSTRAINT [PK_Users]PRIMARY KEY CLUSTERED
	(
	[ID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF,
	IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
	ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]
	) ON [PRIMARY]
	

	GO
	



