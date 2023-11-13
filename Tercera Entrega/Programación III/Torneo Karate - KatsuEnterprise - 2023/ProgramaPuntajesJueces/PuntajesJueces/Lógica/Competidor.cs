using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntajesJueces.Lógica
{
     class Competidor
    {
        bool competidoractivo;

        public Competidor()
        { }

        public Competidor(bool competidoractivo)
        { this.competidoractivo = competidoractivo; }

        public void CompetidorActivo(bool competidoractivo)
        {

            string sentencia = $"SELECT CI FROM Compite WHERE {competidoractivo = true}";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());
            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();


        }

        public System.Data.DataTable ListarCBox()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = $"SELECT Nombre, Apellido, CI FROM Competidor";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            //si dejamos la conexion abierta a la base de datas, pueden surgir problemas de inyecciones
            Conexion.GetInstancia().Desconectar();

            return dt;
        }

    }

    


}
