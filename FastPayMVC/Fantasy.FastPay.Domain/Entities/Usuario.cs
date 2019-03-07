using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entities
{
    public class Usuario : Entity
    {        
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CpfOrCnpj { get;  set; }
        public int MyProperty { get; set; }


        private List<Pedido> _pedidos;
        private List<Pedido> Pedidos
        {
            get { return _pedidos ?? (_pedidos = new List<Pedido>()); }
        }
        
        public void AdicionarPedido(Pedido pedido)
        {
            // pre validação da instancia pedido
            // regras de negocio
            //pedido.Validate();
            
            // processamento
            Pedidos.Add(pedido);            
        }




    }
}
