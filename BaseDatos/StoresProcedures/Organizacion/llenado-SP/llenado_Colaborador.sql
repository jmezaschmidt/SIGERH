
exec sp_crearColaborador 'Javier', 'Meza', 'Schmidt', '3452706', '1991/04/20', 'Administrador'
exec sp_crearColaborador 'Alejandra', 'Monge', 'Granados', '3450160', '1990/12/13', 'Administrador'
exec sp_crearColaborador 'Mauricio', 'Munoz', 'Chaves', '114740899', '1991/01/01', 'Administrador'


Select * FROM dbo.Colaborador INNER JOIN dbo.Usuario ON idColaborador = FK_idColaborador 
INNER JOIN dbo.RolesXUsuario ON idUsuario = FK_idUsuario INNER JOIN dbo.TipoUsuario ON idTipoUsuario = FK_idTipoUsuario

Select * From dbo.Colaborador
Select * From dbo.Usuario
Select * From dbo.RolesXUsuario
