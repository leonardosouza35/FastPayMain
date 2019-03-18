using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms.Usuario
{
    public partial class CadastroUsuarioForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}