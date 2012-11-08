ALTER PROCEDURE [dbo].[sp_asignarRolUsuario]

@cedula int,
@tipoUsuario nvarchar(40)
	
AS
BEGIN
	BEGIN TRY
		
		INSERT into dbo.RolesXUsuario (FK_idUsuario, FK_idTipoUsuario) values
		((Select idUsuario FROM dbo.Colaborador INNER JOIN dbo.Usuario ON idColaborador = FK_idColaborador where cedula = @cedula),
		(Select idTipoUsuario FROM dbo.TipoUsuario where tipoUsuario = @tipoUsuario))
	
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