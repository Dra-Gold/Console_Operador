create database Recutramiento;
use Recutramiento;

create table Calificacion(
Id int identity primary key,
Nombre varchar(20)
);

create table Posicion(
Id int identity primary key,
Nombre varchar(20)
);

create table Clase(
Id int identity primary key,
Nombre varchar(20)
);


create table Caracteristicas(
Id int identity primary key,
Nombre varchar(20)
);


create table Operador(
Ope_Id int identity,
Ope_Nombre varchar (80),
Ope_Calificacion int,
Ope_Posicion int,
Ope_Clase int,
PRIMARY KEY (Ope_Id),
FOREIGN KEY (Ope_Calificacion) REFERENCES Calificacion(Id),
FOREIGN KEY (Ope_Posicion) REFERENCES Posicion(Id),
FOREIGN KEY (Ope_Clase) REFERENCES Clase(Id)
);

create table Caracteristicas_Operador(
Id int identity primary key,
Id_Operador int,
Id_Caracteristicas int,
FOREIGN KEY (Id_Operador) REFERENCES Operador(Ope_Id),
FOREIGN KEY (Id_Caracteristicas) REFERENCES Caracteristicas(Id)
);


insert into Calificacion values ('Starter');
insert into Calificacion values ('Senior Operator');
insert into Calificacion values ('Top Operator');

insert into Posicion values ('Melee');
insert into Posicion values ('Ranger');

insert into Clase values ('Guard');
insert into Clase values ('Medic');
insert into Clase values ('Vanguard');
insert into Clase values ('Caster');
insert into Clase values ('Sniper');
insert into Clase values ('Defender');
insert into Clase values ('Suporter');
insert into Clase values ('Specialist');

insert into Caracteristicas values ('Healing');
insert into Caracteristicas values ('Support');
insert into Caracteristicas values ('DPS');
insert into Caracteristicas values ('AoE');
insert into Caracteristicas values ('Slow');
insert into Caracteristicas values ('Survival');
insert into Caracteristicas values ('Defense');
insert into Caracteristicas values ('Debuff');
insert into Caracteristicas values ('Shift');
insert into Caracteristicas values ('Crowd Control');
insert into Caracteristicas values ('Nuker');
insert into Caracteristicas values ('Summon');
insert into Caracteristicas values ('Fast-Redeploy');
insert into Caracteristicas values ('Dp_Recovery');
insert into Caracteristicas values ('Robot');

Insert Into Operador values ('Texas',2,1,3);

insert Into Caracteristicas_Operador values (1,10);