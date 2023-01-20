CREATE PROCEDURE [dbo].[GetUsuarios]
	@skip int = 0,
	@take int = 20
AS
	SELECT * FROM Usuarios 
	ORDER BY Nombre DESC
	OFFSET @Skip ROWS
	FETCH NEXT @take ROWS ONLY;
RETURN 0