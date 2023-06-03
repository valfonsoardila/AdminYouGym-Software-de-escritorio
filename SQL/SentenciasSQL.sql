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
create table GIMNASIO(
Id_Gimnasio nvarchar(6) primary key not null,
Nombre_De_Gimnasio nvarchar(100)not null,
NIT nvarchar(50)not null,
CodigoCamara varchar(6)not null,
Frase_Distintiva text,
Regimen varchar(20)not null,
PBX nvarchar(30),
Direccion nvarchar(100),
Telefono varchar(15)
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
create table ADMINISTRADOR(
Id varchar(12) primary key not null,
Tipo_De_Id char(2)not null,
ImagenPerfil image,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int,
Sexo varchar(5),
Direccion_Domicilio text,
Telefono varchar(15),
Correo varchar(100),
Rol varchar(14),
);
create table EMPLEADO(
Id varchar(12) primary key not null,
Tipo_De_Id char(2)not null,
ImagenPerfil image,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int,
Sexo varchar(5),
Direccion_Domicilio text,
Telefono varchar(15),
Correo varchar(100),
Rol varchar(14),
);
create table CLIENTE(
Id varchar(12) primary key not null,
Codigo_Cliente nvarchar(10) not null,
Tipo_De_Id char(2)not null,
ImagenPerfil image,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int,
Sexo varchar(5),
Direccion_Domicilio text,
Telefono varchar(15),
Correo varchar(100),
Peso float not null,
Altura float not null,
Clasificacion_Por_Peso varchar(50),
Indice_Masa_Corporal float,
Indice_Grasa_Corporal float,
Indice_Masa_Muscular float,
Indice_Masa_Osea float,
Indice_Masa_Residual float,
);
create table MEMBRESIA(
CodigoMiembro varchar(12) primary key not null,
Categoria varchar(12) not null,
Estado varchar(12) not null,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
NombrePlan varchar(70)not null,
Creditos int,
ValorInscripcion int,
ValorMensual int,
Abono int,
Saldo int,
);
create table ENTRENADOR(
Id varchar(12) primary key not null,
Tipo_De_Id char(2)not null,
Codigo_Entrenador nvarchar(10) not null,
ImagenPerfil image,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int not null,
Sexo varchar(5) not null,
Direccion_Domicilio text not null,
Telefono varchar(15),
Correo varchar(100),
Salario int,
Horas_Extras_De_Trabajo int,
Dias_De_Trabajo int,
Meses_De_Contrato int,
Tipo_De_Contrato varchar(20)
);

create table PLAN_EJERCICIO(
Id_Plan_De_Ejercicio varchar(12) primary key not null,
Tipo_De_Tiempo varchar(10)not null,
Numero_DiasMeses int,
Fecha_De_Entreno datetime not null,
Jornada varchar(30) not null,
Objetivo varchar(40)not null,
Descripcion_Plan_Ejercicio varchar(100) not null,
Estado char(10),
Ciclo char(1),
Precio int
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
create table USUARIO(
CodigoUsuario nvarchar(20) primary key not null,
ImagenPerfil image,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Correo varchar(100) not null,
Rol varchar(14) not null,
NombreUsuario varchar(15) not null,
Contraseña varchar(30) not null,
);
