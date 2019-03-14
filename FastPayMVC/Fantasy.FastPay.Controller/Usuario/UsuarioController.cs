using Fantasy.FastPay.DAO;
using Fantasy.FastPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Controller
{
    public class UsuarioController
    {
        private UsuarioDAO _usuarioDAO;
 
        public UsuarioController()
        {
            _usuarioDAO = new UsuarioDAO();
        }

        public List<Usuario> ObterTodos(){
            return _usuarioDAO.ObterTodos();
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarioDAO.AdicionarUsuario(usuario);
        }

        public Usuario ObterUsuario(int usuarioId)
        {
            return _usuarioDAO.ObterUsuario(usuarioId);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _usuarioDAO.AtualizarUsuario(usuario);
        }

        public void DeletarUsuario(int usuarioId)
        {
            _usuarioDAO.DeletarUsuario(usuarioId);
        }
    }
}
