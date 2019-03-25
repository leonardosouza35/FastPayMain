use [FastPayDB]
go

--ADICIONAR PAIS 
CREATE Procedure [dbo].[spAdicionarPais] 

	@Nome	varchar(50),	
	@Descricao	varchar(50)			
AS
	INSERT INTO Paises(Nome, Descricao, DataCadastro) values(@Nome,@Descricao, CURRENT_TIMESTAMP);
	                                     
	RETURN;


--ADICIONAR PAIS 
CREATE Procedure [dbo].[spObterTodosPaises] 
	
AS
	select nome, descricao, datacadastro from Paises;
	                                     
	RETURN;

