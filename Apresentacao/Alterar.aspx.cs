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
    public partial class Alterar : System.Web.UI.Page
    {
        #region Carrega Pagina Principal
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            pnlMensagem.Visible = false;
        }
        #endregion

        #region Metodo Consultar Registros
        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtID.Text);
            InteracaoBancoDados dados = new InteracaoBancoDados();
            ModeloPessoa modelo = dados.Consultar(codigo);

            if (modelo != null){
                pnlIDConfirma.Visible = false;
                pnlDados.Visible = true;
                pnlBotoes.Visible = true;
                txtNome.Text = modelo.Nome;
                txtSobrenome.Text = modelo.Sobrenome;
                txtEndereco.Text = modelo.Endereco;
                txtTelefone.Text = modelo.Telefone;
                txtEmail.Text = modelo.Email;
                txtDataCad.Text = Convert.ToString((modelo.DataCad).ToShortDateString());
                txtDataAltCad.Text = Convert.ToString((DateTime.Now).ToShortDateString());
                txtNome.Focus();
            }
            else{
                pnlDados.Visible = false;
                pnlMensagem.Visible = true;
                lblMensagem.Text = "Esta pessoa não está cadastrada no Sistema";
                pnlBotoes.Visible = true;
                txtID.Text = string.Empty;
                txtID.Focus();
            }
        }
        #endregion

        #region Metodo Alterar Registros
        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            InteracaoBancoDados dados = new InteracaoBancoDados();
            ModeloPessoa mod = new ModeloPessoa();
            mod.Id = Convert.ToInt32(txtID.Text);
            mod.Nome = txtNome.Text;
            mod.Sobrenome = txtSobrenome.Text;
            mod.Endereco = txtEndereco.Text;
            mod.Telefone = txtTelefone.Text;
            mod.Email = txtEmail.Text;
            mod.DataAltCad = DateTime.Now;
            dados.alterar(mod);
            pnlMensagem.Visible = true;
            lblMensagem.Text = "Dados alterados com sucesso!";
            pnlIDConfirma.Visible = true;
            txtID.Text = string.Empty;
            txtID.Focus();
        }
        #endregion

        #region Metodo Nova Consulta
        protected void btnNConsulta_Click(object sender, EventArgs e)
        {
            pnlIDConfirma.Visible = true;
            pnlDados.Visible = false;
            pnlMensagem.Visible = false;
            txtID.Text = string.Empty;
            txtID.Focus();
        }
        #endregion

        #region Carregar Pagin Principal
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
        #endregion
    }
}