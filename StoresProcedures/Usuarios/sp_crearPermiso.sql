CREATE PROCEDURE [dbo].[sp_crearPermiso]

--Parametros
@permiso nvarchar(40)
	
AS
BEGIN
	
	BEGIN TRY
	
		INSERT into dbo.Permisos(permiso) values (@permiso)
	
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