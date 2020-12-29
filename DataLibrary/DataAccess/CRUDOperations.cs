using System.Collections.Generic;
using System.Windows.Forms;
using static DataLibrary.DataAccess.SqlDataAccess;


namespace DataLibrary.DataAccess
{
    public static class CRUDOperations
    {
        public static void Create<T>(string query, T model)
        {
            int rowsAffected = ManipulateData(query, model);

            if (rowsAffected > 0)
                MessageBox.Show("Operation completed successfully");
        }

        public static List<T> Read<T>(string query)
        {
            return LoadData<T>(query);
        }

        public static void Update<T>(string query, T model)
        {
            int rowsAffected = ManipulateData(query, model);

            if (rowsAffected > 0)
                MessageBox.Show("Operation completed successfully");
        }

        public static void Delete<T>(string query, T model)
        {
            int rowsAffected = ManipulateData(query, model);

            if (rowsAffected > 0)
                MessageBox.Show("Operation completed successfully");
        }
    }
}
