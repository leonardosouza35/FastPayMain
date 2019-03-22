/* Carga de Dados */
use [FastPayDB]
go

-- Opção Moeda
insert into OpcaoMoeda(Nome,Descricao) values('$','US Dollar');
insert into OpcaoMoeda(Nome,Descricao) values('R$','Real');

--Paises
insert into Paises(Nome, DataCadastro) values('EUA', CURRENT_TIMESTAMP);
insert into Paises(Nome, DataCadastro) values('Brasil',CURRENT_TIMESTAMP);

--Tipo Pessoa
insert into TipoPessoa(Nome,Descricao) values('Física', 'Pessoa Física');
insert into TipoPessoa(Nome,Descricao) values('Jurídica', 'Pessoa Jurídica');

--Tipo Conta
insert into TipoConta(Nome,Descricao) values('Poupança', 'Conta Poupança');
insert into TipoConta(Nome,Descricao) values('Corrente', 'Conta Corrente');


-- Status Ordem 
insert into StatusOrdem(Nome,Descricao) values('Aberto', '');
insert into StatusOrdem(Nome,Descricao) values('Processando', '');
insert into StatusOrdem(Nome,Descricao) values('Pago', '');
insert into StatusOrdem(Nome,Descricao) values('Cancelado', '');