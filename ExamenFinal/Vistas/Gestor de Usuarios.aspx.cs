using ExamenFinal.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Vistas
{
    public partial class Gestor_de_Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BIngresoDatosUsuario_Click(object sender, EventArgs e)
        {

            string id = TIngresoIdUsuario.Text;
            string nombre = TIngresoNombre.Text;
            string primerApellido = TApellido1.Text;
            string segundoApellido = TApellido2.Text;

            CRUD nuevoUsuario = new CRUD(id, nombre, primerApellido, segundoApellido);
            nuevoUsuario.agregarPersona(id, nombre, primerApellido, segundoApellido);
            
            TIngresoIdUsuario.Text="";
            TIngresoNombre.Text = "";
            TApellido1.Text = "";
            TApellido2.Text = "";
        }

        public void BModificarUsuario_Click(object sender, EventArgs e)
        {

            string id = TIngresoIdUsuario.Text;
            string nombre = TIngresoNombre.Text;
            string primerApellido = TApellido1.Text;
            string segundoApellido = TApellido2.Text;

            CRUD modificarUsuario = new CRUD(id, nombre, primerApellido, segundoApellido);
            modificarUsuario.modificarPersona(id, nombre, primerApellido, segundoApellido);

            TIngresoIdUsuario.Text = "";
            TIngresoNombre.Text = "";
            TApellido1.Text = "";
            TApellido2.Text = "";
        }

        public void BEliminarUsuario_Click(object sender, EventArgs e)
        {

            string id = TIngresoIdUsuario.Text;
            string nombre = TIngresoNombre.Text;
            string primerApellido = TApellido1.Text;
            string segundoApellido = TApellido2.Text;

            CRUD eliminarPersona = new CRUD(id, nombre,primerApellido, segundoApellido);
            eliminarPersona.eliminarPersona(id);

            TIngresoIdUsuario.Text = "";
            TIngresoNombre.Text = "";
            TApellido1.Text = "";
            TApellido2.Text = "";
        }

        public void BMenu_Click(object sender, EventArgs e)
        {

            Response.Redirect("Menu.aspx");
        }


    }
}