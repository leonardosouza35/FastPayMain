using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Services
{
    public interface IEstadoService : IServiceBase<Estado>
    {
        void Adicionar(Estado estado);
    }
}
