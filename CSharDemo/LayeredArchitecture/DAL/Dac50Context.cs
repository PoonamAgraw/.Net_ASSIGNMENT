using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.Models;
using Microsoft.Data.SqlClient;

namespace LayeredArchitecture.DAL
{
    public class Dac50Context
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac50;Integrated Security=True;";
        #region Select 
        public List<Emp> GetEmpRecord()
        {
            SqlConnection connection = new SqlConnection(conn);

            SqlCommand command = new SqlCommand("Select * from emp", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Emp> list = new List<Emp>();
            while (reader.Read())
            {
                list.Add(new Emp()
                {
                    EId = Convert.ToInt32(reader["ID"]),
                    EName = reader["Name"].ToString(),
                    EAddress = reader["Address"].ToString()

                });
            }
            connection.Close();
            return list;


        }
        #endregion


        #region Search by id
        public List<Emp> SearchById(int selectId)
        {
            SqlConnection connection = new SqlConnection(conn);
            string selectById = $"select * from emp where Id = {selectId}";
            SqlCommand cmd = new SqlCommand(selectById, connection);
            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<Emp> list = new List<Emp>();
            while (reader.Read())
            {
                list.Add(new Emp()
                {
                    EId = Convert.ToInt32(reader["ID"]),
                    EName = reader["Name"].ToString(),
                    EAddress = reader["Address"].ToString()
                });
            }
            connection.Close();
            return list;
        }
        #endregion


        #region Insert
        public int InsertRecord(Emp emp)
        {
            SqlConnection connection = new SqlConnection(conn);
            string insertQuery = $"insert into emp values ('{emp.EName}','{emp.EAddress}')";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            connection.Open();
            int count = cmd.ExecuteNonQuery();

            connection.Close();
            return count;
        }
        #endregion


        #region Update
        public int UpdateRecord(int id, Emp emp1)
        {
            SqlConnection connection = new SqlConnection(conn);
            string updateQuery = $"update emp set Name ='{emp1.EName}', Address ='{emp1.EAddress}' where Id={emp1.EId} ";
            SqlCommand cmd = new SqlCommand(updateQuery, connection);
            connection.Open();
            int count = cmd.ExecuteNonQuery();
            connection.Close();
            return count;
        }
        #endregion

        public int DeleteRecord(int id)
        {
            SqlConnection connection= new SqlConnection(conn);
            string deleteRecord = $"Delete emp where Id={id}";
            SqlCommand cmd = new SqlCommand(deleteRecord, connection);
            connection.Open();
            int count = cmd.ExecuteNonQuery();
            connection.Close();
            return count;
                
        }
    }
}
