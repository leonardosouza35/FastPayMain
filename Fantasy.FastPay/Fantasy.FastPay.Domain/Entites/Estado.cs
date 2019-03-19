using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entites
{
    public class Estado : Entity
    {
        public int Nome { get; set; }

        public override void Validate()
        {

        }
    }
}
