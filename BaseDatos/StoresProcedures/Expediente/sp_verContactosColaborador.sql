<<<<<<< HEAD:BaseDatos/StoresProcedures/Usuarios/sp_verContactosUsuario.sql
ALTER PROCEDURE [dbo].[sp_verContactosUsuario]
=======
CREATE PROCEDURE [dbo].[sp_verContactosColaborador]
>>>>>>> 0f94dc3e26606d7f035518156c994958709cf125:BaseDatos/StoresProcedures/Expediente/sp_verContactosColaborador.sql

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