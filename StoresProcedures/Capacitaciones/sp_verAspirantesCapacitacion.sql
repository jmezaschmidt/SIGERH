ALTER PROCEDURE [dbo].[sp_verAspirantesCapacitacion]

@idCapacitacion int
	
AS
BEGIN

	BEGIN TRY
		
		Select Colaborador.nombre + ' ' + apellido1 + ' ' + ' ' + apellido2 Nombre, cedula, ISNULL(puesto, 'Sin asignar') Puesto, 
		ISNULL(Departamento.nombre, 'Sin asignar') Departamento 
		FROM dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador
		LEFT JOIN dbo.Puesto ON idPuesto = FK_idPuesto
		LEFT JOIN dbo.Departamento ON idDepartamento = FK_idDepartamento			
		Except
		(
			Select Colaborador.nombre + ' ' + apellido1 + ' ' + ' ' + apellido2 Nombre, cedula, ISNULL(puesto, 'Sin asignar') Puesto, 
			ISNULL(Departamento.nombre, 'Sin asignar') Departamento 
			FROM dbo.CapacitacionesXExpediente INNER JOIN dbo.Expediente ON idExpediente = FK_idExpediente
			INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador
			LEFT JOIN dbo.Puesto ON idPuesto = FK_idPuesto
			LEFT JOIN dbo.Departamento ON idDepartamento = FK_idDepartamento
			where FK_idCapacitacion = @idCapacitacion
		)		
				
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