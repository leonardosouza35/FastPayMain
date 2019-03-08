using Fantasy.FastPay.Controller;
using Fantasy.FastPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms
{
    public partial class UsuarioForm : System.Web.UI.Page
    {
        #region Propriedades
        public UsuarioController _usuarioController;
        public UsuarioController UsuarioController
        {
            get{return _usuarioController ?? (_usuarioController = new UsuarioController());} 
        }
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            //Esta linha existe para carregar a tela com usuarios somente quando for...
            // A primeira vez que o usuario esta entrando na pagina
            // Ou quando usuario atualizar a página inteira com f5, ctrl + r            
            if (!IsPostBack)
            {
                CarregarUsuarios();
            }
            
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();

        }
        #endregion

        #region Metodos 

        private void CarregarUsuarios()
        {
            //Sessao, viewState, apllication State 
            Session["usuarios"] = UsuarioController.ObterTodos();
            var usuarios = Session["usuarios"];
            grdUsuario.DataSource = usuarios;
            grdUsuario.DataBind();
        }

        private void SalvarUsuario()
        {
            if (string.IsNullOrEmpty(txtNome.Text)
                || string.IsNullOrEmpty(txtSobreNome.Text))
            {
                lblMessage.Visible = true;                
            }
            else
            {
                lblMessage.Visible = false;
                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.SobreNome = txtSobreNome.Text;

                UsuarioController.AdicionarUsuario(usuario);

                Session["usuarios"] = UsuarioController.ObterTodos();

                grdUsuario.DataSource = Session["usuarios"];
                grdUsuario.DataBind();
            }
        }
        #endregion 
    }
}