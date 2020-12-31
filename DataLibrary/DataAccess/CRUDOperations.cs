using SchoolApp.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using static DataLibrary.DataAccess.SqlDataAccess;


namespace DataLibrary.DataAccess
{
    public static class CRUDOperations
    {
        public static void Create<T>(string query, T model,bool viewMessage)
        {
            int rowsAffected = ManipulateData(query, model);

            if (rowsAffected > 0 && viewMessage == true)
            {
                if (model is Student)
                    MessageBox.Show("Student added successfully");
                else
                    MessageBox.Show("Teacher added successfully");
            }
        }

        public static List<T> Read<T>(string query)
        {
            return LoadData<T>(query);
        }

        public static void Update<T>(string query, T model,bool viewMessage)
        {
            int rowsAffected = ManipulateData(query, model);

            if (rowsAffected > 0 && viewMessage == true)
            {
                if (model is Student)
                    MessageBox.Show("Student updated successfully");
                else
                    MessageBox.Show("Teacher updated successfully");
            }
        }

        public static void Delete<T>(string query, T model,bool viewMessage)
        {
            int rowsAffected = ManipulateData(query, model);

            if (rowsAffected > 0 && viewMessage == true)
            {
                if (model is Student)
                    MessageBox.Show("Student deleted successfully");
                else
                    MessageBox.Show("Teacher deleted successfully");
            }
        }
    }
}
