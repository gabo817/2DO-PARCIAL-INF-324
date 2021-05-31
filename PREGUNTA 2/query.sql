create table seguimiento					
(
nroTramite int,
codFlujo varchar(3),
codProceso varchar(3),
usuario int,
fechaini date,
fechafin date
)

create table Iniciales
(
tipo varchar(20),
valor int,
)


insert into seguimiento values(100,'F1','P1',1	,'2018/4/1','2018/4/2');
insert into seguimiento values(100,'F1','P2',1	,'2018/4/2',null);
insert into seguimiento values(210,'F1','P1',10,'2019/4/1',null);
