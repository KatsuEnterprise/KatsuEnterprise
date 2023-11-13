using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorKata.Lógica
{
    class Califica
    {

        string CIComp, IDRound, NumKata, IDToreno;
        double Puntaje;
        int NumJuez;

        public Califica(string CIComp, string IDRound, string NumKata, string IDToreno, double Puntaje, int NumJuez)
        {

            this.CIComp = CIComp;
            this.IDRound = IDRound;
            this.NumKata = NumKata;
            this.IDToreno = IDToreno;
            this.Puntaje = Puntaje;
            this.NumJuez = NumJuez; 
        }


        public void IngresarDatosACalifica()
        {
                string sentencia = "INSERT INTO Califica (CI, IDTorneo, NumKata, NumJuez, Puntaje, IDRound) " +
                                  "VALUES (@CI, @IDTorneo, @NumKata, @NumJuez, @Puntaje, @IDRound)";

                using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
                using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
                {
                    cmd.Parameters.AddWithValue("@CI", this.CIComp);
                    cmd.Parameters.AddWithValue("@IDTorneo", this.IDToreno);
                    cmd.Parameters.AddWithValue("@NumKata", this.NumKata);
                    cmd.Parameters.AddWithValue("@NumJuez", this.NumJuez);
                    cmd.Parameters.AddWithValue("@Puntaje", this.Puntaje);
                    cmd.Parameters.AddWithValue("@IDRound", this.IDRound);

                    cmd.ExecuteNonQuery();
                }
        }


    }
}
