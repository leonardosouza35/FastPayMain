using Fantasy.FastPay.Controller;
using Fantasy.FastPay.Domain.Entities;
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

        // So tem esse evento, mas precisamos do evento do botao
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarOPagamentos();
            }

        }

        protected void btnSalvarOrdemPagamento_Click(object sender, EventArgs e)
        {
            // da mesma forma e seguindo o exemplo do cadastro de Usuario, você deve fazer o mesmo para pagamento
            /// ou seja
            /// 
            SalvarOrdemPagamento();
        }

        #endregion

        #region METODOS
        private void CarregarOPagamentos()
        {
            //Session["opagamentos"] = OrdemPagamentoController.ObterOrdens();
            //var usuarios = Session["usuarios"];
            //grdOrdemPagamento.DataSource = usuarios;
            //grdOrdemPagamento.DataBind();
            grdOrdemPagamento.DataSource = OrdemPagamentoController.ObterOrdens();
            grdOrdemPagamento.DataBind();
        }

        private void SalvarOrdemPagamento()
        {
            if (string.IsNullOrEmpty(txNomeCompleto.Text)
                || string.IsNullOrEmpty(txCPF.Text) || string.IsNullOrEmpty(txNumContrato.Text))
            {
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Visible = false;
                var ordemPagamento = new OrdemPagamento();
                ordemPagamento.NomeCompleto = txNomeCompleto.Text;
                ordemPagamento.CPF = txCPF.Text;
                ordemPagamento.NumeroContrato = txNumContrato.Text;

                OrdemPagamentoController.AdicionarUsuario(ordemPagamento);

                grdOrdemPagamento.DataSource = OrdemPagamentoController.ObterOrdens();
                grdOrdemPagamento.DataBind();
            }
        #endregion







            /// Agora é o seguinte
            /// Eu não quero mais este cara aqui.
            /// blz ??
            /// Se eu rodar o codigo dessa forma nao vai dar erro
            /// pq existe um componente que esta apontando para ele
            /// // eu até posso deixar esse "evento" aqui sem um componente vinculado
            /// /// pq olhando para ele, não passa de um método de c# como outro qualquer


            ///  Mas eu não posso ter... um componente com o OnClick apontando para um método (Evento) que não
            ///  existe no codebehind
            ///  

        }
    }
}