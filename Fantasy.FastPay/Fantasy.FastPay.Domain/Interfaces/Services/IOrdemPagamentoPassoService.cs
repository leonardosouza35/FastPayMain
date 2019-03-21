using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Services
{
    public interface IOrdemPagamentoPassoService: IServiceBase<OrdemPagamentoPasso>
    {
        List<OrdemPagamentoPasso> ObterTodasAsOrdensPagamentoPasso();
        OrdemPagamentoPasso ObterPorId(int ordemPagamentoPassoId);
        void Adicionar(OrdemPagamentoPasso ordemPagamentoPasso);
        void Atualizar(OrdemPagamentoPasso ordemPagamentoPasso);
        void Remover(OrdemPagamentoPasso ordemPagamentoPasso);
    }
}
