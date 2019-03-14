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
            var sequence = 1;
            if (Db.OPagamentos.Any())
            {
                var maxId = Db.OPagamentos.Max(u => u.Id); // u => u.Id Expressão Lambda - Ler sobre Expressão Lambda e Função Anônima
                maxId++;
                sequence = maxId;
            }

            opagamento.Id = sequence;
            Db.OPagamentos.Add(opagamento);
        }

        public OrdemPagamento ObterOrdemPagamento(int ordemPagamentoId)
        {
            return Db.OPagamentos.FirstOrDefault(u => u.Id == ordemPagamentoId);
        }

        public void AtualizarOrdemPagamento(OrdemPagamento ordemPagamento)
        {
            var _ordemPagamento = Db.OPagamentos.FirstOrDefault(u => u.Id == ordemPagamento.Id);

            if (ordemPagamento != null)
            {
                _ordemPagamento.NomeCompleto = ordemPagamento.NomeCompleto;
                _ordemPagamento.CPF = ordemPagamento.CPF;
                _ordemPagamento.NumeroContrato = ordemPagamento.NumeroContrato;
            }

        }

        public void DeletarOrdemPagamento(int ordemPagamentoId)
        {
            Db.OPagamentos.RemoveAll(u => u.Id == ordemPagamentoId);
        }
    }
}
