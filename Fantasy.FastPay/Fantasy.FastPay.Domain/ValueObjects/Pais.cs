using System;
namespace Fantasy.FastPay.Domain.Entites
{
    public class Pais: ValueObjet
    {
        public DateTime? DataCadastro { get; set; }

        public Pais()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
