using Fantasy.FastPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.DAO
{
    public class OrdemPagamentoDAO : BaseDAO
    {
        public List<OrdemPagamento> ObterOrdens()
        {
            return Db.OPagamentos;
        }

        public void AdicionarOrdemPagamento(OrdemPagamento opagamento)
        {
            Db.OPagamentos.Add(opagamento);
        }
    }
}
