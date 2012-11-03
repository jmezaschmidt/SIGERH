CREATE PROCEDURE [dbo].[sp_asignarPermiso]

--Parametros
@tipoUsuario nvarchar(40),
@permiso nvarchar(40)
	
AS
BEGIN

INSERT into dbo.PermisosXTipoUsuario(FK_idTipoUsuario, FK_idPermiso) values 
((Select idTipoUsuario FROM dbo.TipoUsuario where tipoUsuario = @tipoUsuario), (Select idPermiso FROM dbo.Permisos where permiso = @permiso))
		
END
GO