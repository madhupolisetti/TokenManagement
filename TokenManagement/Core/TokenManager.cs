using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TokenManagement.Model;

namespace TokenManagement.Core
{
    public class TokenManager
    {
        private string _connectionString = string.Empty;
        private SqlConnection _sqlConnection = null;
        public TokenManager(string connectionString)
        {
            if (connectionString.Equals(string.Empty))
                throw new ArgumentException("Conncetion String should not be empty.", "connectionString");
            this._connectionString = connectionString;
            this._sqlConnection = new SqlConnection(this._connectionString);
        }
        public TokenManager()
        {
            if (System.Configuration.ConfigurationManager.ConnectionStrings["DbConnectionString"] == null)
                throw new KeyNotFoundException("DbConnectionString not found in application config file.");
            this._connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            this._sqlConnection = new SqlConnection(this._connectionString);
            Model.Token t = new Model.Token();              
        }
        public Newtonsoft.Json.Linq.JObject Search(List<DbParameter> _parameterList)
        {
            return new Newtonsoft.Json.Linq.JObject();
        }
    }
}
