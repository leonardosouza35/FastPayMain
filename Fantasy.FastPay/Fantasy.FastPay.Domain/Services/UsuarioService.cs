using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        
        public UsuarioService(IUsuarioRepository usuarioRepository) :base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Adicionar(Usuario usuario)
        {
            _usuarioRepository.Adicionar(usuario);
        }


        public List<Usuario> ObterTodos()
        {
            return _usuarioRepository.ObterTodos();
        }

        public Usuario ObterPorId(int usuarioId)
        {
            return _usuarioRepository.ObterPorId(usuarioId);
        }

        public void Atualizar(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);
        }

        public void Remover(Usuario usuario)
        {
            _usuarioRepository.Remover(usuario);

        }


        public Usuario ObterPor(string email, string senha)
        {
            return _usuarioRepository.ObterPor(email, senha);
        }
    }
}
