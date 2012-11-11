CREATE PROCEDURE [dbo].[sp_modificarEstadoDepartamentoJefe]

--Parametros
@nombre nvarchar(50),
@cedula int,
@estado bit
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.JefesXDepartamento SET habilitado = @estado where 
		FK_idColaborador = (SELECT idColaborador FROM dbo.Colaborador where cedula = @cedula) AND
		FK_idDepartamento = (SELECT idDepartamento FROM dbo.Departamento where nombre = @nombre)
		
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