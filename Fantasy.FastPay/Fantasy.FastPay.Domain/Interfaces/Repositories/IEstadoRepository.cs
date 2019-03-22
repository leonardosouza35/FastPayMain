using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Repositories
{
    public interface IEstadoRepository : IRepositoryBase<Estado>
    {
        void Adicionar(Estado estado);
    }
}
