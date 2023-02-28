--Crea base de datos
create database YouGym
--Comando para eliminar(drop database YouGym)

use YouGym

create table CLIENTE(
Id varchar(12) primary key not null,
Tipo_De_Id char(2)not null,
Codigo_Cliente nvarchar(10) not null,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int not null,
Sexo varchar(5) not null,
Peso float not null,
Altura float not null,
Direccion_Domicilio text,
Telefono varchar(15),
Correo varchar(100),
Clasificacion_Por_Peso varchar(50),
IndMC float,
IndGC float,
IndMM float,
IndMO float,
IndMR float,
);

create table ENTRENADOR(
Id varchar(12) primary key not null,
Tipo_De_Id char(2)not null,
Codigo_Entrenador nvarchar(10) not null,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int not null,
Direccion_Domicilio text not null,
Sexo varchar(5) not null,
Salario int,
Horas_Extras_De_Trabajo int,
Dias_De_Trabajo int,
Meses_De_Contrato int,
Tipo_De_Contrato varchar(20)
);

create table SERVICIO(
Id_Plan_De_Ejercicio varchar(12) primary key not null,
Tipo_De_Tiempo varchar(10)not null,
Numero_DiasMeses int,
Fecha_De_Entreno datetime not null,
Sesion char(1) not null,
Objetivo varchar(40)not null,
Descripcion_Plan_Ejercicio varchar(100) not null,
Estado char(10),
Ciclo char(1),
Precio int
);

create table CAJA_REGISTRADORA(
Id_Caja varchar(12) primary key not null,
Fecha_De_Apertura datetime not null,
Fecha_De_Cierre datetime not null,
Estado varchar(10) not null,
Monto int
);