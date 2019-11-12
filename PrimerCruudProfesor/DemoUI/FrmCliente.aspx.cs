using Business;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoUI
{
    public partial class FrmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.Id = txtId.Text;
                c.Nombre = txtNombre.Text;
                c.Compania = txtCompania.Text;
                ClienteBusiness b = new ClienteBusiness();
                string m = b.CrearCliente(c);
                lblResultado.Text = m;

            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }
    }
}