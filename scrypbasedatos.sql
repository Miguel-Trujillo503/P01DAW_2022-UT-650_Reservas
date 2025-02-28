CREATE DATABASE ParqueoDB;
GO

USE ParqueoDB;
GO

CREATE TABLE Usuarios (
    UsuarioId INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100),
    Correo VARCHAR(100) UNIQUE,
    Telefono VARCHAR(20),
    Contraseña VARCHAR(200),
    Rol VARCHAR(50) CHECK (Rol IN ('Cliente', 'Empleado'))
);

CREATE TABLE Sucursales (
    SucursalId INT PRIMARY KEY IDENTITY,
    NombreSucursal VARCHAR(200),
    Direccion VARCHAR(300),
    Telefono VARCHAR(20),
    AdministradorId INT,
    EspaciosDisponibles INT,
    FOREIGN KEY (AdministradorId) REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE EspaciosParqueo (
    EspacioId INT PRIMARY KEY IDENTITY,
    SucursalId INT,
    NumeroEspacio VARCHAR(10),
    Ubicacion VARCHAR(100),
    CostoPorHora DECIMAL(10,2),
    Estado VARCHAR(20) CHECK (Estado IN ('Disponible', 'Ocupado')),
    FOREIGN KEY (SucursalId) REFERENCES Sucursales(SucursalId)
);

CREATE TABLE Reservas (
    ReservaId INT PRIMARY KEY IDENTITY,
    UsuarioId INT,
    EspacioId INT,
    Fecha DATE,
    HoraInicio TIME,
    CantidadHoras INT,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId),
    FOREIGN KEY (EspacioId) REFERENCES EspaciosParqueo(EspacioId)
);


SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EspaciosParqueo';
