

CREATE PROCEDURE sp<NombreNombre>

	@param int, @param2 int
	
AS
BEGIN

	BEGIN TRY
	
	/* SELECT's y declaración de variables */
	
	BEGIN TRANSACTION
	
	
	/* NO siempre es necesario hacerlo transaccional */
	/* Con esto nos aseguramos no tener la base inconsistente si falla algo al ingresar un asiento o algo así */
	
	COMMIT TRANSACTION;
	
	/* Borrar tablas temporales si fueron utilizadas */
	
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