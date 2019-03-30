using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Repositories
{
    public interface IOrdemPagamentoRepository: IRepositoryBase<OrdemPagamento>
    {
         List<OrdemPagamento> ObterOrdensPorUsuario(int usuarioId);
    }
}
