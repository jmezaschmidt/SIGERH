CREATE PROCEDURE [dbo].[sp_crearDepartamento]

--Parametros
@nombre nvarchar(50),
@descripcion nvarchar(100)
	
AS
BEGIN
	BEGIN TRY
		
		INSERT into dbo.Departamento(nombre, descripcion, habilitado) values (@nombre, @descripcion, 1)	
		Select 1
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		Select 0
	END CATCH		
END
GO