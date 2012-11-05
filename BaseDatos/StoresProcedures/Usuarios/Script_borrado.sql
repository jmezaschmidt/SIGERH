DELETE FROM dbo.RolesXUsuario

DELETE FROM dbo.Usuario
DBCC CHECKIDENT('dbo.Usuario', RESEED, 0)

DELETE FROM dbo.Colaborador
DBCC CHECKIDENT('dbo.Colaborador', RESEED, 0)

DELETE FROM dbo.PermisosXTipoUsuario

DELETE FROM dbo.TipoUsuario
DBCC CHECKIDENT('dbo.TipoUsuario', RESEED, 0)

DELETE FROM dbo.Permisos
DBCC CHECKIDENT('dbo.Permisos', RESEED, 0)

DELETE FROM dbo.ContactosXColaborador

DELETE FROM dbo.TipoContacto
DBCC CHECKIDENT('dbo.TipoContacto', RESEED, 0)

