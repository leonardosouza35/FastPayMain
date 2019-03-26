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
    public partial class LoginForm : System.Web.UI.Page
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

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
            
        }

        private void Entrar()
        {

            if (string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtSenha.Text))
            {
                lblMensagem.Text = "Informe email e a senha para entrar no sistema";
            }
            else
            {
                if (txtEmail.Text != "admin@fastpay.com"
                    && txtSenha.Text != "abc123")
                {
                    lblMensagem.Text = "Usuario ou senha inválido";
                }
                else
                {
                    var usuario = new Usuario();
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtSenha.Text;
                    usuario.EhAdministrador = true;
                    Session["USER-LOGADO"] = usuario;
                    Response.Redirect("~/Forms/InicioForm.aspx");
                }

                
                
            }

            //if (string.IsNullOrEmpty(txtEmail.Text)
            //    || string.IsNullOrEmpty(txtSenha.Text))
            //{
            //    lblMensagem.Text = "Informe email e a senha para entrar no sistema";
            //}
            //else
            //{
            //    var usuario = UsuarioAppService.ObterPor(txtEmail.Text, txtSenha.Text);
            //    if (usuario == null)
            //    {
            //        lblMensagem.Text = "Usuario ou senha inválido";
            //    }
            //    else
            //    {
            //        Session["USER-LOGADO"] = usuario;
            //        Response.Redirect("~/Forms/Inicio.aspx");
            //    }
            //}
        }
    }
}