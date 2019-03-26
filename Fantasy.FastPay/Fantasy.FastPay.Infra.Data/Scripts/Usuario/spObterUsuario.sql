use [FastPayDB]
go


CREATE Procedure [dbo].[spObterUsuario] 
	@Email	varchar(50),	
	@Senha	varchar(50)			
AS
	select Id, Email, Senha from Usuarios
	where Email=@Email 
		  and Senha=@Senha
	                                     
	RETURN;
