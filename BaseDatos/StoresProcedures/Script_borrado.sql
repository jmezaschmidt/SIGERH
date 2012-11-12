DELETE FROM dbo.JefesXDepartamento

DELETE FROM dbo.RolesXUsuario

DELETE FROM dbo.Solicitud
DBCC CHECKIDENT('dbo.Solicitud', RESEED, 0)

DELETE FROM dbo.Ausencia
DBCC CHECKIDENT('dbo.Ausencia', RESEED, 0)

DELETE FROM dbo.Contrato
DBCC CHECKIDENT('dbo.Contrato', RESEED, 0)

DELETE FROM dbo.CapacitacionesXExpediente

DELETE FROM dbo.Capacitacion
DBCC CHECKIDENT('dbo.Capacitacion', RESEED, 0)

DELETE FROM dbo.ProyectosXExpediente

DELETE FROM dbo.Proyecto
DBCC CHECKIDENT('dbo.Proyecto', RESEED, 0)

DELETE FROM dbo.Expediente
DBCC CHECKIDENT('dbo.Expediente', RESEED, 0)

DELETE FROM dbo.Usuario
DBCC CHECKIDENT('dbo.Usuario', RESEED, 0)

DELETE FROM dbo.ContactosXColaborador

DELETE FROM dbo.TipoContacto
DBCC CHECKIDENT('dbo.TipoContacto', RESEED, 0)

DELETE FROM dbo.Colaborador
DBCC CHECKIDENT('dbo.Colaborador', RESEED, 0)

DELETE FROM dbo.Departamento
DBCC CHECKIDENT('dbo.Departamento', RESEED, 0)

DELETE FROM dbo.Puesto
DBCC CHECKIDENT('dbo.Puesto', RESEED, 0)

DELETE FROM dbo.PermisosXTipoUsuario

DELETE FROM dbo.TipoUsuario
DBCC CHECKIDENT('dbo.TipoUsuario', RESEED, 0)

DELETE FROM dbo.Permisos
DBCC CHECKIDENT('dbo.Permisos', RESEED, 0)
