using System;

namespace AdministradorKata.Lógica
{
    class Torneo
    {
        private int codigoTorneo;
        private string categoria;
        private string genero;
        DateTime fecha;
        DateTime hora;
        string lugar;

        public Torneo()
        { }

        public Torneo(int codigoTorneo, string categoria, string genero, DateTime fecha, DateTime hora, string lugar)
        {
            this.codigoTorneo = codigoTorneo;
            this.categoria = categoria;
            this.genero = genero;
            this.fecha = fecha;
            this.hora = hora;
            this.lugar = lugar;
        }

        public void AltaTorneo()
        {
            string fecha = this.fecha.ToString("yyyy-MM-dd");
            string hora = this.hora.ToString("HH:mm");

            string sentencia = "INSERT INTO Torneo (IDTorneo, CategoriaTorneo, GeneroTorneo, FechaTorneo, HoraTorneo, LugarTorneo)" +
                $"VALUES ({this.codigoTorneo}, '{this.categoria}', '{this.genero}', '{fecha}', '{hora}', '{this.lugar}') ";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());
            cmd.ExecuteNonQuery();
            Conexion.GetInstancia().Desconectar();
        }

        public void ModificarTorneo()
        {
            string fecha = this.fecha.ToString("yyyy-MM-dd");

            string sentencia = $"UPDATE Torneo SET IDTorneo = '{this.codigoTorneo}', CateoriaTorneo = '{this.categoria}', GeneroTorneo = '{this.genero}'," +
                $" FechaTorneo = '{fecha}', HoraTonreo = {this.hora}" +
                $"WHERE IDTorneo = '{codigoTorneo}'";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

        public void BajaTorneo(string codigoTorneo)
        {

            string sentencia = $"DELETE FROM Torneo WHERE IDTorneo = '{this.codigoTorneo}' ";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();

        }

        public System.Data.DataTable ListarDGVTorneo()
        {

            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = "SELECT IDTorneo as CodigoTorneo, CategoriaTorneo as Categoria, GeneroTorneo as Genero,  DATE_FORMAT(FechaTorneo, '%Y-%m-%d'), HoraTorneo as Horario FROM Torneo";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();
            //si dejamos la conexion abierta a la base de datas, pueden surgir problemas de inyecciones

            return dt;
        }

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
