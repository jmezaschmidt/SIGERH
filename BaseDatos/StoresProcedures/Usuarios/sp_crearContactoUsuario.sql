ALTER PROCEDURE [dbo].[sp_crearContactoUsuario]

@cedula int,
@valor nvarchar(30),
@tipoContacto nvarchar(20)
	
AS
BEGIN

	BEGIN TRY
		
		INSERT INTO dbo.ContactosXColaborador (Valor, FK_idTipoContacto, FK_idColaborador)
		values (@valor, (Select idTipoContacto FROM dbo.TipoContacto where tipoContacto = @tipoContacto), (Select idColaborador FROM dbo.Colaborador where cedula = @cedula))
		
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