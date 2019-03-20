using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Services
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        
        public EmpresaService(IEmpresaRepository empresaRepository) :base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public void Adicionar(Empresa empresa)
        {
            _empresaRepository.Adicionar(empresa);
        }
    }
}
