DROP DATABASE hotel_reservaciones;
CREATE DATABASE hotel_reservaciones;
USE hotel_reservaciones;

CREATE TABLE reservaciones (
  id_resevacion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  nombre varchar(150),
  telefono varchar(12),
  ciudad varchar(50),
  estado varchar(30),
  email varchar(100),
  fechaIngreso date,
  fechaSalida date,
  adultos int(1),
  ninos int(2),
  habitacion int(2),
  entrada boolean,
  salida boolean
);

CREATE TABLE usuarios (
  id_usuarios INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  usuario  varchar(30),
  contrasena varchar(25),
  tipo_usuario enum("administrador","recepcionista")
);


INSERT INTO usuarios VALUES (null,"admin","admin","1");
INSERT INTO usuarios VALUES (null,"user","user","2");
