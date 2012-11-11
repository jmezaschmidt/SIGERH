
exec sp_asignarCapacitacionColaborador 1, 3452706, '2012/11/01', '2013/01/10'


Select * From dbo.Proyecto INNER JOIN dbo.CapacitacionesXProyecto ON idProyecto = FK_idProyecto