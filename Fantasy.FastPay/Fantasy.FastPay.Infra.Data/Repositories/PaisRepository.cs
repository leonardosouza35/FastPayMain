using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class PaisRepository: RepositoryBase<Pais>, IPaisRepository
    {
        public Pais ObterPorId(int paisId)
        {
            try{
                OpenConnection();
            }catch(Exception ex)
            {
            }
            finally{
                CloseConnection();
            }
            return null;
        }

        public void Adicionar(Pais pais)
        {
            try
            {
                OpenConnection();
                
                var paramNome = new SqlParameter("@Nome",System.Data.SqlDbType.VarChar);
                paramNome.Direction = System.Data.ParameterDirection.Input;
                paramNome.Value = pais.Nome;

                var paramDescricao = new SqlParameter("@Descricao", System.Data.SqlDbType.VarChar);
                paramDescricao.Direction = System.Data.ParameterDirection.Input;
                paramDescricao.Value = pais.Descricao;

                                
                ExecuteNoQuery("spAdicionarPais", paramNome, paramDescricao);
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

        public void Atualizar(Pais pais)
        {
            throw new NotImplementedException();
        }

        public void Remover(Pais pais)
        {
            throw new NotImplementedException();
        }

        public List<Pais> ObterTodos()
        {
            var paises = new List<Pais>();
            try
            {
                OpenConnection();
                var reader = ExecuteReader("spObterTodosPaises");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var pais = new Pais();
                        pais.Nome = reader["nome"].ToString();                        
                        pais.Descricao = reader["descricao"].ToString();                        
                        pais.DataCadastro = reader["datacadastro"] is DBNull ? default(DateTime?) : Convert.ToDateTime(reader["datacadastro"]);
                        paises.Add(pais);
                    }
                }

                return paises;

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
