GO

CREATE VIEW LibroCorto AS
SELECT Id,Nombre
FROM Libro

GO

CREATE FUNCTION LongitudDeTituloEnLibros()
RETURNS
@LongitudDeLibros TABLE(
	NombreDeLibro nvarchar(MAX) NOT NULL, 
	LongitudDelNombre INT NOT NULL
)
BEGIN
	INSERT INTO @LongitudDeLibros
	SELECT Nombre, LEN(Nombre)
	FROM Libro
	RETURN
END

