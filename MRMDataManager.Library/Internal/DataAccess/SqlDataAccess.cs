using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRMDataManager.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<T> LoadData<T, U>(string StoredProcedure, U parameters, string connectionstringname)
        {
            string connectionstring = GetConnectionString(connectionstringname);
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                List<T> rows = connection.Query<T>(StoredProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }
        public void SaveData<T>(string StoredProcedure, T parameters, string connectionstringname)
        {
            string connectionstring = GetConnectionString(connectionstringname);
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                connection.Execute(StoredProcedure, parameters,
                          commandType: CommandType.StoredProcedure);

             }
        }
    }
}
