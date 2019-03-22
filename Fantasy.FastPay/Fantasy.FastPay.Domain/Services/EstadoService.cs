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
        private readonly IEstadoRepository _repository;

        public EstadoService(IEstadoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public void Adicionar(Estado estado)
        {
            _repository.Adicionar(estado);
        }
    }
}
