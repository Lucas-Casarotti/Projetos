CREATE TABLE [dbo].[Estados]
(
	[ID_Estado] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Estado] VARCHAR(2) NULL
)

INSERT INTO dbo.Estados (Estado) 
VALUES
('AC'),
('AL'),
('AM'),
('AP'),
('BA'),
('CE'),
('DF'),
('ES'),
('GO'),
('MA'),
('MG'),
('MS'),
('MT'),
('PA'),
('PB'),
('PE'),
('PI'), 
('PR'),
('RJ'),
('RN'),
('RO'),
('RR'),
('RS'),
('SC'),
('SE'),
('SP'),
('TO');

