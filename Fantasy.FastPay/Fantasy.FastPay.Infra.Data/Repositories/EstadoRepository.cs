using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using Fantasy.FastPay.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class EstadoRepository : RepositoryBase<Estado>, IEstadoRepository
    {
       

        public List<Estado> ObterTodosOsEstados()
        {
            try
            {
                OpenConnection();

                var listaEstados = new List<Estado>();
                var dataReader = ExecuteReader("select Id, Nome,  Descricao from ESTADOS");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        var estado = new Estado();
                        estado.Nome = dataReader["Nome"] as string;
                        estado.Descricao = dataReader["Descricao"] as string;
                        estado.Id = Convert.ToInt32(dataReader["Id"]);



                        listaEstados.Add(estado);
                    }
                }

                return listaEstados;
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

        public Estado ObterPorId(int estadoId)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Estado estado)
        {
            try
            {
                OpenConnection();

                SqlParameter paramId = new SqlParameter("@Id", System.Data.SqlDbType.Int);
                paramId.Value = estado.Id;
                
                SqlParameter paramNome = new SqlParameter("@Nome", System.Data.SqlDbType.VarChar);
                paramNome.Value = estado.Nome;

                SqlParameter paramDescricao = new SqlParameter("@Descricao", System.Data.SqlDbType.Int);
                paramDescricao.Value = estado.Descricao;

                var sqlInsert = @"insert into FastPayDB.dbo.Estados(Id, Nome, Descricao)
                                    values(@Id, @Nome, @Descricao)";

                ExecuteNoQuery(sqlInsert, paramId, paramNome, paramDescricao);

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

        public void Atualizar(Estado estado)
        {
            throw new NotImplementedException();
        }

        public void Remover(Estado estado)
        {
            throw new NotImplementedException();
        }
    }
}
