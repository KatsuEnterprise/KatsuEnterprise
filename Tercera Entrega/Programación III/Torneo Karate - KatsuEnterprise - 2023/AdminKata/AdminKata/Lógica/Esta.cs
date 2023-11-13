using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorKata.Lógica
{
    class Esta
    {
        private int  CIComp, IDTorneo;

        public Esta(int cIComp, int iDTorneo)
        { 
            IDTorneo = iDTorneo;
            CIComp = cIComp;
        }

        public Esta() { }

        public void GuardarCompetidorEnTorneo(string Cedula, string Torneo)
        {

            string sentencia = $"INSERT INTO Esta VALUES ({Cedula}, {Torneo})";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();

        }

    }
}
