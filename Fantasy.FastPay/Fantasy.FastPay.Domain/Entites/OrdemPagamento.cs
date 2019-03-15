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
        public decimal ValorEnviado { get; set; }
        public DateTime DataPagamentoRecebido { get; set; }                        
        public decimal ValorRecebido { get; set; }
        public int UsuarioId { get; set; }
        public string NomeBeneficiario { get; set; }
        public string SobreNomeBeneficiario { get; set; }
        public string CpfOrCnpj { get; set; }
        public string EstadoBeneficiario { get; set; }
        public string CidadeBeneficiario { get; set; }
        public string CepBeneficiario { get; set; }
        public string TelefoneBeneificiario { get; set; }
        public string Agencia { get; set; }
        public string TipoDeConta { get; set; }
        public string NumeroDaConta { get; set; }
        public int BancoPagadorId { get; set; }
        public short StatusOrdem { get; set; }
    }
}
