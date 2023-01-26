using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;
namespace DAL.Persistence
{
    public class PontosTuristicosDAL : Conexao
    {
        

        public void Gravar(PontosTuristicos pt)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into PontosTuristicos (Nome_PT, Desc_PT, Endereco_PT, Cidade_PT, ID_Estado) values(@v1, @v2, @v3, @v4, @v5)", Con);

                Cmd.Parameters.AddWithValue("@v1", pt.Nome_PT);
                Cmd.Parameters.AddWithValue("@v2", pt.Desc_PT);
                Cmd.Parameters.AddWithValue("@v3", pt.Endereco_PT);
                Cmd.Parameters.AddWithValue("@v4", pt.Cidade_PT);
                Cmd.Parameters.AddWithValue("@v5", pt.ID_Estado);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar Ponto turístico" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(int ID_PT)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from PontosTuristicos where ID_PT=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", ID_PT);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir Ponto turístico" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(PontosTuristicos pt)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update PontosTuristicos set Nome_PT=@v1, Desc_PT=@v2, Endereco_PT=@v3, Cidade_PT=@v4, ID_Estado=@v5 where ID_PT=@v6", Con);

                Cmd.Parameters.AddWithValue("@v1", pt.Nome_PT);
                Cmd.Parameters.AddWithValue("@v2", pt.Desc_PT);
                Cmd.Parameters.AddWithValue("@v3", pt.Endereco_PT);
                Cmd.Parameters.AddWithValue("@v4", pt.Cidade_PT);
                Cmd.Parameters.AddWithValue("@v5", pt.ID_Estado);

                Cmd.Parameters.AddWithValue("@v6", pt.ID_PT);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<PontosTuristicos> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from PontosTuristicos", Con);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<PontosTuristicos> lista = new List<PontosTuristicos>();

                while (Dr.Read())
                {
                    PontosTuristicos pt = new PontosTuristicos();
                    pt.ID_PT = Convert.ToInt32(Dr["ID_PT"]);
                    pt.Nome_PT = Convert.ToString(Dr["Nome_PT"]);
                    pt.Endereco_PT = Convert.ToString(Dr["Endereco_PT"]);
                    pt.Cidade_PT = Convert.ToString(Dr["Cidade_PT"]);

                    lista.Add(pt);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar pontos turísticos" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public PontosTuristicos PesquisarPorID(int ID_PT)
        {
            try
            {
                AbrirConexao();
                string SQL = "SELECT PontosTuristicos.Nome_PT,                        " +
                             "       PontosTuristicos.Desc_PT,                        " +
                             "	   PontosTuristicos.Endereco_PT,                      " +
                             "	   PontosTuristicos.Cidade_PT,                        " +
                             "     Estados.ID_Estado,                                 " +
                             "	   Estados.Estado                                     " +
                             "FROM dbo.PontosTuristicos WITH(NOLOCK)                  " +
                             "     INNER JOIN dbo.Estados WITH(NOLOCK)                " +
                             "     ON Estados.ID_Estado = PontosTuristicos.ID_Estado  " +
                             "WHERE PontosTuristicos.ID_PT = @v1";

                
                Cmd = new SqlCommand(SQL, Con);
                Cmd.Parameters.AddWithValue("@v1", ID_PT);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                PontosTuristicos pt = null; 

                if (Dr.Read())
                {
                    pt = new PontosTuristicos();

                    pt.Nome_PT = Convert.ToString(Dr["Nome_PT"]);
                    pt.Desc_PT = Convert.ToString(Dr["Desc_PT"]);
                    pt.Endereco_PT = Convert.ToString(Dr["Endereco_PT"]);
                    pt.Cidade_PT = Convert.ToString(Dr["Cidade_PT"]);
                    pt.ID_Estado = Convert.ToInt32(Dr["ID_Estado"]);
                    
                }
                return pt;
            }
            catch (Exception ex)
            {

                throw new Exception("Ponto turístico não encontrado" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<PontosTuristicos> PesquisarPorNome(string Nome_PT)
        {
            try
            {
                AbrirConexao();
                string SQL = string.Format("select * from PontosTuristicos where Nome_PT like('%{0}%')", Nome_PT);
                Cmd = new SqlCommand(SQL, Con);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<PontosTuristicos> lista = new List<PontosTuristicos>();

                while (Dr.Read())
                {
                    PontosTuristicos pt = new PontosTuristicos();
                    pt.ID_PT = Convert.ToInt32(Dr["ID_PT"]);
                    pt.Nome_PT = Convert.ToString(Dr["Nome_PT"]);
                    pt.Endereco_PT = Convert.ToString(Dr["Endereco_PT"]);
                    pt.Cidade_PT = Convert.ToString(Dr["Cidade_PT"]);

                    lista.Add(pt);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Ponto turístico não encontrado" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
