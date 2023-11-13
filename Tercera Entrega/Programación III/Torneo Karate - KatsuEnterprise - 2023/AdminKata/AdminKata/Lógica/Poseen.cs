using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorKata.Lógica
{
    class Poseen
    {

        string CIComp, IDRound, NumKata, IDToreno;

        public Poseen(string CIComp, string IDRound, string NumKata, string IDTorneo)
        { 
        
            this.CIComp = CIComp;
            this.IDRound = IDRound;
            this.NumKata = NumKata; 
            this.IDToreno = IDTorneo; 

        }

        public Poseen() { }

        public void IngresarKataComp(string CIComp, string IDRound, string NumKata, string IDTorneo)
        {
            
            string sentencia = $"INSERT INTO Poseen VALUES('{CIComp}', '{IDRound}', '{NumKata}', '{IDTorneo}')";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

    }
}
