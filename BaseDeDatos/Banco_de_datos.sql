Drop database Banco_de_datos;
CREATE DATABASE Banco_de_datos;
USE Banco_de_datos;
SET LANGUAGE us_english

CREATE TABLE EMPLEADO(
id_identificador INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(50),
correo_institucional VARCHAR(75),
direccion_vivienda VARCHAR(75),
Usuario VARCHAR(50),
contasena VARCHAR(25),
Id_tipo INT
);

CREATE TABLE TIPO(
ID_tipo INT PRIMARY KEY IDENTITY,
tipo VARCHAR(25)
);

CREATE TABLE CITA (
ID_cita INT PRIMARY KEY IDENTITY,
fecha DATETIME,
identificador_cita int,
id_lugar INT,
id_hora INT,
id_identificador INT
);

CREATE TABLE LUGAR (
Id_lugar INT PRIMARY KEY IDENTITY,
lugar VARCHAR (100)
);

CREATE TABLE HORA (
Id_hora INT PRIMARY KEY IDENTITY,
hora TIME
);
CREATE TABLE CABINA(
ID_cabina INT PRIMARY KEY IDENTITY,
direccion VARCHAR(75),
Telefono VARCHAR (10),
Correo VARCHAR (100)
);

CREATE TABLE CABINAxEMPLEADO(
id_cabinaxempleado INT PRIMARY KEY IDENTITY,
id_cabina INT,
id_Identificador INT
);

CREATE TABLE CIUDADANO(
dui INT PRIMARY KEY,
nombre VARCHAR(100),
direccion_domicilio VARCHAR(75),
telefono VARCHAR(10),
correo_electronico VARCHAR(75),
Enfermedad varchar (100),
institucion varchar (100),
Id_vacunacion INT,
Id_Identificador INT
);


 

CREATE TABLE EMPLEADOxCIUDADANO(
id_empleadoxciudadano INT PRIMARY KEY IDENTITY,
id_identificador INT,
dui_ciudadano INT
);

CREATE TABLE ENFERMEDAD(
Id_enfermedad INT PRIMARY KEY IDENTITY,
enfermedad VARCHAR(100),
dui_ciudadano INT
);

CREATE TABLE IDENTIFICADOR(
ID_numero INT PRIMARY KEY IDENTITY,
Numero_identificador INT
);

CREATE TABLE VACUNACION(
ID_vacunacion INT PRIMARY KEY IDENTITY,
Fecha_Entrada DATETIME,
Fecha_salida DATETIME,
Tiempo TIME
);

CREATE TABLE EFECTO_SECUNDARIO(
ID_secundario INT PRIMARY KEY IDENTITY,
Efecto_secundario VARCHAR (100),
ID_vacunacion INT
); 

ALTER TABLE CABINAxEMPLEADO
ADD CONSTRAINT FK_CABINAxEMPLEADO_id_cabina
FOREIGN KEY (id_cabina) REFERENCES CABINA (ID_cabina);

ALTER TABLE CABINAxEMPLEADO
ADD CONSTRAINT FK_CABINAxEMPLEADO_id_identificador
FOREIGN KEY (id_Identificador) REFERENCES EMPLEADO (id_identificador);

ALTER TABLE EMPLEADO
ADD CONSTRAINT FK_EMPLEADO_ID_tipo
FOREIGN KEY (ID_tipo) REFERENCES TIPO (ID_tipo);

ALTER TABLE CITA
ADD CONSTRAINT FK_CITA_id_identificador
FOREIGN KEY (id_identificador) REFERENCES EMPLEADO (id_identificador);

ALTER TABLE CITA
ADD CONSTRAINT FK_CITA_id_lugar
FOREIGN KEY (id_lugar) REFERENCES LUGAR (ID_lugar);

ALTER TABLE CITA
ADD CONSTRAINT FK_CITA_id_hora
FOREIGN KEY (id_hora) REFERENCES HORA (ID_hora);

ALTER TABLE EMPLEADOxCIUDADANO
ADD CONSTRAINT FK_EMPLEADOxCIUDADANO_id_identificador
FOREIGN KEY (id_identificador) REFERENCES EMPLEADO(id_identificador);

ALTER TABLE EMPLEADOxCIUDADANO
ADD CONSTRAINT FK_EMPLEADOxCIUDADANO_dui_ciudadano
FOREIGN KEY (dui_ciudadano) REFERENCES CIUDADANO(dui);

ALTER TABLE ENFERMEDAD
ADD CONSTRAINT FK_ENFERMEDAD_dui_ciudadano
FOREIGN KEY (dui_ciudadano) REFERENCES CIUDADANO(dui);

ALTER TABLE CIUDADANO
ADD CONSTRAINT FK_CIUDADANO_Id_Identificador
FOREIGN KEY (Id_Identificador) REFERENCES IDENTIFICADOR(ID_numero);

ALTER TABLE CIUDADANO
ADD CONSTRAINT FK_VACUNACION_Id_vacunacion
FOREIGN KEY (Id_vacunacion) REFERENCES VACUNACION(ID_vacunacion);

ALTER TABLE EFECTO_SECUNDARIO
ADD CONSTRAINT FK_EFECTO_SECUNDARIO_Id_vacunacion
FOREIGN KEY (Id_vacunacion) REFERENCES VACUNACION(ID_vacunacion);



SET IDENTITY_INSERT EMPLEADO ON

INSERT INTO EMPLEADO(id_identificador,Nombre,correo_institucional,direccion_vivienda,Usuario,contasena)
VALUES(1,'Fernando Jose Lopez Avelar','00223519@covid.sv','Col.y Calle STA. Teresa#112','Fernan#1','lopez00223519')

SET IDENTITY_INSERT EMPLEADO OFF









