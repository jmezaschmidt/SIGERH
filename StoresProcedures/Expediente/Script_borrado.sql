DELETE FROM dbo.Solicitud
DBCC CHECKIDENT('dbo.Solicitud', RESEED, 0)

DELETE FROM dbo.TipoSolicitud
DBCC CHECKIDENT('dbo.TipoSolicitud', RESEED, 0)

DELETE FROM dbo.EstadoSolicitud
DBCC CHECKIDENT('dbo.EstadoSolicitud', RESEED, 0)

DELETE FROM dbo.Expediente
DBCC CHECKIDENT('dbo.Expediente', RESEED, 0)
