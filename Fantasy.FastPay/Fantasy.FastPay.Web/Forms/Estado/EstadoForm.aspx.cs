using Fantasy.FastPay.Application;
using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Services;
using Fantasy.FastPay.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms.Estado
{
    public partial class EstadoForm : System.Web.UI.Page
    {
        #region Propriedades
        public IEstadoAppService EstadoAppService
        {
            get {
                var estadoRepository = new EstadoRepository();
                var estadoServico = new EstadoService(estadoRepository);
                //_iEstadoAppService = new EstadoAppService(estadoServico);
                return new EstadoAppService(estadoServico);
            }
        }
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarEstados();
            }

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarEstado();
        }

        protected void grdEstados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":
                    EditarEstado(Convert.ToInt32(e.CommandArgument));
                    break;

                case "Remover":
                    RemoverEstado(Convert.ToInt32(e.CommandArgument));
                    break;

                default:
                    lblMessage.Text = "Não foi possível definir Editar ou Remover registro";
                    break;
            }
        }
       
        #endregion

        #region Metodos
        private void CarregarEstados()
        {
            grdEstados.DataSource = EstadoAppService.ObterTodosOsEstados();
            grdEstados.DataBind();
        }

        private void SalvarEstado()
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
                    var estadoId = Convert.ToInt32(Session["EstadoId"]);
                    var estado = new Domain.ValueObjects.Estado();

                    estado.Id = estadoId;
                    estado.Nome = txtNome.Text;
                    estado.Descricao = txtDescricao.Text;

                    EstadoAppService.Atualizar(estado);
                }
                else
                {
                    var nome = txtNome.Text;
                    var descricao = txtDescricao.Text;
                    var estado = new Domain.ValueObjects.Estado();
                    estado.Nome = nome;
                    estado.Descricao = descricao;
                    EstadoAppService.Adicionar(estado);
                }

                CarregarEstados();
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

       
        private void RemoverEstado(int estadoId)
        {
            var estado = new Domain.ValueObjects.Estado(); // so estou fazendo isso aqui pq o método Remover só aceita instância da classe Estado
            estado.Id = estadoId; // Mas nada me impede tbm de criar ou um outro método de Remover que aceite o id de estado. Só alterar e testar

            EstadoAppService.Remover(estado);

            CarregarEstados();
        }

        private void EditarEstado(int estadoId)
        {
            Session["modo"] = "Edicao"; // Utilizando a sessão para controlar se tela esta no estado de inclusão ou edição
            Session["EstadoId"] = estadoId;// Mas existem outras maneiras de controlar isso tbm redirecionando por exemplo para outra tela... uma  tela só de edição
            var estado = EstadoAppService.ObterPorId(estadoId);

            txtNome.Text = estado.Nome;
            txtDescricao.Text = estado.Descricao;
        }

        #endregion
    }
}