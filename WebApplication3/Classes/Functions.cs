using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public class Functions
    {

        public static bool ValidarLogin(string login, string senha)
        {

            //bool retorno = false;
            //foreach (Usuario usuario in Usuario.Lista)
            //{
            //    if (usuario.Login == login)
            //    {
            //        if (usuario.Senha == senha)
            //        {
            //            retorno = true;
            //            break;
            //        }
            //    }
            //}
            //return retorno;
            Usuario usuario = ObterUsuarioPorLogin(login);
            return usuario.Login == login && usuario.Senha == senha;

        }

        public static bool VerificarUsuarioAdmin()
        {

            bool retorno = false;
            foreach (Usuario usuario in Usuario.Lista)
            {
                if (usuario.Login == "admin")
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;

        }

        public static Usuario ObterUsuario(Int32 id)
        {
            Usuario usuario;
            return usuario = Usuario.Lista.Single(u => u.Id == id);
        
        }

        public static string ObterConnectionString()
        {
            return "server=localhost;user id=root;sslmode=None;database=senai_sis";
        }

        public static Usuario ObterUsuarioPorLogin(string login)
		{
            Usuario usuario = new Usuario();

            MySqlConnection conexao = new MySqlConnection(Functions.ObterConnectionString());

            string query = $"SELECT * FROM usuario WHERE Login = '{login}'LIMIT 1";

            MySqlCommand comando = new MySqlCommand(query, conexao);
			try
			{
                conexao.Open();

                MySqlDataReader dadoLido = comando.ExecuteReader();
				while (dadoLido.Read())
				{
                    usuario = (new Usuario(dadoLido));
				}
			}
			catch 
			{
                //tratamento do erro
			}
			finally
			{
                conexao.Close();
			}
            return usuario;
		}

        public static Usuario ObterUsuarioPorId(Int32 id)
		{

		}

    }
}