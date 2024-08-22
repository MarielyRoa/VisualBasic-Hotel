


USE Hotel;

IF OBJECT_ID('Usuarios', 'U') IS NOT NULL
    DROP TABLE Usuarios;

IF OBJECT_ID('Reservas', 'U') IS NOT NULL
    DROP TABLE Reservas;

IF OBJECT_ID('Habitaciones', 'U') IS NOT NULL
    DROP TABLE Habitaciones;

IF OBJECT_ID('Clientes', 'U') IS NOT NULL
    DROP TABLE Clientes;

CREATE TABLE Clientes (
    ID_Cliente INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Telefono VARCHAR(15),
    Email VARCHAR(100)
);
CREATE TABLE Usuarios (
    ID_Usuario INT PRIMARY KEY,
    Nombre_Usuario VARCHAR(50) NOT NULL,
    Contrasena VARCHAR(50) NOT NULL
);

-- Insertar datos de ejemplo en la tabla de usuarios
INSERT INTO Usuarios (ID_Usuario, Nombre_Usuario, Contrasena)
VALUES (1, 'admin', 'admin123'),
       (2, 'usuario', 'usuario123');

CREATE TABLE Habitaciones (
    ID_Habitacion INT PRIMARY KEY,
    Tipo VARCHAR(50) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL
);
CREATE TABLE Reservas (
    ID_Reserva INT PRIMARY KEY,
    ID_Cliente INT,
    ID_Habitacion INT,
    Fecha_Entrada DATE NOT NULL,
    Fecha_Salida DATE NOT NULL,
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente),
    FOREIGN KEY (ID_Habitacion) REFERENCES Habitaciones(ID_Habitacion)
);
INSERT INTO Clientes (ID_Cliente, Nombre, Apellido, Telefono, Email)
VALUES (1, 'Juan', 'Perez', '123456789', 'juan.perez@example.com'),
       (2, 'Maria', 'Garcia', '987654321', 'maria.garcia@example.com');
INSERT INTO Habitaciones (ID_Habitacion, Tipo, Precio)
VALUES (1, 'Individual', 50.00),
       (2, 'Doble', 75.00),
       (3, 'Suite', 150.00);
INSERT INTO Reservas (ID_Reserva, ID_Cliente, ID_Habitacion, Fecha_Entrada, Fecha_Salida)
VALUES (1, 1, 1, '2024-07-15', '2024-07-20'),
       (2, 2, 2, '2024-07-18', '2024-07-22');
SELECT COUNT(*) AS Habitaciones_Disponibles
FROM Habitaciones
WHERE Tipo = 'Doble' AND ID_Habitacion NOT IN (
    SELECT ID_Habitacion
    FROM Reservas
    WHERE (Fecha_Entrada <= '2024-07-19' AND Fecha_Salida >= '2024-07-16')
);
-- Verificar existencia de la reserva
SELECT COUNT(*) AS Reserva_Existe
FROM Reservas
WHERE ID_Reserva = 1;

-- Si la reserva existe, actualizamos
UPDATE Reservas
SET ID_Habitacion = 2, Fecha_Entrada = '2024-07-17', Fecha_Salida = '2024-07-21'
WHERE ID_Reserva = 1;
DELETE FROM Reservas
WHERE ID_Reserva = 1;


SELECT * FROM Clientes