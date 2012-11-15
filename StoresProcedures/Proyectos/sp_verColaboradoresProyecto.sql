ALTER PROCEDURE [dbo].[sp_verColaboradoresProyecto]

@nombre nvarchar(50)
	
AS
BEGIN
	BEGIN TRY
		Select Colaborador.nombre + ' ' + apellido1 + ' ' + ' ' + apellido2 Nombre, cedula, ISNULL(puesto, 'Sin asignar') Puesto, 
		ISNULL(Departamento.nombre, 'Sin asignar') Departamento FROM 
		dbo.Proyecto INNER JOIN dbo.ProyectosXExpediente ON idProyecto = FK_idProyecto
		INNER JOIN dbo.Expediente ON  idExpediente = FK_idExpediente
		INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador
		LEFT JOIN dbo.Puesto ON idPuesto = FK_idPuesto
		LEFT JOIN dbo.Departamento ON idDepartamento = FK_idDepartamento
		where Proyecto.nombre = @nombre
		
	
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