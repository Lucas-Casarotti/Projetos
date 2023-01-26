using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRUD.Controller
{
    public class Conexao
    {
        // ATRIBUTOS 
        // ESTABELECER A CONEXÃO COM O BANCO
        protected SqlConnection Con;
        // UTILIZADO PARA ESCREVER E EXECUTAR QUERYS NO BANCO
        protected SqlCommand Cmd;
        // UTILIZADO PARA LER REGISTRO DAS QUERYS, OU SEJA, DE UM SELECT
        protected SqlDataReader Dr;

        protected void AbrirConexao()
        {
            Con = new SqlConnection("Data Source=DESKTOP-3KK17LJ\\SQLEXPRESS;Initial Catalog=Pessoas;Integrated Security=True");
            Con.Open();
        }

        protected void FecharConexao()
        {
            Con.Close();
        }
    }
}