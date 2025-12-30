using Microsoft.Data.SqlClient;

namespace DataBaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac50;Integrated Security=True";
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac50;Integrated Security=True";
            #region SelectQuery
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac50;Integrated Security=True";


            //SqlConnection con = new SqlConnection(connection);

            //string selectQuery = "SELECT * FROM Emp2";

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = selectQuery;
            //cmd.Connection = con;

            //con.Open();

            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader["Id"]);
            //    string? nm = reader["Name"].ToString();
            //    string? address = reader["Address"].ToString();
            //    Console.WriteLine($"Id:{id}, Name: {nm}, Address: {address}");
            //}
            //con.Close();
            #endregion


            SqlConnection conn = new SqlConnection(connection);
            Console.WriteLine("Enter ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            string insertQuery = $"Insert into Emp(ID,NAME,ADDRESS) values({id},'{nm}','{address}')";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = insertQuery;
            cmd.Connection = conn;

            conn.Open();
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            if (noOfRowsAffected > 0)
            {
                Console.WriteLine("Record Inserted Successfully");
            }
            else
            {
                Console.WriteLine("Error");
            }

            conn.Close();


        }
    }
}
