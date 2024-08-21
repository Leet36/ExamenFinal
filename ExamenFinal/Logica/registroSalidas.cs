using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenFinal.Logica
{
    public class registroSalidas
    {

        public string id { get; set; }
        public string paisDestino { get; set; }
        public string aeropuertoSalida { get; set; }
        public string aeropuertoDestino { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

        public registroSalidas(string id, string paisDestino, string aeropuertoSalida, string aeropuertoDestino, string fecha, string hora)
        {


            this.id = id;
            this.paisDestino = paisDestino;
            this.aeropuertoSalida = aeropuertoSalida;
            this.aeropuertoDestino = aeropuertoDestino;
            this.fecha = aeropuertoSalida;
            this.hora = hora;
        }



        public void registrarSalida(string id, string paisDestino, string aeropuertoSalida, string aeropuertoDestino, string fecha, string hora) //Este metodo permite  agregar  un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=migracion; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string ingreso = "Insert into registroSalidas ([Id],[PaisDestino],[AeropuertoSalida],[AeropuertoDestino],[fecha],[hora]) values('" + id + "','" + paisDestino + "','" + aeropuertoSalida + "','" + aeropuertoDestino + "','" + fecha + "','" + hora + "') ";
            SqlCommand comando = new SqlCommand(ingreso, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

        }





    }
}