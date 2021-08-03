<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.CadastroUsuario" %>

<asp:Content ID="Content" ContentPlaceHolderId="Content" runat="server">
   
        <div>
            <asp:Panel ID="pnlCadastro" runat="server">
                <asp:Label ID="lblOperacao" runat="server" Text="Operacao"></asp:Label>
                <table ID="tblCadastro" runat="server">
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="labelId" runat="server" Text="ID"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="inputId" runat="server" ReadOnly="true"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelNome" runat="server" Text="Nome"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputUsuarioNome" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="inputUsuarioNome" ErrorMessage="Informe o nome"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        
                        <td>
                            <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputUsuarioEmail" runat="server" ></asp:TextBox>                            
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="inputUsuarioEmail" ErrorMessage="Informe o Email"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelLogin" runat="server" Text="Login"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputCadastroLogin" runat="server" ></asp:TextBox>                            
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="inputCadastroLogin" ErrorMessage="Informe o login"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelSenha" runat="server" Text="Senha"></asp:Label>
                        </td>                    
                        <td>
                            <asp:TextBox ID="inputCadastroSenha" type="password" runat="server" ></asp:TextBox>                            
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="inputCadastroSenha" ErrorMessage="Informe a senha"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="labelFoto" runat="server" Text="Foto"></asp:Label>
                        </td>
                        <td>
                            <asp:FileUpload ID="inputFoto" runat="server"/>

                        	<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="inputFoto" ErrorMessage="Anexe uma foto"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                </table>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                 <hr />
                <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="BtnIncluir_Click" />
                <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar" OnClick="BtnAtualizar_Click" />
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="BtnExcluir_Click" />
            </asp:Panel>
        </div>


    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
    </asp:Content>
