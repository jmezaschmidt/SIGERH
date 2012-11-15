ALTER PROCEDURE [dbo].[sp_modificarEstadoSolicitud]

--Parametros
@idSolicitud int,
@estado nvarchar(30)
	
AS
BEGIN

	BEGIN TRY
	
		DECLARE @resultado bit
		
		SET @resultado = 1
		
		UPDATE dbo.Solicitud SET FK_idEstadoSolicitud = (SELECT idEstadoSolicitud FROM dbo.EstadoSolicitud where EstadoSolicitud = @estado)
		where idSolicitud = @idSolicitud
		
		Select @resultado
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()		
		SET @resultado = 0
		Select @resultado
	END CATCH	
END
GO