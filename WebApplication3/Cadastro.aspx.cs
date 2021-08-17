using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            pnlLista.Visible = true;
            bool logado = false;
            string loginNome = string.Empty;

            if (Session["Logado"] != null) { 
                logado = Convert.ToBoolean(Session["Logado"].ToString());
                loginNome = Session["NomeLogin"].ToString();
            }
            else
            {
                logado = false;
                loginNome = string.Empty;
            }

            if (logado) {               

                if (!IsPostBack) { 
                    GridViewUsuarios.DataSource = Functions.Todos();
                    GridViewUsuarios.DataBind();
                }

            } else { 
                pnlLista.Visible = false;
                Response.Write("<script>alert('Usuário não autenticado!</script> ");
            }
        }

        protected void BtnInserir_Click(object sender, EventArgs e)
        {
            string operacao = "INS";
            Response.Redirect($"CadastroUsuario.aspx?operacao={operacao}");
        }      

        protected void GridViewUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Alterar")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridViewUsuarios.Rows[rowIndex];

                Int32 id = int.Parse(row.Cells[1].Text);

                string operacao = "UPD";
                Response.Redirect($"CadastroUsuario.aspx?operacao={operacao}&id={id}");

                //ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert(' alterar Nome: " + nome + " E-mail: " + email + " Login: " + login + "');", true);
            }

            if (e.CommandName == "Excluir")
            {

                int rowIndex = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridViewUsuarios.Rows[rowIndex];

                Int32 id = int.Parse(row.Cells[1].Text);

                string operacao = "DEL";
                Response.Redirect($"CadastroUsuario.aspx?operacao={operacao}&id={id}");

                //ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert(' excluir Nome: " + nome + " E-mail: " + email + " Login: " + login + "');", true);

            }

        }


     
    }
}