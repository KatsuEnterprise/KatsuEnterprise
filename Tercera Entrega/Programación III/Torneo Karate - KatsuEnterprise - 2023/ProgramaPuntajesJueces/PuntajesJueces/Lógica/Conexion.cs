namespace PuntajesJueces.Lógica
{
    class Conexion
    {
        private static MySql.Data.MySqlClient.MySqlConnection conexion;
        /* SINGLETON */
        private static Conexion instancia;


        private Conexion()
        {
            conexion = null;
        }
        public static Conexion GetInstancia()
        {
            if (instancia == null)
                instancia = new Conexion();
            return instancia;
        }
        /* SINGLETON - FIN*/

        public MySql.Data.MySqlClient.MySqlConnection Conectar()
        {
            if (conexion == null)
            {
                string conexion_string = System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
                conexion = new MySql.Data.MySqlClient.MySqlConnection(conexion_string);
                conexion.Open();
            }

            return conexion;
        }


        public void Desconectar()
        {
            if (conexion != null)
                conexion.Close();
            conexion = null;
            //es necesario porque al cerrar la conexion no queda en null, y cuando se quiere volver a conectar, conexion no es null (esta cerrada, pero existiendo)
            //entonces retorna la conexion cerrada
        }

    }
}
