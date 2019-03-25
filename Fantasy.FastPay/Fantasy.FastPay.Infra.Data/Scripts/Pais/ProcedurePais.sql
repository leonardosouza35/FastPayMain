use [FastPayDB]
go

--ADICIONAR PAIS 
CREATE Procedure [dbo].[spAdicionarPais] 

	@Nome	varchar(50),	
	@Descricao	varchar(50)			
AS
	INSERT INTO Paises(Nome, Descricao, DataCadastro) values(@Nome, @Descricao, CURRENT_TIMESTAMP);
	                                     
	RETURN;


--ADICIONAR PAIS 
CREATE Procedure [dbo].[spObterTodosPaises] 
	
AS
	select Id, nome, descricao, datacadastro from Paises;
	                                     
	RETURN;

--OBTER PAIS POR ID
CREATE Procedure [dbo].[spObterPais] 
	@Id	Int	
AS
	select Id, nome, descricao, datacadastro from Paises
	where Id =@Id
	                                     
	RETURN;

--ATUALIZAR
CREATE Procedure [dbo].[spAtualizarPais] 
	@Id	Int,	
	@Nome varchar(50),
	@Descricao varchar(50)
AS
	UPDATE Paises set Nome =@Nome, Descricao=@Descricao
	where Id=@Id
	                                     
	RETURN;

--ATUALIZAR
CREATE Procedure [dbo].[spRemoverPais] 
	@Id	Int		
AS
	delete from Paises
	where Id=@Id
	                                     
	RETURN;

