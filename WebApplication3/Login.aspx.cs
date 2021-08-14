using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Cadastro2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { 
                inputLogin.Text = string.Empty;
                inputSenha.Text = string.Empty;
            }
            
            if (HttpContext.Current.Session["Logado"] == null)
            {
                Session["Login"] = string.Empty;
                Session["Logado"] = false;
            }
        }

        protected void BtnConfirmarLogin_Click(object sender, EventArgs e)
        {
            bool temError = false;
            string mensagemErro = string.Empty;

            string senha = inputSenha.Text;
            string login = inputLogin.Text;

            if (!temError)
            {
                if (login == string.Empty)
                {
                    temError = true;
                    mensagemErro = "Informe um login valido! (" + login + ")";
                }
            }

            if (!temError)
            {
                if (senha == string.Empty)
                {
                    temError = true;
                    mensagemErro = "Informe uma senha válida!";
                }
            }

            if (!temError)
            {
                if (Functions.ValidarLogin(login, senha))
                {
                    Session["NomeLogin"] = login;
                    Session["Logado"] = true;
                    inputLogin.Enabled = false;
                    inputSenha.Visible = false;
                    btnConfirmaLogin.Visible = false;
                }
                else
                {
                    temError = true;
                    mensagemErro = "usuário ou senha incorreto!(" + login + ")(" + senha + ")";
                }
            }


            if (temError)
            {
                Response.Write("<script>alert('Erro: " + mensagemErro + " " + login + "')</script>");
            }
            
            
        }

		protected void inputLogin_TextChanged(object sender, EventArgs e)
		{

		}
	}
}