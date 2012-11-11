exec sp_asignarRolUsuario 3452706, 'Colaborador'

Select * From dbo.Usuario INNER JOIN dbo.RolesXUsuario ON idUsuario = FK_idUsuario