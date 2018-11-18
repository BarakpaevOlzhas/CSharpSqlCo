using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlDz
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserConectionString"].ConnectionString;
                sqlConnection.ConnectionString = connectionString;

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "Create Table Gruppa (id int not null, Name Nvarchar(MAX))";

                SqlDataReader reader = sqlCommand.ExecuteReader();
            }
        }
    }
}
