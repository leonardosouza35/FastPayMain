using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Services
{
    public interface IOrdemPagamentoService: IServiceBase<OrdemPagamento>
    {
        List<OrdemPagamento> ObterOrdensPorUsuario(int usuarioId);
    }
}
