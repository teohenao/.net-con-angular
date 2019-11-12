using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace SQLConnectiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo un objeto DataTable llamado empresas
            DataTable dtEmpresas = new DataTable("Empresas");

            //Al objeto dtEmpresas le agrego dos dataColumns de tipo string
            dtEmpresas.Columns.Add("CustomerID",typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            //creamos un Objeto SqlConention
            SqlConnection con = new SqlConnection();
            //Indicamos el conection string que se utilizara
            con.ConnectionString = "Data Source=TEOPC;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //creo un objeto SqlComand
            SqlCommand myComand = new SqlCommand();
            //indico la cadena TSQL que utilizara
            myComand.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            //indico el objeto de conexion que utilizara
            myComand.Connection = con;

            //abrimos la conexion con la base de datos
            con.Open();
            //Creo un objeto de dataReader y ejecuto el metodo, executeReader del objeto myComand
            SqlDataReader myDr = myComand.ExecuteReader();
            //cargo los datos en el dataTable utilizando el objeto dataReader
            dtEmpresas.Load(myDr);
            //cierro la conexion
            con.Close();

            //Recorro la lista de empresas obtenidas y las muestro por consola
            Console.Write("Listado de empresas");
            foreach (DataRow empresa in dtEmpresas.Rows)
            {
                String idEmpresa = empresa["CustomerID"].ToString();
                String nombreEmpresa = empresa["CompanyName"].ToString();
                Console.WriteLine(idEmpresa +" - "+nombreEmpresa);
            }


        }
    }
}
