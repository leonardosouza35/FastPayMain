using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        public List<string> ValidationMessages { get; private set; }
        public bool IsValidated { get; private set; }

        public UsuarioAppService(IUsuarioService usuarioService) :base(usuarioService)
        {
            _usuarioService = usuarioService;
            ValidationMessages = new List<string>();
        }

        public void Adicionar(Usuario usuario)
        {
            usuario.Validate();
            if (usuario.IsValidated)
            {
                _usuarioService.Adicionar(usuario);
                IsValidated = usuario.IsValidated; 
            }
        }
    }
}
