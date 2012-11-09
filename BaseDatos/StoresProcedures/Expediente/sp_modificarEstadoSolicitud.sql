CREATE PROCEDURE [dbo].[sp_modificarEstadoSolicitud]

--Parametros
@idSolicitud int,
@estado nvarchar(30)
	
AS
BEGIN

	BEGIN TRY
	
		UPDATE dbo.Solicitud SET FK_idEstadoSolicitud = (SELECT idEstadoSolicitud FROM dbo.EstadoSolicitud where EstadoSolicitud = @estado)
		where idSolicitud = @idSolicitud
	
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