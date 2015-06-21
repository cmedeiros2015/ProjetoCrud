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
    public partial class Login : System.Web.UI.Page
    {
        #region Metodos

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

        #region Metodo Login Usuário
        private void ConfirmaUsuario(ModeloLoginPessoa loginMod)
        {
            InteracaoBancoDados login = new InteracaoBancoDados();
            loginMod.email = txtEmail.Text;
            loginMod.senha = txtSenha.Text;
            login.LogarUsuario(loginMod);

            if (!login.LogarUsuario(loginMod)){
                lblMensagem.Text = "Usuário não está cadastrado no Sistema!";
                LimpaCampos(this);
                txtEmail.Focus();
            }else{
                Response.Redirect("default.aspx");
            }
        }
        #endregion

        #endregion

        #region Eventos

        #region Evento Carregar Página
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LimpaCampos(this);
                txtEmail.Focus();
            }
        }
        #endregion

        #region Evento Logar Usuário
        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            ModeloLoginPessoa mod = new ModeloLoginPessoa();
            ConfirmaUsuario(mod);
            LimpaCampos(this);
            txtEmail.Focus();
        }
        #endregion

       #endregion
    }
}