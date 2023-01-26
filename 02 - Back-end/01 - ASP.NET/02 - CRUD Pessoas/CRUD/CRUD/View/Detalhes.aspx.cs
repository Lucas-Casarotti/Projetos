using CRUD.Controller;
using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD.View
{ 

    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int Codigo = Convert.ToInt32(Session["Codigo"]);
                ListarDados(Codigo);
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Codigo = Convert.ToInt32(Session["Codigo"]);
            p.Nome     = txtNome.Text;
            p.Endereco = txtEndereco.Text;
            p.Email    = txtEmail.Text;

            PessoaController pc = new PessoaController();
            pc.Atualizar(p);
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Index.aspx");
        }

        public void ListarDados(int Codigo)
        {
            PessoaController pc = new PessoaController();
            Pessoa p = pc.PesquisarPorCodigo(Codigo);
            
            if(p != null)
            {
                txtNome.Text     = p.Nome;
                txtEndereco.Text = p.Endereco;
                txtEmail.Text    = p.Email;
            }
        }
    }
}