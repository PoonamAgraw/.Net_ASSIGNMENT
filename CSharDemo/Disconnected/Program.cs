using System.Data;
using Microsoft.Data.SqlClient;

namespace Disconnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _Conn = $"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac50;Integrated Security=True";
            SqlConnection con = new SqlConnection(_Conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EMP", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet ds = new DataSet();
            da.Fill(ds, "Emp");

            foreach (DataRow row in ds.Tables["Emp"].Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                string nm = row["Name"].ToString();
                string add = row["Address"].ToString();
                Console.WriteLine($"Id: {id}, Name: {nm}, Address: {add}");
            }


             SqlConnection conn = new SqlConnection(_Conn);
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM EMP", conn);

            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            SqlCommandBuilder builder = new SqlCommandBuilder(da1);

            DataSet ds1 = new DataSet();
            da.Fill(ds1, "Emp");
    

            Console.WriteLine("Enter Name:");
            string nmm = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            string addd = Console.ReadLine();

            DataRow newRow = ds1.Tables["Emp"].NewRow();
            newRow["Name"] = nmm;
            newRow["Address"] = addd;

            ds1.Tables["Emp"].Rows.Add(newRow);

            da1.Update(ds1, "Emp");
            Console.WriteLine("Record inserted!");

        }
    }
}
