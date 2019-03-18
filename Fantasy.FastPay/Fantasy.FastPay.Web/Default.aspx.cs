using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCriarConta_Click(object sender, EventArgs e)
        {
            CriarConta();

        }

        private void CriarConta()
        {
            //HttpContext.Current.a
            Session["Nome"] = txtNome.Text;
            Session["Email"] =  txtEmail.Text;                   
            Response.Redirect("~/Forms/Usuario/CadastroUsuarioForm.aspx");

        }
    }
}