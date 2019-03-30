using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application
{
    public class OrdemPagamentoAppService: AppServiceBase<OrdemPagamento>, IOrdemPagamentoAppService
    {
        private readonly IOrdemPagamentoService _ordemPagamentoService;
        
        public OrdemPagamentoAppService(IOrdemPagamentoService ordemPagamentoService): base(ordemPagamentoService)
        {
            _ordemPagamentoService = ordemPagamentoService;
        }
        public List<OrdemPagamento> ObterOrdensPorUsuario(int usuarioId)
        {
            return _ordemPagamentoService.ObterOrdensPorUsuario(usuarioId);
        }
    }
}
