ALTER PROCEDURE [dbo].[sp_crearColaborador]

@nombre nvarchar(20),
@apellido1 nvarchar(20),
@apellido2 nvarchar(20),
@cedula int,
@fechaNacimiento date,
@tipoUsuario nvarchar(40)
	
AS
BEGIN

	BEGIN TRY
		
		DECLARE @lastID int
		INSERT INTO dbo.Colaborador (nombre, apellido1, apellido2,cedula, fechaNacimiento) values (@nombre, @apellido1, @apellido2, @cedula, @fechaNacimiento)
		 
		SET @lastID = SCOPE_IDENTITY()
		INSERT INTO dbo.Usuario (nickname, password, FK_idColaborador) values 
		(@nombre +'.'+ @apellido1 + CAST(@lastID as nvarchar), HashBytes('MD5', CAST(@cedula as nvarchar(50))), @lastID)
		
		SET @lastID = SCOPE_IDENTITY()		
		INSERT INTO dbo.RolesXUsuario (FK_idTipoUsuario, FK_idUsuario) 
			values((Select idTipoUsuario FROM dbo.TipoUsuario where tipoUsuario = @tipoUsuario), @lastID) 	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		ROLLBACK
		RAISERROR (@Message, @ErrorNumber, @ErrorSeverity, @ErrorState)		 
	END CATCH
END
GO