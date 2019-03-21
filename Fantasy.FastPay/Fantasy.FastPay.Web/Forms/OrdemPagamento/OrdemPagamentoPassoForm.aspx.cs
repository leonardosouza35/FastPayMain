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

namespace Fantasy.FastPay.Web.Forms.OrdemPagamento
{
    public partial class OrdemPagamentoPassoForm : System.Web.UI.Page
    {
        private IOrdemPagamentoPassoAppService _iOrdemPagamentoPassoAppService;
        public IOrdemPagamentoPassoAppService OrdemPagamentoPassoAppService
        {
            get
            {
                var ordemPagamentoPassoRepository = new OrdemPagamentoPassoRepository();
                var ordemPagamentoPassoServico = new OrdemPagamentoPassoService(ordemPagamentoPassoRepository);
                _iOrdemPagamentoPassoAppService = new OrdemPagamentoPassoAppService(ordemPagamentoPassoServico);
                return _iOrdemPagamentoPassoAppService;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var todasasordensPagamentoPasso = OrdemPagamentoPassoAppService.ObterTodasAsOrdensPagamentoPasso();
        }
    }
}