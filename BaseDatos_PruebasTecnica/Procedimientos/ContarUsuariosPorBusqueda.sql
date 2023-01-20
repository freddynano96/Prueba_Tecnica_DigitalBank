CREATE PROCEDURE [dbo].[ContarUsuariosPorBusqueda]
	@Busqueda NVARCHAR(100)
AS
	SELECT COUNT(*) FROM Usuarios WHERE Nombre Like '%'+@busqueda+'%'
RETURN 0