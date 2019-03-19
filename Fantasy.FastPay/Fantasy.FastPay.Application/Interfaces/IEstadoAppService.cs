using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application.Interfaces
{
    public interface IEstadoAppService : IAppServiceBase<Estado>
    {
        void Adicionar(Estado estado);
    }
}
