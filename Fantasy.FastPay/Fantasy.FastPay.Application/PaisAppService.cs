using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application
{
    public class PaisAppService: AppServiceBase<Pais>, IPaisAppService
    {
        private readonly IPaisService _paisService;
        public PaisAppService(IPaisService paisService) : base(paisService)
        {
            _paisService = paisService;
        }
        public Pais ObterPorId(int paisId)
        {
            return _paisService.ObterPorId(paisId);
        }

        public void Adicionar(Pais pais)
        {
            _paisService.Adicionar(pais);
        }

        public void Atualizar(Pais pais)
        {
            throw new NotImplementedException();
        }

        public void Remover(Pais pais)
        {
            throw new NotImplementedException();
        }

        public List<Pais> ObterTodos()
        {
            return _paisService.ObterTodos();
        }
    }
}
