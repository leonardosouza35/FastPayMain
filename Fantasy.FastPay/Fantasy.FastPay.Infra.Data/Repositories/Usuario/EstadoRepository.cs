using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class EstadoRepository : RepositoryBase<Estado>, IEstadoRepository
    {
        public void Adicionar(Estado estado)
        {
            var estados = new List<Estado>(); 
            var  param = new SqlParameter();

            var linhasAfetadas = ExecuteNoQuery("select... ou storeprocedure", param);

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        var est = new Estado();
            //        estado.Nome = reader["Nome"].ToString();
            //        ///
            //    }
            //}
        }
    }
}
