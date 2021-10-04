# Factura.WebAPI
Prueba tecnica
Cuenta con aquitectura N capas, de las cuales se realiza la creacion de cinco capas.	
Se utiliza como intermediario entre base de datos y el API, Entity Framework.
Para el control de excepciones se crea una Middleware globalizado el cual es capaz de obtener todas las excepciones que genera la API en su ejecuccion.
Se utiliza la inyeccion de dependencias.
Tambien se implementan princios SOLID.
La base de datos que se usa es SQL Server 2012.

Script base de datos
create database pruebaTecnica
go
use pruebaTecnica
go 
create table Facturas(
idFactura bigint primary key identity (1,1),
numeroFactura bigint not null,
fecha datetime not null,
tipoDePago int not null,
documentoCliente bigint,
nombreCliente varchar(50),
subtotal decimal(8,0),
descuento decimal(8,0),
iva decimal(8,0),
totalDescuento decimal(8,0),
totalImpuesto decimal(8,0),
total decimal(8,0))

create table productos(
idProducto bigint,
Producto varchar(20))
