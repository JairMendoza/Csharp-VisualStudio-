using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Archivos_Mp3
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=BD_Amigos; Uid=root; pwd=1234567890;");
            conectar.Open();
            return conectar;
        }
    }
}
