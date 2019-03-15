using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entites
{
    public class OrdemPagamentoPasso : Entity
    {
        public int OrdemPagamentoId { get; set; }
        public DateTime DataPasso { get; set; }
        public short StatusPasso { get; set; }
        public string Descricao { get; set; }
        public int UsuarioId { get; set; } // id do usuario que alterou o status ou 0 (zero) se foi alterado pelo sistema
    }
}
