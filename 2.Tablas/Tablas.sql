IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'BDSeguros')
BEGIN
    CREATE DATABASE [BDSeguros]
END
GO
USE BDSeguros
GO
DROP TABLE IF EXISTS FIN_Pago
DROP TABLE IF EXISTS FIN_Afiliacion
DROP TABLE IF EXISTS FIN_Seguro
DROP TABLE IF EXISTS FIN_Persona
GO
--TABLA: FIN_Persona
CREATE TABLE [dbo].[FIN_Persona](
	[codigo_per] [int] IDENTITY(1,1) NOT NULL,
	[nombres_per] [varchar](100) NOT NULL,
	[apellidoPaterno_per] [varchar](100) NOT NULL,
    [apellidoMaterno_per] [varchar](100) NOT NULL,
	[documentoIdentidad_per] [varchar](20) NOT NULL,
	[Eliminado_AUD] [bit] NOT NULL,
	[FechaRegistro_AUD] [smalldatetime] NOT NULL,
	[UsuarioRegistro_AUD] [int] NULL,
	[FechaEdicion_AUD] [smalldatetime] NULL,
	[UsuarioEdicion_AUD] [int] NULL,
 CONSTRAINT [PK_FIN_persona] PRIMARY KEY CLUSTERED 
(
	[codigo_per] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FIN_Persona] ADD  CONSTRAINT [DF_FIN_persona_Eliminado_AUD]  DEFAULT ((0)) FOR [Eliminado_AUD]
GO
ALTER TABLE [dbo].[FIN_Persona] ADD  CONSTRAINT [DF_FIN_persona_FechaRegistro_AUD]  DEFAULT (getdate()) FOR [FechaRegistro_AUD]
GO

--TABLA: FIN_Seguro
CREATE TABLE [dbo].[FIN_Seguro](
	[codigo_seg] [int] IDENTITY(1,1) NOT NULL,
	[companiaAseguradora_seg] [varchar](200) NOT NULL,
	[tipoSeguro_seg] [varchar](50) NOT NULL,
	[factorImpuesto_seg] [decimal](8, 2) NOT NULL,
	[porcentajeComision_seg] [decimal](8, 2) NOT NULL,
	[montoPrima_seg] [decimal](10, 2) NOT NULL,
	[moneda_seg] [char](1) NOT NULL,
	[edadMaxPermitida_seg] [decimal](5, 2) NOT NULL,
	[fechaVigencia_seg] [smalldatetime] NOT NULL,
	[estado_seg] [char](1) NOT NULL,
	[importeMensual_seg] [decimal](10, 2) NOT NULL,
	[cobertura_seg] [nvarchar](200) NOT NULL,
	[Eliminado_AUD] [bit] NOT NULL,
	[FechaRegistro_AUD] [smalldatetime] NOT NULL,
	[UsuarioRegistro_AUD] [int] NULL,
	[FechaEdicion_AUD] [smalldatetime] NULL,
	[UsuarioEdicion_AUD] [int] NULL,
 CONSTRAINT [PK_FIN_seguros] PRIMARY KEY CLUSTERED 
(
	[codigo_seg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FIN_Seguro] ADD  CONSTRAINT [DF_FIN_seguros_Eliminado_AUD]  DEFAULT ((0)) FOR [Eliminado_AUD]
GO
ALTER TABLE [dbo].[FIN_Seguro] ADD  CONSTRAINT [DF_FIN_seguros_FechaRegistro_AUD]  DEFAULT (getdate()) FOR [FechaRegistro_AUD]
GO

--TABLA: FIN_Afiliacion
CREATE TABLE [dbo].[FIN_Afiliacion](
	[codigo_afi] [int] IDENTITY(1,1) NOT NULL,
	[codigo_seg] [int] NOT NULL,
	[codigo_per] [int] NOT NULL,
	[Eliminado_AUD] [bit] NOT NULL,
	[FechaRegistro_AUD] [smalldatetime] NOT NULL,
	[UsuarioRegistro_AUD] [int] NULL,
	[FechaEdicion_AUD] [smalldatetime] NULL,
	[UsuarioEdicion_AUD] [int] NULL,
 CONSTRAINT [PK_FIN_Afiliacion] PRIMARY KEY CLUSTERED 
(
	[codigo_afi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FIN_Afiliacion] ADD  CONSTRAINT [DF_FIN_Afiliacion_Eliminado_AUD]  DEFAULT ((0)) FOR [Eliminado_AUD]
GO
ALTER TABLE [dbo].[FIN_Afiliacion] ADD  CONSTRAINT [DF_FIN_Afiliacion_FechaRegistro_AUD]  DEFAULT (getdate()) FOR [FechaRegistro_AUD]
GO
ALTER TABLE [dbo].[FIN_Afiliacion]  WITH CHECK ADD  CONSTRAINT [FK_FIN_Persona_FIN_Afiliacion] FOREIGN KEY([codigo_per])
REFERENCES [dbo].[FIN_Persona] ([codigo_per])
GO
ALTER TABLE [dbo].[FIN_Afiliacion] CHECK CONSTRAINT [FK_FIN_Persona_FIN_Afiliacion]
GO
ALTER TABLE [dbo].[FIN_Afiliacion]  WITH CHECK ADD  CONSTRAINT [FK_FIN_Seguro_FIN_Afiliacion] FOREIGN KEY([codigo_seg])
REFERENCES [dbo].[FIN_Seguro] ([codigo_seg])
GO
ALTER TABLE [dbo].[FIN_Afiliacion] CHECK CONSTRAINT [FK_FIN_Seguro_FIN_Afiliacion]
GO
ALTER TABLE [dbo].[FIN_Afiliacion]  WITH CHECK ADD  CONSTRAINT [FK_FIN_seguros_FIN_Afiliacion] FOREIGN KEY([codigo_seg])
REFERENCES [dbo].[FIN_Seguro] ([codigo_seg])
GO
ALTER TABLE [dbo].[FIN_Afiliacion] CHECK CONSTRAINT [FK_FIN_seguros_FIN_Afiliacion]
GO

--TABLA: FIN_Pago
CREATE TABLE [dbo].[FIN_Pago](
	[codigo_pag] [int] IDENTITY(1,1) NOT NULL,
	[codigo_seg] [int] NOT NULL,
	[montoPagar_pag] [decimal](10, 2) NOT NULL,
	[mesPago_pag] [int] NOT NULL,
	[anioPago_pag] [int] NULL,
	[Eliminado_AUD] [bit] NOT NULL,
	[FechaRegistro_AUD] [smalldatetime] NOT NULL,
	[UsuarioRegistro_AUD] [int] NULL,
	[FechaEdicion_AUD] [smalldatetime] NULL,
	[UsuarioEdicion_AUD] [int] NULL,
 CONSTRAINT [PK_FIN_Pago] PRIMARY KEY CLUSTERED 
(
	[codigo_pag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FIN_Pago] ADD  CONSTRAINT [DF_FIN_Pago_Eliminado_AUD]  DEFAULT ((0)) FOR [Eliminado_AUD]
GO
ALTER TABLE [dbo].[FIN_Pago] ADD  CONSTRAINT [DF_FIN_Pago_FechaRegistro_AUD]  DEFAULT (getdate()) FOR [FechaRegistro_AUD]
GO
ALTER TABLE [dbo].[FIN_Pago]  WITH CHECK ADD  CONSTRAINT [FK_FIN_Seguro_FIN_Pago] FOREIGN KEY([codigo_seg])
REFERENCES [dbo].[FIN_Seguro] ([codigo_seg])
GO
ALTER TABLE [dbo].[FIN_Pago] CHECK CONSTRAINT [FK_FIN_Seguro_FIN_Pago]
GO

