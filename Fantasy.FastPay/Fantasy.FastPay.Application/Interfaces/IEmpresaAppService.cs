using Fantasy.FastPay.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application.Interfaces
{
    public interface IEmpresaAppService: IAppServiceBase<Empresa>
    {
        List<Empresa> ObterTodasAsEmpresas();
        Empresa ObterPorId(int empresaId);
        void Adicionar(Empresa empresa);
        void Atualizar(Empresa empresa);
        void Remover(Empresa empresa);
    }
}
