using Fantasy.FastPay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entites
{
    public class OrdemPagamento : Entity
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataPagamentoRecebido { get; set; }
        public int UsuarioEnvioId { get; set; }
        public int UsuarioRecebidoId { get; set; }        
        public int EmpresaEnvioId { get; set; }       
        public Empresa Empresa{get;set;}
        public int BancoPagadorId { get; set; }
        public int OpcaoMoedaIdOrigem { get; set; }
        public int OpcaoMoedaIdDestino { get; set; }        
        public decimal ValorEnviado { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal TaxaCambioMercado { get; private set; }
        public decimal TaxaCambioEmpresa { get; private set; }      
        public StatusOrdemEnum StatusOrdem { get; set; }

        public void SetEmpresa(Empresa empresa ){
            if (empresa == null)
                AddValidationMessage("Informe uma empresa");
            else
                Empresa = empresa;            
        }

        public void CalcularTaxaCambio()
        {
            TaxaCambioEmpresa = TaxaCambioMercado * Empresa.PercentualCalculoTaxa;
        }


        public override void Validate()
        {
            if (OpcaoMoedaIdOrigem == 0)
                AddValidationMessage("Não foi possível identifiar a modeda  de origem");

            if (OpcaoMoedaIdDestino == 0)
                AddValidationMessage("Não foi possível identifiar a modeda de destino");

            if (BancoPagadorId == 0)
                AddValidationMessage("Não foi possível identifiar o banco pagador");

            if (TaxaCambioMercado == 0)
                AddValidationMessage("Taxa de câmbio não identificado");

            if (Empresa == null)
                AddValidationMessage("É necessário saber qual a empresa está enviando a remessa");

            if (TaxaCambioEmpresa == 0)
                AddValidationMessage("Não foi possível identificar qual é a taxa de cambio praticado");
        }
    }
}
