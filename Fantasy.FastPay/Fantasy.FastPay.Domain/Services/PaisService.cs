using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        private readonly IPaisRepository _paisRepository;
        
        public PaisService(IPaisRepository paisRepository) : base(paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public Pais ObterPorId(int paisId)
        {
            return _paisRepository.ObterPorId(paisId);
        }

        public void Adicionar(Pais pais)
        {
            _paisRepository.Adicionar(pais);
        }

        public void Atualizar(Pais pais)
        {
            _paisRepository.Atualizar(pais);
        }

        public void Remover(Pais pais)
        {
            _paisRepository.Remover(pais);
        }

        public List<Pais> ObterTodos()
        {
            return _paisRepository.ObterTodos();
        }
    }
}
