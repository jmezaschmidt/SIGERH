ALTER PROCEDURE [dbo].[sp_verRolesUsuario]

@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		Select TipoUsuario FROM dbo.Colaborador INNER JOIN Usuario ON idColaborador = FK_idColaborador
		INNER JOIN dbo.RolesXUsuario ON idUsuario = FK_idUsuario
		INNER JOIN dbo.TipoUsuario ON idTipoUsuario = FK_idTipoUsuario where cedula = @cedula
	
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