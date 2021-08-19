<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visitantes.aspx.cs" Inherits="WebApplication3.Visitantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="telaVisitantes" runat="server">
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
     </form>
</body>
</html>
