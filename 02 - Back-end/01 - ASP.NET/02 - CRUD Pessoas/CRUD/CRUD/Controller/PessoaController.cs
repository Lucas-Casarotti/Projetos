using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CRUD.Model;
namespace CRUD.Controller
{
    public class PessoaController : Conexao
    {
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                string sql = @"INSERT INTO dbo.Pessoas (Nome, Endereco, Email) 
                               VALUES (@V1, @V2, @V3)";
                Cmd = new SqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@V1", p.Nome);
                Cmd.Parameters.AddWithValue("@V2", p.Endereco);
                Cmd.Parameters.AddWithValue("@V3", p.Email);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar o Pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                string sql = @"UPDATE dbo.Pessoas 
                               SET Nome=@V1, Endereco=@V2, Email=@V3 WHERE Codigo=@V4";
                Cmd = new SqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@V1", p.Nome);
                Cmd.Parameters.AddWithValue("@V2", p.Endereco);
                Cmd.Parameters.AddWithValue("@V3", p.Email);
                Cmd.Parameters.AddWithValue("@V4", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                string sql = @"DELETE FROM dbo.Pessoas 
                               WHERE Codigo=@V1";
                Cmd = new SqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@V1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Excluir Pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                string sql = @"SELECT * 
                               FROM dbo.Pessoas";
                Cmd = new SqlCommand(sql, Con);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<Pessoa> lista = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Codigo   = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome     = Convert.ToString(Dr["Nome"]);
                    p.Email    = Convert.ToString(Dr["Email"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);

                    lista.Add(p);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar pessoas" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pessoa PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                string sql = @"SELECT * 
                               FROM dbo.Pessoas 
                               WHERE Codigo=@V1";
                Cmd = new SqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@V1", Codigo);
                SqlDataReader Dr = null;
                // ExecuteReader: É UTILIZADO PARA EXECUTAR UMA QUERY QUE RETORNA UM DATAREADER(QUE RETORNA DADOS, POR EXEMPLO UM SELECT)
                // NESTE CASO ESTÁ EXECUTANDO A VARIÁVEL "CMD" E NELA CONTÉM UMA QUERY
                Dr = Cmd.ExecuteReader();
                Pessoa p = new Pessoa();
                if (Dr.Read())
                {
                    p.Nome     = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email    = Convert.ToString(Dr["Email"]);
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Pesquisar Pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> PesquisarPorNome(string Nome)
        {
            try
            {
                AbrirConexao();
                string sql = @"SELECT *
                               FROM fn_BuscarNome(@V1)";
                Cmd = new SqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@V1", Nome);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<Pessoa> lista = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Codigo   = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome     = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email    = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Pesquisar Pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}