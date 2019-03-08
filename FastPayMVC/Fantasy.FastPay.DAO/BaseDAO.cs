using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.DAO
{
    public abstract class BaseDAO
    {
        private readonly string stringConnection = "";
        private SqlCommand _sqlCommand;
        
        private SqlConnection _sqlConnection;
        private SqlConnection SqlConnection { 
            get {
                return _sqlConnection ?? (_sqlConnection = new SqlConnection(stringConnection));
            } 
        }

        
        protected void CreateCommand(string stringCommand)
        {
            
            _sqlCommand = new SqlCommand(stringCommand, SqlConnection);
            
        }
        protected void OpenConnection()
        {
            SqlConnection.Open();
        }

        protected void CloseConnection()
        {
            SqlConnection.Close();
            SqlConnection.Dispose();
        }

        protected SqlDataReader ExecuteDataReader()
        {
            return _sqlCommand.ExecuteReader(); 
        }

    }
}
