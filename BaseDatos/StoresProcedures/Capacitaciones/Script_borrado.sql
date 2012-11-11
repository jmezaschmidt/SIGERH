DELETE FROM dbo.CapacitacionesXExpediente


DELETE FROM dbo.Capacitacion
DBCC CHECKIDENT('dbo.Capacitacion', RESEED, 0)

