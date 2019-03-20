using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        
        public Usuario ObterUsuarioPor(string nome)
        {
            SqlParameter param1 = new SqlParameter();

            var reader = ExecuteReader("select * from...", param1);

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
            }
                        
            return new Usuario();
        }

        public void Adicionar(Usuario usuario)
        {
            var sql = "";
            var reader = ExecuteReader(sql);
            if (reader.HasRows)
            {
                
            }
        }
    }
}
