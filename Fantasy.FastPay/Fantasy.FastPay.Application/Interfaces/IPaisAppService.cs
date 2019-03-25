using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application.Interfaces
{
    public interface IPaisAppService: IAppServiceBase<Pais>
    {
        List<Pais> ObterTodos();
        Pais ObterPorId(int paisId);
        void Adicionar(Pais pais);
        void Atualizar(Pais pais);
        void Remover(Pais pais);
    }
}
