ALTER PROCEDURE [dbo].[sp_crearColaborador]

--Parametros
@nombre nvarchar(20),
@apellido1 nvarchar(20),
@apellido2 nvarchar(20),
@fechaNacimiento date,
@nickname nvarchar(40),
@password nvarchar(50)
	
AS
BEGIN

DECLARE @lastID int

INSERT INTO dbo.Colaborador (nombre, apellido1, apellido2, fechaNacimiento) values (@nombre, @apellido1, @apellido2, @fechaNacimiento)

SET @lastID = SCOPE_IDENTITY()

INSERT INTO dbo.Usuario (nickname, password, FK_idColaborador) values (@nickname, HashBytes('MD5', @password), @lastID)
END
GO