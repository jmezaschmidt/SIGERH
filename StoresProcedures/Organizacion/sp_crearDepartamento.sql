ALTER PROCEDURE [dbo].[sp_crearDepartamento]

--Parametros
@nombre nvarchar(50),
@descripcion nvarchar(100),
@padre nvarchar(50)
	
AS
BEGIN
	BEGIN TRY
		
		DECLARE @resultado bit
		SET @resultado = 1
		
		INSERT into dbo.Departamento(nombre, descripcion, habilitado, FK_idDepartamentoPadre) values (@nombre, @descripcion, 1,
		(Select idDepartamento FROM dbo.Departamento where nombre = @padre))	
		
		Select @resultado 
	
	END TRY
	
	BEGIN CATCH
		declare @ErrorNumber int = ERROR_NUMBER()
		declare @ErrorSeverity int = ERROR_SEVERITY()
		declare @ErrorState int = ERROR_STATE()
		declare @Message nvarchar(200) = ERROR_MESSAGE()
		Select @resultado
	END CATCH		
END
GO