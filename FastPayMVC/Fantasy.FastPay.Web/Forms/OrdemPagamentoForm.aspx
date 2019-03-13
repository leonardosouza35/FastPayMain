<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdemPagamentoForm.aspx.cs" Inherits="Fantasy.FastPay.Web.Forms.OrdemPagamentoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblNomeCompleto" runat="server" AssociatedControlID="txtNomeCompleto" Text="Nome Completo"></asp:Label>
        <br />        
        <asp:TextBox ID="txtNomeCompleto" runat="server"></asp:TextBox>        
        <br />
        <br />

        <asp:Label ID="lblRG" runat="server" AssociatedControlID="txRG" Text="RG"></asp:Label>
        <br />        
        <asp:TextBox ID="txRG" runat="server"></asp:TextBox>        
        <br />
        <br />

        <asp:Label ID="lblNumeroContrato" runat="server" AssociatedControlID="txNumContrato" Text="Numero de Contrato"></asp:Label>
        <br />        
        <asp:TextBox ID="txNumContrato" runat="server"></asp:TextBox>        
        <br />
        <br />
    <div>
    
    </div>
       
    </form>
</body>
</html>
