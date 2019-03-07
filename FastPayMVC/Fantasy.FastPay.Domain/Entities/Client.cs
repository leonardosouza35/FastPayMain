using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entities
{
    // Classe Descartável
    public class Client
    {
        public Client()
        {
            var usuario = new Usuario();                        
            usuario.AdicionarPedido(new Pedido());
        }
    }
}
