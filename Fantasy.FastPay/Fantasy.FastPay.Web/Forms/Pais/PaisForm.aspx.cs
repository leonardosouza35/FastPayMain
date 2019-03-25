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
                    EditarPais(Convert.ToInt32(e.CommandArgument));
                    break;

                case "Remover":
                    RemoverPais(Convert.ToInt32(e.CommandArgument));
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

                if (Session["modo"] == "Edicao")
                {
                    var paisId = Convert.ToInt32(Session["PaisId"]);
                    var pais = new Domain.Entites.Pais();

                    pais.Id = paisId;
                    pais.Nome = txtNome.Text;
                    pais.Descricao = txtDescricao.Text;

                    PaisAppService.Atualizar(pais);                    
                }
                else
                {
                    var nome = txtNome.Text;
                    var descricao = txtDescricao.Text;
                    var pais = new Domain.Entites.Pais();
                    pais.Nome = nome;
                    pais.Descricao = descricao;
                    PaisAppService.Adicionar(pais);                                    
                }

                CarregarPaises();
                LimparCampos();
                Session["modo"] = "Incluir";
            }            
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtNome.Focus();
        }

        private void RemoverPais(int paisId)
        {
            var pais = new Domain.Entites.Pais(); // so estou fazendo isso aqui pq o método Remover só aceita instância da classe Pais
            pais.Id = paisId; // Mas nada me impede tbm de criar ou um outro método de Remover que aceite o id de pais. Só alterar e testar
            
            PaisAppService.Remover(pais);

            CarregarPaises();
        }

        private void EditarPais(int paisId)
        {
            Session["modo"] = "Edicao"; // Utilizando a sessão para controlar se tela esta no estado de inclusão ou edição
            Session["PaisId"] = paisId;// Mas existem outras maneiras de controlar isso tbm redirecionando por exemplo para outra tela... uma  tela só de edição
            var pais = PaisAppService.ObterPorId(paisId);

            txtNome.Text = pais.Nome;
            txtDescricao.Text = pais.Descricao;
        }

        #endregion

    }
}