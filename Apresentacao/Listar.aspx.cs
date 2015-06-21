using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObjetoTransferencia;
using Negocio;

namespace Apresentacao
{
    public partial class Listar : System.Web.UI.Page
    {
        #region Metodo Carrega Pagina
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        #endregion

        #region Metodo Carregar Grid
        protected void CarregarGrid()
        {
            InteracaoBancoDados conect = new InteracaoBancoDados();
            gvPessoas.DataSource = conect.Listar();
            gvPessoas.DataBind();
        }
        #endregion

        #region Metodo Carrega Principal
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");           
        }
        #endregion

        #region Metodo Paginacao do Grid
        protected void gvPessoas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            InteracaoBancoDados conect = new InteracaoBancoDados();
            gvPessoas.PageIndex = e.NewPageIndex;
            gvPessoas.DataSource = conect.Listar();
            gvPessoas.DataBind();
        }
        #endregion
    }
}