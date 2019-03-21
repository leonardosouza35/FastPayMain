using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Services
{
    public class OrdemPagamentoPassoService: ServiceBase<OrdemPagamentoPasso>, IOrdemPagamentoPassoService
    {
        private readonly IOrdemPagamentoPassoRepository _ordemPagamentoPassoRepository;
        public OrdemPagamentoPassoService(IOrdemPagamentoPassoRepository ordemPagamentoPassoRepository): base(ordemPagamentoPassoRepository)
        {
            _ordemPagamentoPassoRepository = ordemPagamentoPassoRepository;
        }

        public List<OrdemPagamentoPasso> ObterTodasAsOrdensPagamentoPasso()
        {
            return _ordemPagamentoPassoRepository.ObterTodasAsOrdensPagamentoPasso();
        }

        public OrdemPagamentoPasso ObterPorId(int ordemPagamentoPassoId)
        {
            return _ordemPagamentoPassoRepository.ObterPorId(ordemPagamentoPassoId);
        }

        public void Adicionar(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            _ordemPagamentoPassoRepository.Adicionar(ordemPagamentoPasso);
        }

        public void Atualizar(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            _ordemPagamentoPassoRepository.Atualizar(ordemPagamentoPasso);
        }

        public void Remover(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            _ordemPagamentoPassoRepository.Remover(ordemPagamentoPasso);
        }
    }
}
