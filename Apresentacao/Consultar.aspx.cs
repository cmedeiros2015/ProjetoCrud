using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class Consultar : System.Web.UI.Page
    {
        #region Carrega Pagina
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            pnlMensagem.Visible = false;
        }
        #endregion

        #region Carrega Pagina Principal
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
        #endregion

        #region Metodo para Excluir Registros
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            InteracaoBancoDados dados = new InteracaoBancoDados();
            dados.Excluir(Convert.ToInt32(txtID.Text));
            pnlMensagem.Visible = true;
            lblMensagem.Text = "Usuário foi excluído(a) com Sucesso!";
            pnlIDConfirma.Visible = true;
            txtID.Text = string.Empty;
            txtID.Focus();
        }
        #endregion

        #region Metodo Consulta Registros
        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtID.Text);
            InteracaoBancoDados dados = new InteracaoBancoDados();
            ModeloPessoa modelo = dados.Consultar(codigo);

            if (modelo != null)
            {
                pnlIDConfirma.Visible = false;
                pnlDados.Visible = true;
                pnlBotoes.Visible = true;
                txtNome.Text = modelo.Nome;
                txtSobrenome.Text = modelo.Sobrenome;
                txtEndereco.Text = modelo.Endereco;
                txtTelefone.Text = modelo.Telefone;
                txtEmail.Text = modelo.Email;
                txtDataCad.Text = Convert.ToString((modelo.DataCad).ToShortDateString());
                string data = Convert.ToString((modelo.DataAltCad).ToShortDateString());
                if (data == "01/01/0001" || data == "")
                {
                    txtDataAltCad.Text = string.Empty;
                }
                else {
                    txtDataAltCad.Text = data;
                }
            }
            else
            {
                pnlDados.Visible = false;
                pnlMensagem.Visible = true;
                lblMensagem.Text = "Esta pessoa não está cadastrada no Sistema!";
                pnlBotoes.Visible = true;
                txtID.Text = string.Empty;
                txtID.Focus();
            }
        }
        #endregion

        #region Nova Consulta Registros
        protected void btnNConsulta_Click(object sender, EventArgs e)
        {
            pnlIDConfirma.Visible = true;
            pnlDados.Visible = false;
            txtID.Text = string.Empty;
            txtID.Focus();
        }
        #endregion
    }
}