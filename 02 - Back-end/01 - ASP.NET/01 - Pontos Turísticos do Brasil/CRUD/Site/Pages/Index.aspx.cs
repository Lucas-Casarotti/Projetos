using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
namespace Site.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    ListarGrid();

                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;
                }
            }
        }

        protected void ListarGrid()
        {
            PontosTuristicosDAL pt = new PontosTuristicosDAL();
            gridPT.DataSource = pt.Listar();
            gridPT.DataBind();
        }

        protected void btnBuscarNomePT(object sender, EventArgs e)
        {
            try
            {

                string Nome_PT = txtNome_PT.Text;
                PontosTuristicosDAL ptDal = new PontosTuristicosDAL();                
                gridPT.DataSource = ptDal.PesquisarPorNome(Nome_PT);
                gridPT.DataBind();
                
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        // PAGINAÇÃO
        protected void gridPT_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           
            PontosTuristicosDAL pt = new PontosTuristicosDAL();
            gridPT.DataSource = pt.Listar();
            gridPT.PageIndex = e.NewPageIndex;
            gridPT.DataBind();
        }

        protected void btnExcluirPT(object sender, EventArgs e)
        {
            try
            {
                int ID_PT = Convert.ToInt32((sender as Button).CommandArgument);

                PontosTuristicos pt = new PontosTuristicos();
                PontosTuristicosDAL ptDal = new PontosTuristicosDAL();

                ptDal.Excluir(ID_PT);
                ListarGrid();
                
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnEditarPT(object sender, EventArgs e)
        {
            int ID_PT = Convert.ToInt32((sender as Button).CommandArgument);
            Session.Add("idPT", ID_PT);
            Response.Redirect("Detalhes.aspx");
        }

        protected void btnVisualizarPT(object sender, EventArgs e)
        {
            int ID_PT = Convert.ToInt32((sender as Button).CommandArgument);
            Session.Add("idPT", ID_PT);
            Response.Redirect("Visualizar.aspx");
        }
    }
}