
exec sp_crearExpediente 3452706
exec sp_crearExpediente 3450160
exec sp_crearExpediente 114740899

Select * From dbo.Expediente INNER JOIN dbo.Colaborador ON idColaborador = FK_idColaborador