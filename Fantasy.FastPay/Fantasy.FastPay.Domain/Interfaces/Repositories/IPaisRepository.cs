using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Repositories
{
    public interface IPaisRepository : IRepositoryBase<Pais>
    {
        List<Pais> ObterTodos();
        Pais ObterPorId(int paisId);
        void Adicionar(Pais pais);
        void Atualizar(Pais pais);
        void Remover(Pais pais);
    }
}
