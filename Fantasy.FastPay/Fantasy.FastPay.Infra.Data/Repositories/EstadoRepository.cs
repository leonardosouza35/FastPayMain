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
                var dataReader = ExecuteReader("spObterTodosOsEstados");
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
            var estados = new List<Estado>();
            try
            {
                OpenConnection();
                var paramId = new SqlParameter("@Id", System.Data.SqlDbType.Int);
                paramId.Direction = System.Data.ParameterDirection.Input;
                paramId.Value = estadoId;

                var reader = ExecuteReader("spObterEstado", paramId);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var estado = new Estado();
                        estado.Id = Convert.ToInt32(reader["Id"]);
                        estado.Nome = reader["nome"].ToString();
                        estado.Descricao = reader["descricao"].ToString();
                        estados.Add(estado);
                    }
                }

                return estados.FirstOrDefault(); ;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Adicionar(Estado estado)
        {
            try
            {
                OpenConnection();              

                var paramNome = new SqlParameter("@Nome", System.Data.SqlDbType.VarChar);
                paramNome.Direction = System.Data.ParameterDirection.Input;
                paramNome.Value = estado.Nome;

                var paramDescricao = new SqlParameter("@Descricao", System.Data.SqlDbType.VarChar);
                paramDescricao.Direction = System.Data.ParameterDirection.Input;
                paramDescricao.Value = estado.Descricao;


                ExecuteNoQuery("spAdicionarEstado", paramNome, paramDescricao);

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
            try
            {
                OpenConnection();

                var paramNome = new SqlParameter("@Nome", System.Data.SqlDbType.VarChar);
                paramNome.Direction = System.Data.ParameterDirection.Input;
                paramNome.Value = estado.Nome;

                var paramDescricao = new SqlParameter("@Descricao", System.Data.SqlDbType.VarChar);
                paramDescricao.Direction = System.Data.ParameterDirection.Input;
                paramDescricao.Value = estado.Descricao;


                ExecuteNoQuery("spAdicionarEstado", paramNome, paramDescricao);

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

        public void Remover(Estado estado)
        {
            try
            {
                OpenConnection();

                var paramId = new SqlParameter("@Id", System.Data.SqlDbType.Int);
                paramId.Direction = System.Data.ParameterDirection.Input;
                paramId.Value = estado.Id;

                ExecuteNoQuery("spRemoverEstado", paramId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
