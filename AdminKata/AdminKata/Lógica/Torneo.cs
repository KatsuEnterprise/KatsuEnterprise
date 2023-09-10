using System;

namespace AdministradorKata.Lógica
{
    class Torneo
    {
        private string codigoTorneo;
        private int round;
        private string categoria;
        private string genero;
        DateTime fecha;
        DateTime hora;
        private string lugar;

        public Torneo(string codigoTorneo, int round, string categoria, string genero, DateTime fecha, DateTime hora, string lugar)
        {
            this.codigoTorneo = codigoTorneo;
            this.round = round;
            this.categoria = categoria;
            this.genero = genero;
            this.fecha = fecha;
            this.hora = hora;
            this.lugar = lugar;
        }


        public Torneo()
        { }

        public void AltaTorneo()
        {

            string fecha = this.fecha.ToString("yyyy-MM-dd");

            string sentencia = "INSERT INTO Torneo (codigoTorneo, round, categoria, genero, fecha, hora, lugar " +
                $"VALUES ('{this.codigoTorneo}', {this.round}, '{this.categoria}', '{this.genero}', '{fecha}', '{this.hora}', '{this.lugar}') ";


            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());


            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();

        }

        public void ModificarTorneo()
        {

            string fecha = this.fecha.ToString("yyyy-MM-dd");

            string sentencia = $"UPDATE Torneo SET CodigoTorneo = '{codigoTorneo}' , round = {round}, cateoria = '{categoria}', genero = '{genero}'," +
                $" fecha = '{fecha}', hora = {hora}, lugar = '{lugar}'  " +
                $"WHERE codigoTorneo = '{codigoTorneo}'";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

        public void BajaTorneo(string codigoTorneo)
        {

            string sentencia = $"DELETE FROM Torneo WHERE codigoTorneo = '{codigoTorneo}' ";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();

        }

        public System.Data.DataTable ListarDGVTorneo()
        {

            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = "SELECT codigoTorneo as Código_Torneo, round as Round, categoria as Categoría, genero as Género, dirección as Dirección, fecha as Fecha, hora as Horario, lugar as Dirección FROM Torneo";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());

            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            Conexion.GetInstancia().Desconectar();
            //si dejamos la conexion abierta a la base de datas, pueden surgir problemas de inyecciones

            return dt;
        }


        /*
        public string CodigoTorneo
        {
            get { return codigoTorneo; }
            set { codigoTorneo = value; }
        }

        public int Round
        {
            get { return round; }
            set { round = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime Hora
        {
            get { return hora; }
            set { hora= value; }
        }

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public override string ToString()
        {
            return "El código del torneo es: " + codigoTorneo + ", y se esta realizando el round " + round +
                ", de la categoría " + categoria + " del género" + genero +
                " en " + lugar + " a las " + hora + " del día " + fecha ;
        }*/

    }
}
