# Mitagem 
Este projeto tem por finalidade estudar ASP.NET MVC, Entity Framework, Dapper, AutoMapper, Consumo de API.

Para o seu funcionamento, é necessário, salvar o resultado da consulta no endereço https://api.cartolafc.globo.com/atletas/mercado em um arquivo json, e sobreescrever o existente neste repositório, com o nome de cartola.json.

//Em breve será implementado a função para consumir direto do link do API.

É necessário a criação de um banco local com o nome de CartolaDB , conforme Webconfig.

É necessário a criação de uma tabela, de acordo com o script abaixo:

CREATE TABLE [dbo].[Clube] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [id_clube] INT           NOT NULL,
    [nome]     VARCHAR (100) NULL,
    CONSTRAINT [PK_dbo.Clube] PRIMARY KEY CLUSTERED ([id] ASC)
);

É necessário inserir os dados dos times, conforme script abaixo:

SET IDENTITY_INSERT [dbo].[Clube] ON
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (1, 262, N'Flamengo')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (2, 263, N'Botafogo')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (3, 264, N'Corinthians')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (4, 265, N'Bahia')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (5, 266, N'Fluminense')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (6, 267, N'Vasco')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (7, 275, N'Palmeiras')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (8, 276, N'São Paulo')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (9, 277, N'Santos')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (10, 282, N'Atlético-MG')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (11, 283, N'Cruzeiro')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (12, 284, N'Grêmio')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (13, 287, N'Vitória')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (14, 292, N'Sport')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (15, 293, N'Atlético-PR')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (16, 294, N'Coritiba')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (17, 303, N'Ponte Preta')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (18, 314, N'Avaí')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (19, 315, N'Chapecoense')
INSERT INTO [dbo].[Clube] ([id], [id_clube], [nome]) VALUES (20, 373, N'Atlético-GO')
SET IDENTITY_INSERT [dbo].[Clube] OFF
