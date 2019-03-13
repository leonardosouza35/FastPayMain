<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioForm.aspx.cs" Inherits="Fantasy.FastPay.Web.Forms.UsuarioForm" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    
        <asp:Label ID="lblNome" runat="server" AssociatedControlID="txtNome" Text="Nome"></asp:Label>
        <br />        
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>        
        <br />
        <br />

        <asp:Label ID="lblSobreNome" runat="server" Text="Sobre Nome" AssociatedControlID="txtSobreNome"></asp:Label>
        <br />        
        <asp:TextBox ID="txtSobreNome" runat="server"></asp:TextBox>        
        <br />
        <br />
        <asp:Button ID="btnSalvarUsuario" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Visible="false" ForeColor="Red"> Informe os campos Nome e Sobre Nome</asp:Label>
                
    <div id="divGrid">         
        <asp:GridView ID="grdUsuario" runat="server" AutoGenerateColumns="False" CellPadding="4" 
            EnableModelValidation="True" ForeColor="#333333" GridLines="None" Width="374px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="SobreNome" HeaderText="Sobre Nome">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>

    </div>
                
    </form>

    </body>
</html>
