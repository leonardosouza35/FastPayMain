<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Master/Page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Fantasy.FastPay.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">            
    <%--<div class="jumbotron">--%>
        <div class="container">
            <div class="row" >
                <div class="col-md-7">
                    <h1 class="titulo text-primary mt-5">A melhor cotação para enviar ou receber dinheiro do exterior</h1>
                    <p>Envie dinheiro para o exterior de forma rápida, direto para a conta bancária dos seus amigos e parentes. Usamos sempre o câmbio comercial, e você paga apenas uma pequena comissão.</p>
                    <p><a class="btn btn-primary" href="#">SAIBA MAIS</a></p>
                </div>

                <div class="col-md-4 mt-5">                    
                        <fieldset>
                            <legend></legend>                            
                            <h1 class="text-primary titulo-cadastro">Criar Conta</h1>
                            <div class="form-group">
                                <label for="txtNome">Nome</label>
                                <%--<input type="text" id="txtNome" class="form-control" placeholder="Nome" />--%>
                                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" placeholder="Nome" />
                            </div>
                            <div class="form-group">
                                <label for="txtEmail">Email</label>
                                <%--<input type="email" id="txtEmail" class="form-control" placeholder="Email" />--%>
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" placeholder="Email" />
                            </div>                                                  
                            <%--<button type="button" class="btn btn-info">Criar Conta</button>      --%>
                            <asp:Button runat="server"  ID="btnCriarConta" OnClick="btnCriarConta_Click" CssClass="btn btn-primary btn-lg btn-block" Text="Criar Conta"/>                                         
                            </fieldset>                                                
                </div>
            </div>
            
        </div>
    <%--</div>--%>
            <%--<div class="row">
                <div class="col-lg-8">
                    <h1>Leo</h1>
                </div>
            </div>--%>
        
</asp:Content>
