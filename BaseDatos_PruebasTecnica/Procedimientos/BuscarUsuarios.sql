CREATE PROCEDURE [dbo].[BuscarUsuarios]
	@skip int = 0,
	@take int,
	@Busqueda nvarchar(100)
AS
	SELECT * FROM Usuarios WHERE Nombre Like '%'+@busqueda+'%'
RETURN 0