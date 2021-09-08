<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.Registro" %>


  <asp:Content ID="ContentRegistro" ContentPlaceHolderId="Content" runat="server">
        <div>
			<table>
				<tr>
					<td>
						<asp:Label ID="LabelPlaca" runat="server" Text="Placa:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="txtPlaca" runat="server"></asp:TextBox>
					&nbsp;<asp:Button ID="btnPesquisar" runat="server" Text="PESQUISAR" />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="LabelNomeRegistro" runat="server" Text="Nome:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="txtNomeRegistro" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="LabelDataRegistro" runat="server" Text="Data:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="txtDataRegistro" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="LabelHora" runat="server" Text="Hora:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="txtHoraRegistro" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="LabelApto" runat="server" Text="APTO N°:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="txtApto" runat="server"></asp:TextBox>
					</td>
				</tr>
			</table>
			<asp:Button ID="btnConfirmarRegistro" runat="server" Text="CONFIRMAR" />
			<asp:Button ID="btnCancelarRegistro" runat="server" Text="CANCELAR" />
        </div>
 </asp:Content>
