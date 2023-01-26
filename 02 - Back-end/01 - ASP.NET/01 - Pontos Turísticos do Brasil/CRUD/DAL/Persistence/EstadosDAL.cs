using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;
namespace DAL.Persistence
{
    public class EstadosDAL : Conexao
    {
        public List<Estados> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Estados", Con);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<Estados> lista = new List<Estados>();

                while (Dr.Read())
                {
                    Estados es = new Estados();

                    es.ID_Estado = Convert.ToInt32(Dr["ID_Estado"]);
                    es.Estado = Convert.ToString(Dr["Estado"]);

                    lista.Add(es);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar Estados" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
