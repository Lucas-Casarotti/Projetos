USE [Pessoas]
GO
/****** Object:  Table [dbo].[Pessoas]    Script Date: 26/01/2023 15:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoas](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NULL,
	[Endereco] [varchar](14) NULL,
	[Email] [varchar](30) NULL
) ON [PRIMARY]
GO
