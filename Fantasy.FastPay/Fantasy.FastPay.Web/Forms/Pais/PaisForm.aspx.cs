using Fantasy.FastPay.Application;
using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Services;
using Fantasy.FastPay.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms.Pais
{
    public partial class PaisForm : System.Web.UI.Page
    {
        #region Propriedades
        public IPaisAppService PaisAppService
        {
            get {

                var paisRepository = new PaisRepository();
                var paisService = new PaisService(paisRepository);
                return new PaisAppService(paisService);
            }
        }
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarPaises();
            }

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarPais();
        }

        protected void grdPaises_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":
                    break;

                case "Remover":
                    break;

                default:
                    lblMessage.Text = "Não foi possível definir Editar ou Remover registro";
                    break;
            }
        }

        #endregion

        #region Métodos
        private void CarregarPaises()
        {
            grdPaises.DataSource = PaisAppService.ObterTodos();
            grdPaises.DataBind();
        }

        

        private void SalvarPais()
        {
            if (string.IsNullOrEmpty(txtNome.Text)
                || string.IsNullOrEmpty(txtDescricao.Text))
            {
                lblMessage.Text = "Informar nome e descrição";
            }
            else
            {
                var nome = txtNome.Text;
                var descricao = txtDescricao.Text;
                var pais = new Domain.Entites.Pais();
                pais.Nome = nome;
                pais.Descricao = descricao;
                PaisAppService.Adicionar(pais);                
                CarregarPaises();
                LimparCampos();
                
            }            
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtNome.Focus();
        }

        #endregion

    }
}