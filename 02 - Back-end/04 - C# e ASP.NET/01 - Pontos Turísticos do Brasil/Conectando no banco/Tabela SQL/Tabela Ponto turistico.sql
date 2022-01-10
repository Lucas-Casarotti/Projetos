USE [master]
GO

/****** Object:  Table [dbo].[PontosTuristicos]    Script Date: 29/09/2021 21:08:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PontosTuristicos](
	[ID_PT] [int] IDENTITY(1,1) NOT NULL,
	[Nome_PT] [nvarchar](50) NOT NULL,
	[Desc_PT] [nvarchar](100) NOT NULL,
	[Endereco_PT] [nvarchar](50) NOT NULL,
	[Cidade_PT] [nvarchar](50) NOT NULL,
	[ID_Estado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [master]
GO

INSERT INTO dbo.PontosTuristicos(Nome_PT, Desc_PT, Endereco_PT, Cidade_PT, ID_Estado) 
VALUES
('Museu de Arte de São Paulo', 'Museu', 'Av. Paulista, 1578', 'São Paulo', 26),
('Centro Histórico de Paraty', 'A cidade de Paraty é perfeita para os apreciadores de história, romance e literatura', 'Paraty', 'Paraty', 19),
('Parque Ibirapuera', 'O Parque Ibirapuera é um dos mais famosos da capital paulista.', 'Av. Pedro Álvares Cabral - Vila Mariana', 'São Paulo', 26),
('Marco Zero da Praça da Sé', ' Marco Zero de São Paulo está localizado na Praça da Sé.', 'Praça da Sé, 68 - Centro Histórico de São Paulo', 'São Paulo', 26),
('Rua 25 de março', 'A rua 25 de março é referência quando se fala em compras em São Paulo. ', '25 de Março ', 'São Paulo', 26);