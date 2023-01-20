CREATE PROCEDURE [dbo].[EliminarUsuario]
	@ID int
AS
	DELETE FROM Usuarios WHERE Id = @ID
RETURN 0