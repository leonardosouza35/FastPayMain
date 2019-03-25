using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application.Interfaces
{
    public interface IEstadoAppService : IAppServiceBase<Estado>
    {
        List<Estado> ObterTodosOsEstados();
        Estado ObterPorId(int estadoId);
        void Adicionar(Estado estado);
        void Atualizar(Estado estado);
        void Remover(Estado estado);
    }
}
