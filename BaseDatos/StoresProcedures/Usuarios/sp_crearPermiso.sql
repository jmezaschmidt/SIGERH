CREATE PROCEDURE [dbo].[sp_crearPermiso]

--Parametros
@permiso nvarchar(40)
	
AS
BEGIN

INSERT into dbo.Permisos(permiso) values (@permiso)
		
END
GO