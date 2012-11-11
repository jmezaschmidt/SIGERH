CREATE PROCEDURE [dbo].[sp_autenticarUsuario]

	@nickname nvarchar(40), 
	@password nvarchar(50), 
	@tipoUsuario nvarchar(40)
		
AS
BEGIN

	BEGIN TRY
	
	declare @passwordMD5 varbinary(50);
	declare @resultado bit;	
		
	set @passwordMD5 = HASHBYTES('MD5', @password);
	print @passwordMD5;
	
    set @resultado = isnull((select 1 from dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = dbo.Expediente.FK_idColaborador
							INNER JOIN dbo.Usuario ON idColaborador = dbo.Usuario.FK_idColaborador 
							INNER JOIN dbo.RolesXUsuario ON FK_idUsuario = idUsuario
							INNER JOIN dbo.TipoUsuario ON idTipoUsuario = FK_idTipoUsuario
							where nickname  = @nickname AND password = @passwordMD5 AND tipoUsuario = @tipoUsuario AND Expediente.habilitado = 1), 0);				
	
	select @resultado Resultado
	
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