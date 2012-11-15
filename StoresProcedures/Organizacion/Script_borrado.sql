DELETE FROM dbo.Puesto
DBCC CHECKIDENT('dbo.Puesto', RESEED, 0)

DELETE FROM dbo.Departamento
DBCC CHECKIDENT('dbo.Departamento', RESEED, 0)
