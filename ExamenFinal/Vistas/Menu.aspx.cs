using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Vistas
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gestor de Usuarios.aspx");
        }

        protected void BRegistroSalidas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro Salidas.aspx");
        }
    }
}