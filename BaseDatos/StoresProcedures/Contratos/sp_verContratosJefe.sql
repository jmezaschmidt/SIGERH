CREATE PROCEDURE [dbo].[sp_verContratosJefe]

@departamento nvarchar(50)
	
AS
BEGIN
	BEGIN TRY
	
		SELECT cedula, Colaborador.nombre +' '+ apellido1 +' '+apellido2, cantidadHorasLaborales, Contrato.fechaCreacion, Expediente.habilitado 
		FROM dbo.Contrato INNER JOIN dbo.Expediente ON idExpediente = FK_idExpediente
		INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador 
		INNER JOIN dbo.Departamento ON idDepartamento = FK_idDepartamento 
		where Departamento.nombre = @departamento AND Contrato.habilitado = 1
		
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