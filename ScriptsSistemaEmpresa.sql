USE [SistemaEmpresa]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[uf] [nvarchar](2) NULL,
	[nome_empresa] [nvarchar](200) NULL,
	[cnpj] [nvarchar](14) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpresaFornecedor]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpresaFornecedor](
	[id_empresa_fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[id_empresa] [int] NOT NULL,
	[id_fornecedor] [int] NOT NULL,
 CONSTRAINT [PK_EmpresaFornecedor] PRIMARY KEY CLUSTERED 
(
	[id_empresa_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[id_fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](200) NULL,
	[rg] [nvarchar](15) NULL,
	[dt_cadastro] [datetime] NULL,
	[dt_nascimento] [datetime] NULL,
	[telefone] [nvarchar](15) NULL,
	[documento] [nvarchar](14) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[id_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([id_empresa], [uf], [nome_empresa], [cnpj]) VALUES (1, N'RS', N'Share', N'85549506000107')
INSERT [dbo].[Empresa] ([id_empresa], [uf], [nome_empresa], [cnpj]) VALUES (2, N'PR', N'Prime', N'80742217000106')
INSERT [dbo].[Empresa] ([id_empresa], [uf], [nome_empresa], [cnpj]) VALUES (3, N'SP', N'Google', N'25217743000149')
INSERT [dbo].[Empresa] ([id_empresa], [uf], [nome_empresa], [cnpj]) VALUES (4, N'AM', N'Spotify', N'12612387000116')
INSERT [dbo].[Empresa] ([id_empresa], [uf], [nome_empresa], [cnpj]) VALUES (6, N'SC', N'Activision', N'12345678912345')
INSERT [dbo].[Empresa] ([id_empresa], [uf], [nome_empresa], [cnpj]) VALUES (7, N'SP', N'Asus', N'00014174749497')
SET IDENTITY_INSERT [dbo].[Empresa] OFF
SET IDENTITY_INSERT [dbo].[EmpresaFornecedor] ON 

INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (1, 1, 1)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (2, 2, 2)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (3, 1, 2)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (4, 3, 1)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (6, 3, 2)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (9, 1, 3)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (10, 1, 4)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (11, 2, 1)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (13, 4, 4)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (14, 4, 3)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (16, 6, 1)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (17, 6, 2)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (18, 6, 3)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (19, 2, 2)
INSERT [dbo].[EmpresaFornecedor] ([id_empresa_fornecedor], [id_empresa], [id_fornecedor]) VALUES (20, 7, 7)
SET IDENTITY_INSERT [dbo].[EmpresaFornecedor] OFF
SET IDENTITY_INSERT [dbo].[Fornecedor] ON 

INSERT [dbo].[Fornecedor] ([id_fornecedor], [nome], [rg], [dt_cadastro], [dt_nascimento], [telefone], [documento]) VALUES (1, N'CocaCola', N'', CAST(N'2019-12-03T03:00:00.000' AS DateTime), NULL, N'123123123', N'17104700000129')
INSERT [dbo].[Fornecedor] ([id_fornecedor], [nome], [rg], [dt_cadastro], [dt_nascimento], [telefone], [documento]) VALUES (2, N'LucasW', N'310921338', CAST(N'2019-12-04T03:00:00.000' AS DateTime), CAST(N'1991-07-05T03:00:00.000' AS DateTime), N'984818052', N'02602020028')
INSERT [dbo].[Fornecedor] ([id_fornecedor], [nome], [rg], [dt_cadastro], [dt_nascimento], [telefone], [documento]) VALUES (3, N'NVIDIA', NULL, CAST(N'2019-12-04T03:00:00.000' AS DateTime), NULL, N'981818181', N'57149622000101')
INSERT [dbo].[Fornecedor] ([id_fornecedor], [nome], [rg], [dt_cadastro], [dt_nascimento], [telefone], [documento]) VALUES (4, N'Blizzard', N'', CAST(N'2019-12-04T03:00:00.000' AS DateTime), NULL, N'444444444', N'53146230000120')
INSERT [dbo].[Fornecedor] ([id_fornecedor], [nome], [rg], [dt_cadastro], [dt_nascimento], [telefone], [documento]) VALUES (6, N'YasminH', N'429205557', CAST(N'2019-12-04T03:00:00.000' AS DateTime), CAST(N'1996-03-14T03:00:00.000' AS DateTime), N'984818052', N'02020011487')
INSERT [dbo].[Fornecedor] ([id_fornecedor], [nome], [rg], [dt_cadastro], [dt_nascimento], [telefone], [documento]) VALUES (7, N'Bruce Dickinson', N'2342343423', CAST(N'2019-12-02T03:00:00.000' AS DateTime), CAST(N'1988-03-09T03:00:00.000' AS DateTime), N'1234324', N'151564145564')
SET IDENTITY_INSERT [dbo].[Fornecedor] OFF
ALTER TABLE [dbo].[EmpresaFornecedor]  WITH CHECK ADD  CONSTRAINT [FK_EmpresaFornecedor_Empresa] FOREIGN KEY([id_empresa])
REFERENCES [dbo].[Empresa] ([id_empresa])
GO
ALTER TABLE [dbo].[EmpresaFornecedor] CHECK CONSTRAINT [FK_EmpresaFornecedor_Empresa]
GO
ALTER TABLE [dbo].[EmpresaFornecedor]  WITH CHECK ADD  CONSTRAINT [FK_EmpresaFornecedor_Fornecedor] FOREIGN KEY([id_fornecedor])
REFERENCES [dbo].[Fornecedor] ([id_fornecedor])
GO
ALTER TABLE [dbo].[EmpresaFornecedor] CHECK CONSTRAINT [FK_EmpresaFornecedor_Fornecedor]
GO
/****** Object:  StoredProcedure [dbo].[buscar_empresa]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Lucas Weber
-- Create date: 03/12/2019
-- Description:	Busca um objeto de Empresa no banco de dados através de sua ID
-- =============================================
CREATE PROCEDURE [dbo].[buscar_empresa] 
	@idEmpresa int
AS
BEGIN
	SET NOCOUNT ON;
	
	select 
		nome_empresa, 
		uf, 
		cnpj
    from Empresa where id_empresa = @idEmpresa

END
GO
/****** Object:  StoredProcedure [dbo].[buscar_fornecedor]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Lucas Weber
-- Create date: 04/12/2019
-- Description:	Busca um objeto de Fornecedor no banco de dados através de sua ID
-- =============================================
CREATE PROCEDURE [dbo].[buscar_fornecedor] 
	@idFornecedor int
AS
BEGIN
	SET NOCOUNT ON;

	select  
		nome, 
		documento,
		rg, 
		dt_cadastro, 
		dt_nascimento,
		telefone 
	  from Fornecedor where id_fornecedor = @idFornecedor

END

GO
/****** Object:  StoredProcedure [dbo].[buscar_lista_fornecedores]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Lucas Weber
-- Create date: 04/12/2019
-- Description:	Busca a listagem de fornecedores pela id da empresa
-- =============================================
CREATE PROCEDURE [dbo].[buscar_lista_fornecedores]
	@idEmpresa int,
	@nome nvarchar(200) = null,
	@documento nvarchar(14) = null,
	@dt_cadastro datetime = null
AS
BEGIN
	
  SET NOCOUNT ON;
  select 
	  f.nome, 
	  f.documento,
	  f.rg, 
	  f.dt_cadastro, 
	  f.dt_nascimento,
	  f.telefone,
	  emp.nome_empresa
  from EmpresaFornecedor ef
  join Fornecedor f on ef.id_fornecedor = f.id_fornecedor
  join Empresa emp on ef.id_empresa = emp.id_empresa
  where emp.id_empresa = @idEmpresa
  AND ISNULL( f.nome,'') LIKE ISNULL('%'+@nome+'%', ISNULL( nome, ''))
  AND ISNULL( f.documento,'') LIKE ISNULL('%'+@documento+'%', ISNULL( documento, ''))
  AND ISNULL( f.dt_cadastro,'') = ISNULL(@dt_cadastro, ISNULL(dt_cadastro,''))
END

GO
/****** Object:  StoredProcedure [dbo].[cadastrar_empresa]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Lucas Weber
-- Create date: 03/12/2019
-- Description:	Cadastra uma nova empresa no banco de dados
-- =============================================
CREATE PROCEDURE [dbo].[cadastrar_empresa] 
	@uf nvarchar(2) null,
	@nome_empresa nvarchar(200) null,
	@cnpj nvarchar(14) null,
	@adicionado bit OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	set @adicionado = 0
	INSERT INTO Empresa values(@uf,@nome_empresa,@cnpj)
    set @adicionado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[cadastrar_empresa_fornecedor]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Lucas Weber
-- Create date: 04/12/2019
-- Description:	Cria o vínculo entre empresa e fornecedor
-- =============================================
CREATE PROCEDURE [dbo].[cadastrar_empresa_fornecedor]
	@id_empresa int,
	@id_fornecedor int,
	@Adicionado bit output
AS
BEGIN
	SET NOCOUNT ON;
	SET @Adicionado = 0
	Insert into EmpresaFornecedor values (@id_empresa,@id_fornecedor);
    SET @Adicionado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[cadastrar_fornecedor]    Script Date: 05/12/2019 23:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Lucas Weber
-- Create date: 03/12/2019
-- Description:	Cadastra um novo fornecedor no banco de dados
-- =============================================
CREATE PROCEDURE [dbo].[cadastrar_fornecedor] 
	@nome nvarchar(200) null,
	@rg nvarchar(15) null,
	@dt_cadastro datetime null,
	@dt_nascimento datetime null,
	@telefone nvarchar(15) null,
	@documento nvarchar(14) null,
	@adicionado bit OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	set @adicionado = 0
	INSERT INTO Fornecedor values(@nome,@rg,@dt_cadastro,@dt_nascimento,@telefone,@documento)
    set @adicionado = 1
END

GO
