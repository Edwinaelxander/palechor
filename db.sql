-- Active: 1693604011540@@127.0.0.1@3306@a
CREATE DATABASE minimarket;



use minimarket;

CREATE TABLE Minimarket(
    idminimarket int AUTO_INCREMENT,
    nit VARCHAR(15) not NULL,
    razonSocial VARCHAR(50) not null,
    telefono VARCHAR(10) not null,
    nomenclatura VARCHAR(50) not null,
    ciudad VARCHAR(50) not null,
    departamento varchar(50) not null,
    correo varchar(50) not null,
    sitioweb varchar(50) not null,
    facebook varchar(50) not null,
    whatsapp varchar(50) not null,
    CONSTRAINT pkminimarket PRIMARY KEY (idminimarket),
    CONSTRAINT unico_nit UNIQUE (nit),
    CONSTRAINT unica_razon_social UNIQUE (razonSocial)
    );


CREATE TABLE Proveedor(
    idProveedor int AUTO_INCREMENT,
    nit VARCHAR(15) not null,
    razonSocial VARCHAR(50) not NULL,
    telefono VARCHAR(10) not NULL,
    correo VARCHAR(50) not NULL,
    nomenclatura VARCHAR(50) not NULL,
    ciudad VARCHAR(50) not NULL,
    CONSTRAINT pk_proveedor PRIMARY key(idProveedor),
    CONSTRAINT unico_nit_proveedor UNIQUE(nit),
    CONSTRAINT unico_razonSocial_proveedor UNIQUE (razonSocial)
);

CREATE TABLE Categoria(
    idcategoria int AUTO_INCREMENT,
    nombre varchar(50) not NULL,
    descripcion VARCHAR(100) not NULL,
    CONSTRAINT pkcategoria PRIMARY KEY (idcategoria),
    CONSTRAINT unico_nombre UNIQUE (nombre)
);
DROP TABLE cliente;
CREATE TABLE cliente(
    idcliente int AUTO_INCREMENT,
    tipodocument0 ENUM('cc','TI','PIP','PPT','PP'),
    identificacion VARCHAR(11) not NULL,
    nombres VARCHAR(50) not NULL,
    apellidos VARCHAR(10) not NULL,
    correoelectronico VARCHAR(50) not NULL,
    telefono VARCHAR(11) not NULL,
    CONSTRAINT pk_cliente PRIMARY KEY(idcliente),
    CONSTRAINT unico_identificacion UNIQUE(identificacion)
);

show tables;
CREATE TABLE producto(
    idProducto int AUTO_INCREMENT,
    nombre VARCHAR(50)NOT NULL,
    marca VARCHAR(50)NULL,
    stock INT DEFAULT 0,
    pvp INT NOT NULL DEFAULT 0,
    descripcion VARCHAR(200),
    unidadMedida ENUM("UND","GR"),
    idCategoria int not null,
    CONSTRAINT pk_idproducto PRIMARY KEY(idProducto),
    CONSTRAINT unico_nombre UNIQUE(nombre),
    CONSTRAINT FOREIGN key (idCategoria) REFERENCES Categoria (idcategoria)
);

CREATE TABLE Empleado(
    idEmpleado int AUTO_INCREMENT,
    tipoDoc ENUM('CC','TI','PAS','PEP','PPT','PPT','CE','Otros'),
    identificacion VARCHAR(11) not NULL,
    nombre VARCHAR(50) not NULL,
    apellido VARCHAR(50) not NULL,
    correo  VARCHAR(50) not NULL,
    celular VARCHAR(11) not NULL,
    clave VARCHAR(8) not NULL,
    idMinimarket int not NULL,
    CONSTRAINT pk_empleado PRIMARY KEY (idEmpleado),
    CONSTRAINT unico_identifecacion_empleado UNIQUE (identificacion),
    CONSTRAINT unico_correo_empleado UNIQUE(correo),    
    CONSTRAINT fk_idMinimarket FOREIGN KEY (idMinimarket) REFERENCES Minimarket (idminimarket)
);

CREATE Table factura(
    idFactura int AUTO_INCREMENT,
    codigoFactura varchar(8) not NULL,
    fechaGeneracion DATETIME not NULL,
    iva int not NULL,
    sinIva int not NULL,
    total int not NULL,
    idEmpleado int not NULL,
    idCliente int not NULL,
    CONSTRAINT pk_factura primary KEY (idFactura),
    CONSTRAINT inico_factura UNIQUE (codigoFactura),
    CONSTRAINT fk_empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado (idEmpleado),
    CONSTRAINT fk_cliente FOREIGN key (idCliente) REFERENCES Cliente(idCliente)
);

create table detalleFactura(
    idDetalleFactura int AUTO_INCREMENT,
    cantidadProdutos int not NULL,
    precioVenta int not NULL,
    subtotal int not NULL,
    idproducto int not NULL,
    idfactura int not NULL,
    CONSTRAINT pk_detalleFactura PRIMARY KEY (idDetalleFactura),
    CONSTRAINT fk_producto FOREIGN KEY (idProducto) REFERENCES Producto (idProducto),
    CONSTRAINT fk_factura FOREIGN KEY (idFactura) REFERENCES Factura (idFactura)
);