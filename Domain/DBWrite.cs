using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class DBWrite
    {
        public void cardToDB(Card card)
        {
            
            String connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = CardBinder;Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Card (name, serialnumber, imagepath) Values(@name, @serialnumber, @imagepath)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@name", card.Name);
                cmd.Parameters.AddWithValue("@serialnumber", card.SerialNumber);
                cmd.Parameters.AddWithValue("@imagepath",card.ImagePath);
                if (connection.State != ConnectionState.Open)
                { connection.Open(); }
                cmd.ExecuteNonQuery();

                Console.WriteLine("Data Saved!");

            }
        }
    }
}
