CREATE PROCEDURE [dbo].[CrearUsuario]
	@Nombre NVARCHAR(100) ,
	@Fecha_Nacimiento DATE,
	@Sexo CHAR(1)
	
AS
	INSERT INTO Usuarios (Nombre,Fecha_Nacimiento,Sexo)
	VALUES (@Nombre, @Fecha_Nacimiento, @Sexo)

	SELECT * FROM Usuarios WHERE Id = SCOPE_IDENTITY()

	
	
RETURN