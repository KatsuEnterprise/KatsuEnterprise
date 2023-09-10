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
        private string profeSupervisor;


        public Competidor(string nombreComp, string apellidoComp, int ciComp, DateTime nacimientoComp, DateTime vecimientoCarnetSalud, string sociedadComp, string escuelaComp, string profeSupervisor, string IDPool)
        {

            this.nombreComp = nombreComp;
            this.apellidoComp = apellidoComp;
            this.ciComp = ciComp;
            this.nacimientoComp = nacimientoComp;
            this.vecimientoCarnetSalud = vecimientoCarnetSalud;
            this.sociedadComp = sociedadComp;
            this.escuelaComp = escuelaComp;
            this.profeSupervisor = profeSupervisor;

        }


        public Competidor()
        { }

        public Competidor(string nombreComp, string apellidoComp, int ciComp, DateTime nacimientoComp, DateTime vencimientoCarnetSaludComp, string sociedadComp, string escuelaComp, string profeSupervisor)
        {
            this.nombreComp = nombreComp;
            this.apellidoComp = apellidoComp;
            this.ciComp = ciComp;
            this.nacimientoComp = nacimientoComp;
            this.sociedadComp = sociedadComp;
            this.escuelaComp = escuelaComp;
            this.profeSupervisor = profeSupervisor;
        }

        public System.Data.DataTable ListarDGVCompetidor()
        {

            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = "SELECT nombreComp as Nombre, apellidoComp as Apellido, ciComp as Cédula, nacimientoComp as FechaNacimiento, vecimientoCarnetSalud as CarnetSalud, sociedadComp as Sociedad, escuelaComp as Escuela, profeSupervisor as Profesor FROM Competidor";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();
            //si dejamos la conexion abierta a la base de datas, pueden surgir problemas de inyecciones

            return dt;
        }



        public void AltaCompetidor()
        {

            string fechaNacimiento = this.nacimientoComp.ToString("yyyy-MM-dd");
            string fechaCS = this.vecimientoCarnetSalud.ToString("yyyy-MM-dd");

            string sentencia = "INSERT INTO Competidor (nombreComp, apellidoComp, ciComp, nacimientoComp, vecimientoCarnetSalud, sociedadComp, escuelaComp, profeSupervisor) " +
                $"VALUES ('{this.nombreComp}', '{this.apellidoComp}', '{this.ciComp}', '{nacimientoComp}', '{vecimientoCarnetSalud}', '{this.sociedadComp}', {this.escuelaComp}, '{this.profeSupervisor}') ";


            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());


            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();

        }

        public void ModificarCompetidor()
        {

            string fechaNacimiento = this.nacimientoComp.ToString("yyyy-MM-dd");
            string fechaCS = this.vecimientoCarnetSalud.ToString("yyyy-MM-dd");

            string sentencia = $"UPDATE Competidor SET nombreComp = '{nombreComp}' , apellidoComp = '{apellidoComp}', ciComp = {ciComp} , nacimientoComp = '{nacimientoComp}'," +
                $" vecimientoCarnetSalud = '{vecimientoCarnetSalud}', sociedadComp = '{sociedadComp}', escuelaComp = '{escuelaComp}', profeSupervisor = '{profeSupervisor}'" +
                $"WHERE ciComp = '{ciComp}'";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

        public void BajaCompetidor(int ciComp)
        {

            string sentencia = $"DELETE FROM Competidor WHERE ciComp = '{ciComp}' ";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();

        }

        public System.Data.DataTable ListarCBox()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = "SELECT nombreComp, apellidoComp from Cómpetidor";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();
            //si dejamos la conexion abierta a la base de datas, pueden surgir problemas de inyecciones

            return dt;
        }

        /* public string NombreComp
         {
             get { return nombreComp; }
             set { nombreComp = value; }
         }

         public string ApellidoComp
         { get { return apellidoComp; }
             set { apellidoComp = value; }
         }

         public int CiComp
         { get { return ciComp; }
             set { ciComp = value; }
         }

         public DateTime NacimientoComp
         { get { return nacimientoComp; }
             set { nacimientoComp = value; }
         }

         public DateTime VencimientoCarnetSalud
         {
             get { return vecimientoCarnetSalud; }
             set { vecimientoCarnetSalud = value; }
         }

         public string SociedadComp
         { get { return sociedadComp; }
             set { sociedadComp = value; }
         }

         public string EscuelaComp
         { get { return escuelaComp; }
             set { escuelaComp = value; }
         }

         public string ProfeSupervisor
         { get { return profeSupervisor; }
             set { profeSupervisor = value; }
         }



         public override string ToString()
         {
             return "El nombre completo del competidor es " + nombreComp + apellidoComp + ", su cédula de identidad es " + ciComp + 
                 ", esta afiliado al hospital " + sociedadComp + "y concurre a la escuela de Karate " + escuelaComp +
                 ", teniendo como profesor supervisor a " + profeSupervisor;
         }*/

    }

}
