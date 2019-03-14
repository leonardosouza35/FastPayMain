using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entities
{
    public class Usuario : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CpfOrCnpj { get;  set; }
        public int MyProperty { get; set; }                        
    }
}
