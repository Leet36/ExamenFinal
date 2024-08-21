using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenFinal.Logica
{
    public class registroEntrada
    {
        public string id { get; set; }
        public string paisOrigen { get; set; }
        public string aeropuertoOrigen { get; set; }
        public string aeropuertoDestino { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

        public registroEntrada(string id, string paisOrigen, string aeropuertoOrigen, string aeropuertoDestino, string fecha, string hora)
        {


            this.id = id;
            this.paisOrigen = paisOrigen;
            this.aeropuertoOrigen = aeropuertoOrigen;
            this.aeropuertoDestino = aeropuertoDestino;
            this.fecha = fecha;
            this.hora = hora;
        }



        public void registrarEntrada(string id, string paisOrigen, string aeropuertoSalida, string aeropuertoDestino, string fecha, string hora) //Este metodo permite  agregar  un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=migracion; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string ingreso = "Insert into registroEntradas ([Id],[PaisOrigen],[AeropuertoSalida],[AeropuertoDestino],[fecha],[hora]) values('" + id + "','" + paisOrigen + "','" + aeropuertoOrigen + "','" + aeropuertoDestino + "','" + fecha + "','" + hora + "') ";
            SqlCommand comando = new SqlCommand(ingreso, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

        }



    }
}