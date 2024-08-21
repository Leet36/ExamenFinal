using ExamenFinal.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Vistas
{
    public partial class Registro_Salidas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BAgregarSalida_Click(object sender, EventArgs e)
        {

            string id = TIdSalida.Text;
            string paisDestino = TPD.Text;
            string aeropuertoSalida = TAS.Text;
            string aeropuertoDestino = TAD.Text;
            string fecha = TFS.Text;
            string hora = THS.Text;


            registroSalidas agregarSalida = new registroSalidas(id, paisDestino, aeropuertoSalida, aeropuertoDestino, fecha, hora);
            agregarSalida.registrarSalida(id, paisDestino, aeropuertoSalida, aeropuertoDestino, fecha, hora);

            TIdSalida.Text = "";
            TPD.Text = "";
            TAS.Text = "";
            TAD.Text = "";
            TFS.Text = "";
            THS.Text = "";




        }
    }
}