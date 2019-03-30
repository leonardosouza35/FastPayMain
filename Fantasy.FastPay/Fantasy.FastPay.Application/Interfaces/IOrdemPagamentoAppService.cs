using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application.Interfaces
{
    public interface IOrdemPagamentoAppService: IAppServiceBase<OrdemPagamento>
    {
        List<OrdemPagamento> ObterOrdensPorUsuario(int usuarioId);
    }
}
