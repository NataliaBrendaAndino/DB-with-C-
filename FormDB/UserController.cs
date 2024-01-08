using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace FormDB
{
    internal class UserController
    {
        public static int AgregarUser(Persona persona) 
        {
            int retorno = 0;
            String consulta = "insert into usuarios (nombre, apellido) values('" 
                + persona.Nombre + "','" + persona.Apellido + "')";
            
            MySqlCommand command = new MySqlCommand(consulta, Conectar.ConectarMysql());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static DataTable listarUser()
        {
            String consulta = "SELECT * FROM usuarios";
            DataTable dt = new DataTable("usuarios");
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, Conectar.ConectarMysql());
            //the method .Fill excute the query in Data Base
            //and load result in object dt.
            da.Fill(dt);

            return dt;
        }

    }
}
