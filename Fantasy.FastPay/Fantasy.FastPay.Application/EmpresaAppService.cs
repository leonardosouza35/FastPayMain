using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application
{
    public class EmpresaAppService : AppServiceBase<Empresa>, IEmpresaAppService
    {
        private readonly IEmpresaService _empresaService;
        public EmpresaAppService(IEmpresaService empresaService) : base(empresaService)
        {
            _empresaService = empresaService;
        }

        public List<Empresa> ObterTodasAsEmpresas()
        {
            return _empresaService.ObterTodasAsEmpresas();
        }

        public Empresa ObterPorId(int empresaId)
        {
            return _empresaService.ObterPorId(empresaId);
        }

        public void Adicionar(Empresa empresa)
        {
            _empresaService.Adicionar(empresa);
        }

        public void Atualizar(Empresa empresa)
        {
            _empresaService.Atualizar(empresa);
        }

        public void Remover(Empresa empresa)
        {
            _empresaService.Remover(empresa);
        }
    }
}
