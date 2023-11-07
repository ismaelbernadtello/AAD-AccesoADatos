-- Insertar el primer registro
INSERT INTO Alumnos (Nombre, Email, Foto, CursoID)
VALUES ('Alberto Saz', 'saz@zaragoza.salesianos.edu', 'Alberto.jpg', 1);

-- Insertar el segundo registro
INSERT INTO Alumnos (Nombre, Email, Foto, CursoID)
VALUES ('Jesús Montero', 'montero@zaragoza.salesianos.edu', 'Jesus.jpg', 2);

-- Insertar el tercer registro
INSERT INTO Alumnos (Nombre, Email, Foto, CursoID)
VALUES ('Ismael Bernad', 'bernad@zaragoza.salesianos.edu', 'Ismael2.jpg', 3);

-- Insertar el cuarto registro
INSERT INTO Alumnos (Nombre, Email, Foto, CursoID)
VALUES ('Ismael Abed', 'abed@zaragoza.salesianos.edu', 'Isma1.jpg', 4);


SELECT * FROM Alumnos;

DELETE FROM Alumnos WHERE Id = 2;

