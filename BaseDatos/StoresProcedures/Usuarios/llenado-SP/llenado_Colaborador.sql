
exec sp_crearColaborador 'Javier', 'Meza', 'Schmidt', '1991/04/20', 'jmezaschmidt', '1234'
exec sp_crearColaborador 'Alejandra', 'Monge', 'Granados', '1990/12/13', 'alemg', '1234'
exec sp_crearColaborador 'Mauricio', 'Munoz', 'Chaves', '1991/01/01', 'mmunoz', '1234'


Select * From dbo.Colaborador INNER JOIN dbo.Usuario ON idColaborador = FK_idColaborador