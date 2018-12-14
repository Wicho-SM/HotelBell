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
  habitacion varchar(4),
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


CREATE TABLE habitacion (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  habitacion varchar(4),
  ocupada boolean
);

INSERT INTO habitacion VALUES (null, "PB01", false),
                              (null, "PB02", false),
                              (null, "PB03", false),
                              (null, "PB04", false),
                              (null, "PB05", false),
                              (null, "PB06", false),
                              (null, "PB07", false),
                              (null, "PB08", false),
                              (null, "PB09", false),
                              (null, "PB10", false),
                              (null, "PB11", false),
                              (null, "PB12", false),
                              (null, "PB13", false),
                              (null, "PB14", false),
                              (null, "PA01", false),
                              (null, "PA02", false),
                              (null, "PA03", false),
                              (null, "PA04", false),
                              (null, "PA05", false),
                              (null, "PA06", false),
                              (null, "PA07", false),
                              (null, "PA08", false),
                              (null, "PA09", false),
                              (null, "PA10", false),
                              (null, "PA11", false);
