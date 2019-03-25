using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web
{
    public partial class Page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var page = this.Page.GetType().Name;

            switch (page)
            {
                case "forms_usuario_cadastrousuarioform_aspx":
                case "default_aspx":
                case "forms_inicioform_aspx":
                    return;                    
            }            

            if (Session["USER-LOGADO"] == null)
            {
                Response.Redirect("~/Forms/LoginForm.aspx");
            }            
        }

        protected void lkEntrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Forms/LoginForm.aspx");
        }

        protected void lbSair_Click(object sender, EventArgs e)
        {
            Session["USER-LOGADO"] = null;
            Response.Redirect("~/Default.aspx");
        }
    }
}