using Fantasy.FastPay.DAO;
using Fantasy.FastPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Controller
{
    public class OrdemPagamentoController
    {
        private OrdemPagamentoDAO _opagamentoDAO;
 
        public OrdemPagamentoController()
        {
            _opagamentoDAO = new OrdemPagamentoDAO();
        }

        public List<OrdemPagamento> ObterOrdens(){
            return _opagamentoDAO.ObterOrdens();
        }

        public void AdicionarOrdemPagamento(OrdemPagamento ordempagamento)
        {
            _opagamentoDAO.AdicionarOrdemPagamento(ordempagamento);
        }

        public OrdemPagamento ObterOrdemPagamento(int ordemPagamentoId)
        {
            return _opagamentoDAO.ObterOrdemPagamento(ordemPagamentoId);  
        }

        public void AtualizarOrdemPagamento(OrdemPagamento ordemPagamento)
        {
            _opagamentoDAO.AtualizarOrdemPagamento(ordemPagamento);
        }

        public void DeletarOrdemPagamento(int ordemPagamentoId)
        {
            _opagamentoDAO.DeletarOrdemPagamento(ordemPagamentoId);
        }
    }
}
