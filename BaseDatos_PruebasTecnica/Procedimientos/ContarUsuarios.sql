CREATE PROCEDURE [dbo].[ContarUsuarios]
AS
	SELECT COUNT(*) AS 'CantidadUsuarios' FROM Usuarios
RETURN 0