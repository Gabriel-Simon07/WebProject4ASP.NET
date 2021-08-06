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
    public class Usuario
    {
        public Usuario() { }
        public Usuario(MySqlDataReader dadoLido) {
            this.Id = dadoLido.GetInt32(0);
            this.Nome = dadoLido.GetString(1);
            this.Email = dadoLido.GetString(2);
            this.Senha = dadoLido.GetString(3);
            this.Login = dadoLido.GetString(4);
            this.Foto = dadoLido.GetString(5);
        }
        //TODO
  //      public Usuario(string)
		//{

		//}

        public Int32 Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Login { get; set; }

        public string Foto { get; set; }

		public static List<Usuario> Lista = new List<Usuario>();

		public List<Usuario> Todos()
		{
            List<Usuario> lista = new List<Usuario>();

            MySqlConnection conexao = new MySqlConnection(Functions.ObterConnectionString());

            string query = "SELECT * FROM usuario";

            MySqlCommand comando = new MySqlCommand(query, conexao);
			//return Usuario.Lista;
			try
			{
                conexao.Open();

                MySqlDataReader dadoLido = comando.ExecuteReader();

				while (dadoLido.Read())
				{
                    lista.Add(new Usuario(dadoLido));
				}
			}
			catch
			{

			}
            return lista;
		}

		//public void Salvar()
		//{

		//	Usuario.Lista.Add(this);

		//}
		public void Salvar()
		{
            MySqlConnection conexao = new MySqlConnection(Functions.ObterConnectionString());

            string query = "Insert into usuario (Nome, Email, Senha, Login, Foto) VALUES(@Nome" +
                ",@Email,@Senha,@Login,@Foto)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

			try
			{
                conexao.Open();
                comando.Parameters.AddWithValue("@Nome", this.Nome);
                comando.Parameters.AddWithValue("@Email", this.Email);
                comando.Parameters.AddWithValue("@Senha", this.Senha);
                comando.Parameters.AddWithValue("@Login", this.Login);
                comando.Parameters.AddWithValue("@Foto", this.Foto);
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