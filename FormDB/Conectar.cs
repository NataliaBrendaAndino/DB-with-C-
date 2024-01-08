using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormDB
{
    class Conectar
    {
        public static MySqlConnection ConectarMysql()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=csharp1";
            MySqlConnection conexion = new MySqlConnection(connectionString);

            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

            }

            return conexion;


        }
    }
}
