using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
	public partial class Visitantes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
			
		}
		protected void CadastrarVisitante(string nome, string placa, string cpf, Int32 id)
		{
			Visitante visitante = new Visitante();

			visitante.Nome = nome;
			visitante.Placa = placa;
			visitante.Cpf = cpf;
			visitante.IdVisitante = id;
		}
	}
}