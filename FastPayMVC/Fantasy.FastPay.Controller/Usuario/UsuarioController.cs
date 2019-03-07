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
    }
}
