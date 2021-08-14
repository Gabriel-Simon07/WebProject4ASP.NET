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

        public Usuario(MySqlDataReader dadoLido)
		{
            this.Id = !dadoLido.IsDBNull(0) ? dadoLido.GetInt32(0) : 0;
            this.Nome = !dadoLido.IsDBNull(1) ? dadoLido.GetString(1) : "";
            this.Email = !dadoLido.IsDBNull(2) ? dadoLido.GetString(2) : "";
            this.Senha = !dadoLido.IsDBNull(3) ? dadoLido.GetString(3) : "";
            this.Login = !dadoLido.IsDBNull(4) ? dadoLido.GetString(4) : "";
            this.Foto = !dadoLido.IsDBNull(5) ? dadoLido.GetString(5) : "";
        }

        public Usuario(string nome, string senha, string email, string login, string foto)
		{
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.Login = login;
            this.Foto = foto;
		}

        public Int32 Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Login { get; set; }

        public string Foto { get; set; }

		

    }
}