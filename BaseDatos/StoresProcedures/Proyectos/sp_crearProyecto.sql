ALTER PROCEDURE [dbo].[sp_crearProyecto]

@nombre nvarchar(50),
@descripcion nvarchar(200)
	
AS
BEGIN
	BEGIN TRY
		
		INSERT INTO dbo.Proyecto (nombre, descripcion, fechaInicio, FK_idEstadoProyecto) values
		(@nombre, @descripcion, GETDATE(), (SELECT idEstadoProyecto FROM dbo.EstadoProyecto where EstadoProyecto = 'Detenido'))
		Select 1
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		Select 0
	END CATCH		
END
GO