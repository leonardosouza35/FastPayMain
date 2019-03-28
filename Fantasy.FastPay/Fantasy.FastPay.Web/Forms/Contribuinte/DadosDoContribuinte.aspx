<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Master/Page.Master" AutoEventWireup="true" CodeBehind="DadosDoContribuinte.aspx.cs" Inherits="Fantasy.FastPay.Web.Forms.Contribuinte.DadosDoContribuinte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h4>Cadastro de Contribuinte</h4>
        <div class="row">
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Inscrição Municipal:</label>
                    <asp:TextBox runat="server" id="txtNome" CssClass="form-control"></asp:TextBox>                    
                </div>                
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Tipo de Pessoa:</label>
                    <asp:TextBox runat="server" id="TextTipoDePessoa" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">CNPJ/CPF:</label>
                    <asp:TextBox runat="server" id="TextBox1" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Insc. Estadal/RG:</label>
                    <asp:TextBox runat="server" id="TextBox2" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div> 
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label for="txtNome">Nome/Razão Social:</label>
                    <asp:TextBox runat="server" id="TextBox3" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label for="txtNome">Nome Fantasia:</label>
                    <asp:TextBox runat="server" id="TextBox4" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-9">
                <div class="form-group">
                    <label for="txtNome">Logradouro:</label>
                    <asp:TextBox runat="server" id="TextBox5" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Numero:</label>
                    <asp:TextBox runat="server" id="TextBox6" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-9">
                <div class="form-group">
                    <label for="txtNome">Complemento:</label>
                    <asp:TextBox runat="server" id="TextBox7" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">CEP:</label>
                    <asp:TextBox runat="server" id="TextBox8" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-9">
                <div class="form-group">
                    <label for="txtNome">Bairro:</label>
                    <asp:TextBox runat="server" id="TextBox9" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">UF:</label>
                    <asp:TextBox runat="server" id="TextBox10" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-9">
                <div class="form-group">
                    <label for="txtNome">Cidade:</label>
                    <asp:TextBox runat="server" id="TextBox11" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Fone do Contribuinte:</label>
                    <asp:TextBox runat="server" id="TextBox12" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-8">
                <div class="form-group">
                    <label for="txtNome">Responsável/Contado:</label>
                    <asp:TextBox runat="server" id="TextBox13" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label for="txtNome">E-mail Contribuinte:</label>
                    <asp:TextBox runat="server" id="TextBox14" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-9">
                <div class="form-group">
                    <label for="txtNome">Descrição da Atividade:</label>
                    <asp:TextBox runat="server" id="TextBox15" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Fone do Contador:</label>
                    <asp:TextBox runat="server" id="TextBox16" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-9">
                <div class="form-group">
                    <label for="txtNome">Nome Contador -> ATENÇÂO: Se não listar o Contador, cadastre em: Cadastros - Contadores</label>
                    <asp:TextBox runat="server" id="TextBox17" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">E-mail do Contador:</label>
                    <asp:TextBox runat="server" id="TextBox18" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Enquadrado</label>
                    <asp:TextBox runat="server" id="TextBox19" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Inicio Atividade</label>
                    <asp:TextBox runat="server" id="TextBox21" placeholder="(DD/MM/AAAA)" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Situação da Empresa</label>
                    <asp:TextBox runat="server" id="TextBox22" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Nº do Processo</label>
                    <asp:TextBox runat="server" id="TextBox23" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label for="txtNome">Data Processo:</label>
                    <asp:TextBox runat="server" id="TextBox20" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtNome">Exigibilidade de ISS:</label>
                    <asp:TextBox runat="server" id="TextBox24" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtNome">Número do Processo Juducial ou Administrativo Susp.Exigibilidade:</label>
                    <asp:TextBox runat="server" id="TextBox25" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Dt.Proc.Exigibilidade:</label>
                    <asp:TextBox runat="server" id="TextBox26" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Optante S.Nacional:</label>
                    <asp:TextBox runat="server" id="TextBox27" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Dt.Opção S.Nacional:</label>
                    <asp:TextBox runat="server" id="TextBox28" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Incentivo Fiscal:</label>
                    <asp:TextBox runat="server" id="TextBox29" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Nº Lei Incentivo Fiscal:</label>
                    <asp:TextBox runat="server" id="TextBox30" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="txtNome">Gerar Boleto?</label>
                    <asp:TextBox runat="server" id="TextBox31" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtNome">Regime de Tributação:</label>
                    <asp:TextBox runat="server" id="TextBox32" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtNome">Regime Especial de Tributação:</label>
                    <asp:TextBox runat="server" id="TextBox33" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label for="txtNome">Item da Lista de Serviços:</label>
                     <a href="#">Pesquisar item  de serviços</a>
                    <asp:TextBox runat="server" id="TextBox34" CssClass="form-control"></asp:TextBox>
                    <asp:TextBox runat="server" id="TextBox35" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        </div>
   

</asp:Content>
