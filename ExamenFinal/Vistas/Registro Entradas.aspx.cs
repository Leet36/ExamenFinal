using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Vistas
{
    public partial class Registro_Entradas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BAgregarEntradaa_Click(object sender, EventArgs e)
        {
            string id = TIdSalida.Text;
            string paisOrigen = TPO.Text;
            string aeropuertoOrigen = TAO.Text;
            string aeropuertoDestino = TAD.Text;
            string fecha = TFE.Text;
            string hora = THE.Text;


            registroEntradas agregarSalida = new registroEntradas(id, paisOrigen aeropuertoOrigen, aeropuertoDestino, fecha, hora);
            agregarEntrada.registrarEntarda(id, paisOrigen, aeropuertoOrigen, aeropuertoOrigen, fecha, hora);

            TIdE.Text = "";
            TPO.Text = "";
            TAO.Text = "";
            TAD.Text = "";
            TFE.Text = "";
            THE.Text = "";

        }
    }
}