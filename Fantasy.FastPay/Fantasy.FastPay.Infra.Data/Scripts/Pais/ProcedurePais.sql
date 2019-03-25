use [FastPayDB]
go

CREATE Procedure [dbo].[spAdicionarPais] 

	@Nome	varchar(50),	
	@Descricao	varchar(50)			
AS
	INSERT INTO Paises(Nome, Descricao, DataCadastro) values(@Nome,@Descricao, CURRENT_TIMESTAMP);
	                                     
	RETURN;

