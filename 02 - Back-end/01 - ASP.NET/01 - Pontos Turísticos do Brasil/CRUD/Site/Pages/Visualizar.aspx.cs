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
    public partial class Visualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    EstadosDAL es = new EstadosDAL();


                    List<Estados> lista = new List<Estados>();
                    lista = es.Listar();

                    for (int cont = 0; lista.Count > cont; cont++)
                    {
                        ListItem item = new ListItem(lista[cont].Estado, lista[cont].ID_Estado.ToString());
                        dp_pt.Items.Add(item);
                    }

                    int ID_PT = Convert.ToInt32(Session["idPT"]);

                    ListarDados(ID_PT);
                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;
                }
            }
        }

        public void ListarDados(int ID_PT)
        {
            try
            {

                PontosTuristicosDAL ptDal = new PontosTuristicosDAL();
                PontosTuristicos pt = ptDal.PesquisarPorID(ID_PT);
                if (pt != null)
                {

                    txtNome_PT.Text = pt.Nome_PT;
                    txtDesc_PT.Text = pt.Desc_PT;
                    txtEndereco_PT.Text = pt.Endereco_PT;
                    txtCidade_PT.Text = pt.Cidade_PT;
                    dp_pt.SelectedIndex = (pt.ID_Estado - 1);
                }
                else
                {
                    lblMensagem1.Text = "Ponto turístico não encontrado";

                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }

    

}