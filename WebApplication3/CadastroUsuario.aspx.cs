using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnIncluir.Visible = true;
            btnAtualiza.Visible = true;
            btnExcluir.Visible = true;
            pnlCadastro.Visible = true;

            string operacao = Request.QueryString["operacao"];
            if (operacao != null)
            {
                if (!IsPostBack)
                {
                    if (operacao == "INS") 
                    {
                        inputUsuarioNome.Text = string.Empty;
                        inputUsuarioEmail.Text = string.Empty;
                        inputCadastroLogin.Text = string.Empty;
                        inputCadastroSenha.Text = string.Empty;
                        //btnIncluir.Visible = true;
                        //btnAtualiza.Visible = false;
                        //btnExcluir.Visible = false;

                    }
                    else if (operacao == "UPD") 
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            Int32 id = int.Parse(Request.QueryString["id"]);
                            Usuario usuario = Functions.ObterUsuario(id);
                            inputUsuarioNome.Text = usuario.Nome;
                            inputUsuarioEmail.Text = usuario.Email;
                            inputCadastroLogin.Text = usuario.Login;
                            inputCadastroSenha.Text = usuario.Senha;
                            //inputFoto.FileContent = System.Configuration.ConfigurationManager.AppSettings
                            //["caminhoArquivo"].Replace(@"\", "/") + "/" + foto.FileName;
                            inputId.Text = usuario.Id.ToString();

							btnIncluir.Visible = true;
							btnAtualiza.Visible = true;
							btnExcluir.Visible = true;
						}
                    }
                    else if (operacao == "DEL") 
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            Int32 id = int.Parse(Request.QueryString["id"]);
                            Usuario usuario = Functions.ObterUsuario(id);
                            inputUsuarioNome.Text = usuario.Nome;
                            inputUsuarioEmail.Text = usuario.Email;
                            inputCadastroLogin.Text = usuario.Login;
                            inputCadastroSenha.Text = usuario.Senha;
                            inputId.Text = usuario.Id.ToString();
                           
                            //btnIncluir.Visible = false;
                            //btnAtualiza.Visible = false;
                            //btnExcluir.Visible = true;
                        }
                    }
                    else
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            Int32 id = int.Parse(Request.QueryString["id"]);
                            Usuario usuario = Functions.ObterUsuario(id);
                            inputUsuarioNome.Text = usuario.Nome;
                            inputUsuarioEmail.Text = usuario.Email;
                            inputCadastroLogin.Text = usuario.Login;
                            inputCadastroSenha.Text = usuario.Senha;
                            //operacao == "DSP" --Display
                            
                        }
                    }
                }
            }
        }

        protected void BtnIncluir_Click(object sender, EventArgs e)
        {
           Usuario usuario = new Usuario();
            CadastrarUsuario(inputUsuarioNome.Text, inputUsuarioEmail.Text, inputCadastroLogin.Text, inputCadastroSenha.Text, inputFoto);
            Functions.Salvar(usuario);
            
            Response.Redirect("Cadastro.aspx");
        }

        protected void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarUsuario(inputId.Text, inputUsuarioNome.Text, inputUsuarioEmail.Text, inputCadastroLogin.Text, inputCadastroSenha.Text, inputFoto);
            Response.Redirect("Cadastro.aspx");
        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {
            RemoverUsuario(inputId.Text);
            Response.Redirect("Cadastro.aspx");
        }

        private void CadastrarUsuario(string nome, string email, string login, string senha, FileUpload foto)
        {

            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["caminhoArquivo"] + @"\" + foto.FileName;
            inputFoto.SaveAs(caminhoArquivo);
            Usuario usuario = new Usuario();
            

            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Login = login;
            usuario.Senha = senha;
            usuario.Foto = System.Configuration.ConfigurationManager.AppSettings
                ["caminhoArquivo"].Replace(@"\", "/") + "/" + foto.FileName;
            Functions.Salvar(usuario);
        }

        private void AtualizarUsuario(string id, string nome, string email, string login, string senha, FileUpload foto)
        {
            Usuario usuario = Functions.ObterUsuarioPorId(int.Parse(id));
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Login = login;
            usuario.Senha = senha;
            usuario.Foto = System.Configuration.ConfigurationManager.AppSettings
                ["caminhoArquivo"].Replace(@"\", "/") + "/" + foto.FileName;
        }

        private void RemoverUsuario(string id)
        {
            Usuario usuario = Functions.ObterUsuario(int.Parse(id));
            Functions.Todos().Remove(usuario);
        }
    }
}
