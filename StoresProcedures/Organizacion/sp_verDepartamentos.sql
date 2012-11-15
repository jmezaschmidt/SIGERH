ALTER PROCEDURE [dbo].[sp_verDepartamentos]

--Parametros

AS
BEGIN
	BEGIN TRY
		
		Select e1.nombre Departamento, e1.descripcion Descripcion, e1.habilitado Habilitado, ISNULL(e2.nombre, 'Sin asignar')  DepartamentoPadre
		FROM dbo.Departamento e1 LEFT JOIN dbo.Departamento e2 ON e1.FK_idDepartamentoPadre = e2.idDepartamento
	
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