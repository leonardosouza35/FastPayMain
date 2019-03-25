using Fantasy.FastPay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Domain.Entites
{
    /// <summary>
    /// Usuario pode ser tanto uma pessoa física quanto uma pessoa jurídica
    /// Quando for pessoa jurídica, a propriedade NomeEmpresa deve ser preenchido
    /// assim como  campo CpfOrCnpj deve estar preenchido com o CNPJ da empresa
    /// </summary>
    public class Usuario: Entity
    {        
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoDePessoaEnum TipoDePessoa { get; set; }
        public string NumeroDocumento { get; set; }
        public string NomeEmpresa { get; set; }        
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }        
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public int CodigoBanco { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public TipoContaEnum TipoDeConta { get; set; }
        public string NumeroDaConta { get; set; }

        public List<OrdemPagamento> Ordens { get; set; }
                  
        public override void Validate()
        {
            //throw new NotImplementedException();
        }
       
    }
}
