using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application
{
    public class OrdemPagamentoPassoAppService: AppServiceBase<OrdemPagamentoPasso>, IOrdemPagamentoPassoAppService
    {
        private readonly IOrdemPagamentoPassoService _ordemPagamentoPassoService;
        public OrdemPagamentoPassoAppService(IOrdemPagamentoPassoService ordemPagamentoPassoService) :base(ordemPagamentoPassoService)
        {
            _ordemPagamentoPassoService = ordemPagamentoPassoService;
        }

        public List<OrdemPagamentoPasso> ObterTodasAsOrdensPagamentoPasso()
        {
            return _ordemPagamentoPassoService.ObterTodasAsOrdensPagamentoPasso();
        }

        public OrdemPagamentoPasso ObterPorId(int ordemPagamentoPassoId)
        {
            return _ordemPagamentoPassoService.ObterPorId(ordemPagamentoPassoId);
        }

        public void Adicionar(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            _ordemPagamentoPassoService.Adicionar(ordemPagamentoPasso);
        }

        public void Atualizar(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            _ordemPagamentoPassoService.Atualizar(ordemPagamentoPasso);
        }

        public void Remover(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            _ordemPagamentoPassoService.Remover(ordemPagamentoPasso);
        }
    }
}
