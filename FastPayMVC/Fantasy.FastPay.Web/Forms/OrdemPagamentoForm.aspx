<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdemPagamentoForm.aspx.cs" Inherits="Fantasy.FastPay.Web.Forms.OrdemPagamentoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblNomeCompleto" runat="server" AssociatedControlID="txNomeCompleto" Text="Nome Completo"></asp:Label>
        <br />        
        <asp:TextBox ID="txNomeCompleto" runat="server"></asp:TextBox>        
        <br />
        <br />

        <asp:Label ID="lblCPF" runat="server" AssociatedControlID="txCPF" Text="CPF"></asp:Label>
        <br />        
        <asp:TextBox ID="txCPF" runat="server"></asp:TextBox>        
        <br />
        <br />

        <asp:Label ID="lblNumeroContrato" runat="server" AssociatedControlID="txNumContrato" Text="Numero de Contrato"></asp:Label>
        <br />        
        <asp:TextBox ID="txNumContrato" runat="server"></asp:TextBox>        
        <br />
        <br />
        <!-- Definição do botao esta ok, exceto por não ter o evento -->
        <!-- vai digitando devagar o OnClick como vou fazer para habilitar a criação 
            automatica no codebehind -->

        <!-- não para copiar e colcar conform vc perguntou... tem que digitar OnClick=.... e deixar que
        o visual studio crie o evento para vc ou vc vai ter q fazer isso sozinho
         -->        
         <asp:Button ID="btnSalvarOrdemPagamento" runat="server" Text="Salvar" OnClick="btnSalvarOrdemPagamento_Click"/>
        <br />
        <br />
                        
        <asp:Label ID="lblMessage" runat="server" Visible="false" ForeColor="Red"> Informe os campos Nome Completo e RG e Numero de Contrato</asp:Label>
        <asp:HiddenField ID="modFormOrdemPagamento" runat="server" Value="incluir"  /> 
        <asp:HiddenField ID="hdOrdemPagamentoId" runat="server" Value="" /> 

    <div id="divGrid">
        <asp:GridView ID="grdOrdemPagamento" runat="server" AutoGenerateColumns="False" CellPadding="4" 
            EnableModelValidation="True" ForeColor="#333333" GridLines="None" Width="374px"
            OnRowCommand="grdOrdemPagamento_RowCommand" DataKeyNames="Id">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="NomeCompleto" HeaderText="Nome Completo">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="CPF" HeaderText="CPF">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="NumeroContrato" HeaderText="Numero de Contrato">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkEditarOrdemPagamento" runat="server" 
                            CausesValidation="false" CommandName="editar" 
                            CommandArgument='<%#Eval("Id")%>' Text="Editar"></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkDeletarOrdemPagamento" runat="server" 
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
