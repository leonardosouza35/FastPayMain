use [FastPayDB]
go

--ADICIONAR ESTADO 
CREATE Procedure [dbo].[spAdicionarEstado] 

	@Nome	varchar(50),	
	@Descricao	varchar(50)			
AS
	INSERT INTO Estados(Nome, Descricao) values(@Nome, @Descricao);
	                                     
	RETURN;
	go


--ADICIONAR ESTADO 
CREATE Procedure [dbo].[spObterTodosOsEstados]
	
AS
	select Id, nome, descricao from Estados;
	
	                                     
	RETURN;
	go

--OBTER ESTADO POR ID
CREATE Procedure [dbo].[spObterEstado] 
	@Id	Int	
AS
	select Id, nome, descricao from Estados
	where Id =@Id
	                                     
	RETURN;
	go

--ATUALIZAR
CREATE Procedure [dbo].[spAtualizarEstado] 
	@Id	Int,	
	@Nome varchar(50),
	@Descricao varchar(50)
AS
	UPDATE Estados set Nome =@Nome, Descricao=@Descricao
	where Id=@Id
	                                     
	RETURN;
	go

--ATUALIZAR
CREATE Procedure [dbo].[spRemoverEstado] 
	@Id	Int		
AS
	delete from Estados
	where Id=@Id
	                                     
	RETURN;

