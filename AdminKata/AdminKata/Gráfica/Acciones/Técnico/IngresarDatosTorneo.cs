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

        private void comBoxNumeroRound_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comBoxCategora_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comBoxGenero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*BOTONES*/

        // Datos que se guardan
        private void btnGuardarDatosTorneo_Click(object sender, EventArgs e)
        {
            string codigoTorneo = txtCodigoTorneo.Text;
            int round = int.Parse(comBoxNumeroRound.Text);
            string categoria = comBoxCategora.Text;
            string genero = comBoxGenero.Text;
            DateTime fecha = DateTime.Parse(dateTimeFechaTorneo.Text);
            DateTime hora = DateTime.Parse(msktxtPonerHoraTorneo.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            { fila = e.RowIndex; }
        }

        private void btnEliminarTorneo_Click(object sender, EventArgs e )
        {
            int fila = 0;
            string codigoTorneo = dataGridView1.Rows[fila].Cells[0].Value.ToString();


            Lógica.Torneo tor = new Lógica.Torneo();

            tor.BajaTorneo(codigoTorneo);

            dataGridView1.DataSource = tor.ListarDGVTorneo();
        }

        private void btnGuardarDatosTorneo_Click_1(object sender, EventArgs e)
        {
            string codigoTorneo = txtCodigoTorneo.Text;
            int round = int.Parse(comBoxNumeroRound.SelectedItem.ToString());
            string categoria = comBoxCategora.SelectedItem.ToString();
            string genero = comBoxGenero.SelectedItem.ToString();
            string lugar = txtLugarTorneo.Text;
            DateTime fecha = DateTime.Parse(dateTimeFechaTorneo.Text);
            DateTime hora = DateTime.Parse(msktxtPonerHoraTorneo.Text);


            if(DateTime.TryParse(msktxtPonerHoraTorneo.Text, out hora))
            {
                Lógica.Torneo tor = new Lógica.Torneo(codigoTorneo, round, categoria, genero, fecha, hora, lugar);
                dataGridView1.DataSource = tor.ListarDGVTorneo();
            }
            else
            {
                MessageBox.Show("Hay un eror al ingresar la hora del toreno");
            }
            
            MessageBox.Show("Torneo creado");

        }
        
    }
}
