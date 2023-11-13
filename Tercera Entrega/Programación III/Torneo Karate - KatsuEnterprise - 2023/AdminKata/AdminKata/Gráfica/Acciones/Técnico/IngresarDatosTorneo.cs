using AdministradorKata.Lógica;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class IngresarDatosTorneo : Form
    {
        private int fila;


        public IngresarDatosTorneo()
        {
            InitializeComponent();
        }

        /*CONFIGURACION DE TEXTBOXS*/

        //Para que no se ingresen símbolos al ingresar el codigo del torneo
        private void txtCodigoTorneo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }

        //Para que no ingresen símbolos al ingresar el lugar del torneo
        private void txtLugarTorneo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }

        //Si la fecha del torneo es antes del dia de hoy, no se puede crear
        private void dateTimeFechaTorneo_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            if (dateTimeFechaTorneo.Value < fechaActual)
                MessageBox.Show("No se puede crear este torneo");

        }


        /*BOTONES*/

        // Datos que se guardan

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            { fila = e.RowIndex; }
        }

        private void btnEliminarTorneo_Click(object sender, EventArgs e)
        {
            int fila = 0;
            string codigoTorneo = dataGridView1.Rows[fila].Cells[0].Value.ToString();

            Lógica.Torneo tor = new Lógica.Torneo();
            tor.BajaTorneo(codigoTorneo);
            dataGridView1.DataSource = tor.ListarDGVTorneo();
        }

        private void btnGuardarDatosTorneo_Click_1(object sender, EventArgs e)
        {
            try
            {
                string codigoTorneo = txtCodigoTorneo.Text;
                string categoria = comBoxCategora.SelectedItem.ToString();
                string genero = comBoxGenero.SelectedItem.ToString();
                string lugar = txtLugarTorneo.Text;
                DateTime fecha = DateTime.Parse(dateTimeFechaTorneo.Text);
                string hora = msktxtPonerHoraTorneo.Text;

                int CodTorneo = int.Parse(codigoTorneo);
                DateTime HoraTorneo = DateTime.Parse(hora);

                Lógica.Torneo tor = new Lógica.Torneo(CodTorneo, categoria, genero, fecha, HoraTorneo, lugar);
                dataGridView1.DataSource = tor.ListarDGVTorneo();
                tor.AltaTorneo();
                MessageBox.Show("Torneo creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void IngresarDatosTorneo_Load(object sender, EventArgs e)
        {
            // **CONFIGURAR LABEL AÑO

            dataGridView1.DataSource = new Lógica.Torneo().ListarDGVTorneo();
            comboBox2.DataSource = new Lógica.Torneo().ListarComboBox();

            comboBox2.ValueMember = "IDTorneo";
            comboBox2.DisplayMember = "IDtorneo";

            //Para que el lbl que ahora dice "2023", cambie si estamos en otro año

            int añoActual = DateTime.Now.Year;
            lblAño.Text = añoActual.ToString();
            lblAnio.Text = añoActual.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IDTorneo = comboBox2.Text;
            string IDRound = comboBox1.SelectedIndex+1.ToString();
            int IDPool = 0;

            if (int.TryParse(IDTorneo, out int IDT) && int.TryParse(IDRound, out int IDR))
            {
                Round round = new Round(IDR, IDT, IDPool);

                try
                {
                    round.AltaRound();
                    dataGridView1.DataSource = new Torneo().ListarDGVTorneo();
                    MessageBox.Show("Round Creado");
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Número de error para clave duplicada
                    {
                        MessageBox.Show("El round que estás intentando crear ya existe.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al crear el round: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Los valores de IDTorneo e IDRound deben ser números enteros.");
            }
        }




    }
}
