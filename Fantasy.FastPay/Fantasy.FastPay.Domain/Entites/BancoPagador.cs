using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entites
{
    public class BancoPagador :Entity
    {
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
