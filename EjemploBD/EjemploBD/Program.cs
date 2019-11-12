using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Mateo Henao Rodriguez
/// Ejemplo de conexion a la base de datos
/// </summary>
namespace EjemploBD
{
    class Program
    {
        static void Main(string[] args)
        {
            //se encarga de establecer la conexion
            SqlConnection con = new SqlConnection();
            //cadena de conexion se puede encontrar en propiedades encima de la base de datos
            con.ConnectionString = "Data Source=TEOPC;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //comand nos permite ejecutar sentencias  
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT EmployeeID,FirstName FROM Employees";
            //comand necesita conectarse con labase de datos
            com.Connection = con;
            //se abre la conexion
            con.Open();

            //execute data reader es para ejecutar la sentencia sql
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["EmployeeID"]);
                Console.WriteLine(dr["FirstName"]);
            }
            Console.Read();
            //se cierra la conexion
            con.Close();
        }
    }
}
