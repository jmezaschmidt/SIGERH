
exec sp_crearTipoUsuario 'Administrador'
exec sp_crearTipoUsuario 'Colaborador'
exec sp_crearTipoUsuario 'Direccion RH'
exec sp_crearTipoUsuario 'Jefe'

Select * From TipoUsuario;