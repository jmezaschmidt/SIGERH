ALTER PROCEDURE [dbo].[sp_asignarPermiso]

--Parametros
@tipoUsuario nvarchar(40),
@permiso nvarchar(40)
	
AS
BEGIN
	BEGIN TRY
		
		INSERT into dbo.PermisosXTipoUsuario(FK_idTipoUsuario, FK_idPermiso) values 
		((Select idTipoUsuario FROM dbo.TipoUsuario where tipoUsuario = @tipoUsuario), (Select idPermiso FROM dbo.Permisos where permiso = @permiso))	
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()		
		RAISERROR (@Message, @ErrorNumber, @ErrorSeverity, @ErrorState)
	END CATCH		
END
GO