use PrubTecnica
create table Jugadores
(Id int primary key,
Nombre varchar(100),
Apellido varchar(100),
FechaNacimiento date,
Pasaporte varchar(100),
Direccion varchar(100),
Sexo varchar(100),
IdEquipo int,
EstadoId varchar(100)
)

create table Estado
(
Id varchar(100) primary key,
NombreEstado varchar(100),
FechaCreacion date,
)

create table Equipo
(
Id int primary key,
Nombre varchar(100),
Pais varchar(10),
EstadoId varchar(100),
Nombre_Jugador varchar(100),
FechaCreacion date 
)

drop table estado
 
select * from Estado
select * from Equipo
select * from Jugadores
delete  from Jugadores where Id=3

insert into Estado values ('Inactivo', 'Angeles', '28-04-2021')
insert into Equipo values ('San francisco', 'EEUU', 'Inactivo', 'Job Fedeirco', '2021-08-12')

dbcc CHECKIDENT('Equipo', RESEED,0)

insert into Jugadores values('Job Federico', 'Bencosme Diaz', '2021-07-21', '402-253698-7', 'Madrid España', 'masculino', 1, 'Activo')