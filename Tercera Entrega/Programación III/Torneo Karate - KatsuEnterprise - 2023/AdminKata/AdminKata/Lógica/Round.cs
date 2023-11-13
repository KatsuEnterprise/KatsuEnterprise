using System;

namespace AdministradorKata.Lógica
{
    class Round
    {
        private int IDRound;
        private int IDTorneo;
        private int IDPool;

        public Round(int IDRound, int IDTorneo, int IDPool)
        {
            this.IDRound = IDRound;
            this.IDTorneo = IDTorneo;
            this.IDPool = IDPool;
        }

        public Round()
        { }

        public void AltaRound()
        {
            string sentencia = $"INSERT INTO Round VALUES('{this.IDRound}', '{this.IDTorneo}', '{this.IDPool}')";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();

        }



    }
}

