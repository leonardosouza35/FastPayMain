using Fantasy.FastPay.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        private UsuarioController _usuarioControler;
        public UsuarioController UsuarioController {
            get { return _usuarioControler ?? (_usuarioControler = new UsuarioController()); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var usuarios = UsuarioController.ObterTodos();
        }
    }
}