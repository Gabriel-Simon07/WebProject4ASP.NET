<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RelatorioVisitas.aspx.cs" Inherits="WebApplication3.RelatorioVisitas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridVisitas" runat="server" AutoGenerateColumns="False">
				<Columns>
					<asp:BoundField HeaderText="ID" />
					<asp:BoundField HeaderText="DATA" />
					<asp:BoundField HeaderText="HORA" />
					<asp:BoundField HeaderText="NOME" />
					<asp:BoundField HeaderText="PLACA" />
					<asp:BoundField HeaderText="N° APTO" />
				</Columns>
			</asp:GridView>
        </div>
    </form>
</body>
</html>
