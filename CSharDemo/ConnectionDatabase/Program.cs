using Microsoft.Data.SqlClient;

namespace DataBaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac50;Integrated Security=True";

            #region SelectQuery
            //SqlConnection con = new SqlConnection(connectionString);

            //string selectQuery = "SELECT * FROM Emp";

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

            #region Insert
            //SqlConnection conn = new SqlConnection(connectionString);
            //Console.WriteLine("Enter ID");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter Address");
            //string address = Console.ReadLine();

            //string insertQuery = $"Insert into Emp(ID,NAME,ADDRESS) values({id},'{nm}','{address}')";
            //SqlCommand cmd = new SqlCommand(insertQuery, conn);
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = insertQuery;
            //cmd.Connection = conn;

            //conn.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record Inserted Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //conn.Close();

            #endregion

            #region update

            //SqlConnection connection = new SqlConnection(connectionString);

            //Console.WriteLine("Enter Id to update");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name to update");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter adress to update");
            //string address = Console.ReadLine();

            //string updateQuery = $"update emp set Name = '{name}' , Address='{address}'  where Id = {id}";
            //SqlCommand command = new SqlCommand(updateQuery, connection);

            //connection.Open();
            //int noOfRowsAffected = command.ExecuteNonQuery();
            //if(noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record Updated successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
            //    connection.Close(); 
            #endregion

            #region Delete
            //SqlConnection connection = new SqlConnection(connectionString);
            //Console.WriteLine("Enter ID to delete");
            //int id = Convert.ToInt32(Console.ReadLine());
            //string deleteQuery = $"delete from emp where Id ={id}";
            //SqlCommand command = new SqlCommand(deleteQuery,connection);
            //connection.Open();
            //int numOfRows= command.ExecuteNonQuery();
            //if(numOfRows>0) {
            //    Console.WriteLine("Record Deleted Successfully");

            //}
            //else
            //{
            //    Console.WriteLine("Error:Id not found");
            //}
            //    connection.Close(); 
            #endregion


           
        }
    }
}
