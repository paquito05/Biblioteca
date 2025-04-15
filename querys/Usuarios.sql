
INSERT INTO Usuarios (DNI, Nombres, Apellidos, Email, Telefono, TipoUsuario)
VALUES 
('12345678', 'Juan', 'Pérez', 'juan.perez@email.com', '987654321', 'Alumno'),
('87654321', 'María', 'Gómez', 'maria.gomez@email.com', '987654322', 'Alumno'),
('11223344', 'Carlos', 'López', 'carlos.lopez@email.com', '987654323', 'Docente'),
('44332211', 'Ana', 'Martínez', 'ana.martinez@email.com', '987654324', 'Docente');
        
               
INSERT INTO Libros (Nombre, Categoria, Autor, Pais, FechaPublicacion, Editorial)
VALUES 
('Cien años de soledad', 'Novela', 'Gabriel García Márquez', 'Colombia', '1967-05-30 10:00:00', 'Sudamericana'),
('El principito', 'Literatura infantil', 'Antoine de Saint-Exupéry', 'Francia', '1943-04-06 14:30:00', 'Reynal & Hitchcock'),
('1984', 'Ciencia ficción', 'George Orwell', 'Reino Unido', '1949-06-08 09:15:00', 'Secker & Warburg'),
('Don Quijote de la Mancha', 'Novela', 'Miguel de Cervantes', 'España', '1605-01-16 11:45:00', 'Francisco de Robles'),
('La ciudad y los perros', 'Novela', 'Mario Vargas Llosa', 'Perú', '1963-10-10 16:20:00', 'Seix Barral'),
('Rayuela', 'Novela', 'Julio Cortázar', 'Argentina', '1963-06-28 13:10:00', 'Sudamericana');
        
INSERT INTO Prestamos (UsuarioID, LibroID, FechaPrestamo, FechaDevolucion, TipoPrestamo, Estado)
VALUES 
(1, 1, '2023-11-01 09:30:00', '2023-11-02 09:45:00', 'Domicilio', 'Devuelto'),
(3, 2, '2023-11-05 14:15:00', NULL, 'Biblioteca', 'Activo'),
(2, 4, '2023-11-03 11:20:00', '2023-11-04 10:05:00', 'Domicilio', 'Devuelto');