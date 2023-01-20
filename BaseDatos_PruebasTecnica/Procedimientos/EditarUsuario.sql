CREATE PROCEDURE [dbo].[EditarUsuario]
	@id INT,
	@Nombre NVARCHAR(100),
	@Fecha_Nacimiento DATE,
	@Sexo CHAR(1)
AS
	UPDATE Usuarios
	SET Nombre = @Nombre,
		Fecha_Nacimiento = @Fecha_Nacimiento,
		Sexo = @Sexo
	WHERE ID = @id
	
	SELECT * FROM Usuarios WHERE ID = @id
RETURN