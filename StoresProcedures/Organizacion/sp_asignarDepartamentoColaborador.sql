CREATE PROCEDURE [dbo].[sp_asignarDepartamentoColaborador]

--Parametros
@nombre nvarchar(50),
@cedula int
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.Colaborador SET FK_idDepartamento = (Select idDepartamento FROM dbo.Departamento where nombre = @nombre) 
		where cedula = @cedula
	
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