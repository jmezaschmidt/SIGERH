

exec sp_asignarProyectoColaborador 'SIGERH', 3450160

Select * FROm dbo.Colaborador
Select * FROm dbo.Expediente

exec sp_verAspirantesProyecto 'SIGERH'