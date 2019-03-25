using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
using Fantasy.FastPay.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Services
{
    public class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;
        public EstadoService(IEstadoRepository estadoRepository) : base(estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public void Adicionar(Estado estado)
        {
            _estadoRepository.Adicionar(estado);
        }

        public List<Estado> ObterTodosOsEstados()
        {
            return _estadoRepository.ObterTodosOsEstados();
        }

        public Estado ObterPorId(int estadoId)
        {
            return _estadoRepository.ObterPorId(estadoId);
        }

        public void Atualizar(Estado estado)
        {
            _estadoRepository.Atualizar(estado);
        }

        public void Remover(Estado estado)
        {
            _estadoRepository.Remover(estado);
        }
    }
}
