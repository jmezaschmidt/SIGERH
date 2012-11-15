ALTER PROCEDURE [dbo].[sp_verProyecto]
@nombre nvarchar(50)	
AS
BEGIN
	BEGIN TRY
		
		SELECT descripcion, fechaInicio, fechaFinal, EstadoProyecto FROM dbo.Proyecto INNER JOIN dbo.EstadoProyecto ON idEstadoProyecto = FK_idEstadoProyecto		
		where nombre = @nombre
	
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