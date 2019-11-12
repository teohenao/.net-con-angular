using Entidades;
using System;
using System.Data.SqlClient;

namespace Data
{
    public class ClienteData
    {

        public string CrearCliente(Cliente unCliente)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=TEOPC;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand com = new SqlCommand();
            com.CommandText = "INSERT INTO [Customers] ([CustomerID],[ContactName],[CompanyName]) VALUES (@id,@nombre,@compania)";
            com.Parameters.AddWithValue("@id", unCliente.Id);
            com.Parameters.AddWithValue("@nombre", unCliente.Nombre);
            com.Parameters.AddWithValue("@compania", unCliente.Compania);
            com.Connection = con;
            con.Open();
            int registros = com.ExecuteNonQuery();
            con.Close();
            if (registros > 0)
                return "Cliente creado con éxito";
            else
                return "No se pudo crear el Cliente";
        }
    }
}
