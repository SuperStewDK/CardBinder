using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password for database acces");
            String word = Console.ReadLine();
            String connectionString = "Data Source = DESKTOP - 65Q4BFL/SQLEXPRESS; Initial Catalog = CardBinder; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Card (Name, SerialNumber, Image) Values(@Name, @SerialNumber, @Image)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name", "Anders And");
                cmd.Parameters.AddWithValue("@SerialNumber", "10101");
                // Test to see if works without image
                SqlParameter imageParameter = new SqlParameter("@Image", SqlDbType.Image);
                imageParameter.Value = DBNull.Value;
                cmd.Parameters.Add(imageParameter);
                //cmd.Parameters.AddWithValue("@Image", "Images/Disneybog.jpg");
                if (connection.State != ConnectionState.Open)
                    { connection.Open(); }
                cmd.ExecuteNonQuery();

                Console.WriteLine("Jinx");
            }
        }
    }
}
