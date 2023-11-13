using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntajesJueces.Lógica
{
     class Torneo
    {

        public Torneo()
        { }

        public System.Data.DataTable ListarComboBox()
        {

            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = "SELECT IDTorneo FROM Torneo";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();
            //si dejamos la conexion abierta a la base de datas, pueden surgir problemas de inyecciones

            return dt;
        }

    }
}
