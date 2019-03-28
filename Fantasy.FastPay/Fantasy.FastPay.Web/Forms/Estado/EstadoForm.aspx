<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Master/Page.Master" AutoEventWireup="true" CodeBehind="EstadoForm.aspx.cs" Inherits="Fantasy.FastPay.Web.Forms.Estado.EstadoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h4 class="mb-3">Cadastro de Estado</h4>
        <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label for="txtNome">Estado:</label>
                    <asp:TextBox runat="server" id="txtNome" placeholder="País" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div> 
        <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label for="txtDescricao">Descrição:</label>
                    <asp:TextBox runat="server" id="txtDescricao" placeholder="Descrição" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>                
        <div class="row">
            <div class="col-md-8">
                <asp:Button runat="server" CssClass="btn btn-primary" Text="Salvar" ID="btnSalvar" OnClick="btnSalvar_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-8">
                <asp:label runat="server" ID="lblMessage" ForeColor="Red"></asp:label>
            </div>
        </div>
        <hr class="mb-4" />
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="grdEstados" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" CssClass="table table-hover" DataKeyNames="Id"
                     OnRowCommand="grdEstados_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Nome" HeaderText="Nome" >
                        <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="lkEditar" runat="server" CausesValidation="false" CommandName="Editar" Text="Editar" CommandArgument='<%#Eval("Id") %>'></asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle Width="10px" />
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="lkRemove" runat="server" CausesValidation="false" CommandName="Remover" Text="Remover" CommandArgument='<%#Eval("Id") %>' OnClientClick="return confirm('Deseja realmente remover este registro do sistema?')"></asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle Width="10px" />
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
            </div>
        </div>
         
    </div>
</asp:Content>
