ALTER PROCEDURE [dbo].[sp_verAspirantesProyecto]

@nombre nvarchar(50)
	
AS
BEGIN
	BEGIN TRY
		
		SELECT Colaborador.nombre +' '+ apellido1 +' '+apellido2 Colaborador, cedula, ISNULL(puesto, 'Sin asignar')
		FROM dbo.Puesto RIGHT JOIN dbo.Colaborador ON idPuesto = FK_idPuesto
		INNER JOIN dbo.Expediente ON idColaborador = FK_idColaborador
		INNER JOIN dbo.ProyectosXExpediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Proyecto ON idProyecto = FK_idProyecto where Proyecto.nombre != @nombre
		
	
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