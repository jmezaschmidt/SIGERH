exec sp_asignarPermiso 'Administrador','crear usuario'

Select * From dbo.TipoUsuario INNER JOIN dbo.PermisosXTipoUsuario ON idTipoUsuario = FK_idTipoUsuario