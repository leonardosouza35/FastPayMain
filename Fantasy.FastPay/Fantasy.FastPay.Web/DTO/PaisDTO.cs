using Fantasy.FastPay.Infra.CrossCutting.Excel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fantasy.FastPay.Web.DTO
{
    public class PaisDTO
    {
        [IgnoreAttribute]
        public int Id { get; set; }

        [ExcelAttribute(DisplayName="Nome")]
        public string Nome { get; set; }

        [ExcelAttribute(DisplayName = "Descrição")]
        public string Descricao { get; set; }
    }
}