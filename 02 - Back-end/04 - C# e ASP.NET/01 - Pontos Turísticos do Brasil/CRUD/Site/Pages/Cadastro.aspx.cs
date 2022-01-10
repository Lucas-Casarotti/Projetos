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
    public partial class Cadastro : System.Web.UI.Page
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
                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;
                }
            }
        }

        protected void btnCadastroPT(object sender, EventArgs e)
        {
            try
            {
                PontosTuristicos pt = new PontosTuristicos();

                pt.Nome_PT       = txtNome_PT.Text;
                pt.Desc_PT       = txtDesc_PT.Text;
                pt.Endereco_PT   = txtEndereco_PT.Text;
                pt.Cidade_PT     = txtCidade_PT.Text;
                pt.ID_Estado = int.Parse(dp_pt.SelectedValue);


                PontosTuristicosDAL ptDal = new PontosTuristicosDAL();

                ptDal.Gravar(pt);
                lblMensagem.Text = "Ponto turístico cadastrado com sucesso!";
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}