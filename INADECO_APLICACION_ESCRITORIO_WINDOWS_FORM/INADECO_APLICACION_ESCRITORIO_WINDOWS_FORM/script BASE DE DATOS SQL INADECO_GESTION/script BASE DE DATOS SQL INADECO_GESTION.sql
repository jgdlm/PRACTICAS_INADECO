USE [master]
GO
/****** Object:  Database [INADECO_GESTION]    Script Date: 06/10/2021 13:19:50 ******/
CREATE DATABASE [INADECO_GESTION] ON  PRIMARY 
( NAME = N'INADECO_GESTION', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESSJORGE\MSSQL\DATA\INADECO_GESTION.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'INADECO_GESTION_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESSJORGE\MSSQL\DATA\INADECO_GESTION_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [INADECO_GESTION] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INADECO_GESTION].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INADECO_GESTION] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET ARITHABORT OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INADECO_GESTION] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INADECO_GESTION] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INADECO_GESTION] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INADECO_GESTION] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INADECO_GESTION] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [INADECO_GESTION] SET  MULTI_USER 
GO
ALTER DATABASE [INADECO_GESTION] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INADECO_GESTION] SET DB_CHAINING OFF 
GO
USE [INADECO_GESTION]
GO
/****** Object:  Table [dbo].[ALUMNOS]    Script Date: 06/10/2021 13:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNOS](
	[DNI_ALUMNO] [nvarchar](9) NOT NULL,
	[NOMBRE] [nvarchar](100) NULL,
	[PRIMER_APELLIDO] [nvarchar](100) NULL,
	[SEGUNDO_APELLIDO] [nvarchar](100) NULL,
	[DIRECCION] [nvarchar](100) NULL,
	[CIUDAD] [nvarchar](100) NULL,
	[CODIGO_POSTAL] [int] NULL,
	[PROVINCIA] [nvarchar](100) NULL,
	[TELEFONO] [nvarchar](10) NULL,
	[EMAIL] [nvarchar](100) NULL,
 CONSTRAINT [PK_ALUMNOS] PRIMARY KEY CLUSTERED 
(
	[DNI_ALUMNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AULAS]    Script Date: 06/10/2021 13:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AULAS](
	[ID_AULA] [int] NOT NULL,
	[NOMBRE_AULA] [nvarchar](10) NULL,
 CONSTRAINT [PK_AULAS] PRIMARY KEY CLUSTERED 
(
	[ID_AULA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CURSOS]    Script Date: 06/10/2021 13:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CURSOS](
	[ID_CURSO] [nvarchar](50) NOT NULL,
	[NOMBRE_CURSO] [nvarchar](100) NULL,
	[FECHA_INICIO] [date] NULL,
	[FECHA_FINALIZACION] [date] NULL,
	[HORARIO] [nvarchar](100) NULL,
	[DNI_ALUMNO] [nvarchar](9) NULL,
	[DNI_PROFESOR] [nvarchar](9) NULL,
	[ID_AULA] [int] NULL,
 CONSTRAINT [PK_CURSOS] PRIMARY KEY CLUSTERED 
(
	[ID_CURSO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROFESORES]    Script Date: 06/10/2021 13:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROFESORES](
	[DNI_PROFESOR] [nvarchar](9) NOT NULL,
	[NOMBRE] [nvarchar](100) NULL,
	[PRIMER_APELLIDO] [nvarchar](100) NULL,
	[SEGUNDO_APELLIDO] [nvarchar](100) NULL,
	[DIRECCION] [nvarchar](100) NULL,
	[CIUDAD] [nvarchar](100) NULL,
	[CODIGO_POSTAL] [int] NULL,
	[PROVINCIA] [nvarchar](100) NULL,
	[TELEFONO] [nvarchar](10) NULL,
	[EMAIL] [nvarchar](100) NULL,
 CONSTRAINT [PK_PROFESORES] PRIMARY KEY CLUSTERED 
(
	[DNI_PROFESOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CURSOS]  WITH CHECK ADD  CONSTRAINT [FK_CURSOS_ALUMNOS] FOREIGN KEY([DNI_ALUMNO])
REFERENCES [dbo].[ALUMNOS] ([DNI_ALUMNO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CURSOS] CHECK CONSTRAINT [FK_CURSOS_ALUMNOS]
GO
ALTER TABLE [dbo].[CURSOS]  WITH CHECK ADD  CONSTRAINT [FK_CURSOS_AULAS] FOREIGN KEY([ID_AULA])
REFERENCES [dbo].[AULAS] ([ID_AULA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CURSOS] CHECK CONSTRAINT [FK_CURSOS_AULAS]
GO
ALTER TABLE [dbo].[CURSOS]  WITH CHECK ADD  CONSTRAINT [FK_CURSOS_PROFESORES] FOREIGN KEY([DNI_PROFESOR])
REFERENCES [dbo].[PROFESORES] ([DNI_PROFESOR])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CURSOS] CHECK CONSTRAINT [FK_CURSOS_PROFESORES]
GO
USE [master]
GO
ALTER DATABASE [INADECO_GESTION] SET  READ_WRITE 
GO
