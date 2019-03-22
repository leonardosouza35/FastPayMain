use [FastPayDB]
go


create table Paises
(
   Id int not null identity primary key,
   Nome varchar(50) not null,
   DataCadastro DateTime 
)


create table Paises
(
   Id int not null identity primary key,
   Nome varchar(50) not null,
   DataCadastro DateTime 
)

create table Empresas
(
	Id int not null identity primary key,
	Nome varchar(50) not null,
	PaisOrigemId int not null,
	EstadoId int not null,
	CidadeId int not null,
	PercentualCalculoTaxa money null
	Foreign Key(PaisOrigemId) references(Paises)
);

insert into FastPayDB.dbo.Empresas(Nome, PaisOrigemId,EstadoId,CidadeId,PercentualCalculoTaxa)
values('São Paulo',1,1,1,570.67);

select * from dbo.Empresas;


