CREATE PROCEDURE [dbo].[ConsultarUsuario]
	@id int
AS
	SELECT * FROM Usuarios WHERE Id = @id
RETURN 0