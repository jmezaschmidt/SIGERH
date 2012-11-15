ALTER PROCEDURE [dbo].[sp_asignarDepartamentoPadre]

--Parametros
@nombre nvarchar(50),
@padre nvarchar(50)
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.Departamento SET FK_idDepartamentoPadre = (Select idDepartamento FROM dbo.Departamento where nombre = @padre) 
		where idDepartamento = (Select idDepartamento FROM dbo.Departamento where nombre = @nombre) 
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		PRINT @Message		
	END CATCH		
END
GO