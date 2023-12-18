/*Procedimiento para buscar los alumnos por id */
CREATE PROCEDURE GetAlumnoById
@Id int
as
BEGIN
    SELECT * FROM Alumnos
    WHERE Id = @Id
END


execute GetAlumnoById 3


/**/
CREATE PROCEDURE insertarAlumno
@Name NVARCHAR(50),
@Email NVARCHAR(50),
@Foto NVARCHAR(50),
@Curso int
AS
BEGIN
    INSERT INTO Alumnos(Nombre,Email,Foto,CursoID)
    VALUES (@Name, @Email, @Foto, @Curso)
END


EXECUTE insertarAlumno('prueba','dasda@gmail.com','a.png',2);