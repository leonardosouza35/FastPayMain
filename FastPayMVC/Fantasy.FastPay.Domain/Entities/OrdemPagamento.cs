using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entities
{
    public class OrdemPagamento: Entity
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string NumeroContrato { get; set; }
    }
}
