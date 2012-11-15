CREATE PROCEDURE [dbo].[sp_modificarEstadoDepartamento]

--Parametros
@nombre nvarchar(50),
@estado bit
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.Departamento SET habilitado = @estado where idDepartamento = (SELECT idDepartamento FROM dbo.Departamento where nombre = @nombre)
		
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