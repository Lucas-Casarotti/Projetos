using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.Model;
using CRUD.Controller;

namespace CRUD.View
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarGrid();
            }
        }

        protected void ListarGrid()
        {
            PessoaController pc = new PessoaController();
            gridPessoas.DataSource = pc.Listar();
            gridPessoas.DataBind();
        }

        protected void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Endereco = txtEndereco.Text;
            p.Email = txtEmail.Text;

            PessoaController pc = new PessoaController();
            pc.Gravar(p);
            LimparCampos();
            Response.Redirect("/View/Index.aspx");
        }

        protected void btnBuscarNome_Click(object sender, EventArgs e)
        {
            string Nome = txtNomeBuscar.Text;
            PessoaController pc = new PessoaController();
            gridPessoas.DataSource = pc.PesquisarPorNome(Nome);
            gridPessoas.DataBind();
        }

        protected void btnFechar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ListarGrid();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32((sender as Button).CommandArgument);
            Session.Add("Codigo", Codigo);
            Response.Redirect("/View/Detalhes.aspx");
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32((sender as Button).CommandArgument);
            PessoaController pc = new PessoaController();
            pc.Excluir(Codigo);
            ListarGrid();
        }

        protected void gridPessoas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            PessoaController pc = new PessoaController();
            gridPessoas.DataSource = pc.Listar();
            gridPessoas.PageIndex = e.NewPageIndex;
            gridPessoas.DataBind();
        }

    }
}