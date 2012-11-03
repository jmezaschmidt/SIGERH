DELETE FROM dbo.Expediente
DBCC CHECKIDENT('dbo.Expediente', RESEED, 0)
