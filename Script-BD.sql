create database DBTp;
use DBTp;

create table Sucursal(
	idSuc int identity(1,1) not null UNIQUE,
	Telefono varchar(100) null,
	Direccion varchar(100) not null,
	primary key(idSuc)
);

create table Empleado(
	idEmpleado int identity(1,1) not null UNIQUE,
	Nombre varchar(100) not null,
	Apellido varchar(150) not null,
	Puesto varchar(50) not null,
	idSuc int not null,
	Email varchar(150) not null,
	Pass varchar(200),
	Soft_Delete tinyint not null,
	primary key(idEmpleado),
	foreign key(idSuc) references Sucursal(idSuc)
);

SELECT *
FROM Sucursal;
SELECT *
FROM Empleado;


DELETE FROM Empleado;
