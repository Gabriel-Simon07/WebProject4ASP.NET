<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.WebForm1" %>

<asp:Content ID="Content" ContentPlaceHolderId="Content" runat="server">
		<asp:Panel ID="pnlLista" runat="server">
            <asp:Button ID="BtnInserir" runat="server" OnClick="BtnInserir_Click" Text="Inserir"  />
             <hr />
                <asp:GridView ID="GridViewUsuarios" runat="server" OnRowCommand="GridViewUsuarios_RowCommand" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnAlterar" runat="server"
                                    CommandName="Alterar"
                                    CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                                    Text="Atualiza" />
                                <asp:Button ID="btnExcluir" runat="server"
                                  CommandName="Excluir"
                                  CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                                  Text="Excluir" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    	<asp:BoundField HeaderText="ID" />
						<asp:BoundField DataField="Nome" HeaderText="Nome" />
						<asp:BoundField DataField="Email" HeaderText="Email" />
						<asp:BoundField DataField="Senha" DataFormatString="***" HeaderText="Senha" />
						<asp:ImageField DataImageUrlField="Foto" HeaderText="Foto">
						</asp:ImageField>
                    </Columns>
                </asp:GridView>           
        </asp:Panel>
        
        <hr />
</asp:Content>
