using Fantasy.FastPay.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms
{
    public partial class OrdemPagamentoForm : System.Web.UI.Page
    {
        #region PROPRIEDADES
        public OrdemPagamentoController _opagamentoController;
        public OrdemPagamentoController OrdemPagamentoController
        {
            get { return _opagamentoController ?? (_opagamentoController = new OrdemPagamentoController()); }
        }
        #endregion

        #region EVENTOS
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarOPagamentos();
            }
            
        }

        #endregion

        #region METODOS
        private void CarregarOPagamentos()
        {
            Session["opagamentos"] = OrdemPagamentoController.ObterOrdens();
            var usuarios = Session["usuarios"];
            //grdOrdemPagamento.DataSource = usuarios;
            //grdOrdemPagamento.DataBind();
        }

        #endregion
    }
}