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
    public partial class Cadastrar : System.Web.UI.Page
    {
        #region Metodo Limpa Campos
        public void LimpaCampos(Control controle)
        {
            foreach (Control campos in controle.Controls)
            {
                if (campos is TextBox)
                {
                    ((TextBox)campos).Text = string.Empty;
                }
                else if (campos.Controls.Count > 0)
                {
                    LimpaCampos(campos);
                }
            }
        }
        #endregion

        #region Metodo Inserir Dados
        private void InserirDados()
        {
            try
            {
                InteracaoBancoDados dados = new InteracaoBancoDados();
                ModeloPessoa modelo = new ModeloPessoa();

                modelo.Nome = txtNome.Text;
                modelo.Sobrenome = txtSobrenome.Text;
                modelo.Endereco = txtEndereco.Text;
                modelo.Telefone = txtTelefone.Text;
                modelo.Email = txtEmail.Text;
                modelo.DataCad = DateTime.Now;
                dados.Gravar(modelo);
                pnlMensagem.Visible = true;
                lblMensagem.Text = "Sr(a)" + " " + txtNome.Text + 
                    " " + txtSobrenome.Text + 
                        " " + "cadastrado(a) com Sucesso!";
                LimpaCampos(this);
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion

        #region Carregar Pagina
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlMensagem.Visible = false;
            txtNome.Focus();
            txtDataCad.Text = Convert.ToString((DateTime.Now).ToShortDateString());
        }
        #endregion

        #region Recarrega Pagina Principal
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
        #endregion

        #region Evento Gravar Dados
        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                InserirDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Não foi possível gravar dados no banco. Mais detalhes: " + ex.Message;
            }
        }
        #endregion

        #region Evento Recarrega Pagina
        protected void btnOK_Click(object sender, EventArgs e)
        {
            txtNome.Focus();
            pnlMensagem.Visible = false;
        }
        #endregion
    }
}