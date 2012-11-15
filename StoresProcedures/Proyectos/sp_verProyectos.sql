CREATE PROCEDURE [dbo].[sp_verProyectos]
	
AS
BEGIN
	BEGIN TRY
		
		SELECT nombre, descripcion, fechaInicio, fechaFinal, EstadoProyecto FROM dbo.Proyecto INNER JOIN dbo.EstadoProyecto ON idEstadoProyecto = FK_idEstadoProyecto		
	
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