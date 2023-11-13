using AdministradorKata.Lógica;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class ValidarPuntaje : Form
    {
        public ValidarPuntaje()
        {
            InitializeComponent();
        }

        private void txtPuntajes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }

        private void ValidarPuntaje_Load(object sender, EventArgs e)
        {
            int añoActual = DateTime.Now.Year;
            lblAño.Text = añoActual.ToString();

            cbTorneo.DataSource = new Torneo().ListarComboBox();
            cbTorneo.ValueMember = "IDTorneo";
            cbTorneo.DisplayMember = "IDTorneo";

            cbNombreCompetidor.DataSource = (new Lógica.Competidor()).ListarCBox();
            cbNombreCompetidor.ValueMember = "CI";
            cbNombreCompetidor.DisplayMember = "Nombre";
        }


        /*BOTONES*/

        //Botón cerrar Programa
        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón maximizar programa

        private void btnMaximizarPrograma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //Botón minimizar programa
        private void btnMinimizarPrograma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton guardar puntaje a base de datos
        private void btnGuardarPuntajeEnBD_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            int numJuez;

            // Obtén el número de juez desde el nombre del botón
            int.TryParse(btn.Name.Substring("btnGuardarPuntajeJ".Length), out numJuez);

            // Obtén los puntajes desde tus cajas de texto
            double puntaje1 = double.Parse(txtPuntajeJ1.Text);
            double puntaje2 = double.Parse(txtPuntajeJ2.Text);
            double puntaje3 = double.Parse(txtPuntajeJ3.Text);
            double puntaje4 = double.Parse(txtPuntajeJ4.Text);
            double puntaje5 = double.Parse(txtPuntajeJ5.Text);
            double puntaje6 = double.Parse(txtPuntajeJ6.Text);
            double puntaje7 = double.Parse(txtPuntajeJ7.Text);

            // Almacena los puntajes en una lista
            List<double> puntajes = new List<double> { puntaje1, puntaje2, puntaje3, puntaje4, puntaje5, puntaje6, puntaje7 };

            // Encuentra el puntaje más bajo y el más alto
            double puntajeMin = puntajes.Min();
            double puntajeMax = puntajes.Max();

            if (puntajeMin == 0.0)
            {
                puntajes.Remove(puntajeMin);  // Elimina el puntaje más bajo (0.0)
                puntajeMin = puntajes.Min();  // Encuentra el siguiente puntaje más bajo
            }

            string cedulaCompetidor = ((DataRowView)cbNombreCompetidor.SelectedItem)["CI"].ToString();

            string IDRound = cbRound.SelectedIndex+1.ToString();
            string KataQuery = $"SELECT NumKata FROM Poseen WHERE CI = {cedulaCompetidor} AND IDTorneo = {cbTorneo.Text} AND IDRound = {IDRound}";


            using (MySql.Data.MySqlClient.MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
            {
                // Suma todos los puntajes, excluyendo el puntaje más bajo y el más alto
                double puntajeFinal = puntajes.Where(p => p != puntajeMin && p != puntajeMax).Sum();

                Califica cal = new Califica(cedulaCompetidor, IDRound, KataQuery, cbTorneo.Text, puntajeFinal, numJuez);

                cmd.Parameters.AddWithValue("@CI", cedulaCompetidor);
                cmd.Parameters.AddWithValue("@IDTorneo", cbTorneo.Text);
                cmd.Parameters.AddWithValue("@IDRound", IDRound);
                cmd.Parameters.AddWithValue("@Kata", KataQuery);
                cmd.Parameters.AddWithValue("@NumJuez", numJuez);  // Utiliza el número de juez obtenido
                cmd.Parameters.AddWithValue("@PuntajeFinal", puntajeFinal);

                // Imprimir la consulta SQL antes de ejecutarla
                Console.WriteLine(cmd.CommandText);

                cal.IngresarDatosACalifica();


                MessageBox.Show($"¡Puntaje enviado con éxito!\nEl puntaje que ha enviado es de: {puntajeFinal}");
            }

            // Limpiar las cajas de texto después de guardar el puntaje
            LimpiarCajasDeTexto();
        }

        private void LimpiarCajasDeTexto()
        {
            // Puedes usar un bucle para limpiar todas las cajas de texto
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }
        }


        //Boton enviar puntaje a la pantalla
        private void btnEnviarPuntajePantalla_Click(object sender, EventArgs e)
        {
          
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>
                 {
                    txtPuntajeJ1, txtPuntajeJ2, txtPuntajeJ3, txtPuntajeJ4, txtPuntajeJ5, txtPuntajeJ6, txtPuntajeJ7
                 };

            for (int i = 0; i < textBoxes.Count; i++)
            {
                int numJuez = i + 1;
                string sql = $"SELECT PuntajeJuez, NumJuez FROM Califica WHERE NumJuez={numJuez}";

                using (MySqlConnection connection = Conexion.GetInstancia().Conectar())
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string puntaje = reader["PuntajeJuez"].ToString();
                            textBoxes[i].Text = puntaje;
                        }
                    }
                }
            }

            Conexion.GetInstancia().Desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cédula del competidor seleccionado en el ComboBox
                string cedulaCompetidor = ((DataRowView)cbNombreCompetidor.SelectedItem)["CI"].ToString();

                // Llamar al método para actualizar el estado del competidor
                Competidor comp = new Competidor();
                comp.ActualizarEstadoCompetidor(cedulaCompetidor);

                MessageBox.Show("Participante Compitiendo!");
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada (puedes mostrar un mensaje de error, escribir en un archivo de registro, etc.)
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
    }
}
