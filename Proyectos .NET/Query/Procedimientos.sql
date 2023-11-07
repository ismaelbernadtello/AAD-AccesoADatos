CREATE PROCEDURE GetAlumnoById
@Id int
as
BEGIN
    SELECT * FROM Alumnos
    WHERE Id = @Id
END


execute GetAlumnoById 3
