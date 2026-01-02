using Microsoft.Data.SqlClient;

namespace _Connected.Models
{
    // Data Access Layer
    public class DACContext
    {
        private readonly string? _connectionString;
        public DACContext(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DAC");
        }

        public List<Emp> GetAllEmps()
        {
            List<Emp> emps = new List<Emp>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Emp", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            emps.Add(new Emp() { 
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString()
                            });
                        }
                    }
                }
            }
            return emps;
        }
    }
}
