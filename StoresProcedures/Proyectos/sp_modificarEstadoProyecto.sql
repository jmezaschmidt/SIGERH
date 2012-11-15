CREATE PROCEDURE [dbo].[sp_modificarEstadoProyecto]

@nombre nvarchar(50),
@estado nvarchar(20)
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.Proyecto SET FK_idEstadoProyecto = (Select idEstadoProyecto FROM dbo.EstadoProyecto where EstadoProyecto = @estado)
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