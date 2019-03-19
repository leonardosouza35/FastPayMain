using Fantasy.FastPay.Application;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Services;
using Fantasy.FastPay.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms
{
    public partial class CadastroUsuarioForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SalvarUsuario();

            if (!IsPostBack)
            {
                CarregarCampos();
            }
        }

        private void CarregarCampos()
        {
            
            txtNome.Text =  Session["Nome"].ToString();            
            txtEmail.Text = Session["Email"].ToString();                        
        }

        private void SalvarUsuario(){

            var usuario = new Usuario();

            var usuarioRepository = new UsuarioRepository();
            var usuarioService = new UsuarioService(usuarioRepository);            
            var usuarioAppService = new UsuarioAppService(usuarioService);

            usuarioAppService.Adicionar(usuario);

            //if(!usuarioAppService.IsValidated)
            //       usuarioAppService.ValidationMessages
            
        }
    }
}