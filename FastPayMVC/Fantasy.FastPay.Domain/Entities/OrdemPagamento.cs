using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entities
{
    public class OrdemPagamento: Entity
    {
        public string NomeBeneficiario { get; set; }
        public string CpfBeneficiario { get; set; }
        public string NomeBanco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
    }
}
