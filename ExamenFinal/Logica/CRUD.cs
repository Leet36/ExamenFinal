using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenFinal.Logica
{
    public class CRUD
    {

        public string id { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }


        public CRUD( string id, string nombre, string primerApellido, string segundoApellido)
        {

          
            this.id = id;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
        }


        public void agregarPersona(string id, string nombre, string primerApellido, string segundoApellido) //Este metodo permite  agregar  un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=migracion; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string ingreso = "Insert into usuarios ([Id],[Nombre],[PrimerApellido],[SegundoApellido]) values('" + id + "','" + nombre + "','" + primerApellido + "','" + segundoApellido + "') ";
            SqlCommand comando = new SqlCommand(ingreso, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

        }

        public void modificarPersona(string id, string nombre, string primerApellido, string segundoApellido) //Este metodo permite  modificar los datos (nombre, priemr apellido y segundo apellido) de un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=migracion; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string modificacion = "Update usuarios set  Nombre='" + nombre + "',   PrimerApellido='" + primerApellido + "', SegundoApellido='" + segundoApellido + "'   where Id= '" + id + "'";
            SqlCommand comando = new SqlCommand(modificacion, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }

        public void eliminarPersona(string id) //Este metodo permite  eliminar los datos de un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=migracion; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string eliminacion = "Delete from usuarios where Id= '" + id + "'";
            SqlCommand comando = new SqlCommand(eliminacion, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }




    }
}