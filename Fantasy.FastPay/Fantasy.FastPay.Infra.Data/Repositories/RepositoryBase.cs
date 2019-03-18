using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        
        //DbContext ou o acesso ao banco de dados 

        private SqlConnection _sqlConnection;
        private SqlConnection SqlConnection
        {
            get { return _sqlConnection ?? (_sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FastPayBD"].ConnectionString)); }
        }

        private SqlCommand _sqlCommand;


        protected SqlDataReader ExecuteReader(string sqlQueryOrProc, params SqlParameter[] parameters)
        {
            try
            {
                SqlConnection.Open();
                _sqlCommand = new SqlCommand(sqlQueryOrProc, SqlConnection);
                _sqlCommand.Parameters.AddRange(parameters.ToArray());
                return _sqlCommand.ExecuteReader();
            }finally{
                SqlConnection.Close();
            }

        }

        public void Dispose()
        {
            _sqlConnection.Dispose();
            _sqlCommand.Dispose();
        }
    }
}
