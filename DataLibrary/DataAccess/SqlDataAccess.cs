
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
      public static string GetConnectionString(string connectionName="School")=> ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

           public static List<T> LoadData<T>(string sql)
           {
             using(IDbConnection conn=new SqlConnection(GetConnectionString()))
             {
                return conn.Query<T>(sql).ToList();
             }
           }

        public static int ManipulateData<T>(string sql,T data)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString()))
            {
                return conn.Execute(sql, data);
            }
        }

        public static List<T>  Search<T>(string sql,T data)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString()))
            {
                return conn.Query<T>(sql,data).ToList();
            }
        }
    }
}
