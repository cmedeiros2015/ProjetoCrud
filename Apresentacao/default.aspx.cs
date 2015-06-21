using System;

namespace Apresentacao
{
    public partial class _default : System.Web.UI.Page
    {
        #region Metodo Carregar Página
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlMensagem.Visible = false;
        }
        #endregion

        #region Metodo Escolha
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string opcao = ddlEscolha.SelectedValue;
            switch (opcao)
            {
                case "0":
                    pnlMensagem.Visible = true;
                    lblMensagem.Text = "Escolha uma opção válida!";
                    ddlEscolha.Focus();
                    break;
                case "1":
                    Response.Redirect("Cadastrar.aspx");
                    break;
                case "2":
                    Response.Redirect("Listar.aspx");
                    break;
                case "3":
                    Response.Redirect("Consultar.aspx");
                    break;
                case "4":
                    Response.Redirect("Alterar.aspx");
                    break;
                case "5":
                    Response.Redirect("Sobre.aspx");
                    break;
                case "6":
                    Response.Redirect("Login.aspx");
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}