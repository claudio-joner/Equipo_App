CREATE DATABASE EQUIPOS_FUTBOL
GO 
USE EQUIPOS_FUTBOL
GO

--CREACION DE TABLAS
CREATE TABLE PERSONAS(
ID INT IDENTITY(1,1),
NOMBRE VARCHAR(500) NOT NULL,
DNI INT NOT NULL,
FECHA_NACIMIENTO DATE NOT NULL,
CONSTRAINT PK_PERSONAS PRIMARY KEY(ID)
);

CREATE TABLE POSICIONES(
ID INT IDENTITY(1,1),
NOMBRE_POSICION VARCHAR(30),
CONSTRAINT PK_POSICIONES PRIMARY KEY(ID)
);

CREATE TABLE EQUIPOS(
ID INT IDENTITY(1,1),
NOMBRE VARCHAR(30) NOT NULL,
DIRECTOR_TECNICO VARCHAR(30) NOT NULL,
CONSTRAINT PK_EQUIPOS PRIMARY KEY(ID)
);

CREATE TABLE JUGADORES(
ID INT IDENTITY(1,1),
PERSONA INT NOT NULL,
CAMISETA INT NOT NULL,
POSICION INT NOT NULL, 
CONSTRAINT PK_JUGADORES PRIMARY KEY (ID),
CONSTRAINT FK_JUGADORES_PERSONAS FOREIGN KEY (PERSONA) REFERENCES PERSONAS(ID),
CONSTRAINT FK_JUGADORES_POSICION FOREIGN KEY (POSICION) REFERENCES POSICIONES(ID)
);

CREATE TABLE EQUIPOS_JUGADORES(
ID INT IDENTITY(1,1),
EQUIPO INT NOT NULL, 
JUGADOR INT NOT NULL,
CONSTRAINT PK_EQUIPOS_JUGADORES PRIMARY KEY(ID),
CONSTRAINT FK_EQUIPOS_JUGADORES_EQU FOREIGN KEY (EQUIPO) REFERENCES EQUIPOS(ID),
CONSTRAINT FK_EQUIPOS_JUGADORES_JUG FOREIGN KEY (JUGADOR) REFERENCES JUGADORES(ID),
CONSTRAINT UK_EQUIPO_JUGADORES UNIQUE (EQUIPO,JUGADOR)
);
--ALTER


--STORED PROCEDURES
GO
CREATE PROCEDURE SP_INSERTAR_PERSONAS
@nombre varchar(100),
@dni int,
@fecha_nac date
AS
BEGIN
	INSERT INTO PERSONAS(NOMBRE,DNI,FECHA_NACIMIENTO)
	VALUES (@nombre,@dni,@fecha_nac)
END

GO
CREATE PROCEDURE SP_CONSULTAR_PERSONAS
@nombre varchar(100),
@dni int
AS
BEGIN
	SELECT * FROM PERSONAS p WHERE  p.NOMBRE LIKE '%@nombre%' OR p.DNI = @dni
END

GO
CREATE PROCEDURE SP_LISTAR_PERSONAS

AS
BEGIN
	SELECT * FROM PERSONAS 
END

GO
CREATE PROCEDURE SP_LISTAR_POSICIONES
AS
BEGIN
	SELECT * FROM POSICIONES
END

GO
CREATE PROCEDURE SP_INSERTAR_JUGADORES
@persona int,
@camiseta int, 
@posicion int
AS
BEGIN
	INSERT INTO JUGADORES(PERSONA,CAMISETA,POSICION)
	VALUES (@persona,@camiseta,@posicion)
END
GO

CREATE PROCEDURE SP_LISTAR_JUGADORES
AS
BEGIN
	SELECT p.NOMBRE ,j.CAMISETA,po.NOMBRE_POSICION FROM JUGADORES j
	JOIN PERSONAS p ON j.PERSONA = p.ID
	JOIN POSICIONES po ON j.POSICION = po.ID
END

GO 

CREATE PROCEDURE SP_PARAM_JUGADOR --VOY A USARLO PARA CREAR LOS JUGADORES Y PERSONAS OBTENFGO LOS PARAMETROS DE SALIDA
@nomJugador varchar(100),
@nomPosicion varchar(100), 
@nro int,
@fecha_nac DATE OUTPUT,
@dni int OUTPUT
AS
BEGIN
select  @dni = p.DNI , @fecha_nac = p.FECHA_NACIMIENTO from JUGADORES j
JOIN PERSONAS p ON j.PERSONA = p.ID
JOIN POSICIONES po ON j.POSICION = po.ID
WHERE (p.NOMBRE like CONCAT('%',@nomJugador,'%')) and 
(po.NOMBRE_POSICION like CONCAT('%',@nomPosicion,'%')) and 
(j.CAMISETA=@nro)
END

GO
-- Ejecuta el procedimiento almacenado y asigna los resultados a variables de salida
DECLARE @fecha_nac DATE, @dni INT;
EXEC SP_PARAM_JUGADOR 'Kroos', 'Delantero', 3, @fecha_nac OUTPUT, @dni OUTPUT;

-- Muestra las variables de salida
SELECT @fecha_nac AS FechaNacimiento, @dni AS DNI;


select * from POSICIONES -- 1 a 11 
select * from personas --1 a 38 


----INSERCIONES DE DATOS
--INSERT INTO POSICIONES(NOMBRE_POSICION)
--VALUES('Arquero'),('Defensor Izq'),('Defensor Central'),('Defesor Der'),('Mediocampista Izq'),
--('Mediocampista Ofensivo'),('Mediocampista Defensivo'),('Mediocampista Der'),
--('Delantero Izq'),('Delantero Der'),('Delantero Central')
--;

--INSERT INTO PERSONAS (NOMBRE, DNI, FECHA_NACIMIENTO) VALUES
--('Lionel Messi', '12345678', '1987-06-24'),
--('Cristiano Ronaldo', '87654321', '1985-02-05'),
--('Neymar Jr.', '98765432', '1992-02-05'),
--('Kylian Mbappé', '23456789', '1998-12-20'),
--('Sergio Ramos', '34567890', '1986-03-30'),
--('Kevin De Bruyne', '45678901', '1991-06-28'),
--('Robert Lewandowski', '56789012', '1988-08-21'),
--('Luka Modric', '67890123', '1985-09-09'),
--('Eden Hazard', '78901234', '1991-01-07'),
--('Virgil van Dijk', '89012345', '1991-07-08'),
--('Mohamed Salah', '90123456', '1992-06-15'),
--('Joshua Kimmich', '01234567', '1995-02-08'),
--('Karim Benzema', '76543210', '1987-12-19'),
--('Harry Kane', '65432109', '1993-07-28'),
--('Ciro Immobile', '54321098', '1990-02-20'),
--('Erling Haaland', '43210987', '2000-07-21'),
--('Marco Verratti', '32109876', '1992-11-05'),
--('Thiago Silva', '21098765', '1984-09-22'),
--('Jadon Sancho', '10987654', '2000-03-25'),
--('Frenkie de Jong', '09876543', '1997-05-12'),
--('Toni Kroos', '98765432', '1990-01-04'),
--('Sadio Mané', '87654321', '1992-04-10'),
--('Romelu Lukaku', '76543210', '1993-05-13'),
--('Thomas Müller', '65432109', '1989-09-13'),
--('David Alaba', '54321098', '1992-06-24'),
--('Pierre-Emerick Aubameyang', '43210987', '1989-06-18'),
--('Raheem Sterling', '32109876', '1994-12-08'),
--('Son Heung-min', '21098765', '1992-07-08'),
--('Gerard Piqué', '10987654', '1987-02-02'),
--('Achraf Hakimi', '09876543', '1998-11-04'),
--('Marquinhos', '98765432', '1994-05-14'),
--('Andrew Robertson', '87654321', '1994-03-11'),
--('Casemiro', '76543210', '1992-02-23'),
--('Sergio Agüero', '65432109', '1988-06-02'),
--('Trent Alexander-Arnold', '54321098', '1998-10-07'),
--('Jorginho', '43210987', '1991-12-20'),
--('Gianluigi Donnarumma', '32109876', '1999-02-25'),
--('Luis Suárez', '21098765', '1987-01-24');


--insert into JUGADORES (persona, camiseta, posicion) values (28, 52, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (14, 99, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (27, 99, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (21, 12, 10);
--insert into JUGADORES (persona, camiseta, posicion) values (20, 76, 8);
--insert into JUGADORES (persona, camiseta, posicion) values (21, 45, 10);
--insert into JUGADORES (persona, camiseta, posicion) values (25, 74, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (23, 13, 10);
--insert into JUGADORES (persona, camiseta, posicion) values (25, 84, 6);
--insert into JUGADORES (persona, camiseta, posicion) values (23, 89, 10);
--insert into JUGADORES (persona, camiseta, posicion) values (33, 3, 5);
--insert into JUGADORES (persona, camiseta, posicion) values (23, 42, 7);
--insert into JUGADORES (persona, camiseta, posicion) values (20, 50, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (32, 78, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (24, 60, 6);
--insert into JUGADORES (persona, camiseta, posicion) values (27, 30, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (32, 87, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (24, 81, 8);
--insert into JUGADORES (persona, camiseta, posicion) values (30, 33, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (32, 2, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (15, 96, 5);
--insert into JUGADORES (persona, camiseta, posicion) values (14, 2, 8);
--insert into JUGADORES (persona, camiseta, posicion) values (14, 51, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (34, 11, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (26, 14, 4);
--insert into JUGADORES (persona, camiseta, posicion) values (9, 19, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (11, 67, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (29, 46, 6);
--insert into JUGADORES (persona, camiseta, posicion) values (16, 47, 7);
--insert into JUGADORES (persona, camiseta, posicion) values (3, 43, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (14, 37, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (17, 10, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (34, 20, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (28, 1, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (35, 61, 6);
--insert into JUGADORES (persona, camiseta, posicion) values (25, 53, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (11, 89, 4);
--insert into JUGADORES (persona, camiseta, posicion) values (9, 41, 8);
--insert into JUGADORES (persona, camiseta, posicion) values (35, 93, 8);
--insert into JUGADORES (persona, camiseta, posicion) values (10, 75, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (6, 64, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (20, 46, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (6, 86, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (13, 67, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (32, 16, 4);
--insert into JUGADORES (persona, camiseta, posicion) values (9, 95, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (25, 49, 6);
--insert into JUGADORES (persona, camiseta, posicion) values (38, 51, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (5, 4, 5);
--insert into JUGADORES (persona, camiseta, posicion) values (27, 11, 7);
--insert into JUGADORES (persona, camiseta, posicion) values (36, 13, 4);
--insert into JUGADORES (persona, camiseta, posicion) values (18, 77, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (26, 18, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (12, 37, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (28, 9, 8);
--insert into JUGADORES (persona, camiseta, posicion) values (30, 63, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (26, 12, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (35, 43, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (12, 96, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (6, 61, 6);
--insert into JUGADORES (persona, camiseta, posicion) values (26, 38, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (24, 90, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (19, 62, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (6, 28, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (30, 42, 6);
--insert into JUGADORES (persona, camiseta, posicion) values (21, 3, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (15, 47, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (25, 86, 2);
--insert into JUGADORES (persona, camiseta, posicion) values (2, 64, 7);
--insert into JUGADORES (persona, camiseta, posicion) values (22, 70, 4);
--insert into JUGADORES (persona, camiseta, posicion) values (18, 20, 8);
--insert into JUGADORES (persona, camiseta, posicion) values (3, 43, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (21, 37, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (19, 88, 9);
--insert into JUGADORES (persona, camiseta, posicion) values (24, 53, 1);
--insert into JUGADORES (persona, camiseta, posicion) values (11, 78, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (21, 49, 11);
--insert into JUGADORES (persona, camiseta, posicion) values (35, 58, 7);
--insert into JUGADORES (persona, camiseta, posicion) values (30, 52, 3);
--insert into JUGADORES (persona, camiseta, posicion) values (33, 7, 10);
