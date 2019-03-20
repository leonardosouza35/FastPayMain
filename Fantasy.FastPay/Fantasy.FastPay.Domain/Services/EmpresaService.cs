using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Services
{
    public class EmpresaService: ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        public EmpresaService(IEmpresaRepository empresaRepository): base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public List<Empresa> ObterTodasAsEmpresas()
        {
            return _empresaRepository.ObterTodasAsEmpresas();
        }


        public Empresa ObterPorId(int empresaId)
        {
            return _empresaRepository.ObterPorId(empresaId);
        }

        public void Adicionar(Empresa empresa)
        {
            _empresaRepository.Adicionar(empresa);
        }

        public void Atualizar(Empresa empresa)
        {
            _empresaRepository.Atualizar(empresa);
        }

        public void Remover(Empresa empresa)
        {
            _empresaRepository.Remover(empresa);
        }
    }
}