CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nombre] NVARCHAR(100) NOT NULL,
	[Fecha_Nacimiento] DATE NOT NULL,
	[Sexo] CHAR(1) NOT NULL, 
    CONSTRAINT [CK_Usuarios_Sexo] CHECK ([Sexo] = 'H' OR [Sexo] = 'M')
)
