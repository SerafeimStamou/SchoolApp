using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace DataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "School")
        {
           return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static int ManipulateData<T>(string query,T model)
        {
            IDbConnection conn = new SqlConnection(GetConnectionString());

            try
            {
               return conn.Execute(query, model);
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
               return 0;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }  
        }

        public static List<T> LoadData<T>(string query)
        {
            IDbConnection conn = new SqlConnection(GetConnectionString());

            try
            {
                return conn.Query<T>(query).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

         public static int CheckForDuplicates<T>(string query,T model)
         {
            IDbConnection conn = new SqlConnection(GetConnectionString());
            
            try
            {
               return conn.Query<T>(query, model).Count();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            } 
         }
    }
}
