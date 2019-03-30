using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Services
{
    public class OrdemPagamentoService : ServiceBase<OrdemPagamento>, IOrdemPagamentoService
    {
        private readonly IOrdemPagamentoRepository _ordemPagamentoRepository;

        public OrdemPagamentoService(IOrdemPagamentoRepository ordemPagamentoRepository): base(ordemPagamentoRepository)
        {
            _ordemPagamentoRepository = ordemPagamentoRepository;
        }
            
        public List<OrdemPagamento> ObterOrdensPorUsuario(int usuarioId)
        {
            return _ordemPagamentoRepository.ObterOrdensPorUsuario(usuarioId);
        }
    }
}
