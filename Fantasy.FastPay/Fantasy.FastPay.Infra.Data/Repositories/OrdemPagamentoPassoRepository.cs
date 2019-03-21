using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class OrdemPagamentoPassoRepository : RepositoryBase<OrdemPagamentoPasso>, IOrdemPagamentoPassoRepository
    {

        public List<OrdemPagamentoPasso> ObterTodasAsOrdensPagamentoPasso()
        {
            try
            {
                OpenConnection();

                var listaOrdensPagamentoPasso = new List<OrdemPagamentoPasso>();
                var dataReader = ExecuteReader("select Descricao, OrdemPagamentoId, UsuarioId from EMPRESAS");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        var ordemPagamentoPasso = new OrdemPagamentoPasso();
                        ordemPagamentoPasso.Descricao = dataReader["Descricao"] as string;
                        ordemPagamentoPasso.OrdemPagamentoId = Convert.ToInt32(dataReader["OrdemPagamentoId"]);
                        ordemPagamentoPasso.UsuarioId = Convert.ToInt32(dataReader["UsuarioId"]);
                        //ordemPagamentoPasso.StatusOrdem = dataReader["StatusOrdem"];
                        //ordemPagamentoPasso.PercentualCalculoTaxa = Convert.ToDecimal(dataReader["PercentualCalculoTaxa"]);

                        listaOrdensPagamentoPasso.Add(ordemPagamentoPasso);
                    }
                }

                return listaOrdensPagamentoPasso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public OrdemPagamentoPasso ObterPorId(int ordemPagamentoPassoId)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            throw new NotImplementedException();
        }

        public void Remover(OrdemPagamentoPasso ordemPagamentoPasso)
        {
            throw new NotImplementedException();
        }
    }
}
