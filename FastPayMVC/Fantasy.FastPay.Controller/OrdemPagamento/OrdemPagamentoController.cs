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

        public void AdicionarUsuario(OrdemPagamento ordempagamento)
        {
            _opagamentoDAO.AdicionarOrdemPagamento(ordempagamento);
        }
    }
}
