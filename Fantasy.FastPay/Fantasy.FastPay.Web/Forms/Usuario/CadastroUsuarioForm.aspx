<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Master/Page.Master" AutoEventWireup="true" CodeBehind="CadastroUsuarioForm.aspx.cs" Inherits="Fantasy.FastPay.Web.Forms.CadastroUsuarioForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 class="mb-3">Completar o Cadastro</h3>
        <h4 class="mb-3">Dados Básicos</h4>
        <div class="row">
            <div class="col-md-4">  
                <div class="form-group">
                    <label for="txtNome">Nome</label>
                    <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" placeholder="Nome" />                    
                </div>                                  
            </div>
            <div class="col-md-4">  
                <div class="form-group">
                    <label for="txtSobreNome">Sobre Nome</label>
                    <asp:TextBox runat="server" ID="txtSobreNome" CssClass="form-control" placeholder="Sobre Nome" />                    
                </div>                                  
            </div>
            <div class="col-md-4">  
                <div class="form-group">
                    <label for="txtEmail">Email</label>
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" placeholder="Email" />                    
                </div>                                  
            </div>
        </div>
        <div class="row">            
            <div class="col-md-4">  
                <div class="form-group">
                    <label for="txtSenha">Senha</label>
                    <asp:TextBox runat="server" ID="txtSenha" CssClass="form-control" placeholder="Senha" TextMode="Password"/>                    
                </div>                                  
            </div>
            <div class="col-md-4">  
                <div class="form-group">
                    <label for="txtConfirmarSenha">Confirmar a Senha</label>
                    <asp:TextBox runat="server" ID="txtConfirmarSenha" CssClass="form-control" placeholder="Confirmar a Senha" TextMode="Password"/>                    
                </div>                                                  
            </div>  
            <div class="col-md-4">
                <div class="form-group">
                    <label for="drpTipoPessoa">Tipo de Pessoa</label>
                    <asp:DropDownList runat="server" ID="drpTipoPessoa" CssClass="form-control" placeholder="Tipo de Pessoa"/>                    
                </div>                                  
            </div>          
        </div>
        <div class="row">            
            <div class="col-md-4">
                <div class="form-group">
                    <label for="txtNumeroDocumento">Número do Documento</label>
                    <asp:TextBox runat="server" ID="txtNumeroDocumento" CssClass="form-control" placeholder="Número do Documento"/>                    
                </div>                                  
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label for="txtNomeEmpresa">Nome da Empresa</label>
                    <asp:TextBox runat="server" ID="txtNomeEmpresa" CssClass="form-control" placeholder="Nome da Empresa"/>                    
                </div>                                  
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label for="txtTelefoneContato1">Telefone Para Contato 1</label>
                    <asp:TextBox runat="server" ID="txtTelefoneContato1" CssClass="form-control" placeholder="Telefone Para Contato"/>                    
                </div>                                  
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label for="txtTelefoneContato2">Telefone Para Contato 2</label>
                    <asp:TextBox runat="server" ID="txtTelefoneContato2" CssClass="form-control" placeholder="Telefone Para Contato"/>                    
                </div>                                  
            </div>
        </div>
        <hr class="mb-4" />
        <h4 class="mb-3">Endereço</h4>
         <div class="row">
             <div class="col-md-2">
                <div class="form-group">
                    <label for="txtCep">Cep</label>
                    <asp:TextBox runat="server" ID="txtCep" CssClass="form-control" placeholder="Cep"/>                    
                </div>                                  
            </div>
         </div>
        <div class="row">            
            <div class="col-md-5">
                <div class="form-group">
                    <label for="txtRua">Rua</label>
                    <asp:TextBox runat="server" ID="txtRua" CssClass="form-control" placeholder="Rua"/>                    
                </div>                                  
            </div>
            <div class="col-md-5">
                <div class="form-group">
                    <label for="txtBairro">Bairro</label>
                    <asp:TextBox runat="server" ID="txtBairro" CssClass="form-control" placeholder="Bairro"/>                    
                </div>                                  
            </div>
        </div>
        <div class="row">
            <div class="col-md-5">
                <div class="form-group">
                    <label for="txtCidade">Cidade</label>
                    <asp:TextBox runat="server" ID="txtCidade" CssClass="form-control" placeholder="Cidade"/>                    
                </div>                                  
            </div>
            <div class="col-md-5">
                <div class="form-group">
                    <label for="txtEstado">Estado</label>
                    <asp:TextBox runat="server" ID="txtEstado" CssClass="form-control" placeholder="Estado"/>                    
                </div>                                  
            </div>
        </div>
        <hr  class="mb-4"/>
        <h4 class="mb-3">Dados Bancários</h4>
        <div class="row">
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtCodigoBanco">Código do Banco</label>
                    <asp:TextBox runat="server" ID="txtCodigoBanco" CssClass="form-control" placeholder="Codigo do Banco"/>                    
                </div>                                  
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtBanco">Banco</label>
                    <asp:TextBox runat="server" ID="txtBanco" CssClass="form-control" placeholder="Banco"/>                    
                </div>                                  
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtAgencia">Agência</label>
                    <asp:TextBox runat="server" ID="txtAgencia" CssClass="form-control" placeholder="Agência"/>                    
                </div>                                  
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="drpTipoDeConta">Tipo de Conta</label>
                    <asp:DropDownList runat="server" ID="drpTipoDeConta" CssClass="form-control"/>                    
                </div>                                  
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNumeroConta">Número da Conta</label>
                    <asp:TextBox runat="server" ID="txtNumeroConta" CssClass="form-control" placeholder="Número da Conta"/>                    
                </div>                                  
            </div>
        </div>
        <hr  class="mb-4"/>
        <div class="row">
            <div class="col-md-4">
                <asp:Button runat="server" id="btnSalvar" CssClass="btn btn-primary btn-lg btn-block" Text="Savar"></asp:Button>
            </div>
        </div>        
        <hr  class="mb-5"/>
        
    </div>
</asp:Content>
