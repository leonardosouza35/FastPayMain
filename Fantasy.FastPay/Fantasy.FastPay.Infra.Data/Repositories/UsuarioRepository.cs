using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        
        
        public void Adicionar(Usuario usuario)
        {
            //var sql = "";
            //var reader = ExecuteReader(sql);
            //if (reader.HasRows)
            //{
                
            //}
        }


        public List<Usuario> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Remover(Usuario usuario)
        {
            throw new NotImplementedException();
        }


        public Usuario ObterPor(string email, string senha)
        {
            try
            {
                OpenConnection();
                var usuarios = new List<Usuario>();

                var paramEmail = new SqlParameter("@Email",SqlDbType.Int);
                paramEmail.Direction = ParameterDirection.Input;
                paramEmail.Value = email;

                var paramSenha = new SqlParameter("@Senha",SqlDbType.Int);
                paramSenha.Direction = ParameterDirection.Input;
                paramSenha.Value = email;

                var reader = ExecuteReader("spObterUsuario", paramEmail, paramSenha);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["Id"]);
                        usuario.Email = reader["Email"].ToString();
                        usuario.Senha = reader["Senha"].ToString();
                        return usuario;
                    }
                }
                return null;
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
