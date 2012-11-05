ALTER PROCEDURE [dbo].[sp_verInfoExpediente]

@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		Select Colaborador.nombre + ' ' + apellido1 + ' ' + ' ' + apellido2 Nombre, cedula, fechaNacimiento, ISNULL(puesto, 'Sin asignar') Puesto, 
		ISNULL(Departamento.nombre, 'Sin asignar') Departamento, fechaCreacion Ingreso,
		CASE Expediente.habilitado
		WHEN 1 THEN 'Habilitado'
		WHEN 0 THEN 'Deshabilitado'
		END Habilitado FROM 
		dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador
		LEFT JOIN dbo.Puesto ON idPuesto = FK_idPuesto
		LEFT JOIN dbo.Departamento ON idDepartamento = FK_idDepartamento where cedula = @cedula
		
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		ROLLBACK
		RAISERROR (@Message, @ErrorNumber, @ErrorSeverity, @ErrorState)
	END CATCH		
END
GO