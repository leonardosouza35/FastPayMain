<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Fantasy.FastPay.Web.Forms.LoginForm" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width; initial-scale=1, shrink-to-fit=no" />    
    <link href="../Scripts/css/bootstrap/bootstrap.css" rel="stylesheet" />
    <link href="../Scripts/css/custom.min.css" rel="stylesheet" />    
    <link href="../Scripts/css/Site.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form class="form-signin" runat="server">
        <h3 class="mb-3">Fast Pay</h3>
        <label for="txtEmail" class="sr-only">Email</label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control mb-2" placeholder="Entre com seu Email" required autofocus />
        <label for="txtSenha" class="sr-only">Senha</label>
        <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control mb-2" placeholder="Entre com a sua Senha" required autofocus  TextMode="Password"/>
        <div class="checkbox mb-2">
            <label>
                <input type="checkbox" value="Lembrar-me">
                 Lembrar -me                
            </label>
        </div>                
        <asp:Button  runat="server" ID="btnEntrar" CssClass="btn btn-primary btn-block" Text="Entrar" OnClick="btnEntrar_Click"/>
        <asp:Label runat="server" ID="lblMensagem" ForeColor="Red" CssClass="mb-3"></asp:Label>
        <hr class="mb-2"/>
        <a href="../Default.aspx"><-- Voltar</a>
               
    </form>
    <script src="../Scripts/js/jquery-3.3.1.slim.min.js"></script>
    <script src="../Scripts/js/popper.min.js"></script>
    <script src="../Scripts/js/bootstrap/bootstrap.js"></script>
</body>
</html>
