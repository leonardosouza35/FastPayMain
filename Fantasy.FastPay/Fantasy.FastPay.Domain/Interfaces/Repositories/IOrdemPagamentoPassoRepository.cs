using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Repositories
{
    public interface IOrdemPagamentoPassoRepository: IRepositoryBase<OrdemPagamentoPasso>
    {
        List<OrdemPagamentoPasso> ObterTodasAsOrdensPagamentoPasso();
        OrdemPagamentoPasso ObterPorId(int ordemPagamentoPassoId);
        void Adicionar(OrdemPagamentoPasso ordemPagamentoPasso);
        void Atualizar(OrdemPagamentoPasso ordemPagamentoPasso);
        void Remover(OrdemPagamentoPasso ordemPagamentoPasso);
    }
}
