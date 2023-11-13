using MySql.Data.MySqlClient;
using System;

namespace AdministradorKata.Lógica
{
    class Competidor
    {
        private string nombreComp;
        private string apellidoComp;
        private int ciComp;
        private DateTime nacimientoComp;
        private DateTime vecimientoCarnetSalud;
        private string sociedadComp;
        private string escuelaComp;
        private string profe;


        public Competidor(string nombreComp, string apellidoComp, int ciComp, DateTime nacimientoComp, DateTime vecimientoCarnetSalud, string sociedadComp, string escuelaComp, string profe)
        {
            this.nombreComp = nombreComp;
            this.apellidoComp = apellidoComp;
            this.ciComp = ciComp;
            this.nacimientoComp = nacimientoComp;
            this.vecimientoCarnetSalud = vecimientoCarnetSalud;
            this.sociedadComp = sociedadComp;
            this.escuelaComp = escuelaComp;
            this.profe = profe;
        }

        public Competidor()
        { }

        public System.Data.DataTable ListarDGVCompetidor()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = "SELECT Nombre AS Nombre, Apellido AS Apellido, CI AS Cédula, DATE_FORMAT(FechaNac, '%Y-%m-%d') AS FechaNacimiento, DATE_FORMAT(VecimientoCarnetSalud, '%Y-%m-%d') AS CarnetSalud, SociedadMedica AS Sociedad, EscuelaCompetidor AS EscuelaKarate, ProfeSupervisor AS ProfeResponsable FROM Competidor";

            using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar()))
            {
                using (MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                {
                    adp.Fill(dt);
                }
            }

            // Si dejamos la conexión abierta a la base de datos, pueden surgir problemas de inyecciones
            Conexion.GetInstancia().Desconectar();
            return dt;
        }

        public void AltaCompetidor()
        {
            string fechaNacimiento = this.nacimientoComp.ToString("yyyy-MM-dd");
            string fechaCS = this.vecimientoCarnetSalud.ToString("yyyy-MM-dd");

            string sentencia = "INSERT INTO Competidor (Nombre, Apellido, CI, FechaNac, VecimientoCarnetSalud, SociedadMedica, EscuelaCompetidor, ProfeSupervisor) " +
                $"VALUES ('{this.nombreComp}', '{this.apellidoComp}', '{this.ciComp}', '{fechaNacimiento}', '{fechaCS}', '{this.sociedadComp}', '{this.escuelaComp}', '{this.profe}') ";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();
            Conexion.GetInstancia().Desconectar();
        }

        public void ModificarCompetidor()
        {
            string fechaNacimiento = this.nacimientoComp.ToString("yyyy-MM-dd");
            string fechaCS = this.vecimientoCarnetSalud.ToString("yyyy-MM-dd");

            string sentencia = $"UPDATE Competidor SET Nombre = '{this.nombreComp}' , Apellido = '{this.apellidoComp}', CI = {this.ciComp} , FechaNac = '{fechaNacimiento}'," +
                $" VecimientoCarnetSalud = '{fechaCS}', SociedadMedica = '{this.sociedadComp}'" +
                $"WHERE CI = '{this.ciComp}'";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

        public void BajaCompetidor(int ciComp)
        {
            string sentencia = $"DELETE FROM Competidor WHERE CI = '{ciComp}' ";

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

        public int CantidadCompetidores(string numTorneo)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            int cant_comp;
            string sql = $"SELECT count(*) FROM Esta WHERE IDTorneo = {numTorneo}";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();

            cant_comp = dt.Rows.Count;

            return cant_comp;
        }

        public Tuple<int[], int[]> SortearPrimerRound(string numTorneo)
        {
            int[] competidores = new int[CantidadCompetidores(numTorneo)];
            int[] pool1 = null;
            int[] pool2 = null;

            if (CantidadCompetidores(numTorneo) == 3)
            {
                pool1 = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    pool1[i] = competidores[i];
                }
            }
            else if (CantidadCompetidores(numTorneo) == 4)
            {
                pool1 = new int[2];
                pool2 = new int[2];

                pool1[0] = competidores[0];
                pool1[1] = competidores[1];
                pool2[0] = competidores[2];
                pool2[1] = competidores[3];
            }
            else if (CantidadCompetidores(numTorneo) == 5)
            {
                pool1 = new int[3];
                pool2 = new int[2];

                pool1[0] = competidores[0];
                pool1[1] = competidores[1];
                pool1[2] = competidores[2];
                pool2[0] = competidores[3];
                pool2[1] = competidores[4];
            }

            return new Tuple<int[], int[]>(pool1, pool2);
            
        }
    

        public int SortearCalificados(int numTorneo)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            int cant_comp;
            string sql = $"SELECT count(*) FROM Esta WHERE IDTorneo = {numTorneo}";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();

            cant_comp = dt.Rows.Count;

            return cant_comp;
        }

        public System.Data.DataTable SortearOtrosRound(string numTorneo)
        {
            int[] competidores = new int[CantidadCompetidores(numTorneo)];

            if (CantidadCompetidores(numTorneo) == 3)
            {
                int[] pool1 = new int[3];

                for (int i = 0; i < 3; i++)
                    pool1[i] = competidores[i];
            }
            else if (CantidadCompetidores(numTorneo) == 4)
            {
                int[] pool1 = new int[2];
                int[] pool2 = new int[2];

                pool1[0] = competidores[0];
                pool1[1] = competidores[1];
                pool2[0] = competidores[2];
                pool2[1] = competidores[3];
            }
            else if (CantidadCompetidores(numTorneo) == 5)
            {
                int[] pool1 = new int[3];
                int[] pool2 = new int[2];

                pool1[0] = competidores[0];
                pool1[1] = competidores[1];
                pool1[2] = competidores[2];
                pool2[0] = competidores[3];
                pool2[1] = competidores[4];

            }

            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = $"SELECT CI, IDTorneo FROM Esta e WHERE e.IDTorneo = {numTorneo} ; ";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();
            //si dejamos la conexion abierta a la base de datas, pueden surgir problemas de inyecciones

            return dt;
        }


        //Estado del competidor
        public void ActualizarEstadoCompetidor(string cedula)
        {
            string sqlDesactivarOtrosCompetidores = "UPDATE Compite SET CompetidorActivo = false WHERE CI <> @CI";
            string sqlActivarCompetidor = "UPDATE Compite SET CompetidorActivo = true WHERE CI = @CI";

            using (MySql.Data.MySqlClient.MySqlCommand cmdDesactivarOtrosCompetidores = new MySql.Data.MySqlClient.MySqlCommand(sqlDesactivarOtrosCompetidores, Conexion.GetInstancia().Conectar()))
            {
                cmdDesactivarOtrosCompetidores.Parameters.Add("@CI", MySqlDbType.VarChar).Value = cedula;
                cmdDesactivarOtrosCompetidores.ExecuteNonQuery();
            }

            using (MySql.Data.MySqlClient.MySqlCommand cmdActivarCompetidor = new MySql.Data.MySqlClient.MySqlCommand(sqlActivarCompetidor, Conexion.GetInstancia().Conectar()))
            {
                cmdActivarCompetidor.Parameters.Add("@CI", MySqlDbType.VarChar).Value = cedula;
                cmdActivarCompetidor.ExecuteNonQuery();
            }

            Conexion.GetInstancia().Desconectar();
        }


        public void CompetidorCompitiendo(string cedula, string IDTorneo, string IDRound, bool competidorActivo )
        {
            string sentencia = $"INSERT INTO Compite VALUES({cedula}, {IDTorneo}, {IDRound},  {competidorActivo} )";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();
            Conexion.GetInstancia().Desconectar();
        }

        public bool CompetidorExiste()
        {
            // Consulta SQL para verificar la existencia del competidor por su CI
            string sentencia = "SELECT COUNT(*) FROM Competidor WHERE CI = @ciComp";

            using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar()))
            {
                cmd.Parameters.AddWithValue("@ciComp", ciComp);

                // Ejecuta la consulta y obtén el resultado
                object result = cmd.ExecuteScalar();

                // Verifica si el resultado es un entero válido
                int count;
                if (result != null && int.TryParse(result.ToString(), out count))
                {
                    // Si count es mayor que 0, el competidor ya existe
                    return count > 0;
                }
                return false;
            }
        }

    }
}



