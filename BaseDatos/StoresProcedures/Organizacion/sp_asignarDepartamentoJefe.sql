ALTER PROCEDURE [dbo].[sp_asignarDepartamentoJefe]

--Parametros
@nombre nvarchar(50),
@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		IF NOT EXISTS (SELECT cedula FROM dbo.Departamento 
						INNER JOIN dbo.JefesXDepartamento ON idDepartamento = FK_idDepartamento
						INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador
						where dbo.Departamento.nombre = @nombre AND cedula = @cedula)
				
		BEGIN
			INSERT INTO dbo.JefesXDepartamento(FK_idDepartamento, FK_idColaborador, habilitado) values
			((SELECT idDepartamento FROM dbo.Departamento where nombre = @nombre),
			(SELECT idColaborador FROM dbo.Colaborador where cedula = @cedula), 1) 
		END
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