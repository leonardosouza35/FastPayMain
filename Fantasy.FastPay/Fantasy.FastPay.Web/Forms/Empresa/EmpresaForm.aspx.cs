using Fantasy.FastPay.Application;
using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Services;
using Fantasy.FastPay.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms.Empresa
{
    public partial class EmpresaForm : System.Web.UI.Page
    {
        private IEmpresaAppService _iempresaAppService;
        public IEmpresaAppService EmpresaAppService
        {
            get {
                var empresaRepository = new EmpresaRepository();
                var empresaServico = new EmpresaService(empresaRepository);
                _iempresaAppService = new EmpresaAppService(empresaServico);
                return _iempresaAppService;
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}