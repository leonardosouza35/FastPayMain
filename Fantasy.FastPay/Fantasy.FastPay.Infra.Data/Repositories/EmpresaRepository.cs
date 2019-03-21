using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class EmpresaRepository: RepositoryBase<Empresa>, IEmpresaRepository
    {

        public List<Empresa> ObterTodasAsEmpresas()
        {
            try
            {
                OpenConnection();

                var listaEmpresas = new List<Empresa>();
                var dataReader = ExecuteReader("select Nome, PaisOrigemId, EstadoId, CidadeId, PercentualCalculoTaxa from EMPRESAS");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        var empresa = new Empresa();
                        empresa.Nome = dataReader["Nome"] as string;
                        empresa.PaisOrigemId = Convert.ToInt32(dataReader["PaisOrigemId"]);
                        empresa.EstadoId = Convert.ToInt32(dataReader["EstadoId"]);
                        empresa.CidadeId = Convert.ToInt32(dataReader["CidadeId"]);
                        empresa.PercentualCalculoTaxa = Convert.ToDecimal(dataReader["PercentualCalculoTaxa"]);

                        listaEmpresas.Add(empresa);
                    }
                }

                return listaEmpresas;
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

        public Empresa ObterPorId(int empresaId)
        {
            try
            {
                OpenConnection();

                // logica de acesso
            }
            catch (Exception ex)
            {
                //tratamento da exceção
            }
            finally
            {
                CloseConnection();
            }

            return new Empresa();
        }

        public void Adicionar(Empresa empresa)
        {
            try
            {
                OpenConnection();
                                                
                SqlParameter paramNome = new SqlParameter("@Nome", System.Data.SqlDbType.VarChar);
                paramNome.Value = empresa.Nome;

                SqlParameter paramPaisOrigem = new SqlParameter("@PaisOrigemId", System.Data.SqlDbType.Int);
                paramPaisOrigem.Value = empresa.PaisOrigemId;

                SqlParameter paramEstado = new SqlParameter("@EstadoId", System.Data.SqlDbType.Int);
                paramEstado.Value = empresa.EstadoId;

                SqlParameter paramCidade = new SqlParameter("@CidadeId", System.Data.SqlDbType.Int);
                paramCidade.Value = empresa.CidadeId;

                SqlParameter paramPercentualTaxa = new SqlParameter("@PercentualTaxa", System.Data.SqlDbType.Money);
                paramPercentualTaxa.Value = empresa.PercentualCalculoTaxa;


                var sqlInsert = @"insert into FastPayDB.dbo.Empresas(Nome, PaisOrigemId,EstadoId, CidadeId, PercentualCalculoTaxa)
                                    values(@Nome, @PaisOrigemId,@EstadoId,@CidadeId,@PercentualTaxa)";
                
                ExecuteNoQuery(sqlInsert, paramNome, paramPaisOrigem, paramEstado, paramCidade, paramPercentualTaxa);

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

        public void Atualizar(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Remover(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
