using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.CrossCutting.Excel.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class ExcelAttribute : Attribute
    {
        public string DisplayName { get; set; }
    }
}
