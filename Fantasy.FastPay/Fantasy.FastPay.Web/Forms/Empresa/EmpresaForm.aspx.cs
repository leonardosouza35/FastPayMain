using Fantasy.FastPay.Application;
using Fantasy.FastPay.Application.Interfaces;
using Fantasy.FastPay.Domain.Services;
using Fantasy.FastPay.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            //var empresas = EmpresaAppService.ObterTodasAsEmpresas();

            //if(empresas.Any()){
            //    Response.Write("Funcionou");
            //}

            var empresa = new FastPay.Domain.Entites.Empresa();

            empresa.Nome = "Bahia";
            empresa.PaisOrigemId = 4;
            empresa.EstadoId = 10;
            empresa.CidadeId = 50;
            empresa.PercentualCalculoTaxa = 1.5m;

            EmpresaAppService.Adicionar(empresa);
            
            //if ( ConfigurationManager.AppSettings["EstadosTaxaDiferente"].Contains(empresa.Nome))
            //    empresa.PercentualCalculoTaxa = 1.8m;
            

        }
    }
}