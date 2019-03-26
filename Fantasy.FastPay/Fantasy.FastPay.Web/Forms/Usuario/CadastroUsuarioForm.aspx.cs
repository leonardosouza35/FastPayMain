using Fantasy.FastPay.Application;
using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
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
        public IUsuarioAppService _usuarioAppService;
        public IUsuarioAppService UsuarioAppService
        {
            get
            {
                IUsuarioRepository repository = new UsuarioRepository();
                IUsuarioService service = new UsuarioService(repository);
                _usuarioAppService = new UsuarioAppService(service);
                return _usuarioAppService;
            }
        }

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
            
            //txtNome.Text =  Session["Nome"].ToString();            
            //txtEmail.Text = Session["Email"].ToString();                        
        }

        private void SalvarUsuario(){

            //var usuario = new Usuario();

            //var usuarioRepository = new UsuarioRepository();
            //var usuarioService = new UsuarioService(usuarioRepository);            
            //var usuarioAppService = new UsuarioAppService(usuarioService);

            //usuarioAppService.Adicionar(usuario);

            //if(!usuarioAppService.IsValidated)
            //       usuarioAppService.ValidationMessages
            
        }
    }
}