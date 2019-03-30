using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class OrdemPagamentoRepository: RepositoryBase<OrdemPagamento>, IOrdemPagamentoRepository
    {
        public List<OrdemPagamento> ObterOrdensPorUsuario(int usuarioId)
        {
            var list = new List<OrdemPagamento>();

            for (int i = 0; i <= 10; i++)
            {
                list.Add(new OrdemPagamento() { Id = i, UsuarioEnvioId = usuarioId, ValorEnviado = i });
            }

            return list;
        }
    }
}
