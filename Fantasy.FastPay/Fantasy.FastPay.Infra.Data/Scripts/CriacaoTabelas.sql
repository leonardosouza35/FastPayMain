use [FastPayDB]
go


create table Paises
(
   Id int not null identity primary key,
   Nome varchar(50) not null,
   Descricao varchar(50) not null,
   DataCadastro datetime not null default CURRENT_TIMESTAMP      
)

create table Estados
(
   Id int not null identity primary key,
   Nome varchar(50) not null,
   Descricao varchar(50) not null
)

create table Cidades
(
   Id int not null identity primary key,
   Nome varchar(50) not null,
   Descricao varchar(50) not null,
   EstadoId int not null references Estados(Id)
)

create table TipoPessoa(
   Id int not null identity primary key,
   Nome varchar(50) not null,
   Descricao varchar(50) not null   
)

create table Endereco(
	CEP varchar(50) not null primary key,
	Nome varchar(50) not null,
	Bairro varchar(50) not null,
	LocalidadeUF varchar(50) not null,
)


create table TipoConta
(
	Id int not null identity primary key,
	Nome varchar(50) not null,
	Descricao varchar(50) not null   
)

create table Usuarios(
	Id int not null identity primary key,
	Nome varchar(50) not null,
	SobreNome varchar(50) not null,
	Email varchar(100) not null,
	Senha varchar(100) not null,
	TipoPessoaId int not null references TipoPessoa(Id),
	NumeroDocumento varchar(50) not null,
	NomeEmpresa varchar(50) not null,
	CEP varchar(50) not null references Endereco(CEP),	
	Telefone1 varchar(50) not null,
	Telefone2 varchar(50) not null,
	CodigoBanco int not null,
	NomeBanco varchar(50) not null,
	Agencia varchar(50) not null,
	TipoDeContaId int not null references TipoConta(Id),
	NumeroDaConta varchar(50) not null
)


create table BancoPagador
(
   Id int not null identity primary key,
   Nome varchar(50) not null,
   DataCadastro datetime not null default CURRENT_TIMESTAMP      
)


create table Empresas
(
	Id int not null identity primary key,
	DataCadastro datetime not null default CURRENT_TIMESTAMP,
	Nome varchar(50) not null,
	PaisOrigemId int not null references Paises(Id),
	EstadoId int not null references Estados(Id),
	CidadeId int not null references Cidades(Id),
	PercentualCalculoTaxa decimal(18,10) not null		
);

create table OpcaoMoeda
(
	Id int not null identity primary key,
	Nome varchar(50) not null,
	Descricao varchar(50) not null   
)

create table StatusOrdem
(
	Id int not null identity primary key,
	Nome varchar(50) not null,
	Descricao varchar(50) not null   
)



create table OrdemPagamento(
	Id int not null identity primary key,
	DataCadastro datetime not null default CURRENT_TIMESTAMP,	
	DataEnvio datetime not null default CURRENT_TIMESTAMP,
	DataPagamentoRecebido datetime not null default CURRENT_TIMESTAMP,
	UsuarioQueEnviouId int not null references Usuarios(Id),  
	UsuarioQueRecebeuId int not null references Usuarios(Id),  
	EmpresaId int not null references Empresas(Id),  
	BancoPagadorId int not null references BancoPagador(Id),  
	OpcaoMoedaOrigem int not null references OpcaoMoeda(Id),  
	OpcaoMoedaDestino int not null references OpcaoMoeda(Id),  
	ValorEnviado money not null,
	ValorRecebido money not null,
	TaxaCambioMercado decimal(18,10) not null,
	TaxaCambioEmpresa decimal(18,10) not null,
	StatusOrdemId int not null references StatusOrdem(Id)	
)

create table OrdemPagamentoPasso
(
   Id int not null identity primary key,
   DataPasso datetime not null default CURRENT_TIMESTAMP,
   StatusOrdemId int not null,
   Descricao varchar(4000) not null,
   OrdemPagamentoId int not null references OrdemPagamento(Id),
   UsuarioId int not null references Usuarios(Id),      
)




