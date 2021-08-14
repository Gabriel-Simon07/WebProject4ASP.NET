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
            Usuario usuario = ObterUsuarioPorLogin(login);
            return usuario.Login == login && usuario.Senha == senha;

        }

		public static bool VerificarUsuarioAdmin()
		{

			bool retorno = false;
			foreach (Usuario usuario in Functions.Todos())
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
			
			return Functions.Todos().Single(u => u.Id == id);

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
            {
                Usuario usuario = new Usuario();

                MySqlConnection conexao = new MySqlConnection(Functions.ObterConnectionString());

                string query = $"SELECT * FROM usuario WHERE id = '{id}' LIMIT 1";

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
                    /*error*/
                }

                finally
                {
                    conexao.Close();
                }

                return usuario;

            }
        }

        public static List<Usuario> Todos()
        {
            List<Usuario> lista = new List<Usuario>();

            MySqlConnection conexao = new MySqlConnection(Functions.ObterConnectionString());

            string query = "SELECT * FROM usuario";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            try
            {
                conexao.Open();

                MySqlDataReader dadoLido = comando.ExecuteReader();

                while (dadoLido.Read())
                {
                    lista.Add(new Usuario(dadoLido));
                }
            }
            catch (SqlException ex)
            {
                string ErrorMessage = ex.ToString();
            }
            return lista;
        }

        public static void Salvar(Usuario usuario)
        {

            MySqlConnection conexao = new MySqlConnection(Functions.ObterConnectionString());

            string query = "Insert into usuario (Nome, Email, Senha, Login, Foto) VALUES(@Nome" +
                ",@Email,@Senha,@Login,@Foto)";

            MySqlCommand comando = new MySqlCommand(query, conexao);
            try
            {
                conexao.Open();
				comando.Parameters.AddWithValue("@Nome", usuario.Nome);
				comando.Parameters.AddWithValue("@Email", usuario.Email);
				comando.Parameters.AddWithValue("@Senha", usuario.Senha);
				comando.Parameters.AddWithValue("@Login", usuario.Login);
				comando.Parameters.AddWithValue("@Foto", usuario.Foto);
				comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string ErrorMessage = ex.ToString();
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}