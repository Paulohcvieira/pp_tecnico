using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UC12_projetoPP
{
    internal class ClassSQL
    {
        public static MySqlConnection conexao = null;
        public static MySqlCommand comando = null;
        public static string server = "server=localhost;database=pp_tecnico;Uid=root;Pwd= ;";
        public static string permissaobd;
    }
}
