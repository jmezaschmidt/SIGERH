exec sp_asignarRolUsuario 114740899, 'Administrador'

Select * From dbo.Usuario INNER JOIN dbo.RolesXUsuario ON idUsuario = FK_idUsuario
