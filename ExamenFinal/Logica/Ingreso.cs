using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenFinal.Logica
{
    public class Ingreso
    {
        public string contraseña { get; set; }
        public string id { get; set; }


        public Ingreso(string contraseña, string id)
        {

            this.contraseña = contraseña;
            this.id = id;
        }


      






    }
}