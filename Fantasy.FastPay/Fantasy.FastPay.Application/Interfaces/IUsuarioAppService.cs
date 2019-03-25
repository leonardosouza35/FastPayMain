using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application.Interfaces
{
    public interface IUsuarioAppService: IAppServiceBase<Usuario>
    {
        void Adicionar(Usuario usuario);
        List<Usuario> ObterTodos();
        Usuario ObterPorId(int usuarioId);
        void Atualizar(Usuario usuario);
        void Remover(Usuario usuario);
        Usuario ObterPor(string email, string senha);     
    }
}
