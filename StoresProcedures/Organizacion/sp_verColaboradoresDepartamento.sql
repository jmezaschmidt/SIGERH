ALTER PROCEDURE [dbo].[sp_verColaboradesDepartamento]

@departamento nvarchar(50)

AS
BEGIN
	BEGIN TRY
		
		Select Colaborador.nombre + ' ' + apellido1 + ' ' + ' ' + apellido2 Nombre, cedula, ISNULL(puesto, 'Sin asignar') Puesto FROM 
		dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador
		LEFT JOIN dbo.Puesto ON idPuesto = FK_idPuesto
		LEFT JOIN dbo.Departamento ON idDepartamento = FK_idDepartamento where dbo.Expediente.habilitado = 1 AND Departamento.nombre = @departamento
	
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