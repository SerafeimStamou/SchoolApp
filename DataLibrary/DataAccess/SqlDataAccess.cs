using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using SchoolApp.Models;

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
                return conn.Execute(sql,data);
            }
        }

        public static void Create<T>(string sql,T model)
        {
           ManipulateData(sql, model);

           if (model is Student)
              MessageBox.Show("Student added successfully");
           else
               MessageBox.Show("Teacher added successfully");
            
        }

        public static List<T> Read<T>(string sql) => LoadData<T>(sql);

        public static void Update<T>(string sql,T model)
        {
            ManipulateData(sql, model);

            if (model is Student)
                MessageBox.Show("Student updated successfully");
            else
                MessageBox.Show("Teacher updated successfully");
        }

        public static void Delete<T>(int Id,T model)
        {

            if (model is Student)
            {
                ManipulateData($"DELETE FROM Students WHERE ID={Id}", model);
                MessageBox.Show("Student deleted successfully");
            }
            else
            {
                ManipulateData($"DELETE FROM Teachers WHERE ID={Id}", model);
                MessageBox.Show("Teacher deleted successfully");
            }
        }
    }
}
