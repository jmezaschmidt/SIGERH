CREATE PROCEDURE [dbo].[sp_crearTipoUsuario]

--Parametros
@tipoUsuario nvarchar(40)
	
AS
BEGIN

INSERT into dbo.TipoUsuario (tipoUsuario) values (@tipoUsuario)
		
END
GO