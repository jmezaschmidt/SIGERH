

exec sp_crearExpediente 1

Select * From dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador