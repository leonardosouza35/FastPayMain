using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        void Adicionar(Usuario usuario);
    }
}
