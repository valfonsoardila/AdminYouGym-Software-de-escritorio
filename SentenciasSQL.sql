--Crea base de datos
create database AdminYouGym

--Eliminar base de datosdrop database AdminPharm
drop database AdminYouGym
--Eliminar un dato de la base de datos
delete from PRODUCTO where Referencia='';
--Usar y seleccionar una base de datos
use AdminYouGym
--Tablas de la base de datos
create table SOFTWARE(
Nombre_De_Software varchar(30) primary key not null,
Fecha_De_Instalacion datetime not null,
Fecha_De_Expiracion varchar(12) not null,
Hora_De_Expiracion varchar(15) not null,
Fecha_De_Activacion varchar(12) not null,
Hora_De_Activacion varchar(15) not null,
Estado_De_Licencia varchar(10) not null,
);
create table LICENCIA(
Licencia nvarchar(30) not null
);
create table CAJA(
Id_Caja varchar(12) primary key not null,
Fecha_De_Apertura varchar(20) not null,
Hora_De_Apertura varchar(15)not null,
Fecha_De_Cierre varchar(20) not null,
Hora_De_Cierre varchar(15)not null,
Estado varchar(10) not null,
Monto_Inicial int,
Monto_Final int,
Venta_Del_Dia int
);
create table CLIENTE(
Id varchar(12) primary key not null,
Codigo_Cliente nvarchar(10) not null,
Tipo_De_Id char(2)not null,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int,
Sexo varchar(5),
Direccion_Domicilio text,
Telefono varchar(15),
Correo varchar(100)
);
create table PRODUCTO(
Cantidad int not null,
Referencia nvarchar(100) primary key not null,
Nombre varchar(100)not null,
Detalle text,
Fecha_De_Registro datetime not null,
Fecha_De_Vencimiento datetime not null,
Lote nvarchar(100) not null,
Marca varchar(80)not null,
Estado varchar(12),
Tipo varchar(20),
Valor_Por_Unidad int,
Valor_Por_Blister int,
Valor_Por_Caja int,
Porcentaje_De_Venta int,
Precio_De_Negocio int,
Precio_De_Venta int,
Ganancia_Por_Producto int,
Ubicacion varchar(12)not null
);