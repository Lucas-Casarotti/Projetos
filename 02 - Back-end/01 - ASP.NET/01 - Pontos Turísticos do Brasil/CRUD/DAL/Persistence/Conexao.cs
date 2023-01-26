using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.NET -> SQL SERVER
namespace DAL.Persistence
{
    public class Conexao
    {
        
        protected SqlConnection Con; //ESTABELECER CONEXAO
        protected SqlCommand Cmd;    //EXECUTAR COMANDOS SQL NO BANCO
        protected SqlDataAdapter Dr; //LER REGISTROS DE QUERYS

        
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=DESKTOP-GNRB423\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
