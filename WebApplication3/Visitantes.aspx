<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visitantes.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.Visitantes" %>

    <asp:Content ID="ContentVisitantes" ContentPlaceHolderId="Content" runat="server">
        <div>
			<table>
				<tr>
					<td>
                        <asp:Label ID="LabelCpfVisitante" runat="server" Text="CPF:"></asp:Label>
					</td>
                    <td>
                        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
                   </td>
				</tr>
			    <tr>
                    <td>
                        <asp:Label ID="LabelNomeVisitante" runat="server" Text="Nome:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNomeVisitante" runat="server"></asp:TextBox>
                    </td>
			    </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelPlaca" runat="server" Text="Placa :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPlacaCarro" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
                <asp:Button ID="btnConfirmar" runat="server" Text="CONFIRMAR" />
                <asp:Button ID="btnFechar" runat="server" Text="FECHAR" />
        </div>
    </asp:Content>
     
