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
        protected void Page_Load(object sender, EventArgs e)        {
            //Esta linha existe para carregar a tela com usuarios somente quando for...
            // A primeira vez que o usuario esta entrando na pagina
            // Ou quando usuario atualizar a página inteira com f5, ctrl + r            
            if (!IsPostBack)
            {
                CarregarUsuarios();
            }
            
        }

        /// <summary>
        /// Método (Evento) que é invocado pelo botão lá no aspx
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            // EU normalmente implemento o que faz este evento dentro de um método como o de baixo
            SalvarUsuario();

        }

        protected void grdUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "editar":
                    EditarUsuario(Convert.ToInt32(e.CommandArgument));
                    break;
                    
                case "deletar":
                    DeletarUsuario(Convert.ToInt32(e.CommandArgument));
                    break;
                default:
                    throw new Exception("Não foi possível editar ou deletar registro");                    
            }            
        }
        
        #endregion

        #region Metodos 

        private void CarregarUsuarios()
        {
            //Sessao, viewState, apllication State 
            //Session["usuarios"] = UsuarioController.ObterTodos();
            //var usuarios = Session["usuarios"]; 
            grdUsuario.DataSource = UsuarioController.ObterTodos();// Binding de dados
            grdUsuario.DataBind();
        }


        /// <summary>
        /// Método privado mas pode ser protected tbm, mas nem chega a fazer tanta diferença pq poucas são as vezes
        /// que referenciamos o codebehind a partir de outro codebehind
        /// </summary>
        private void SalvarUsuario()
        {
            /* e aqui temos algumas validações
               chamadas ao controller para adicionar e obter do modelo em memoria lá no DAO
             * e atualização no grid
             */
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

                if (modForm.Value.ToLower() == "incluir")
                {
                    UsuarioController.AdicionarUsuario(usuario);
                }
                else
                {
                    usuario.Id = Convert.ToInt32(hdUsuarioId.Value);
                    UsuarioController.AtualizarUsuario(usuario);
                }

                
                //aqui foi so para mostrar para vc como trabalhar ou amazenar dados na sessao, mas nao vamos precisar
                /// disso pelo menos por enquanto...
                /// // ta estranho do jeito que está
                /// // deixar essa linha comentada so como referência de como trabalhar com sessão
                //Session["usuarios"] = UsuarioController.ObterTodos();

                grdUsuario.DataSource = UsuarioController.ObterTodos();
                grdUsuario.DataBind();                
            }

            modForm.Value = "incluir";
        }


        private void DeletarUsuario(int usuarioId)
        {
            UsuarioController.DeletarUsuario(usuarioId);
            grdUsuario.DataSource = UsuarioController.ObterTodos();
            grdUsuario.DataBind();
        }

        private void EditarUsuario(int usuarioId)
        {
            var usuario = UsuarioController.ObterUsuario(usuarioId);
            txtNome.Text = usuario.Nome;
            txtSobreNome.Text = usuario.SobreNome;
            
            modForm.Value = "editar";
            hdUsuarioId.Value = usuario.Id.ToString();
            
        }
        #endregion 

    }
}