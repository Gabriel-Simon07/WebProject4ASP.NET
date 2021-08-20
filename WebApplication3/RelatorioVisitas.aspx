<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RelatorioVisitas.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.RelatorioVisitas" %>

	<asp:Content ID="ContentVisitantes" ContentPlaceHolderId="Content" runat="server">
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
			<asp:Button ID="btnVoltar" runat="server" Text="VOLTAR" />
        </div>
	</asp:Content>
