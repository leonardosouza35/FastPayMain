using Fantasy.FastPay.Application;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.Services;
using Fantasy.FastPay.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fantasy.FastPay.Web.Forms.Estado
{
    public partial class EstadoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEstadoRepository estadoRepository = new EstadoRepository();

            var estadoService = new EstadoService(estadoRepository);

            var appAppService = new EstadoAppService(estadoService);

            var estado = new Domain.Entites.Estado();
            
            appAppService.Adicionar(estado);
        }
    }
}