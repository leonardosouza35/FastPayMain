using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Services;
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
        
    }
}
