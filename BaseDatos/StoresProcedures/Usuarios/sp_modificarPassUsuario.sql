ALTER PROCEDURE [dbo].[sp_modificarPassUsuario]

@cedula int,
@password nvarchar(50) 
	
AS
BEGIN
	BEGIN TRY
		
		UPDATE dbo.Usuario SET password = HashBytes('MD5', @password) 
		where idUsuario = (SELECT idUsuario FROM dbo.Colaborador INNER JOIN dbo.Usuario ON idColaborador = FK_idColaborador where cedula = @cedula)
	
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