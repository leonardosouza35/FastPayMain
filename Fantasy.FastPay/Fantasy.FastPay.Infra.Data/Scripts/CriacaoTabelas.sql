use [FastPayDB]
go

create table Empresas
(
	Id int not null identity primary key,
	Nome varchar(50) not null,
	PaisOrigemId int not null,
	EstadoId int not null,
	CidadeId int not null,
	PercentualCalculoTaxa money null
);

insert into FastPayDB.dbo.Empresas(Nome, PaisOrigemId,EstadoId,CidadeId,PercentualCalculoTaxa)
values('S�o Paulo',1,1,1,570.67);

select * from dbo.Empresas;

