
USE GestionLaboratorios

CREATE TABLE Sede (
    id INT PRIMARY KEY IDENTITY,
    nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Laboratorio (
    id INT PRIMARY KEY IDENTITY,
    nombre NVARCHAR(100) NOT NULL,
    capacidad INT NOT NULL,
    sede_id INT FOREIGN KEY REFERENCES Sede(id)
);

CREATE TABLE Computadora (
    id INT PRIMARY KEY IDENTITY,
    codigo NVARCHAR(50) NOT NULL,
    condicion NVARCHAR(50) NOT NULL,
    ubicacion NVARCHAR(100) NOT NULL,
    laboratorio_id INT FOREIGN KEY REFERENCES Laboratorio(id)
);

CREATE TABLE Ticket (
    id INT PRIMARY KEY IDENTITY,
    codigoPC NVARCHAR(50) NOT NULL,
    condicion NVARCHAR(50) NOT NULL,
    urgencia NVARCHAR(50) NOT NULL,
    ubicacion NVARCHAR(100) NOT NULL,
    computadora_id INT FOREIGN KEY REFERENCES Computadora(id),
	laboratorio_id INT FOREIGN KEY REFERENCES Laboratorio(id)
);
