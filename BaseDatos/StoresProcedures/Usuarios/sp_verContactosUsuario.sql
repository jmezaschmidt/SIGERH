CREATE PROCEDURE [dbo].[sp_verContactosUsuario]

@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		Select Valor Contacto, tipoContacto FROM dbo.Colaborador INNER JOIN dbo.ContactosXColaborador ON idColaborador = FK_idColaborador
		INNER JOIN TipoContacto ON idTipoContacto = FK_idTipoContacto where cedula = @cedula
	
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