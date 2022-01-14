USE [db_SNR]
GO
/****** Object:  Table [dbo].[Inmueble]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inmueble](
	[Inmueble_id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[DireccionInmueble] [varchar](255) NOT NULL,
	[NumHabitaciones] [varchar](50) NOT NULL,
	[Ciudad] [varchar](50) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[estado] [varchar](10) NOT NULL,
	[precio] [varchar](50) NOT NULL,
	[foto] [image] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Inmueble_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[persona_id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [char](8) NOT NULL,
	[nombre] [varchar](150) NOT NULL,
	[apellido] [varchar](250) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[celular] [char](9) NOT NULL,
	[direccion] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[celular] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublicarI]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicarI](
	[id_Publicar] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[DireccionInmueble] [varchar](255) NOT NULL,
	[NumHabitaciones] [varchar](50) NOT NULL,
	[Ciudad] [varchar](50) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[estado] [varchar](10) NOT NULL,
	[precio] [varchar](50) NOT NULL,
	[foto] [image] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Publicar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[persona_id] [int] NULL,
	[usuario] [varchar](50) NOT NULL,
	[clave] [varchar](100) NOT NULL,
	[nivel] [varchar](30) NOT NULL,
	[estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inmueble]  WITH CHECK ADD FOREIGN KEY([usuario_id])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO
ALTER TABLE [dbo].[PublicarI]  WITH CHECK ADD FOREIGN KEY([usuario_id])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([persona_id])
REFERENCES [dbo].[Persona] ([persona_id])
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_D]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Inmueble_D]																																																																																																																																		
  @pInmueble_id int  
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DELETE dbo.Inmueble	
			WHERE Inmueble_id = @pInmueble_id
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_I]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENAD PARA INSERTAR EN LA TABLA INMUEBLE 
create procedure [dbo].[USP_Inmueble_I]

	@pusuario_id int, 
	@pDireccionInmueble varchar(255),
	@pNumHabitaciones varchar(50) ,
	@pCiudad varchar(50),
	@pDescripcion varchar(500),
	@pestado varchar(10),
	@precio varchar(50),
	@pfoto image
As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         INSERT INTO dbo.Inmueble
         VALUES(@pusuario_id,@pDireccionInmueble,@pNumHabitaciones,@pCiudad ,@pDescripcion,@pestado,@precio,@pfoto)
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_Publico_Buscar]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Inmueble_Publico_Buscar]
	@pbusqueda varchar(150)

AS
BEGIN
		SELECT id_Publicar,usuario_id,DireccionInmueble,NumHabitaciones,Ciudad,Descripcion,estado,precio,foto
		FROM dbo.PublicarI
		WHERE NumHabitaciones LIKE '%' + @pbusqueda + '%'
		OR
		DireccionInmueble LIKE '%' + @pbusqueda+'%'
		OR
		precio LIKE '%' + @pbusqueda+'%'
		OR
		Estado=@pbusqueda
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_Publico_U]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA LISTAR INMUEBLES(PUBLICOS USUARIO)
create procedure [dbo].[USP_Inmueble_Publico_U]
	@idusuario int
As 
BEGIN 
	SELECT * FROM PublicarI WHERE usuario_id=@idusuario
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_S]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA LISTAR INMUEBLES
create procedure [dbo].[USP_Inmueble_S]
As 
BEGIN 
	SELECT * FROM Inmueble 
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_S_Buscar]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Inmueble_S_Buscar]
	@pbusqueda varchar(150),
	@pidusuario int
AS
BEGIN
		SELECT Inmueble_id,usuario_id,DireccionInmueble,NumHabitaciones,Ciudad,Descripcion,estado,precio,foto
		FROM dbo.Inmueble 
		WHERE DireccionInmueble LIKE '%' + @pbusqueda + '%'
		OR
		Ciudad LIKE '%' + @pbusqueda+'%'
		AND
		usuario_id=@pidusuario
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_U]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO DE ACTUALIZAR EN LA TABLA INMUEBLE
CREATE PROCEDURE [dbo].[USP_Inmueble_U]
	@pinmueble_id int,
	@pdireccion varchar(255),
	@pnumeroh varchar(50),
	@pciudad varchar(50),
	@pdescripcion varchar(500),
	@pestado varchar(10),
	@pprecio varchar(50),
	@pimagen image
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			UPDATE dbo.Inmueble SET
			DireccionInmueble=@pdireccion,
			NumHabitaciones=@pnumeroh,
			Ciudad=@pciudad,
			Descripcion=@pdescripcion,
			estado=@pestado,
			precio=@pprecio,
			foto=@pimagen
			WHERE Inmueble_id=@pinmueble_id
	COMMIT 
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO
/****** Object:  StoredProcedure [dbo].[USP_Inmueble_Usuario_S]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA LISTAR INMUEBLE
create procedure [dbo].[USP_Inmueble_Usuario_S]
	@idusuario int
As 
BEGIN 
	SELECT * FROM Inmueble WHERE usuario_id=@idusuario
END
GO
/****** Object:  StoredProcedure [dbo].[USP_inmueble_Verificar]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--PROCEDIMIENTO ALMACENADO PARA VERIFICAR INMUEBLE:
CREATE PROCEDURE [dbo].[USP_inmueble_Verificar]
	@pvalor varchar (150),
	@existe bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		IF EXISTS (SELECT DireccionInmueble FROM Inmueble WHERE DireccionInmueble=LTRIM(rtrim(@pvalor)))
			BEGIN
				SET @existe=1
			END
		ELSE
		BEGIN
				SET @existe=0
			END
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Persona_I]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO DE INSERTAR EN LA TABLA PERSONA
CREATE PROCEDURE [dbo].[USP_Persona_I]
	@pdni char(8),
	@pnombre varchar(150),
	@papellido varchar(150),
	@pemail varchar(250),
	@pcelular char(9),
	@pdireccion text

AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Persona
			VALUES(@pdni,@pnombre,@papellido,@pemail,@pcelular,@pdireccion)
	COMMIT 
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO
/****** Object:  StoredProcedure [dbo].[USP_Persona_S]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO LISTAR TABLA PERSONA
CREATE PROCEDURE [dbo].[USP_Persona_S]
AS
BEGIN
			SELECT * FROM Persona
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Persona_Verificar]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA VERIFICAR persona:
CREATE PROCEDURE [dbo].[USP_Persona_Verificar]
	@pvalor varchar (150),
	@existe bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		IF EXISTS (SELECT nombre FROM Persona WHERE nombre=LTRIM(rtrim(@pvalor)))
			BEGIN
				SET @existe=1
			END
		ELSE
		BEGIN
				SET @existe=0
			END
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Publicar_I]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Metodo Insertar Inmueble_publico
create procedure [dbo].[USP_Publicar_I]

	@pusuario_id int, 
	@pDireccionInmueble varchar(255),
	@pNumHabitaciones varchar(50) ,
	@pCiudad varchar(50),
	@pDescripcion varchar(500),
	@pestado varchar(10),
	@precio varchar(50),
	@pfoto image
As 
BEGIN 
   BEGIN TRAN 
       BEGIN TRY  
         INSERT INTO dbo.PublicarI
         VALUES(@pusuario_id,@pDireccionInmueble,@pNumHabitaciones,@pCiudad ,@pDescripcion,@pestado,@precio,@pfoto)
   COMMIT 
       END TRY
       BEGIN CATCH
	       ROLLBACK
	   END CATCH
   END
GO
/****** Object:  StoredProcedure [dbo].[USP_Publicar_V]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA VERIFICAR Publico_I:
CREATE PROCEDURE [dbo].[USP_Publicar_V]
	@pvalor varchar (150),
	@existe bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		IF EXISTS (SELECT DireccionInmueble FROM PublicarI WHERE DireccionInmueble=LTRIM(rtrim(@pvalor)))
			BEGIN
				SET @existe=1
			END
		ELSE
		BEGIN
				SET @existe=0
			END
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Usuario_I]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO DE INSERTAR EN LA TABLA USUARIO
CREATE PROCEDURE [dbo].[USP_Usuario_I]
	@ppersona_id int,
	@pusuario varchar(50),
	@pclave varchar(100),
	@pnivel varchar(30),
	@pestado char(1)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Usuario
			VALUES(@ppersona_id,@pusuario,@pclave,@pnivel,@pestado)
	COMMIT 
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
	END
GO
/****** Object:  StoredProcedure [dbo].[USP_usuario_loguear]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_usuario_loguear]
	@pusuario varchar (50),
	@pclave varchar (100) 
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		SELECT u.usuario_id,p.apellido,p.nombre,p.email, u.usuario,u.nivel,u.estado
		FROM dbo.Usuario as u
		INNER JOIN dbo.Persona as p
		ON u.persona_id = p.persona_id
		WHERE (u.usuario =@pusuario OR p.email=@pusuario) AND u.clave = @pclave

	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Usuario_Verificar]    Script Date: 14/01/2022 18:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO ALMACENADO PARA VERIFICAR USUARIO:
CREATE PROCEDURE [dbo].[USP_Usuario_Verificar]
	@pvalor varchar (150),
	@existe bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		IF EXISTS (SELECT usuario FROM Usuario WHERE usuario=LTRIM(rtrim(@pvalor)))
			BEGIN
				SET @existe=1
			END
		ELSE
		BEGIN
				SET @existe=0
			END
	COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO
