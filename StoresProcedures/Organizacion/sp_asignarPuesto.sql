CREATE PROCEDURE [dbo].[sp_asignarPuesto]

--Parametros
@cedula int,
@puesto nvarchar(50)
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.Colaborador SET FK_idPuesto = (Select idPuesto FROM dbo.Puesto where puesto = @puesto) 
		where idColaborador = (Select idColaborador FROM dbo.Colaborador where cedula = @cedula)
	
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