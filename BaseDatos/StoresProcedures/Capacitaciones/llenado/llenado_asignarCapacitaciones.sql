
exec sp_asignarCapacitacionProyecto 'SIGERH', 1, '2012/11/01', '2013/01/10'


Select * From dbo.Proyecto INNER JOIN dbo.CapacitacionesXProyecto ON idProyecto = FK_idProyecto