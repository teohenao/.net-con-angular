using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT EmployeeID,FirstName FROM Employees";
            com.Connection = con;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                Console.Write(dr["EmployeeID"]+" "+ dr["FirstName"]);
            }
            Console.ReadLine();
            con.Close();
        }

    }
}
