using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControloDePropinas
{
    class DataBase
    {
        public MySqlConnection conexao(MySqlConnection Conectar)
        {
            Conectar = new MySqlConnection("datasource = localhost; username = root; database = controlo_propinas; password = dudoamarildo; Sslmode=none;");
            return Conectar;

        }

        public MySqlConnection ConetarUsuari()
        {
            return new MySqlConnection("datasource = localhost; username = root; database = enti_uso; password = dudoamarildo; Sslmode=none;");
          

        }

    }
}
