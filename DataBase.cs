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
        // Método que retorna a string de conexão do Banco de Dados com todos os alunos do sistema...
        public MySqlConnection conexao(MySqlConnection Conectar)
        {
          Conectar = new MySqlConnection("datasource = localhost; username = root; database = controlo_propinas; password = mariopaulos06; Sslmode=none;");
          // Conectar = new MySqlConnection("datasource = localhost; username = root; database = controlo_propinas; password = dudoamarildo; Sslmode=none;");
            return Conectar;

        }
        


        // Método que retorna a string de conexão do Banco de Dados com todos os usuários do sistema...
        public string ConetarUsuario()
        {
          string Conectar = "Server=localhost;Port=3306;Database=enti_uso;Uid=root;Pwd=mariopaulos06;Sslmode=none;";
          //string Conectar = "Server=localhost;Port=3306;Database=enti_uso;Uid=root;Pwd=dudoamarildo;Sslmode=none;";
            return Conectar;
        }


        public void ListaTurmas()
        {
        }

    }
}
