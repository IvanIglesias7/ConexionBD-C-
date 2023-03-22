using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecyto1.Clases
{
     class CConexion
    {
        NpgsqlConnection conexion = new NpgsqlConnection();

        static string servidor = "localhost";
        static string bd = "pilotoPharma";
        static string usuario = "postgres";
        static string passw = "1234";
        static string puerto = "5432";

        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario +
            ";" + "password=" + passw + ";" + "database=" + bd + ";";  


        public NpgsqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                Console.WriteLine("Se ha abierto la conexion");

            }catch(NpgsqlException  e)
            {
                Console.WriteLine(e.Message);
            }

        return conexion;
        }
    }
}
