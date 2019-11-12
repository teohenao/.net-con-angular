using Data;
using Entidades;
using System;
using System.Data.SqlClient;

namespace Business
{
    public class ClienteBusiness
    {
        ClienteData data;
        public string CrearCliente(Cliente unCliente)
        {
            try
            {
                data = new ClienteData();
                return data.CrearCliente(unCliente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
