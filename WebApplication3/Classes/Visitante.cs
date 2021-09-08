using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;


namespace WebApplication3
{
	public class Visitante
	{
		public Visitante() { }

		public Visitante(MySqlDataReader dadoLido)
		{
			this.IdVisitante = !dadoLido.IsDBNull(0) ? dadoLido.GetInt32(0) : 0;
			this.Nome = !dadoLido.IsDBNull(1) ? dadoLido.GetString(1) : "";
			this.Cpf = !dadoLido.IsDBNull(2) ? dadoLido.GetString(2) : "";
			this.Placa = !dadoLido.IsDBNull(3) ? dadoLido.GetString(3) : "";
		}

		public Visitante(Int32 id, string nome, string cpf, string placa)
		{
			this.IdVisitante = id;
			this.Nome = nome;
			this.Cpf = cpf;
			this.Placa = placa;
		}

		public Int32 IdVisitante { get; set; }
		public string Cpf{ get; set; }
		public string Nome{ get; set; }
		public string Placa{ get; set; }
	}
}