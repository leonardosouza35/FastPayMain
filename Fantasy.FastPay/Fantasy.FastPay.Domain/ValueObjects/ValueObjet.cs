

namespace Fantasy.FastPay.Domain
{
    /// <summary>
    /// Objetos de valor são objetos imutáveis
    /// </summary>
    public abstract class ValueObjet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
