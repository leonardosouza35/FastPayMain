using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Services;
using Fantasy.FastPay.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application
{
    public class EstadoAppService: AppServiceBase<Estado>, IEstadoAppService
    {
        private readonly IEstadoService _estadoService;
        public EstadoAppService(IEstadoService estadoService) : base(estadoService)
        {
            _estadoService = estadoService;
        }

        public void Adicionar(Estado estado)
        {
            _estadoService.Adicionar(estado);            
        }


        public List<Estado> ObterTodosOsEstados()
        {
            return _estadoService.ObterTodosOsEstados();
        }

        public Estado ObterPorId(int estadoId)
        {
            return _estadoService.ObterPorId(estadoId);
        }

        public void Atualizar(Estado estado)
        {
            _estadoService.Atualizar(estado);
        }

        public void Remover(Estado estado)
        {
            _estadoService.Remover(estado);
        }
    }
}
