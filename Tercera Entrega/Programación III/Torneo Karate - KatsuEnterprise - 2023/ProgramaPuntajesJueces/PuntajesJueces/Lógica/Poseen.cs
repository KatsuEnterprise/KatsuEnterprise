using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntajesJueces.Lógica
{
    class Poseen
    {
        string CI, IDTorneo, IDRound;

        public Poseen(string CI, string IDTorneo, string IDRound)
        {
            this.CI = CI;
            this.IDTorneo = IDTorneo;
            this.IDRound = IDRound;
        }


        public Poseen() { } 

        public void NumKataComp(string CI, string IDTorneo, string IDRound)
        {
            string sql = $"SELECT NumKata FROM Poseen WHERE CI = {CI} AND IDTorneo = {IDTorneo} AND IDRound = {IDRound}";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

    }
}
