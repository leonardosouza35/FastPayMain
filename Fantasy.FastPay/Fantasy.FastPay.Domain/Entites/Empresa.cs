

using System;
namespace Fantasy.FastPay.Domain.Entites
{
  /// <summary>
  /// Esta classe representa a empresa que faz o envio da remessa
  /// e que pode ser a própria FastPay ou alguma outra empres parceiro que utiliza a FastPay
  /// como integrador de pagamento
  /// </summary>
    public class Empresa: Entity
    {
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public Pais Pais { get; set; }
        public int  PaisOrigemId { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }        
        public decimal PercentualCalculoTaxa { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
      
    }
}
