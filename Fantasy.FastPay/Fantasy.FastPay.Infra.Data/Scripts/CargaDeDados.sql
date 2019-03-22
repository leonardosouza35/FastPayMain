/* Carga de Dados */
use [FastPayDB]
go

-- Op��o Moeda
insert into OpcaoMoeda(Nome,Descricao) values('$','US Dollar');
insert into OpcaoMoeda(Nome,Descricao) values('R$','Real');

--Paises
insert into Paises(Nome, DataCadastro) values('EUA', CURRENT_TIMESTAMP);
insert into Paises(Nome, DataCadastro) values('Brasil',CURRENT_TIMESTAMP);

--Tipo Pessoa
insert into TipoPessoa(Nome,Descricao) values('F�sica', 'Pessoa F�sica');
insert into TipoPessoa(Nome,Descricao) values('Jur�dica', 'Pessoa Jur�dica');

--Tipo Conta
insert into TipoConta(Nome,Descricao) values('Poupan�a', 'Conta Poupan�a');
insert into TipoConta(Nome,Descricao) values('Corrente', 'Conta Corrente');


-- Status Ordem 
insert into StatusOrdem(Nome,Descricao) values('Aberto', '');
insert into StatusOrdem(Nome,Descricao) values('Processando', '');
insert into StatusOrdem(Nome,Descricao) values('Pago', '');
insert into StatusOrdem(Nome,Descricao) values('Cancelado', '');