CREATE PROCEDURE [dbo].[sp_crearCapacitacion]

@nombre nvarchar(50),
@descripcion nvarchar(100),
@duracion int
	
AS
BEGIN

	BEGIN TRY
		
		INSERT INTO dbo.Capacitacion(nombre, descripcion, duracion)
		values (@nombre, @descripcion, @duracion)
		
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