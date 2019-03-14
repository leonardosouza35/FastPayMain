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
        <asp:HiddenField ID="modForm" runat="server" Value="incluir"  /> 
        <asp:HiddenField ID="hdUsuarioId" runat="server" Value="" /> 
                
    <div id="divGrid">         
        <asp:GridView ID="grdUsuario" runat="server" AutoGenerateColumns="False" CellPadding="4" 
            EnableModelValidation="True" ForeColor="#333333" GridLines="None" Width="374px" 
            OnRowCommand="grdUsuario_RowCommand" DataKeyNames="Id" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="SobreNome" HeaderText="Sobre Nome">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkEditarUsuario" runat="server" 
                            CausesValidation="false" CommandName="editar" 
                            CommandArgument='<%#Eval("Id")%>' Text="Editar"></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkDeletarUsuario" runat="server" 
                            CausesValidation="false" CommandName="deletar"  OnClientClick="return confirm('Tem certeza que deseja deletar este item ?')"
                            CommandArgument='<%#Eval("Id") %>'                                                         
                            Text="Deletar"></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" />
                </asp:TemplateField>
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
