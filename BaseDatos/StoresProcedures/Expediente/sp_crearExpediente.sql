CREATE PROCEDURE [dbo].[sp_crearExpediente]

--Parametros
@idUsuario int
	
AS
BEGIN

INSERT into dbo.Expediente(fechaCreacion, habilitado, FK_idColaborador) values (GETDATE(), 1, @idUsuario)
		
END
GO