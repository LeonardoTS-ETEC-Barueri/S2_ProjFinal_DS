using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;       // Driver de conexão MySQL x VS Studio 2019.

namespace DAL_ProjFinalDS
{
    public class DAL_Conexao
    {
        public string myConnection = "server = localhost; user id = root; database=db_listacontatos_ds_fims2";


        // Método para inicializar a conexão com a base de dados.
        public MySqlConnection conectar()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Open();

                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar. Tente novamente. \n Erro: " + ex.Message);
            }
        }

    }
}
